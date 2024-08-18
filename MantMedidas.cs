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
            //string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";
            string conexionString = "Server=LENOVO\\SQLEXPRESS;Database=RestauranteDB;integrated security=true";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(abrevMedidaActual))
                    {
                        string queryInsertar = "INSERT INTO medidas (abreviatura, nombre_medida, estado) VALUES (@abreviatura, @nombreMedida, @estado)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@abreviatura", txtabreviatura.Text);
                            insertarCommand.Parameters.AddWithValue("@nombreMedida", txtmedida.Text);
                            insertarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Medida registrada con éxito.");
                                MantMedidas_Load(sender, e);
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
                        string queryActualizar = "UPDATE medidas SET abreviatura = @abreviaturaNueva, nombre_medida = @nombreMedida, estado = @estado WHERE abreviatura = @abreviaturaActual";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@abreviaturaActual", abrevMedidaActual);
                            actualizarCommand.Parameters.AddWithValue("@abreviaturaNueva", txtabreviatura.Text);
                            actualizarCommand.Parameters.AddWithValue("@nombreMedida", txtmedida.Text);
                            actualizarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Medida actualizada con éxito.");
                                MantMedidas_Load(sender, e);
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
            //string conexionString = "Server=LENOVO\\SQLEXPRESS;Database=RestauranteDB;integrated security=true";

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
                                string obtenerDatosQuery = "SELECT abreviatura, nombre_medida, estado FROM medidas WHERE abreviatura = @abreviatura";
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
            this.Text = "Mantenimiento de Usuarios || Creando...";

            txtabreviatura.Text = "";
            txtmedida.Text = "";
            abrevMedidaActual = "";
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

        private void FiltroDatosBusqueda(string busqueda)
        {
            string conexion = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";
            //string conexion = "Server=LENOVO\\SQLEXPRESS;Database=RestauranteDB;integrated security=true";

            using (SqlConnection conectar = new SqlConnection(conexion))
            {
                try
                {
                    conectar.Open();

                    string query = @"
                        SELECT * FROM medidas
                        WHERE CAST(id AS VARCHAR) LIKE @buscar OR
                        abreviatura LIKE @buscar OR
                        nombre_medida LIKE @buscar";

                    using (SqlCommand comando = new SqlCommand(query, conectar))
                    {
                        comando.Parameters.AddWithValue("@buscar", "%" + busqueda + "%");

                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        tabladatos.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void txtbuscador_TextChanged(object sender, EventArgs e)
        {
            FiltroDatosBusqueda(txtbuscador.Text);
        }

        private void MantMedidas_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            //string conexion = "Server=LENOVO\\SQLEXPRESS;Database=RestauranteDB;integrated security=true";
            string conexion = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";
            string consulta = "select * from medidas";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tabladatos.DataSource = dt;
        }

        private void txtbuscador_Enter(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "(ID, Abreviatura, Nombre)")
            {
                txtbuscador.Text = "";
                txtbuscador.ForeColor = Color.Black;
            }
        }

        private void txtbuscador_Leave(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "")
            {
                txtbuscador.Text = "(ID, Abreviatura, Nombre)";
                txtbuscador.ForeColor = Color.Gray;
                MantMedidas_Load(sender, e);
            }
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            txtbuscador.Text = "";
        }

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Text = "Mantenimiento de Usuarios || Editando...";
            txtabreviatura.Text = tabladatos.SelectedCells[1].Value.ToString();
            abrevMedidaActual = txtabreviatura.Text;
            txtmedida.Text = tabladatos.SelectedCells[2].Value.ToString();

            estadochk.Checked = Convert.ToBoolean(tabladatos.SelectedCells[3].Value);
            verificarbtn.Visible = false;
            verificarbtn.Enabled=false;
            guardarbtn.Visible = true;
            guardarbtn.Enabled=true;
            txtabreviatura.Enabled = true;
            txtmedida.Enabled = true;
        }

        private void estadochk_CheckedChanged(object sender, EventArgs e)
        {
            if (estadochk.Checked == true)
            {
                estadochk.Text = "Activo";
                estadochk.ForeColor = Color.Lime;
            }
            else if (estadochk.Checked == false)
            {

                estadochk.Text = "Inactivo";
                estadochk.ForeColor = Color.Red;
            }
        }
    }
}
