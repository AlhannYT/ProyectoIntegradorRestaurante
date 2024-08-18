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
    public partial class MantSalas : Form
    {
        public MantSalas()
        {
            InitializeComponent();
        }

        private string nombreSalaActual;

        private void guardarbtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtnombresala.Text))
            {
                MessageBox.Show("Error: No deje campos vacios.");
                return;
            }

            MantMesas mesas = new MantMesas();

            string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";
            //string conexionString = "Server=LENOVO\\SQLEXPRESS;Database=RestauranteDB;integrated security=true";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(nombreSalaActual))
                    {
                        string queryInsertar = "INSERT INTO salas (nombre_sala, estado) VALUES (@nombreSala, @estado)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@nombreSala", txtnombresala.Text);
                            insertarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Sala registrada con éxito.");
                                mesas.RecargarClick();
                                MantSalas_Load(sender, e);
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
                        string verificarQuery = "SELECT COUNT(*) FROM salas WHERE nombre_sala = @nombreSalaActual";
                        using (SqlCommand verificarCommand = new SqlCommand(verificarQuery, conexion))
                        {
                            verificarCommand.Parameters.AddWithValue("@nombreSalaActual", nombreSalaActual);
                        }

                        string queryActualizar = "UPDATE salas SET nombre_sala = @nuevoNombreSala, estado = @estado WHERE nombre_sala = @nombreSalaActual";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@nuevoNombreSala", txtnombresala.Text);
                            actualizarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);
                            actualizarCommand.Parameters.AddWithValue("@nombreSalaActual", nombreSalaActual);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Sala actualizada con éxito.");
                                mesas.RecargarClick();
                                MantSalas_Load(sender, e);
                                limpiarbtn_Click(sender, e);
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

        private void txtnombresala_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtnombresala.SelectionStart;

            txtnombresala.Text = txtnombresala.Text.ToUpper();

            txtnombresala.SelectionStart = posicion;
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
                        SELECT * FROM salas
                        WHERE CAST(id AS VARCHAR) LIKE @buscar OR
                        nombre_sala LIKE @buscar";

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

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            this.Text = "Mantenimiento de Salas || Creando...";
            
            txtnombresala.Text = "";
            estadochk.Checked = true;
        }

        private void txtbuscador_TextChanged(object sender, EventArgs e)
        {
            FiltroDatosBusqueda(txtbuscador.Text);
        }

        private void MantSalas_Load(object sender, EventArgs e)
        {
            string conexion = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";
            //string conexion = "Server=LENOVO\\SQLEXPRESS;Database=RestauranteDB;integrated security=true";
            string consulta = "select * from salas";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tabladatos.DataSource = dt;
        }

        private void txtbuscador_Enter(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "(ID, Nombre Sala)")
            {
                txtbuscador.Text = "";
                txtbuscador.ForeColor = Color.Black;
            }
        }

        private void txtbuscador_Leave(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "")
            {
                txtbuscador.Text = "(ID, Nombre Sala)";
                txtbuscador.ForeColor = Color.Gray;
                MantSalas_Load(sender, e);
            }
        }

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Text = "Mantenimiento de Salas || Editando...";

            txtnombresala.Text = tabladatos.SelectedCells[1].Value.ToString();
            nombreSalaActual = txtnombresala.Text;
            estadochk.Checked = Convert.ToBoolean(tabladatos.SelectedCells[2].Value);
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

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            limpiarbtn_Click(sender, e);
            MantSalas_Load(sender, e);
        }
    }
}
