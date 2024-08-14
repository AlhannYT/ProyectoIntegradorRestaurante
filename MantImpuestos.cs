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
    public partial class MantImpuestos : Form
    {
        public MantImpuestos()
        {
            InitializeComponent();
        }
        private string nombreImpuestoActual;
        private void MantImpuestos_Load(object sender, EventArgs e)
        {
            string conexion = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";
            string consulta = "select id, nombre_impuesto, porcentaje, fecha_registro, estado from impuestos";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tabladatos.DataSource = dt;
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtnombreimpuesto.Text) || string.IsNullOrEmpty(txtvalorimpuesto.Text))
            {
                MessageBox.Show("Error: No deje campos vacios.");
                return;
            }

            string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(nombreImpuestoActual))
                    {
                        string queryInsertar = "INSERT INTO impuestos (nombre_impuesto, porcentaje, fecha_registro, estado) VALUES (@nombre, @porcentaje, @fecha, @estado)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@nombre", txtnombreimpuesto.Text);
                            insertarCommand.Parameters.AddWithValue("@porcentaje", txtvalorimpuesto.Text);
                            insertarCommand.Parameters.AddWithValue("@fecha", fecharegistro.Value);
                            insertarCommand.Parameters.AddWithValue("@estado", estado.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Impuesto registrado con éxito.");
                                MantImpuestos_Load(sender, e);
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
                        string verificarPassQuery = "SELECT COUNT(*) FROM impuestos WHERE nombre_impuesto = @nombreImpuestoActual";
                        using (SqlCommand verificarPassCommand = new SqlCommand(verificarPassQuery, conexion))
                        {
                            verificarPassCommand.Parameters.AddWithValue("@nombreImpuestoActual", nombreImpuestoActual);
                        }

                        string queryActualizar = "UPDATE impuestos SET nombre_impuesto = @nuevoNombreImpuesto, porcentaje = @porcentajeImpuesto, estado= @estado where nombre_impuesto= @actualNombreImpuesto";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@actualNombreImpuesto", nombreImpuestoActual);
                            actualizarCommand.Parameters.AddWithValue("@nuevoNombreImpuesto", txtnombreimpuesto.Text);
                            actualizarCommand.Parameters.AddWithValue("@porcentajeImpuesto", txtvalorimpuesto.Text);
                            actualizarCommand.Parameters.AddWithValue("@estado", estado.Checked ? 1 : 0);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Impuesto actualizado con éxito.");
                                MantImpuestos_Load(sender, e);
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

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            txtvalorimpuesto.Text = "";
            txtnombreimpuesto.Text = "";
        }

        private void estado_CheckedChanged(object sender, EventArgs e)
        {
            if (estado.Checked == true)
            {
                estado.Text = "Activo";
                estado.ForeColor = Color.Lime;
            }
            else if (estado.Checked == false)
            {

                estado.Text = "Inactivo";
                estado.ForeColor = Color.Red;
            }
        }

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Text = "Mantenimiento de Usuarios || Editando...";
            txtnombreimpuesto.Text = tabladatos.SelectedCells[1].Value.ToString();
            nombreImpuestoActual = txtnombreimpuesto.Text;
            txtvalorimpuesto.Text = tabladatos.SelectedCells[2].Value.ToString();

            if (tabladatos.SelectedCells[3].Value != DBNull.Value)
            {
                DateTime fecha = Convert.ToDateTime(tabladatos.SelectedCells[3].Value);
                fecharegistro.Value = fecha;
            }
            else
            {
                fecharegistro.Value = DateTime.Now;
            }

            estado.Checked = Convert.ToBoolean(tabladatos.SelectedCells[4].Value);
        }

        private void txtnombreimpuesto_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtnombreimpuesto.SelectionStart;

            txtnombreimpuesto.Text = txtnombreimpuesto.Text.ToUpper();

            txtnombreimpuesto.SelectionStart = posicion;

            if (txtnombreimpuesto.Text == "")
            {
                RestablecerFormulario();
            }
        }


        private void RestablecerFormulario()
        {
            txtnombreimpuesto.Text = "";

            txtvalorimpuesto.Text = "";

            this.Text = "Mantenimiento de Usuarios || Creando...";

            nombreImpuestoActual = "";

            txtnombreimpuesto.Focus();

            estado.Text = "Activo";
            estado.ForeColor = Color.Lime;
            estado.Checked = true;

        }

        private void txtbuscador_Enter(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "(ID, Nombre, Porcentaje)")
            {
                txtbuscador.Text = "";
                txtbuscador.ForeColor = Color.Black;
            }
        }

        private void txtbuscador_Leave(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "")
            {
                txtbuscador.Text = "(ID, Nombre, Porcentaje)";
                txtbuscador.ForeColor = Color.Gray;
                MantImpuestos_Load(sender, e);
            }
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            txtbuscador.Text = "(ID, Nombre, Porcentaje)";
            txtbuscador.ForeColor = Color.Gray;

            txtnombreimpuesto.Text = "";

            txtvalorimpuesto.Text = "";

            this.Text = "Mantenimiento de Usuarios || Creando...";

            nombreImpuestoActual = "";

            txtnombreimpuesto.Focus();

            estado.Text = "Activo";
            estado.ForeColor = Color.Lime;
            estado.Checked = true;

            MantImpuestos_Load(sender, e);
        }
    }
}
