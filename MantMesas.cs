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

            ocupadochk.Cursor = Cursors.Hand;
            estadomesa.Cursor = Cursors.Hand;
            estadochk.Cursor = Cursors.Hand;
            buscarsala.Cursor = Cursors.Hand;
            button2.Cursor = Cursors.Hand;
            button5.Cursor = Cursors.Hand;
            agregar.Cursor = Cursors.Hand;
            Editar.Cursor = Cursors.Hand;
        }

        public int MesaID;
        private int SalaID = 0;  // 0 = nueva sala, >0 = edicion

        private void guardarbtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtnumeroMesa.Text) ||
                string.IsNullOrWhiteSpace(txtcapacidad.Text) ||
                string.IsNullOrWhiteSpace(idsalaconsulta.Text))
            {
                MessageBox.Show("No debe dejar campos vacíos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtnumeroMesa.Text, out int numeroMesa) || numeroMesa <= 0)
            {
                MessageBox.Show("El número de mesa solo admite números > 0.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnumeroMesa.Focus();
                return;
            }

            if (!int.TryParse(txtcapacidad.Text, out int capacidad) || capacidad <= 0)
            {
                MessageBox.Show("La capacidad solo admite números > 0.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcapacidad.Focus();
                return;
            }

            if (!int.TryParse(idsalaconsulta.Text, out int idSala) || idSala <= 0)
            {
                MessageBox.Show("Debe seleccionar una sala válida.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string estado = estadomesa.Checked ? "libre" : "inactiva";
            bool ocupada = ocupadochk.Checked;

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();

                try
                {
                    if (MesaID == 0)
                    {
                        string queryInsertar = @"
                        INSERT INTO Mesa (IdSala, Numero, Capacidad, Estado, Ocupado, Reservado, IdGrupo, EsPrincipal)
                        VALUES (@IdSala, @Numero, @Capacidad, @Estado, @Ocupado, 0, 0, 0);";

                        using (SqlCommand cmd = new SqlCommand(queryInsertar, conexion))
                        {
                            cmd.Parameters.AddWithValue("@IdSala", idSala);
                            cmd.Parameters.AddWithValue("@Numero", numeroMesa);
                            cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                            cmd.Parameters.AddWithValue("@Estado", estado);
                            cmd.Parameters.AddWithValue("@Ocupado", ocupada ? 1 : 0);

                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Mesa registrada con éxito.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar la mesa.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        string queryActualizar = @"
                        UPDATE Mesa
                        SET IdSala   = @IdSala,
                        Numero   = @Numero,
                        Capacidad= @Capacidad,
                        Estado   = @Estado,
                        Ocupado  = @Ocupado
                        WHERE IdMesa = @IdMesa;";

                        using (SqlCommand cmd = new SqlCommand(queryActualizar, conexion))
                        {
                            cmd.Parameters.AddWithValue("@IdMesa", MesaID);
                            cmd.Parameters.AddWithValue("@IdSala", idSala);
                            cmd.Parameters.AddWithValue("@Numero", numeroMesa);
                            cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                            cmd.Parameters.AddWithValue("@Estado", estado);
                            cmd.Parameters.AddWithValue("@Ocupado", ocupada ? 1 : 0);

                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Mesa actualizada con éxito.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar la mesa.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            recargarbtn_Click(sender, e);
            limpiarbtn_Click(sender, e);
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            MesaID = 0;
            idmesatxt.Clear();
            txtnumeroMesa.Clear();
            txtcapacidad.Clear();
            idsalaconsulta.Clear();
            salatxt.Clear();

            ocupadochk.Checked = false;
            estadomesa.Checked = true;

            string conexionString = ConexionBD.ConexionSQL();
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                string consultaIdMesa = "SELECT ISNULL(MAX(IdMesa), 0) + 1 FROM Mesa;";
                using (SqlCommand cmd = new SqlCommand(consultaIdMesa, conexion))
                {
                    object resultado = cmd.ExecuteScalar();
                    idmesatxt.Text = Convert.ToInt32(resultado).ToString();
                }
            }
            txtnumeroMesa.Focus();
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
                PrepararNuevaSala();
                CargarSalasEnGrid();
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

            txtbuscador.Text = "";
            ActivoChk.Checked = false;
            AplicarFiltrosConsultaMesas();

            CargarSalas("", false);
            PrepararNuevaSala();
        }

        private void CargarPanelMesas(

              string texto = "",
              bool? soloOcupadas = null,
              bool? soloReservadas = null,
              bool? soloLibres = null)
        {
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();

                string sql = @"
                        SELECT 
                        m.IdMesa,
                        m.IdSala,
                        s.Nombre AS NombreSala,
                        m.Numero,
                        m.Capacidad,
                        m.Ocupado,
                        ISNULL(m.Reservado, 0) AS Reservado,
                        m.Estado
                        FROM Mesa m
                        INNER JOIN Sala s ON m.IdSala = s.IdSala
                        WHERE 1 = 1";

                if (!string.IsNullOrWhiteSpace(texto))
                {
                    sql += @"
                    AND (
                    CAST(m.IdMesa  AS varchar(10)) LIKE @filtro
                    OR CAST(m.Numero AS varchar(10)) LIKE @filtro
                    OR s.Nombre LIKE @filtro)";
                }

                if (soloOcupadas.HasValue && soloOcupadas.Value)
                {
                    sql += " AND m.Ocupado = 1";
                }

                if (soloReservadas.HasValue && soloReservadas.Value)
                {
                    sql += " AND ISNULL(m.Reservado,0) = 1";
                }

                if (soloLibres.HasValue && soloLibres.Value)
                {
                    sql += " AND m.Ocupado = 0";
                }

                sql += " ORDER BY m.IdSala, m.Numero;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    if (!string.IsNullOrWhiteSpace(texto))
                        comando.Parameters.AddWithValue("@filtro", "%" + texto + "%");

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        panelMesas.Controls.Clear();
                        botonActivo = null;
                        idMesaSeleccionada = -1;

                        while (lector.Read())
                        {
                            Button btnMesa = new Button
                            {
                                Width = 150,
                                Height = 100,
                                Margin = new Padding(10),
                                TextAlign = ContentAlignment.MiddleCenter,
                                Font = new Font("Segoe UI", 10, FontStyle.Bold)
                            };

                            bool ocupada = Convert.ToBoolean(lector["Ocupado"]);
                            bool reservada = Convert.ToBoolean(lector["Reservado"]);

                            if (ocupada)
                                btnMesa.BackColor = Color.LightCoral;
                            else if (reservada)
                                btnMesa.BackColor = Color.LightSkyBlue;
                            else
                                btnMesa.BackColor = Color.LightGreen;

                            int idMesa = Convert.ToInt32(lector["IdMesa"]);
                            int numero = Convert.ToInt32(lector["Numero"]);
                            string nombreSala = lector["NombreSala"].ToString();
                            int capacidad = Convert.ToInt32(lector["Capacidad"]);

                            btnMesa.Text =
                                $"Mesa #{numero}\nSala: {nombreSala}\nAsientos: {capacidad}";

                            btnMesa.Tag = new MesaInfo
                            {
                                Id = idMesa,
                                Ocupado = ocupada,
                                Reservado = reservada
                            };

                            btnMesa.Click += BtnMesa_Click;

                            panelMesas.Controls.Add(btnMesa);
                        }
                    }
                }
            }
        }

        private void AplicarFiltrosConsultaMesas()
        {
            string texto = txtbuscador.Text.Trim();

            if (texto == "Buscar por numero de Mesa o Sala")
            {
                texto = "";
            }

            bool? soloOcupadas = ConsulOcupadoChk.Checked ? (bool?)true : null;
            bool? soloReservadas = ReservadoChk.Checked ? (bool?)true : null;
            bool? soloLibres = ActivoChk.Checked ? (bool?)true : null;

            CargarPanelMesas(texto, soloOcupadas, soloReservadas, soloLibres);
        }

        private class MesaInfo
        {
            public int Id { get; set; }
            public bool Ocupado { get; set; }
            public bool Reservado { get; set; }
        }

        private Button botonActivo = null;
        private int idMesaSeleccionada = -1;

        private void BtnMesa_Click(object sender, EventArgs e)
        {
            Button btnSeleccionado = sender as Button;
            if (btnSeleccionado == null) return;

            if (botonActivo != null && botonActivo != btnSeleccionado)
            {
                MesaInfo anterior = botonActivo.Tag as MesaInfo;
                if (anterior != null)
                {
                    if (anterior.Ocupado)
                        botonActivo.BackColor = Color.LightCoral;
                    else if (anterior.Reservado)
                        botonActivo.BackColor = Color.LightSkyBlue;
                    else
                        botonActivo.BackColor = Color.LightGreen;     // libre
                }
            }

            botonActivo = btnSeleccionado;
            botonActivo.BackColor = Color.DodgerBlue;

            MesaInfo mesa = botonActivo.Tag as MesaInfo;
            idMesaSeleccionada = (mesa != null) ? mesa.Id : -1;
        }

        private void CargarMesaParaEdicion(int idMesa)
        {
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();

                string sql = @"
                SELECT 
                m.IdMesa,
                m.IdSala,
                m.Numero,
                m.Capacidad,
                m.Ocupado,
                m.Reservado,
                m.Estado,
                s.Nombre AS NombreSala
                FROM Mesa m
                LEFT JOIN Sala s ON m.IdSala = s.IdSala
                WHERE m.IdMesa = @IdMesa;";

                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@IdMesa", idMesa);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {

                            MesaID = Convert.ToInt32(dr["IdMesa"]);
                            idmesatxt.Text = MesaID.ToString();

                            idsalaconsulta.Text = dr["IdSala"].ToString();
                            salatxt.Text = dr["NombreSala"].ToString();

                            txtnumeroMesa.Text = dr["Numero"].ToString();
                            txtcapacidad.Text = dr["Capacidad"].ToString();

                            bool ocupado = dr["Ocupado"] != DBNull.Value && Convert.ToBoolean(dr["Ocupado"]);
                            ocupadochk.Checked = ocupado;

                            if (dr["Estado"] != DBNull.Value)
                            {
                                string est = dr["Estado"].ToString().Trim().ToLower();

                                bool activa = (est == "libre");
                                estadomesa.Checked = activa;
                            }
                        }
                    }
                }
            }

            tabControl2.SelectedTab = tabEventos;
            txtnumeroMesa.Focus();
        }

        private void recargarbtn_Click(object sender, EventArgs e)
        {
            MantMesas_Load(sender, e);
        }

        private void txtbuscador_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltrosConsultaMesas();
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            txtbuscador.Clear();
            ConsulOcupadoChk.Checked = false;
            ReservadoChk.Checked = false;
            ActivoChk.Checked = false;

            AplicarFiltrosConsultaMesas();
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
            if (string.IsNullOrWhiteSpace(txtnombresala.Text) ||
         string.IsNullOrWhiteSpace(capacidadtxt.Text) ||
         string.IsNullOrWhiteSpace(pisotxt.Text))
            {
                MessageBox.Show("Error: No deje campos vacíos.");
                return;
            }

            if (!int.TryParse(capacidadtxt.Text, out int capacidad) || capacidad < 0)
            {
                MessageBox.Show("La capacidad solo admite números.");
                capacidadtxt.Focus();
                return;
            }

            if (!int.TryParse(pisotxt.Text, out int piso) || piso < 0)
            {
                MessageBox.Show("Piso solo admite números.");
                pisotxt.Focus();
                return;
            }

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();

                if (SalaID == 0)
                {
                    string sql = @"
                            INSERT INTO Sala (Nombre, Capacidad, Piso, Activo)
                            VALUES (@Nombre, @Capacidad, @Piso, @Activo);
                            SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtnombresala.Text.Trim());
                        cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                        cmd.Parameters.AddWithValue("@Piso", piso);
                        cmd.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);

                        object result = cmd.ExecuteScalar();
                        SalaID = Convert.ToInt32(result);
                    }

                    MessageBox.Show("Sala registrada con éxito.");
                }
                else
                {
                    string sql = @"
                            UPDATE Sala
                            SET Nombre   = @Nombre,
                            Capacidad = @Capacidad,
                            Piso      = @Piso,
                            Activo    = @Activo
                            WHERE IdSala = @IdSala;";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@IdSala", SalaID);
                        cmd.Parameters.AddWithValue("@Nombre", txtnombresala.Text.Trim());
                        cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                        cmd.Parameters.AddWithValue("@Piso", piso);
                        cmd.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sala actualizada con éxito.");
                }
            }

            idsalatxt.Text = SalaID.ToString();
            CargarSalas(metbuscar.Text.Trim(), metfiltrochk.Checked);
        }

        private void CargarProximoIdSala()
        {
            string conexionString = ConexionBD.ConexionSQL();
            string consultaIdSala = "SELECT ISNULL(MAX(IdSala), 0) + 1 FROM Sala";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(consultaIdSala, conexion))
                {
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                        idsalatxt.Text = resultado.ToString();
                    else
                        idsalatxt.Text = "?";
                }
            }
        }

        private void CargarSalasEnGrid()
        {
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();

                string sql = @"
                SELECT 
                IdSala      AS ID,
                Nombre      AS Nombre,
                Piso        AS Piso,
                Capacidad   AS Capacidad,
                Activo
                FROM Sala
                ORDER BY Nombre;";

                using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    tabladatos.DataSource = dt;
                }
            }

            if (tabladatos.Columns.Contains("ID"))
                tabladatos.Columns["ID"].HeaderText = "ID";

            if (tabladatos.Columns.Contains("Nombre"))
                tabladatos.Columns["Nombre"].HeaderText = "Nombre";

            if (tabladatos.Columns.Contains("Piso"))
                tabladatos.Columns["Piso"].HeaderText = "Piso";

            if (tabladatos.Columns.Contains("Capacidad"))
                tabladatos.Columns["Capacidad"].HeaderText = "Capacidad";

            if (tabladatos.Columns.Contains("Activo"))
                tabladatos.Columns["Activo"].HeaderText = "Activo";
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
            string puesto = "SELECT IdSala, Nombre FROM Sala WHERE Activo = 1 ORDER BY Nombre;";

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
            if (e.RowIndex < 0) return;

            idconsultatxt.Text = salaconsultadt.Rows[e.RowIndex].Cells["IdSala"].Value.ToString();
            salaconsultatxt.Text = salaconsultadt.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            idsalaconsulta.Text = idconsultatxt.Text;
            salatxt.Text = salaconsultatxt.Text;
            buscarsala_Click(sender, e);
            guardarbtn.Focus();
        }

        private readonly string conexionString = ConexionBD.ConexionSQL();

        private void CargarSalas(string filtro = "", bool soloActivas = false)
        {
            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();

                string sql = @"
                    SELECT 
                    IdSala,
                    Nombre,
                    Piso,
                    Capacidad,
                    Activo
                    FROM Sala
                    WHERE (@f = '' 
                    OR Nombre LIKE '%' + @f + '%' 
                    OR CAST(IdSala AS varchar(10)) LIKE '%' + @f + '%')
                    AND (@soloActivas = 0 OR Activo = 1)
                    ORDER BY Nombre;";

                using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@f", filtro ?? "");
                    da.SelectCommand.Parameters.AddWithValue("@soloActivas", soloActivas ? 1 : 0);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    tabladatos.DataSource = dt;
                }
            }

            if (tabladatos.Columns.Contains("IdSala"))
                tabladatos.Columns["IdSala"].HeaderText = "ID";
            if (tabladatos.Columns.Contains("Nombre"))
                tabladatos.Columns["Nombre"].HeaderText = "Nombre";
            if (tabladatos.Columns.Contains("Piso"))
                tabladatos.Columns["Piso"].HeaderText = "Piso";
            if (tabladatos.Columns.Contains("Capacidad"))
                tabladatos.Columns["Capacidad"].HeaderText = "Capacidad";
            if (tabladatos.Columns.Contains("Activo"))
                tabladatos.Columns["Activo"].HeaderText = "Activo";
        }

        private void PrepararNuevaSala()
        {
            SalaID = 0;
            CargarProximoIdSala();

            txtnombresala.Clear();
            pisotxt.Clear();
            capacidadtxt.Clear();
            estadochk.Checked = true;
            txtnombresala.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrepararNuevaSala();
        }

        private void metbuscar_TextChanged(object sender, EventArgs e)
        {
            CargarSalas(metbuscar.Text.Trim(), metfiltrochk.Checked);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            metbuscar.Clear();
            metfiltrochk.Checked = false;
            CargarSalas("", false);
            CargarSalasEnGrid();
        }

        private void tabladatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = tabladatos.Rows[e.RowIndex];
            if (row.Cells["IdSala"].Value == null) return;

            SalaID = Convert.ToInt32(row.Cells["IdSala"].Value);
            idsalatxt.Text = SalaID.ToString();

            txtnombresala.Text = row.Cells["Nombre"].Value?.ToString();
            pisotxt.Text = row.Cells["Piso"].Value?.ToString();
            capacidadtxt.Text = row.Cells["Capacidad"].Value?.ToString();

            bool activo = false;
            if (row.Cells["Activo"].Value != DBNull.Value)
                activo = Convert.ToBoolean(row.Cells["Activo"].Value);

            estadochk.Checked = activo;
        }

        private void metfiltrochk_CheckedChanged(object sender, EventArgs e)
        {
            CargarSalas(metbuscar.Text.Trim(), metfiltrochk.Checked);
        }

        private void selecmetodo_Click(object sender, EventArgs e)
        {
            if (tabladatos.CurrentRow == null || tabladatos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione una sala en la tabla.");
                return;
            }

            DataGridViewRow row = tabladatos.CurrentRow;

            if (row.Cells["IdSala"].Value == null) return;

            SalaID = Convert.ToInt32(row.Cells["IdSala"].Value);
            idsalatxt.Text = SalaID.ToString();
            txtnombresala.Text = row.Cells["Nombre"].Value?.ToString();
            pisotxt.Text = row.Cells["Piso"].Value?.ToString();
            capacidadtxt.Text = row.Cells["Capacidad"].Value?.ToString();

            bool activo = false;
            if (row.Cells["Activo"].Value != DBNull.Value)
                activo = Convert.ToBoolean(row.Cells["Activo"].Value);

            estadochk.Checked = activo;
        }
        private void Editar_Click(object sender, EventArgs e)
        {
            if (idMesaSeleccionada <= 0)
            {
                MessageBox.Show("Seleccione una mesa en la lista.");
                return;
            }

            CargarMesaParaEdicion(idMesaSeleccionada);

            tabControl2.SelectedIndex = 1;
            txtnumeroMesa.Focus();
        }

        private void ConsulOcupadoChk_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltrosConsultaMesas();
        }

        private void ReservadoChk_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltrosConsultaMesas();
        }

        private void ActivoChk_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltrosConsultaMesas();
        }

        private void txtbuscador_Enter(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "Buscar por numero de Mesa o Sala")
            {
                txtbuscador.Text = "";
            }
        }
        private void txtbuscador_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbuscador.Text))
            {
                txtbuscador.Text = "Buscar por numero de Mesa o Sala";
            }
        }
    }
}
