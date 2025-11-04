using PdfSharp.Snippets.Drawing;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto_restaurante
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cajaspanel.Location = new Point(221, 4);
            cajaspanel.BringToFront();
            cajaspanel.Visible = true;
        }

        private string IDModificar;
        public int PersonaID;
        public int PermisosUsuarioID;

        private void guardatbtn_Click(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(IDModificar))
                    {
                        string queryInsertar = "INSERT INTO cajas (nombre_caja, numero_caja, estado, responsable) VALUES (@nombreCaja, @numeroCaja, @estado, @responsable)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@responsable", idresponsabletxt.Text);
                            insertarCommand.Parameters.AddWithValue("@nombreCaja", nombrecajatxt.Text);
                            insertarCommand.Parameters.AddWithValue("@numeroCaja", numerocajatxt.Text);
                            insertarCommand.Parameters.AddWithValue("@estado", estadocajachk.Checked ? 1 : 0);

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
                            actualizarCommand.Parameters.AddWithValue("@id", IDModificar.ToString());
                            actualizarCommand.Parameters.AddWithValue("@numeroCaja", numerocajatxt.Text);
                            actualizarCommand.Parameters.AddWithValue("@nombreCaja", nombrecajatxt.Text);
                            actualizarCommand.Parameters.AddWithValue("@estado", estadocajachk.Checked ? 1 : 0);
                            actualizarCommand.Parameters.AddWithValue("@responsable", idresponsabletxt.Text);

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
            nombrecajatxt.Text = "";
            numerocajatxt.Text = "";
            idresponsabletxt.Text = "";
            responsabletxt.Text = "";
            responsablepanel.Visible = false;
            estadocajachk.Checked = true;
        }

        private void estadochk_CheckedChanged(object sender, EventArgs e)
        {
            if (estadocajachk.Checked == true)
            {
                estadocajachk.Text = "Activo";
                estadocajachk.ForeColor = Color.Lime;
            }
            else if (estadocajachk.Checked == false)
            {

                estadocajachk.Text = "Inactivo";
                estadocajachk.ForeColor = Color.Red;
            }
        }

        private void MantCajas_Load(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();

            //using (SqlConnection conexion = new SqlConnection(conexionString))
            //{
            //    try
            //    {
            //        conexion.Open();

            //        string query = "SELECT usuario FROM login_usuario where estado = 1";
            //        using (SqlCommand comando = new SqlCommand(query, conexion))
            //        {
            //            using (SqlDataReader lector = comando.ExecuteReader())
            //            {
            //                while (lector.Read())
            //                {
            //                    //responsablecmbx.Items.Add(lector["usuario"].ToString());
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Ocurrió un error al cargar las salas: {ex.Message}");
            //    }
            //}

            string consulta = "select id, numero_caja, nombre_caja, responsable, estado from cajas";

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
            //MantCajas_Load(sender, e);
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            IDModificar = "";
        }

        private void buscarresponsable_Click(object sender, EventArgs e)
        {

        }

        private void Configuracion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuariospanel.Location = new Point(221, 4);
            usuariospanel.BringToFront();

            string conexionString = ConexionBD.ConexionSQL();
            string consulta = @"
            SELECT 
                u.IdUsuario,
                u.Login,
                p.NombreCompleto,
                e.IdEmpleado
            FROM Usuario u
            LEFT JOIN Persona p ON u.IdPersona = p.IdPersona
            LEFT JOIN Empleado e ON e.IdPersona = p.IdPersona
            WHERE u.Activo = 1 AND p.Activo = 1;
            ";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tablausuarios.DataSource = dt;

            if (tablausuarios.Columns.Contains("IdEmpleado"))
            {
                tablausuarios.Columns["IdEmpleado"].Visible = false;
            }

            usuariospanel.Visible = true;
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idempleadotxt.Text) || string.IsNullOrEmpty(nombreempleadotxt.Text) ||
        string.IsNullOrEmpty(txtRegistroUsuario.Text) || string.IsNullOrEmpty(txtRegistroPass.Text) || string.IsNullOrEmpty(txtconfirmarpass.Text))
            {
                MessageBox.Show("Error: No deje campos vacíos.");
                return;
            }

            if (txtRegistroPass.Text != txtconfirmarpass.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                SqlTransaction trans = conexion.BeginTransaction();

                try
                {
                    string verificarUsuario = "SELECT COUNT(*) FROM Usuario WHERE IdPersona = @IdPersona";
                    using (SqlCommand cmdVerificar = new SqlCommand(verificarUsuario, conexion, trans))
                    {
                        cmdVerificar.Parameters.AddWithValue("@IdPersona", PersonaID);
                        int existe = (int)cmdVerificar.ExecuteScalar();

                        if (existe == 0)
                        {
                            string nuevoUsuario = @"
                            INSERT INTO Usuario (Login, Contrasena, IdPersona, Activo, CreadoEn)
                            VALUES (@Login, @Contrasena, @IdPersona, @Activo, GETDATE());
                            SELECT SCOPE_IDENTITY();";

                            using (SqlCommand insertarUsuario = new SqlCommand(nuevoUsuario, conexion, trans))
                            {
                                insertarUsuario.Parameters.AddWithValue("@Login", txtRegistroUsuario.Text);
                                insertarUsuario.Parameters.AddWithValue("@Contrasena", txtRegistroPass.Text);
                                insertarUsuario.Parameters.AddWithValue("@IdPersona", PersonaID);
                                insertarUsuario.Parameters.AddWithValue("@Activo", estadoempleadochk.Checked ? 1 : 0);

                                insertarUsuario.ExecuteScalar();
                            }

                            trans.Commit();
                            MessageBox.Show("Usuario registrado con éxito.");
                        }
                        else
                        {
                            string actualizarUsuario = @"
                            UPDATE Usuario 
                            SET Login = @Login, Contrasena = @Contrasena, Activo = @Activo
                            WHERE IdPersona = @IdPersona";

                            using (SqlCommand actualizarCommand = new SqlCommand(actualizarUsuario, conexion, trans))
                            {
                                actualizarCommand.Parameters.AddWithValue("@Login", txtRegistroUsuario.Text);
                                actualizarCommand.Parameters.AddWithValue("@Contrasena", txtRegistroPass.Text);
                                actualizarCommand.Parameters.AddWithValue("@Activo", estadoempleadochk.Checked ? 1 : 0);
                                actualizarCommand.Parameters.AddWithValue("@IdPersona", PersonaID);

                                actualizarCommand.ExecuteNonQuery();
                            }

                            trans.Commit();
                            MessageBox.Show("Usuario actualizado con éxito.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
        }

        public int Estadobuscarpuesto = 1;

        private void buscarempleado_Click(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();
            string empleado = "SELECT \r\n    e.IdEmpleado,\r\n    e.IdPersona AS Persona,\r\n    p.NombreCompleto\r\nFROM Empleado e\r\nLEFT JOIN Persona p ON e.IdPersona = p.IdPersona\r\nLEFT JOIN PersonaDocumento pd ON p.IdPersona = pd.IdPersona\r\nWHERE e.Activo = 1 AND p.Activo = 1;";

            SqlDataAdapter adaptador = new SqlDataAdapter(empleado, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            empleadousuariodt.DataSource = dt;

            if (Estadobuscarpuesto == 1)
            {
                buscarempleado.Image = Proyecto_restaurante.Properties.Resources.cancelar1;
                //toolTip1.SetToolTip(buscarpuesto, "Cancelar búsqueda");
                empleadopanel.Visible = true;

                Estadobuscarpuesto = 0;
            }
            else
            {
                buscarempleado.Image = Proyecto_restaurante.Properties.Resources.busqueda1;
                //toolTip1.SetToolTip(buscarpuesto, "Buscar departamento");
                empleadopanel.Visible = false;

                Estadobuscarpuesto = 1;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            idempleadotxt.Text = idempleadoconsulta.Text;
            nombreempleadotxt.Text = nombreempleadoconsulta.Text;
            buscarempleado_Click(sender, e);
        }

        private void txtRegistroUsuario_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtRegistroUsuario.SelectionStart;

            txtRegistroUsuario.Text.ToUpper();

            txtRegistroUsuario.SelectionStart = posicion;
        }

        private void empleadousuariodt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = empleadousuariodt.Rows[e.RowIndex];

            idempleadoconsulta.Text = fila.Cells["IdEmpleado"].Value.ToString();
            PersonaID = Convert.ToInt32(fila.Cells["Persona"].Value);
            nombreempleadoconsulta.Text = fila.Cells["NombreCompleto"].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            IDModificar = "";
        }

        private void tablausuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = tablausuarios.Rows[e.RowIndex];

                if (fila.Cells["IdEmpleado"].Value != DBNull.Value)
                {
                    int idEmpleado = Convert.ToInt32(fila.Cells["IdEmpleado"].Value);
                    PermisosUsuarioID = Convert.ToInt32(fila.Cells["IdUsuario"].Value);

                    idusuariopermiso.Text = fila.Cells["IdUsuario"].Value.ToString();
                    usuariologin.Text = fila.Cells["Login"].Value.ToString();

                    string rutaImagenes = @"C:\SistemaArchivos\Empleados\";
                    string rutaImagenEmpleado = Path.Combine(rutaImagenes, idEmpleado + ".jpg");

                    if (usuarioimg.Image != null)
                    {
                        usuarioimg.Image.Dispose();
                        usuarioimg.Image = null;
                    }

                    if (File.Exists(rutaImagenEmpleado))
                    {
                        using (FileStream fs = new FileStream(rutaImagenEmpleado, FileMode.Open, FileAccess.Read))
                        {
                            usuarioimg.Image = Image.FromStream(fs);
                        }
                    }
                    else
                    {
                        usuarioimg.Image = Proyecto_restaurante.Properties.Resources.perfilcliente;
                    }
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            colores.Location = new Point(221, 4);
            colores.BringToFront();
            colores.Visible = true;
        }

        public int UsuarioID;

        private void guardarpermisosbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idusuariopermiso.Text))
            {
                MessageBox.Show("Error: No deje campos vacíos.");
                return;
            }

            string conexionString = ConexionBD.ConexionSQL();
            int idUsuario = Convert.ToInt32(idusuariopermiso.Text);

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string verificarQuery = "SELECT COUNT(*) FROM PermisosUsuario WHERE IdUsuario = @IdUsuario";
                    int existe = 0;

                    using (SqlCommand cmdVerificar = new SqlCommand(verificarQuery, conexion))
                    {
                        cmdVerificar.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());
                    }

                    if (existe == 0)
                    {
                        string queryInsertar = "INSERT INTO PermisosUsuario (IdUsuario, Admin) VALUES (@IdUsuario, @Admin)";
                        using (SqlCommand cmdInsertar = new SqlCommand(queryInsertar, conexion))
                        {
                            cmdInsertar.Parameters.AddWithValue("@IdUsuario", idUsuario);
                            cmdInsertar.Parameters.AddWithValue("@Admin", admin.Checked ? 1 : 0);
                            cmdInsertar.ExecuteNonQuery();
                        }

                        MessageBox.Show("Permisos asignados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string queryActualizar = "UPDATE PermisosUsuario SET Admin = @Admin WHERE IdUsuario = @IdUsuario";
                        using (SqlCommand cmdActualizar = new SqlCommand(queryActualizar, conexion))
                        {
                            cmdActualizar.Parameters.AddWithValue("@IdUsuario", idUsuario);
                            cmdActualizar.Parameters.AddWithValue("@Admin", admin.Checked ? 1 : 0);
                            cmdActualizar.ExecuteNonQuery();
                        }

                        MessageBox.Show("Permisos actualizados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            permisospanel.Location = new Point(221, 4);
            permisospanel.BringToFront();

            usuariospanel.Visible = false;

            permisospanel.Visible = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            usuariospanel.Location = new Point(221, 4);
            usuariospanel.BringToFront();

            permisospanel.Visible = false;

            usuariospanel.Visible = true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            cajaspanel.Visible = false;
            usuariospanel.Visible = false;
            colores.Visible = false;
            permisospanel.Visible = false;
        }

        private void agregar_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            numerocajatxt.Focus();
        }

        private string colorRGB = "";
        private string nombrePC = Environment.MachineName;
        private string conexionString = ConexionBD.ConexionSQL();

        private void guardarcolorbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(colorRGB))
            {
                MessageBox.Show("Debe seleccionar un color antes de guardar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();

                string query = @"
                IF EXISTS (SELECT 1 FROM Configuracion WHERE NombrePC = @NombrePC)
                    UPDATE Configuracion SET ColorPanel = @ColorPanel WHERE NombrePC = @NombrePC
                ELSE
                    INSERT INTO Configuracion (NombrePC, ColorPanel) VALUES (@NombrePC, @ColorPanel);";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@NombrePC", nombrePC);
                    cmd.Parameters.AddWithValue("@ColorPanel", colorRGB);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Exito, reinicie el sistema para que se apliquen los cambios!.",
                            "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buscarcolor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color colorSeleccionado = colorDialog.Color;

                    vistaprevia.BackColor = colorSeleccionado;

                    colorRGB = $"{colorSeleccionado.R},{colorSeleccionado.G},{colorSeleccionado.B}";
                }
            }
        }

        private void defaultcolor_Click(object sender, EventArgs e)
        {
            Color colorDefault = Color.Silver;

            vistaprevia.BackColor = colorDefault;

            colorRGB = $"{colorDefault.R},{colorDefault.G},{colorDefault.B}";
        }
    }
}

