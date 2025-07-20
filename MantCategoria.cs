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
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(nombreCategoriaActual))
                    {
                        string queryInsertar = "INSERT INTO categoria (nombre_categoria, estado) VALUES (@nombreCateg, @estado)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@nombreCateg", txtcategoria.Text);
                            insertarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Categoria registrada con éxito.");
                                limpiarbtn_Click(sender, e);
                                MantCategoria_Load(sender, e);
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

                        string queryActualizar = "UPDATE categoria SET nombre_categoria = @nuevoNombreCateg, estado= @estado where nombre_categoria= @nombreCategActual";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@nuevoNombreCateg", txtcategoria.Text);
                            actualizarCommand.Parameters.AddWithValue("@nombreCategActual", nombreCategoriaActual);
                            actualizarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Categoria actualizada con éxito.");
                                limpiarbtn_Click(sender, e);
                                MantCategoria_Load(sender, e);
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
            nombreCategoriaActual = "";
            this.Text = "Mantenimiento de Categoria || Creando...";
        }

        private void txtcategoria_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtcategoria.SelectionStart;

            txtcategoria.Text = txtcategoria.Text.ToUpper();

            txtcategoria.SelectionStart = posicion;

            if(txtcategoria.Text=="")
            {
                limpiarbtn_Click(sender, e);
            }
        }

        private void FiltroDatosBusqueda(string busqueda)
        {
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conectar = new SqlConnection(conexionString))
            {
                try
                {
                    conectar.Open();

                    string query = @"
                        SELECT * FROM categoria
                        WHERE CAST(id AS VARCHAR) LIKE @buscar OR
                        nombre_categoria LIKE @buscar";

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

        private void MantCategoria_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            string conexionString = ConexionBD.ConexionSQL();

            string consulta = "select * from categoria";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tabladatos.DataSource = dt;
        }

        private void txtbuscador_Enter(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "(ID, Nombre Categoria)")
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
                MantCategoria_Load(sender, e);
            }
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

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Text = "Mantenimiento de Categoria || Editando...";
            txtcategoria.Text = tabladatos.SelectedCells[1].Value.ToString();
            nombreCategoriaActual = txtcategoria.Text;
            estadochk.Checked = Convert.ToBoolean(tabladatos.SelectedCells[2].Value);
        }
    }
}
