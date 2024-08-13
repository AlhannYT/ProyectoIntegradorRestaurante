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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proyecto_restaurante
{
    public partial class MantMonedas : Form
    {
        public MantMonedas()
        {
            InitializeComponent();
            txtsiglasmoneda.MaxLength = 3;
            txtsimbolomon.MaxLength = 1;

        }

        private string nombreMonedaActual;

        private void button1_Click(object sender, EventArgs e)
        {
            string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(nombreMonedaActual))
                    {
                        string queryInsertar = "INSERT INTO monedas (nombre_moneda, siglas_moneda, simbol_moneda, estado) VALUES (@nomMoneda, @sigMoneda, @simMoneda, @estado)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@nomMoneda", txtnombremoneda.Text);
                            insertarCommand.Parameters.AddWithValue("@sigMoneda", txtsiglasmoneda.Text);
                            insertarCommand.Parameters.AddWithValue("@simMoneda", txtsimbolomon.Text);
                            insertarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Moneda registrada con éxito.");
                                MantMonedas_Load(sender, e);
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
                        string verificarDepaQuery = "SELECT COUNT(*) FROM monedas WHERE nombre_moneda = @nombreMonedaActual";
                        using (SqlCommand verificarPassCommand = new SqlCommand(verificarDepaQuery, conexion))
                        {
                            verificarPassCommand.Parameters.AddWithValue("@nombreMonedaActual", nombreMonedaActual);
                        }

                        string queryActualizar = "UPDATE monedas SET nombre_moneda = @nuevoNombreMoneda, siglas_moneda = @siglasMoneda, simbol_moneda = @simboloMoneda, estado = @estado where nombre_moneda= @viejoNombreMoneda";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@viejoNombreMoneda", nombreMonedaActual);
                            actualizarCommand.Parameters.AddWithValue("@nuevoNombreMoneda", txtnombremoneda.Text);
                            actualizarCommand.Parameters.AddWithValue("@siglasMoneda", txtsiglasmoneda.Text);
                            actualizarCommand.Parameters.AddWithValue("@simboloMoneda", txtsimbolomon.Text);
                            actualizarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Moneda Actualizada actualizado con éxito.");
                                MantMonedas_Load(sender, e);
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

        private void txtbuscador_Enter(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "(ID, Nombre, Siglas)")
            {
                txtbuscador.Text = "";
                txtbuscador.ForeColor = Color.Black;
            }
        }

        private void txtbuscador_Leave(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "")
            {
                txtbuscador.Text = "(ID, Nombre, Siglas)";
                txtbuscador.ForeColor = Color.Gray;
                MantMonedas_Load(sender, e);
            }
        }

        private void MantMonedas_Load(object sender, EventArgs e)
        {
            string conexion = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";
            string consulta = "select * from monedas";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tabladatos.DataSource = dt;
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            txtnombremoneda.Text = "";
            txtsiglasmoneda.Text = "";
            txtsimbolomon.Text = "";
            estadochk.Checked = true;
            this.Text = "Mantenimiento de Monedas || Creando...";
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
            this.Text = "Mantenimiento de Monedas || Editando...";
            txtnombremoneda.Text = tabladatos.SelectedCells[1].Value.ToString();
            nombreMonedaActual = txtnombremoneda.Text;
            txtsiglasmoneda.Text = tabladatos.SelectedCells[2].Value.ToString();
            txtsimbolomon.Text = tabladatos.SelectedCells[3].Value.ToString();
            estadochk.Checked = Convert.ToBoolean(tabladatos.SelectedCells[4].Value);

        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            txtbuscador.Text = "(ID, Nombre, Siglas)";
            txtbuscador.ForeColor = Color.Gray;

            this.Text = "Mantenimiento de Monedas || Creando...";

            nombreMonedaActual = "";


            txtnombremoneda.Focus();

            estadochk.Text = "Activo";
            estadochk.ForeColor = Color.Lime;
            estadochk.Checked = true;

            MantMonedas_Load(sender, e);
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
                        SELECT * FROM monedas
                        WHERE CAST(id AS VARCHAR) LIKE @buscar OR
                        nombre_moneda LIKE @buscar OR
                        siglas_moneda LIKE @buscar";

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

        private void txtnombremoneda_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtnombremoneda.SelectionStart;

            txtnombremoneda.Text = txtnombremoneda.Text.ToUpper();

            txtnombremoneda.SelectionStart = posicion;
        }

        private void txtsiglasmoneda_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtsiglasmoneda.SelectionStart;

            txtsiglasmoneda.Text = txtsiglasmoneda.Text.ToUpper();

            txtsiglasmoneda.SelectionStart = posicion;
        }

        private void txtsiglasmoneda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (txtsiglasmoneda.Text.Length >= 3 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtsimbolomon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (txtsimbolomon.Text.Length >= 1 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
