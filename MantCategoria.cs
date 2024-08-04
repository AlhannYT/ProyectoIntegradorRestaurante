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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proyecto_restaurante
{
    public partial class MantCategoria : Form
    {
        public MantCategoria()
        {
            InitializeComponent();
        }

        private bool mensajeMostrado = false;
        private string nombreCategoriaActual;

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(nombreCategoriaActual))
                    {
                        string queryInsertar = "INSERT INTO categoria (nombre_categoria) VALUES (@nombreCateg)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@nombreCateg", txtcategoria.Text);


                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Categoria registrada con éxito.");
                                txtcategoria.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los datos.");
                            }
                        }
                    }
                    else
                    {
                        string verificarPassQuery = "SELECT COUNT(*) FROM categoria WHERE nombre_categoria = @nombreCategActual";
                        using (SqlCommand verificarPassCommand = new SqlCommand(verificarPassQuery, conexion))
                        {
                            verificarPassCommand.Parameters.AddWithValue("@nombreCategActual", nombreCategoriaActual);

                        }

                        string queryActualizar = "UPDATE categoria SET nombre_categoria = @nuevoNombreCateg";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@nuevoNombreCateg", txtcategoria.Text);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Categoria actualizada con éxito.");
                                txtcategoria.Text = "";
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
            txtcategoria.Text = "";
        }

        private void txtcategoria_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtcategoria.SelectionStart;

            txtcategoria.Text = txtcategoria.Text.ToUpper();

            txtcategoria.SelectionStart = posicion;
        }
    }
}
