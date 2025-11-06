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
            if (string.IsNullOrWhiteSpace(txtnumeroMesa.Text) || string.IsNullOrWhiteSpace(capacidadtxt.Text) || string.IsNullOrWhiteSpace(idsalaconsulta.Text))
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

            if (!int.TryParse(txtnumeroMesa.Text, out int numeromesa))
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
                        string queryInsertar = @"
                        INSERT INTO Mesa (IdSala, Numero, Capacidad, Estado, Ocupado)
                        VALUES (@IdSala, @Numero, @Capacidad, @Estado, @Ocupado)";

                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@IdSala", Convert.ToInt32(idsalaconsulta.Text));
                            insertarCommand.Parameters.AddWithValue("@Numero", numeromesa);
                            insertarCommand.Parameters.AddWithValue("@Capacidad", capacidad);
                            insertarCommand.Parameters.AddWithValue("@Estado", estadochk.Checked ? 1 : 0);
                            insertarCommand.Parameters.AddWithValue("@Ocupado", ocupadochk.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Mesa registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiarbtn_Click(sender, e);
                                recargarbtn_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar la mesa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        string queryActualizar = @"
                        UPDATE Mesa
                        SET IdSala = @IdSala, Numero = @Numero, Capacidad = @Capacidad, Estado = @Estado, Ocupado = @Ocupado
                        WHERE IdMesa = @IdMesa";

                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@IdMesa", MesaID);
                            actualizarCommand.Parameters.AddWithValue("@IdSala", Convert.ToInt32(idsalaconsulta.Text));
                            actualizarCommand.Parameters.AddWithValue("@Numero", numeromesa);
                            actualizarCommand.Parameters.AddWithValue("@Capacidad", capacidad);
                            actualizarCommand.Parameters.AddWithValue("@Estado", estadochk.Checked ? 1 : 0);
                            actualizarCommand.Parameters.AddWithValue("@Ocupado", ocupadochk.Checked ? 1 : 0);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Mesa actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiarbtn_Click(sender, e);
                                recargarbtn_Click(sender, e);
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
            txtnumeroMesa.Text = "";
            txtcapacidad.Text = "";
            MantMesas_Load(sender, e);
            recargarbtn_Click(sender, e);
        }

        private void MantMesas_Load(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();

            string consultaIdMesa = "SELECT ISNULL(MAX(IdMesa), 0) + 1 FROM Mesa";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(consultaIdMesa, conexion))
                {
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        idmesatxt.Text = resultado.ToString();
                    }
                    else
                    {
                        idmesatxt.Text = "?";
                    }
                }
            }

            string consultaIdSala = "SELECT ISNULL(MAX(IdSala), 0) + 1 FROM Sala";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(consultaIdSala, conexion))
                {
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        idsalatxt.Text = resultado.ToString();
                    }
                    else
                    {
                        idsalatxt.Text = "?";
                    }
                }
            }

            string consulta = "select IdMesa, IdSala, Numero, Capacidad, Ocupado, Estado from Mesa";

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

                            int estado = Convert.ToInt32(lector["Ocupado"]);
                            tarjeta.BackColor = (estado == 1) ? Color.LightCoral : Color.LightGreen;

                            tarjeta.Tag = new
                            {
                                Id = Convert.ToInt32(lector["IdMesa"]),
                                Estado = estado
                            };

                            Label lblMesa = new Label();
                            lblMesa.Text = "Mesa # " + lector["Numero"].ToString();
                            lblMesa.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                            lblMesa.AutoSize = false;
                            lblMesa.TextAlign = ContentAlignment.MiddleCenter;
                            lblMesa.Dock = DockStyle.Top;

                            Label lblSala = new Label();
                            lblSala.Text = "Sala: " + lector["IdSala"].ToString();
                            lblSala.Dock = DockStyle.Top;
                            lblSala.TextAlign = ContentAlignment.MiddleCenter;

                            Label lblAsientos = new Label();
                            lblAsientos.Text = "Asientos: " + lector["Capacidad"].ToString();
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
                        SELECT * FROM Mesa
                        WHERE CAST(IdMesa AS VARCHAR) LIKE @buscar OR
                        IdSala LIKE @buscar OR
                        Numero LIKE @buscar OR
                        Capacidad LIKE @buscar";

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

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            limpiarbtn_Click(sender, e);
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 1;
            txtnumeroMesa.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnombresala.Text) || string.IsNullOrEmpty(capacidadtxt.Text) || string.IsNullOrEmpty(pisotxt.Text))
            {
                MessageBox.Show("Error: No deje campos vacíos.");
                return;
            }

            if (!int.TryParse(capacidadtxt.Text, out int capacidad))
            {
                MessageBox.Show("La capacidad solo admite números.");
                capacidadtxt.Clear();
                capacidadtxt.Focus();
                return;
            }

            if (!int.TryParse(pisotxt.Text, out int piso))
            {
                MessageBox.Show("Piso solo admite números.");
                capacidadtxt.Clear();
                capacidadtxt.Focus();
                return;
            }

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();

                try
                {
                    if (SalaID == 0)
                    {
                        string nuevaSala = @"
                        INSERT INTO Sala (Nombre, Capacidad, Piso, Activo)
                        VALUES (@Nombre, @Capacidad, @Piso, @Activo);
                        SELECT SCOPE_IDENTITY();";

                        using (SqlCommand insertarSala = new SqlCommand(nuevaSala, conexion))
                        {
                            insertarSala.Parameters.AddWithValue("@Nombre", txtnombresala.Text);
                            insertarSala.Parameters.AddWithValue("@Capacidad", capacidad);
                            insertarSala.Parameters.AddWithValue("@Piso", piso);
                            insertarSala.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);

                            object resultado = insertarSala.ExecuteScalar();

                            if (resultado != null)
                            {
                                SalaID = Convert.ToInt32(resultado);
                                MessageBox.Show("Sala registrada con éxito (ID: " + SalaID + ").");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo registrar la sala.");
                            }
                        }
                    }
                    else
                    {
                        string actualizarSala = @"
                        UPDATE Sala 
                        SET Nombre = @Nombre, Capacidad = @Capacidad, Piso = @Piso, Activo = @Activo
                        WHERE IdSala = @IdSala;";

                        using (SqlCommand actualizarCommand = new SqlCommand(actualizarSala, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@IdSala", SalaID);
                            actualizarCommand.Parameters.AddWithValue("@Nombre", txtnombresala.Text);
                            actualizarCommand.Parameters.AddWithValue("@Capacidad", capacidad);
                            actualizarCommand.Parameters.AddWithValue("@Piso", piso);
                            actualizarCommand.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Sala actualizada con éxito.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar la sala.");
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

        private void ocupadochk_CheckedChanged(object sender, EventArgs e)
        {
            if (ocupadochk.Checked == true)
            {
                ocupadochk.Text = "Si";
                ocupadochk.ForeColor = Color.Red;
            }
            else
            {
                ocupadochk.Text = "No";
                ocupadochk.ForeColor = Color.Lime;
            }
        }

        private void estadomesa_CheckedChanged(object sender, EventArgs e)
        {
            if (estadomesa.Checked == true)
            {
                estadomesa.Text = "Activo";
                estadomesa.ForeColor = Color.Lime;
            }
            else
            {
                estadomesa.Text = "Inactivo";
                estadomesa.ForeColor = Color.Red;
            }
        }

        private void estadochk_CheckedChanged_1(object sender, EventArgs e)
        {
            if (estadochk.Checked == true)
            {
                estadochk.Text = "Activo";
                estadochk.ForeColor = Color.Lime;
            }
            else
            {
                estadochk.Text = "Inactivo";
                estadochk.ForeColor = Color.Red;
            }
        }

        public int Estadobuscarsala = 1;

        private void buscarsala_Click(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();
            string puesto = "select IdSala, Nombre from Sala";

            SqlDataAdapter adaptador = new SqlDataAdapter(puesto, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            salaconsultadt.DataSource = dt;

            if (Estadobuscarsala == 1)
            {
                buscarsala.Image = Proyecto_restaurante.Properties.Resources.cancelar1;
                toolTip1.SetToolTip(buscarsala, "Cancelar búsqueda");
                salapanel.Visible = true;

                Estadobuscarsala = 0;
            }
            else
            {
                buscarsala.Image = Proyecto_restaurante.Properties.Resources.busqueda1;
                toolTip1.SetToolTip(buscarsala, "Buscar sala");
                salapanel.Visible = false;

                Estadobuscarsala = 1;
            }
        }

        private void salaconsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idconsultatxt.Text = salaconsultadt.SelectedCells[0].Value.ToString();
            salaconsultatxt.Text = salaconsultadt.SelectedCells[1].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            idsalaconsulta.Text = idconsultatxt.Text;
            salatxt.Text = salaconsultatxt.Text;
            buscarsala_Click(sender, e);
            guardarbtn.Focus();
        }

        private void txtnombresala_TextChanged(object sender, EventArgs e)
        {
            //int posicion = txtnombresala.SelectionStart;

            //txtnombresala.Text = txtnumeroMesa.Text.ToUpper();

            //txtnombresala.SelectionStart = posicion;
        }
    }
}
