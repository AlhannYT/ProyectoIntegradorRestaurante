using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proyecto_restaurante
{
    public partial class MantMedidas : Form
    {
        public MantMedidas()
        {
            InitializeComponent();
            txtabreviatura.MaxLength = 3;
        }

        private bool mensajeMostrado = false;
        private string abrevMedidaActual;

        private void txtabreviatura_TextChanged(object sender, EventArgs e)
        {
            Regex letrasRegex = new Regex(@"^[A-Z]*$");

            int posicion = txtabreviatura.SelectionStart;

            txtabreviatura.Text = txtabreviatura.Text.ToUpper();

            txtabreviatura.SelectionStart = posicion;

            if (!letrasRegex.IsMatch(txtabreviatura.Text))
            {
                MessageBox.Show("Solo se permiten letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtabreviatura.Text = string.Empty;
            }
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(abrevMedidaActual))
                    {
                        string queryInsertar = "INSERT INTO medidas (abreviatura, nombre_medida) VALUES (@abreviatura, @nombreMedida)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@abreviatura", txtabreviatura.Text);
                            insertarCommand.Parameters.AddWithValue("@nombreMedida", txtmedida.Text);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Medida registrada con éxito.");
                                limpiarCampos();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los datos.");
                            }
                        }
                    }
                    else
                    {
                        string queryActualizar = "UPDATE medidas SET nombre_medida = @nombreMedida WHERE abreviatura = @abreviatura";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@abreviatura", abrevMedidaActual);
                            actualizarCommand.Parameters.AddWithValue("@nombreMedida", txtmedida.Text);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Medida actualizada con éxito.");
                                limpiarCampos();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar los datos.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void txtmedida_TextChanged(object sender, EventArgs e)
        {
            Regex letrasRegex = new Regex(@"^[A-Z]*$");

            int posicion = txtmedida.SelectionStart;

            txtmedida.Text = txtmedida.Text.ToUpper();

            txtmedida.SelectionStart = posicion;

            if (!letrasRegex.IsMatch(txtmedida.Text))
            {
                MessageBox.Show("Solo se permiten letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmedida.Text = string.Empty;
            }
        }

        private void verificarbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtabreviatura.Text))
            {
                MessageBox.Show("Error: Colocar una abreviatura.");
                return;
            }

            string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string verificarQuery = "SELECT COUNT(*) FROM medidas WHERE abreviatura = @abreviatura";
                    using (SqlCommand verificarCommand = new SqlCommand(verificarQuery, conexion))
                    {
                        verificarCommand.Parameters.AddWithValue("@abreviatura", txtabreviatura.Text);
                        int medidaCount = (int)verificarCommand.ExecuteScalar();

                        if (medidaCount > 0)
                        {
                            DialogResult editar = MessageBox.Show("Ya existe una medida con esa abreviatura. ¿Desea editarla?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (editar == DialogResult.Yes)
                            {
                                string obtenerDatosQuery = "SELECT abreviatura, nombre_medida FROM medidas WHERE abreviatura = @abreviatura";
                                using (SqlCommand obtenerDatosCommand = new SqlCommand(obtenerDatosQuery, conexion))
                                {
                                    obtenerDatosCommand.Parameters.AddWithValue("@abreviatura", txtabreviatura.Text);

                                    using (SqlDataReader reader = obtenerDatosCommand.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            txtabreviatura.Text = reader["abreviatura"].ToString();
                                            txtmedida.Text = reader["nombre_medida"].ToString();
                                        }
                                    }
                                }

                                abrevMedidaActual = txtabreviatura.Text;
                                guardarbtn.Visible = true;
                                
                                guardarbtn.Enabled = true;
                                verificarbtn.Visible = false;
                                txtabreviatura.Enabled = false;

                            }
                            else
                            {
                                MessageBox.Show("Operación cancelada.");
                                return;
                            }
                        }
                        else
                        {
                            //MessageBox.Show("No se encontró ninguna medida con esa abreviatura. Puedes proceder a crear una nueva.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            guardarbtn.Visible = true;
                            guardarbtn.Enabled = true;
                            verificarbtn.Visible = false;
                            txtmedida.Enabled = true;
                            txtmedida.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
        }

        private void limpiarCampos()
        {
            txtabreviatura.Text = string.Empty;
            txtmedida.Text = string.Empty;
            abrevMedidaActual = null;
            txtabreviatura.Enabled = true;
            guardarbtn.Visible = false;
            guardarbtn.Enabled = false;
            verificarbtn.Visible = true;
            txtmedida.Enabled = false;
            verificarbtn.Enabled = true;
        }

        private void txtabreviatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                verificarbtn_Click(sender, e);
            }
        }
    }
}
