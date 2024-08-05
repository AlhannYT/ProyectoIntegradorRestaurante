using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_restaurante
{
    public partial class MantDepart : Form
    {
        public MantDepart()
        {
            InitializeComponent();
        }

        //private bool mensajeMostrado = false;
        private string nombreDepartActual;

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(nombreDepartActual))
                    {
                        string queryInsertar = "INSERT INTO departamento (provincia, nombre_depa) VALUES (@nombreProv, @nombreDepa)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@nombreDepa", txtnombredepa.Text);
                            insertarCommand.Parameters.AddWithValue("@nombreProv", txtprovincia.Text);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Departamento registrado con éxito.");
                                txtnombredepa.Text = "";
                                txtprovincia.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los datos.");
                            }
                        }
                    }
                    else
                    {
                        string verificarDepaQuery = "SELECT COUNT(*) FROM departamento WHERE nombre_depa = @nombreDepartActual";
                        using (SqlCommand verificarPassCommand = new SqlCommand(verificarDepaQuery, conexion))
                        {
                            verificarPassCommand.Parameters.AddWithValue("@nombreDepartActual", nombreDepartActual);

                        }

                        string queryActualizar = "UPDATE departamento SET provincia = @provinciaDepa, nombre_depa = @nuevoNombreDepart";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@nuevoNombreDepart", txtnombredepa.Text);
                            actualizarCommand.Parameters.AddWithValue("@provinciaDepa", txtprovincia.Text);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Departamento actualizado con éxito.");
                                txtnombredepa.Text = "";
                                txtprovincia.Text = "";
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

        private void txtnombredepa_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtnombredepa.SelectionStart;

            txtnombredepa.Text = txtnombredepa.Text.ToUpper();

            txtnombredepa.SelectionStart = posicion;
        }

        private void txtprovincia_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtprovincia.SelectionStart;

            txtprovincia.Text = txtprovincia.Text.ToUpper();

            txtprovincia.SelectionStart = posicion;
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            txtprovincia.Text = "";
            txtnombredepa.Text = "";
        }

        private void txtbuscador_Enter(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "(ID, Nombre, Provincia)")
            {
                txtbuscador.Text = "";
                txtbuscador.ForeColor = Color.Black;
            }
        }

        private void txtbuscador_Leave(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "")
            {
                txtbuscador.Text = "(ID, Nombre, Provincia)";
                txtbuscador.ForeColor = Color.Gray;
                MantDepart_Load(sender, e);
            }
        }

        private void MantDepart_Load(object sender, EventArgs e)
        {
            string conexion = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";
            string consulta = "select * from departamento";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tabladatos.DataSource = dt;
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
                        SELECT * FROM departamento
                        WHERE CAST(id AS VARCHAR) LIKE @buscar OR
                        provincia LIKE @buscar OR
                        nombre_depa LIKE @buscar";

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
    }
}
