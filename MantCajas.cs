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
    public partial class MantCajas : Form
    {
        public MantCajas()
        {
            InitializeComponent();
        }

        private string nombreCajaActual;
        private int idCaja = 0;

        private void guardatbtn_Click(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(nombreCajaActual))
                    {
                        string queryInsertar = "INSERT INTO cajas (nombre_caja, numero_caja, estado, responsable) VALUES (@nombreCaja, @numeroCaja, @estado, @responsable)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@responsable", responsablecmbx.SelectedItem.ToString());
                            insertarCommand.Parameters.AddWithValue("@nombreCaja", txtnombrecaja.Text);
                            insertarCommand.Parameters.AddWithValue("@numeroCaja", txtnumerocaja.Text);
                            insertarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Caja registrada con éxito.");
                                limpiarbtn_Click(sender, e);
                                MantCajas_Load(sender, e);
                                recargarbtn_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los datos.");
                            }
                        }
                    }
                    else
                    {
                        string queryActualizar = "UPDATE cajas SET nombre_caja = @nuevoNombreCaja, numero_caja = @numeroCaja, estado = @estado, responsable = @responsable where nombre_caja = @nombreCajaActual and id = @idCaja";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@nuevoNombreCaja", txtnombrecaja.Text);
                            actualizarCommand.Parameters.AddWithValue("@numeroCaja", txtnumerocaja.Text);
                            actualizarCommand.Parameters.AddWithValue("@nombreCajaActual", nombreCajaActual);
                            actualizarCommand.Parameters.AddWithValue("@idCaja", idCaja);
                            actualizarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);
                            actualizarCommand.Parameters.AddWithValue("@responsable", responsablecmbx.SelectedItem.ToString());

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Caja actualizada con éxito.");
                                limpiarbtn_Click(sender, e);
                                MantCajas_Load(sender, e);
                                recargarbtn_Click(sender, e);
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
            txtnombrecaja.Text = "";
            txtnumerocaja.Text = "";
            estadochk.Checked = true;
            this.Text = "Mantenimiento de Cajas || Creando...";
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

        private void MantCajas_Load(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT usuario FROM login_usuario where estado = 1";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                responsablecmbx.Items.Add(lector["usuario"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al cargar las salas: {ex.Message}");
                }
            }

            string consulta = "select id, numero_caja, nombre_caja, responsable, estado from cajas";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tabladatos.DataSource = dt;
        }

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Text = "Mantenimiento de Cajas || Editando...";

            idCaja = Convert.ToInt32(tabladatos.SelectedCells[0].Value);
            txtnombrecaja.Text = tabladatos.SelectedCells[2].Value.ToString();
            nombreCajaActual = tabladatos.SelectedCells[2].Value.ToString();
            txtnumerocaja.Text = tabladatos.SelectedCells[1].Value.ToString();
            responsablecmbx.Text = tabladatos.SelectedCells[3].Value.ToString();
            estadochk.Checked = Convert.ToBoolean(tabladatos.SelectedCells[4].Value);
        }

        private void txtnombrecaja_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtnombrecaja.SelectionStart;

            txtnombrecaja.Text = txtnombrecaja.Text.ToUpper();

            txtnombrecaja.SelectionStart = posicion;
        }

        private void txtbuscador_Enter(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "(ID, Numero, Nombre Caja)")
            {
                txtbuscador.Text = "";
                txtbuscador.ForeColor = Color.Black;
            }
        }

        private void txtbuscador_Leave(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "")
            {
                txtbuscador.Text = "(ID, Numero, Nombre Caja)";
                txtbuscador.ForeColor = Color.Gray;
                MantCajas_Load(sender, e);
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
                        SELECT * FROM cajas
                        WHERE CAST(id AS VARCHAR) LIKE @buscar OR
                        nombre_caja LIKE @buscar OR
                        numero_caja LIKE @buscar OR
                        responsable LIKE @buscar";

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
            limpiarbtn_Click(sender, e);
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            txtbuscador.Text = "(ID, Numero, Nombre Caja)";
            limpiarbtn_Click(sender, e);
        }

        private void recargarbtn_Click(object sender, EventArgs e)
        {
            responsablecmbx.Items.Clear();
            MantCajas_Load(sender, e);
        }
    }
}
