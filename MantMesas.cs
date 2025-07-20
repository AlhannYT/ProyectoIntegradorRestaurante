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

        private int idMesa = 0;

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

            string conexionString = ConexionBD.ConexionSQL();

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
                            insertarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Mesa registrada con éxito.");
                                recargarbtn_Click(sender, e);
                                limpiarbtn_Click(sender, e);
                                MantMesas_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los datos.");
                            }
                        }
                    }
                    else
                    {
                        string verificarQuery = "SELECT COUNT(*) FROM mesas WHERE nombre_mesa = @nombreMesaActual and id=@IDMesaActual";
                        using (SqlCommand verificarCommand = new SqlCommand(verificarQuery, conexion))
                        {
                            verificarCommand.Parameters.AddWithValue("@nombreMesaActual", nombreMesaActual);
                            verificarCommand.Parameters.AddWithValue("@IDMesaActual", idMesa);
                        }

                        string queryActualizar = "UPDATE mesas SET sala = @sala, nombre_mesa = @nuevoNombreMesa, estado = @estado, num_asientos = @numAsientos WHERE id = @IDMesa and nombre_mesa = @nombreMesaActual";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@IDMesa", idMesa);
                            actualizarCommand.Parameters.AddWithValue("@nombreMesaActual", nombreMesaActual);
                            actualizarCommand.Parameters.AddWithValue("@nuevoNombreMesa", txtnombreMesa.Text);
                            actualizarCommand.Parameters.AddWithValue("@sala", salacmbx.SelectedItem.ToString());
                            actualizarCommand.Parameters.AddWithValue("@numAsientos", txtNumAsientos.Text);
                            actualizarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Mesa actualizada con éxito.");
                                limpiarbtn_Click(sender, e);
                                MantMesas_Load(sender, e);
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
            salacmbx.SelectedIndex = -1;
            txtnombreMesa.Text = "";
            txtNumAsientos.Text = "";
            this.Text = "Mantenimiento de Mesas || Creando...";
            MantMesas_Load(sender, e);
            estadochk.Checked = true;
            recargarbtn_Click(sender, e);
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT nombre_sala FROM salas where estado = 1";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                salacmbx.Items.Add(lector["nombre_sala"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al cargar las salas: {ex.Message}");
                }
            }

            string consulta = "select id, nombre_mesa, sala, num_asientos, estado from mesas";

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
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conectar = new SqlConnection(conexionString))
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
            limpiarbtn_Click(sender, e);
        }

        private void estadochk_CheckedChanged(object sender, EventArgs e)
        {
            if (estadochk.Checked == true)
            {
                estadochk.Text = "Disponible";
                estadochk.ForeColor = Color.Lime;
            }
            else if (estadochk.Checked == false)
            {

                estadochk.Text = "Reservada";
                estadochk.ForeColor = Color.Red;
            }
        }

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Text = "Mantenimiento de Mesas || Editando...";

            idMesa = Convert.ToInt32(tabladatos.SelectedCells[0].Value);
            txtnombreMesa.Text = tabladatos.SelectedCells[1].Value.ToString();
            nombreMesaActual = txtnombreMesa.Text;
            salacmbx.Text = tabladatos.SelectedCells[2].Value.ToString();
            txtNumAsientos.Text = tabladatos.SelectedCells[3].Value.ToString();

            estadochk.Checked = Convert.ToBoolean(tabladatos.SelectedCells[4].Value);
        }
    }
}
