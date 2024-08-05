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

namespace Proyecto_restaurante
{
    public partial class MantMesas : Form
    {
        public MantMesas()
        {
            InitializeComponent();
        }

        private string nombreMesaActual;

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            Regex numerosRegex = new Regex(@"^[\d-]+$");

            if (txtnombreMesa.Text == "" || salacmbx.SelectedItem == null)
            {
                MessageBox.Show("No debe dejar campos vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                salacmbx.Focus();
                return;
            }

            if (!numerosRegex.IsMatch(txtNumAsientos.Text))
            {
                MessageBox.Show("Numero de asientos solo admite números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumAsientos.Text = "";
                txtNumAsientos.Focus();
                return;
            }
            string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(nombreMesaActual))
                    {
                        string queryInsertar = "INSERT INTO mesas (sala, nombre_mesa, estado, num_asientos) VALUES (@sala, @nombreMesa, @estado, @numAsientos)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@sala", salacmbx.SelectedItem.ToString());
                            insertarCommand.Parameters.AddWithValue("@nombreMesa", txtnombreMesa.Text);
                            insertarCommand.Parameters.AddWithValue("@numAsientos", txtNumAsientos.Text);
                            insertarCommand.Parameters.AddWithValue("@estado", 1);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Mesa registrada con éxito.");
                                limpiarbtn_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los datos.");
                            }
                        }
                    }
                    else
                    {
                        //string verificarPassQuery = "SELECT COUNT(*) FROM mesas WHERE nombre_mesa = @nombreMesaActual";
                        //using (SqlCommand verificarPassCommand = new SqlCommand(verificarPassQuery, conexion))
                        //{
                        //    verificarPassCommand.Parameters.AddWithValue("@nombreMesaActual", nombreMesaActual);

                        //}

                        //string queryActualizar = "UPDATE mesa SET nombre_categoria = @nuevoNombreCateg, sala = @sala, nombre_mesa = @nombreMesa, num_asientos = @numAsientos WHERE nombre_categoria = @nombreCategActual";
                        //using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        //{
                        //    actualizarCommand.Parameters.AddWithValue("@nuevoNombreCateg", txtcategoria.Text);
                        //    actualizarCommand.Parameters.AddWithValue("@sala", comboBoxSala.SelectedItem.ToString());
                        //    actualizarCommand.Parameters.AddWithValue("@nombreMesa", txtnombreMesa.Text);
                        //    actualizarCommand.Parameters.AddWithValue("@numAsientos", txtNumAsientos.Text);
                        //    actualizarCommand.Parameters.AddWithValue("@nombreCategActual", nombreCategoriaActual);

                        //    int rowsAffected = actualizarCommand.ExecuteNonQuery();

                        //    if (rowsAffected > 0)
                        //    {
                        //        MessageBox.Show("Categoría actualizada con éxito.");
                        //        limpiarbtn_Click(sender, e);
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("No se pudo actualizar los datos.");
                        //    }
                        //}
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
            salacmbx.SelectedIndex = -1;
            txtnombreMesa.Text = "";
            txtNumAsientos.Text = "";
        }

        private void txtnombreMesa_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtnombreMesa.SelectionStart;

            txtnombreMesa.Text = txtnombreMesa.Text.ToUpper();

            txtnombreMesa.SelectionStart = posicion;
        }


        private void nuevaSalabtn_Click(object sender, EventArgs e)
        {
            MantSalas salas = new MantSalas();
            salas.Show();
        }

        private void MantMesas_Load(object sender, EventArgs e)
        {
            string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT nombre_sala FROM salas";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                salacmbx.Items.Add(reader["nombre_sala"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al cargar las salas: {ex.Message}");
                }
            }

            string consulta = "select id, nombre_mesa, sala, num_asientos from mesas";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tabladatos.DataSource = dt;
        }

        public void RecargarClick()
        {
            recargarbtn.PerformClick();
        }

        private void recargarbtn_Click(object sender, EventArgs e)
        {
            salacmbx.Items.Clear();
            MantMesas_Load(sender, e);
        }

        private void FiltroDatosBusqueda(string busqueda)
        {
            string conexion = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";

            using (SqlConnection conectar = new SqlConnection(conexion))
            {
                try
                {
                    conectar.Open();

                    string query = @"
                        SELECT * FROM mesas
                        WHERE CAST(id AS VARCHAR) LIKE @buscar OR
                        sala LIKE @buscar OR
                        nombre_mesa LIKE @buscar OR
                        num_asientos LIKE @buscar";

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

        private void txtbuscador_Enter(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "(ID, Nombre, Sala, N° Asientos)")
            {
                txtbuscador.Text = "";
                txtbuscador.ForeColor = Color.Black;
            }
        }

        private void txtbuscador_Leave(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "")
            {
                txtbuscador.Text = "(ID, Nombre, Sala, N° Asientos)";
                txtbuscador.ForeColor = Color.Gray;
                MantMesas_Load(sender, e);
            }
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            txtbuscador.Text = "";
        }
    }
}
