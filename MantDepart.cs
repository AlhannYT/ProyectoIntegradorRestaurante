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

        private string nombreDepartActual;

        private int idDepart=0;

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(nombreDepartActual))
                    {
                        // Insertar un nuevo departamento
                        string queryInsertar = "INSERT INTO departamento (provincia, nombre_depa, estado) VALUES (@nombreProv, @nombreDepa, @estado)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@nombreDepa", txtnombredepa.Text);
                            insertarCommand.Parameters.AddWithValue("@nombreProv", txtprovincia.Text);
                            insertarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Departamento registrado con éxito.");
                                MantDepart_Load(sender, e);
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
                        string queryActualizar = "UPDATE departamento SET provincia = @provinciaDepa, nombre_depa = @nuevoNombreDepart, estado = @estado WHERE id = @idDepart";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@idDepart", idDepart);
                            actualizarCommand.Parameters.AddWithValue("@nuevoNombreDepart", txtnombredepa.Text);
                            actualizarCommand.Parameters.AddWithValue("@provinciaDepa", txtprovincia.Text);
                            actualizarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Departamento actualizado con éxito.");
                                MantDepart_Load(sender, e);
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
            nombreDepartActual = "";
            idDepart = 0;
            this.Text = "Mantenimiento de Departamento || Creando...";
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            string conexionString = ConexionBD.ConexionSQL();
            string consulta = "select * from departamento";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tabladatos.DataSource = dt;
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

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Text = "Mantenimiento de Departamento || Editando...";
            idDepart = Convert.ToInt32(tabladatos.SelectedCells[0].Value);
            txtnombredepa.Text = tabladatos.SelectedCells[1].Value.ToString();
            nombreDepartActual = txtnombredepa.Text;
            txtprovincia.Text = tabladatos.SelectedCells[2].Value.ToString();
            estadochk.Checked = Convert.ToBoolean(tabladatos.SelectedCells[3].Value);
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
