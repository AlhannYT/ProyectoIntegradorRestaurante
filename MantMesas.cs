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

        public int MesaID;
        private int SalaID;


        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombreMesa.Text) || string.IsNullOrWhiteSpace(capacidadtxt.Text) || string.IsNullOrWhiteSpace(txtIdSala.Text))
            {
                MessageBox.Show("No debe dejar campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtcapacidad.Text, out int capacidad))
            {
                MessageBox.Show("La capacidad solo admite números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcapacidad.Clear();
                txtcapacidad.Focus();
                return;
            }

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (MesaID == 0)
                    {
                        // Insertar nueva mesa
                        string queryInsertar = @"
                        INSERT INTO Mesa (IdSala, Numero, Capacidad, Estado, Ocupado)
                        VALUES (@IdSala, @Numero, @Capacidad, @Estado, @Ocupado)";

                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@IdSala", Convert.ToInt32(txtids.Text));
                            insertarCommand.Parameters.AddWithValue("@Numero", numero);
                            insertarCommand.Parameters.AddWithValue("@Capacidad", capacidad);
                            insertarCommand.Parameters.AddWithValue("@Estado", estadochk.Checked ? 1 : 0);
                            insertarCommand.Parameters.AddWithValue("@Ocupado", ocupadocheck.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Mesa registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiarCampos();
                                cargarMesas();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar la mesa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        // Actualizar mesa existente
                        string queryActualizar = @"
                    UPDATE Mesa
                    SET IdSala = @IdSala, Numero = @Numero, Capacidad = @Capacidad, Estado = @Estado, Ocupado = @Ocupado
                    WHERE IdMesa = @IdMesa";

                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@IdMesa", MesaID);
                            actualizarCommand.Parameters.AddWithValue("@IdSala", Convert.ToInt32(txtIdSala.Text));
                            actualizarCommand.Parameters.AddWithValue("@Numero", numero);
                            actualizarCommand.Parameters.AddWithValue("@Capacidad", capacidad);
                            actualizarCommand.Parameters.AddWithValue("@Estado", estadochk.Checked ? 1 : 0);
                            actualizarCommand.Parameters.AddWithValue("@Ocupado", ocupadocheck.Checked ? 1 : 0);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Mesa actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiarCampos();
                                cargarMesas();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar la mesa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            //salacmbx.SelectedIndex = -1;
            txtnombreMesa.Text = "";
            txtcapacidad.Text = "";
            MantMesas_Load(sender, e);
            //estadochk.Checked = true;
            recargarbtn_Click(sender, e);
        }

        private void txtnombreMesa_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtnombreMesa.SelectionStart;

            txtnombreMesa.Text = txtnombreMesa.Text.ToUpper();

            txtnombreMesa.SelectionStart = posicion;
        }

        private void MantMesas_Load(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();

            //using (SqlConnection conexion = new SqlConnection(conexionString))
            //{
            //    try
            //    {
            //        conexion.Open();

            //        string query = "SELECT nombre_sala FROM salas WHERE estado = 1";
            //        using (SqlCommand comando = new SqlCommand(query, conexion))
            //        {
            //            using (SqlDataReader lector = comando.ExecuteReader())
            //            {
            //                while (lector.Read())
            //                {
            //                    salacmbx.Items.Add(lector["nombre_sala"].ToString());
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Ocurrió un error al cargar las salas: {ex.Message}");
            //    }
            //}

            string consulta = "select IdMesa, IdSala, Numero, Capacidad, Estado from Mesa";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        panelMesas.Controls.Clear();

                        while (lector.Read())
                        {
                            Panel tarjeta = new Panel();
                            tarjeta.Width = 150;
                            tarjeta.Height = 100;
                            tarjeta.BorderStyle = BorderStyle.FixedSingle;
                            tarjeta.Margin = new Padding(10);

                            int estado = Convert.ToInt32(lector["estado"]);
                            tarjeta.BackColor = (estado == 1) ? Color.LightGreen : Color.LightCoral;

                            tarjeta.Tag = new
                            {
                                Id = Convert.ToInt32(lector["id"]),
                                Estado = estado
                            };

                            Label lblMesa = new Label();
                            lblMesa.Text = lector["nombre_mesa"].ToString();
                            lblMesa.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                            lblMesa.AutoSize = false;
                            lblMesa.TextAlign = ContentAlignment.MiddleCenter;
                            lblMesa.Dock = DockStyle.Top;

                            Label lblSala = new Label();
                            lblSala.Text = "Sala: " + lector["sala"].ToString();
                            lblSala.Dock = DockStyle.Top;
                            lblSala.TextAlign = ContentAlignment.MiddleCenter;

                            Label lblAsientos = new Label();
                            lblAsientos.Text = "Asientos: " + lector["num_asientos"].ToString();
                            lblAsientos.Dock = DockStyle.Bottom;
                            lblAsientos.TextAlign = ContentAlignment.MiddleCenter;

                            tarjeta.Controls.Add(lblAsientos);
                            tarjeta.Controls.Add(lblSala);
                            tarjeta.Controls.Add(lblMesa);

                            tarjeta.Click += Tarjeta_Click;

                            panelMesas.Controls.Add(tarjeta);
                        }
                    }
                }
            }
        }

        private Color colorSeleccionado = Color.DodgerBlue;
        private int idMesaSeleccionada = -1;
        private Panel tarjetaActiva = null;

        private void Tarjeta_Click(object sender, EventArgs e)
        {
            Panel tarjetaSeleccionada = sender as Panel;

            if (tarjetaSeleccionada != null)
            {
                if (tarjetaActiva != null)
                {
                    dynamic anterior = tarjetaActiva.Tag;
                    tarjetaActiva.BackColor = (anterior.Estado == 1) ? Color.LightGreen : Color.LightCoral;
                }

                tarjetaActiva = tarjetaSeleccionada;
                tarjetaSeleccionada.BackColor = Color.DodgerBlue;

                dynamic mesa = tarjetaSeleccionada.Tag;
                idMesaSeleccionada = mesa.Id;
            }
        }

        public void RecargarClick()
        {
            recargarbtn.PerformClick();
        }

        private void recargarbtn_Click(object sender, EventArgs e)
        {
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

                        //tabladatos.DataSource = dt;
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
            //if (txtbuscador.Text == "(ID, Nombre, Sala, N° Asientos)")
            //{
            //    txtbuscador.Text = "";
            //    txtbuscador.ForeColor = Color.Black;
            //}
        }

        private void txtbuscador_Leave(object sender, EventArgs e)
        {
            //if (txtbuscador.Text == "")
            //{
            //    txtbuscador.Text = "(ID, Nombre, Sala, N° Asientos)";
            //    txtbuscador.ForeColor = Color.Gray;
            //    MantMesas_Load(sender, e);
            //}
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            limpiarbtn_Click(sender, e);
        }

        private void estadochk_CheckedChanged(object sender, EventArgs e)
        {
            //if (estadochk.Checked == true)
            //{
            //    estadochk.Text = "Disponible";
            //    estadochk.ForeColor = Color.Lime;
            //}
            //else if (estadochk.Checked == false)
            //{

            //    estadochk.Text = "Reservada";
            //    estadochk.ForeColor = Color.Red;
            //}
        }

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //idMesa = Convert.ToInt32(tabladatos.SelectedCells[0].Value);
            //txtnombreMesa.Text = tabladatos.SelectedCells[1].Value.ToString();
            //nombreMesaActual = txtnombreMesa.Text;
            //salacmbx.Text = tabladatos.SelectedCells[2].Value.ToString();
            //txtNumAsientos.Text = tabladatos.SelectedCells[3].Value.ToString();

            //estadochk.Checked = Convert.ToBoolean(tabladatos.SelectedCells[4].Value);
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnombresala.Text) || string.IsNullOrEmpty(capacidadtxt.Text))
            {
                MessageBox.Show("Error: No deje campos vacíos.");
                return;
            }

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                SqlTransaction trans = conexion.BeginTransaction();

                try
                {
                    if (SalaID == 0)
                    {
                        string nuevaSala = @"
                        INSERT INTO Sala (Nombre, Capacidad, Activo)
                        VALUES (@Nombre, @Capacidad, @Activo);
                        SELECT SCOPE_IDENTITY();";

                        using (SqlCommand insertarPersona = new SqlCommand(nuevaSala, conexion, trans))
                        {
                            insertarPersona.Parameters.AddWithValue("@Nombre", txtnombresala.Text);
                            insertarPersona.Parameters.AddWithValue("@Capacidad", capacidadtxt.Text);
                            insertarPersona.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);
                        }

                        trans.Commit();
                        MessageBox.Show("Sala registrada con éxito.");
                    }
                    else
                    {
                        string actualizarSala = @"
                        UPDATE Sala 
                        SET Nombre = @Nombre, Capacidad = @Capacidad, Activo = @Activo,
                        WHERE IdSala = @IdSala";

                        using (SqlCommand actualizarCommand = new SqlCommand(actualizarSala, conexion, trans))
                        {
                            actualizarCommand.Parameters.AddWithValue("@IdSala", SalaID);
                            actualizarCommand.Parameters.AddWithValue("@Nombre", txtnombreMesa.Text);
                            actualizarCommand.Parameters.AddWithValue("@Capacidad", capacidadtxt.Text);
                            actualizarCommand.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);
                            actualizarCommand.ExecuteNonQuery();
                        }

                        trans.Commit();
                        MessageBox.Show("Sala actualizada con éxito.");
                    }
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
        }
    }
}
