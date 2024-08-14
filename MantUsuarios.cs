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
    public partial class MantUsuarios : Form
    {
        public MantUsuarios()
        {
            InitializeComponent();
        }
        private bool mensajeMostrado = false;
        private string nombreUsuarioActual;


        private void passView_CheckedChanged(object sender, EventArgs e)
        {
            if (passView.Checked == true)
            {
                passView.Image = Proyecto_restaurante.Properties.Resources.ojos_cruzados;
                txtRegistroPass.UseSystemPasswordChar = false;
                txtnuevapass.UseSystemPasswordChar = false;
                txtRegistroPass.Focus();
            }
            else if (passView.Checked == false)
            {
                passView.Image = Proyecto_restaurante.Properties.Resources.ojo;
                txtRegistroPass.UseSystemPasswordChar = true;
                txtnuevapass.UseSystemPasswordChar = true;
                txtRegistroPass.Focus();
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

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            RestablecerFormulario();
        }

        private void verificarbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegistroUsuario.Text))
            {
                MessageBox.Show("Error: Colocar un nombre.");
                return;
            }

            //cambia lo que dice "Server= Tu servidor", y los datos tuyos donde van, la base de datos va a ser la misma, pero el login y la contra es el tuyo
            string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string verificarQuery = "SELECT COUNT(*) FROM login_usuario WHERE usuario = @nombre";
                    using (SqlCommand verificarCommand = new SqlCommand(verificarQuery, conexion))
                    {
                        verificarCommand.Parameters.AddWithValue("@nombre", txtRegistroUsuario.Text);
                        int userCount = (int)verificarCommand.ExecuteScalar();

                        if (userCount > 0)
                        {
                            if (!mensajeMostrado)
                            {
                                DialogResult editar = MessageBox.Show("Ya existe un usuario con ese nombre. ¿Desea editarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                mensajeMostrado = true;

                                if (editar == DialogResult.Yes)
                                {
                                    string obtenerDatosQuery = "SELECT estado, privilegio FROM login_usuario WHERE usuario = @nombre";
                                    using (SqlCommand obtenerDatosCommand = new SqlCommand(obtenerDatosQuery, conexion))
                                    {
                                        obtenerDatosCommand.Parameters.AddWithValue("@nombre", txtRegistroUsuario.Text);

                                        using (SqlDataReader reader = obtenerDatosCommand.ExecuteReader())
                                        {
                                            if (reader.Read())
                                            {
                                                estadochk.Checked = reader.GetBoolean(0);
                                                privilegiochk.Checked = reader.GetBoolean(1);
                                            }
                                        }
                                    }
                                    estadochk.Enabled = true;
                                    privilegiochk.Enabled = true;
                                    nombreUsuarioActual = txtRegistroUsuario.Text;
                                    txtRegistroPass.Enabled = true;
                                    txtnuevapass.Visible = true;
                                    txtnuevapass.Enabled = true;
                                    confirmarpass.Text = "Confirmar Contraseña";
                                    confirmarpass.Visible = true;
                                    guardarbtn.Visible = true;
                                    verificarbtn.Visible = false;
                                    passView.Enabled = true;
                                    txtRegistroPass.Focus();
                                    this.Text = "Mantenimiento de Usuarios || Editando...";
                                    checkBox1.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("Operación cancelada.");
                                    return;
                                }
                            }
                        }
                        else
                        {
                            if (!mensajeMostrado)
                            {
                                estadochk.Enabled = true;
                                privilegiochk.Enabled = true;
                                txtRegistroPass.Enabled = true;
                                txtnuevapass.Visible = false;
                                txtnuevapass.Enabled = false;
                                confirmarpass.Visible = false;
                                guardarbtn.Visible = true;
                                verificarbtn.Visible = false;
                                passView.Enabled = true;
                                this.Text = "Mantenimiento de Usuarios || Creando...";
                                MessageBox.Show("Ingrese la contraseña y haga clic en 'Guardar Datos' para registrar el nuevo usuario.");
                                mensajeMostrado = true;
                            }
                        }
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && txtnuevapass.Visible == true)
            {
                if (txtRegistroPass.Text != txtnuevapass.Text)
                {
                    MessageBox.Show("Debe colocar la misma contraseña");
                    txtnuevapass.Text = "";
                    txtnuevapass.Focus();
                    return;
                }
            }

            string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(nombreUsuarioActual))
                    {
                        string queryInsertar = "INSERT INTO login_usuario (usuario, pass, privilegio, estado) VALUES (@nombre, @pass, @privilegio, @estado)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@nombre", txtRegistroUsuario.Text);
                            insertarCommand.Parameters.AddWithValue("@pass", txtRegistroPass.Text);
                            insertarCommand.Parameters.AddWithValue("@privilegio", privilegiochk.Checked ? 1 : 0);
                            insertarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Usuario registrado con éxito.");
                                MantUsuarios_Load(sender, e);
                                eliminarbtn_Click(sender, e);
                                RestablecerFormulario();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los datos.");
                            }
                        }
                    }
                    else
                    {
                        string verificarPassQuery = "SELECT COUNT(*) FROM login_usuario WHERE usuario = @nombreActual AND pass = @passAntigua";
                        using (SqlCommand verificarPassCommand = new SqlCommand(verificarPassQuery, conexion))
                        {
                            verificarPassCommand.Parameters.AddWithValue("@nombreActual", nombreUsuarioActual);
                            verificarPassCommand.Parameters.AddWithValue("@passAntigua", txtRegistroPass.Text);
                            int passCount = (int)verificarPassCommand.ExecuteScalar();

                            if (passCount == 0)
                            {
                                MessageBox.Show("La contraseña actual no es correcta.");
                                return;
                            }
                        }

                        string queryActualizar = "UPDATE login_usuario SET usuario = @nuevoNombre, pass = @pass, privilegio= @privilegio, estado = @estado WHERE usuario = @nombreActual";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@nuevoNombre", txtRegistroUsuario.Text);
                            actualizarCommand.Parameters.AddWithValue("@pass", txtnuevapass.Text);
                            actualizarCommand.Parameters.AddWithValue("@privilegio", privilegiochk.Checked ? 1 : 0);
                            actualizarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);
                            actualizarCommand.Parameters.AddWithValue("@nombreActual", nombreUsuarioActual);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Usuario actualizado con éxito.");
                                MantUsuarios_Load(sender, e);
                                RestablecerFormulario();
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

        private void privilegiochk_CheckedChanged(object sender, EventArgs e)
        {
            if (privilegiochk.Checked == true)
            {
                privilegiochk.Text = "Administrador";
                privilegiochk.ForeColor = Color.Yellow;
            }
            else if (privilegiochk.Checked == false)
            {
                privilegiochk.Text = "Usuario";
                privilegiochk.ForeColor = Color.White;
            }
        }


        private void RestablecerFormulario()
        {
            estadochk.Enabled = false;
            privilegiochk.Enabled = false;

            txtRegistroUsuario.Text = "";
            txtRegistroPass.Enabled = false;

            txtRegistroPass.Text = "";

            txtnuevapass.Text = "";
            txtnuevapass.Visible = false;
            txtnuevapass.Enabled = false;

            verificarbtn.Visible = true;

            guardarbtn.Visible = false;

            this.Text = "Mantenimiento de Usuarios || Creando...";

            nombreUsuarioActual = "";

            mensajeMostrado = false;

            txtRegistroUsuario.Focus();

            estadochk.Text = "Activo";
            estadochk.ForeColor = Color.Lime;
            estadochk.Checked = true;

            privilegiochk.Text = "Usuario";
            privilegiochk.ForeColor = Color.Black;
            privilegiochk.Checked = false;

            passView.Enabled = false;
            checkBox1.Enabled = false;

            passView.Checked = false;
            checkBox1.Checked = false;
            confirmarpass.Visible = false;

            button1.Enabled = false;
        }

        private void txtRegistroUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                verificarbtn_Click(sender, e);
                e.Handled = true;
            }
        }

        private void txtRegistroUsuario_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtRegistroUsuario.SelectionStart;

            txtRegistroUsuario.Text = txtRegistroUsuario.Text.ToUpper();

            txtRegistroUsuario.SelectionStart = posicion;

            if(txtRegistroUsuario.Text=="")
            {
                RestablecerFormulario();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                confirmarpass.Text = "Nueva Contraseña";
                confirmarpass.Visible = true;
                guardarbtn.Visible = true;
                verificarbtn.Visible = false;
            }
            else if (checkBox1.Checked == false)
            {
                confirmarpass.Text = "Confirmar Contraseña";
                confirmarpass.Visible = true;
                guardarbtn.Visible = true;
                verificarbtn.Visible = false;
            }
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
                        SELECT id, usuario, estado, privilegio from login_usuario
                        WHERE CAST(id AS VARCHAR) LIKE @buscar OR
                        usuario LIKE @buscar";

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

        private void MantUsuarios_Load(object sender, EventArgs e)
        {
            ConfirmPanelTransp.BackColor = Color.FromArgb(100, 0, 0, 0);

            button1.Enabled = false;
            string conexion = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";
            string consulta = "select id, usuario, estado, privilegio from login_usuario";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tabladatos.DataSource = dt;
        }

        private void txtbuscador_TextChanged(object sender, EventArgs e)
        {
            FiltroDatosBusqueda(txtbuscador.Text);
        }

        private void txtbuscador_Enter(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "(ID, Usuario)")
            {
                txtbuscador.Text = "";
                txtbuscador.ForeColor = Color.Black;
            }
        }

        private void txtbuscador_Leave(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "")
            {
                txtbuscador.Text = "(ID, Usuario)";
                txtbuscador.ForeColor = Color.Gray;
                MantUsuarios_Load(sender, e);
            }
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            txtbuscador.Text = "(ID, Usuario)";
            txtbuscador.ForeColor = Color.Gray;

            estadochk.Enabled = false;
            privilegiochk.Enabled = false;


            txtRegistroPass.Enabled = false;

            txtRegistroPass.Text = "";

            txtnuevapass.Text = "";
            txtnuevapass.Visible = false;
            txtnuevapass.Enabled = false;

            verificarbtn.Visible = true;

            guardarbtn.Visible = false;

            this.Text = "Mantenimiento de Usuarios || Creando...";

            nombreUsuarioActual = "";

            mensajeMostrado = false;

            txtRegistroUsuario.Focus();

            estadochk.Text = "Activo";
            estadochk.ForeColor = Color.Lime;
            estadochk.Checked = true;

            privilegiochk.Text = "Usuario";
            privilegiochk.ForeColor = Color.Black;
            privilegiochk.Checked = false;

            passView.Enabled = false;
            checkBox1.Enabled = false;

            passView.Checked = false;
            checkBox1.Checked = false;
            confirmarpass.Visible = false;

            button1.Enabled = false; //Boton de eliminar usuario (olvidé cambiarle el nombre xd)

            MantUsuarios_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelconfirmacion.Location = new Point(310, 94);
            panelconfirmacion.Visible = true;

            ConfirmPanelTransp.Location = new Point(0, 0);
            ConfirmPanelTransp.Visible = true;
        }

        private void cancelarbtn_Click(object sender, EventArgs e)
        {
            ConfirmPanelTransp.Location = new Point(764, 363);
            ConfirmPanelTransp.Visible = false;

            panelconfirmacion.Visible = false;
            panelconfirmacion.Location = new Point(470, 363);
        }

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRegistroUsuario.Text = tabladatos.SelectedCells[1].Value.ToString();
            estadochk.Checked = Convert.ToBoolean(tabladatos.SelectedCells[2].Value);
            privilegiochk.Checked = Convert.ToBoolean(tabladatos.SelectedCells[3].Value);

            estadochk.Enabled = true;
            privilegiochk.Enabled = true;
            nombreUsuarioActual = txtRegistroUsuario.Text;
            txtRegistroPass.Enabled = true;
            txtnuevapass.Visible = true;
            txtnuevapass.Enabled = true;
            confirmarpass.Text = "Confirmar Contraseña";
            confirmarpass.Visible = true;
            guardarbtn.Visible = true;
            verificarbtn.Visible = false;
            passView.Enabled = true;
            txtRegistroPass.Focus();
            this.Text = "Mantenimiento de Usuarios || Editando...";
            checkBox1.Enabled = true;

            button1.Enabled = true;
        }

        public string UsuarioAdministrador;

        private void eliminarusuariobtn_Click(object sender, EventArgs e)
        {
            string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();

                string verificarPassQuery = "SELECT COUNT(*) FROM login_usuario WHERE usuario = @nombreAdmin AND pass = @pass";
                using (SqlCommand verificarPassCommand = new SqlCommand(verificarPassQuery, conexion))
                {
                    verificarPassCommand.Parameters.AddWithValue("@nombreAdmin", UsuarioAdministrador);
                    verificarPassCommand.Parameters.AddWithValue("@pass", confirmarpasspanel.Text);
                    int passCount = (int)verificarPassCommand.ExecuteScalar();

                    if (passCount == 0)
                    {
                        MessageBox.Show("Contraseña incorrecta.");
                        confirmarpasspanel.Text = "";
                        return;
                    }
                }

                DialogResult editar = MessageBox.Show("¿Está de acuerdo con eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (editar == DialogResult.Yes)
                {
                    string eliminarUsuarioQuery = "DELETE FROM login_usuario WHERE usuario = @nombre";

                    using (SqlCommand obtenerDatosCommand = new SqlCommand(eliminarUsuarioQuery, conexion))
                    {
                        obtenerDatosCommand.Parameters.AddWithValue("@nombre", txtRegistroUsuario.Text);

                        int rowsAffected = obtenerDatosCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario eliminado exitosamente.");
                            button1.Enabled = false;
                            confirmarpasspanel.Text = "";
                            eliminarbtn_Click(sender, e);
                            limpiarbtn_Click(sender, e);
                            MantUsuarios_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el usuario.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Operación cancelada.");
                }
            }

            cancelarbtn_Click(sender, e);
        }

        private void instrucciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instrucciones para crear: \n1-Colocar nombre de usuario \n2-Colocar privilegios \n3-Colocar contraseña \n4-Guardar" +
                " \n\nInstrucciones para Editar: \n1-Dar click al usuario en la tabla \n2-Para poder guardar los cambios este usuario debe de proporcionar su contaseña o estar presente al momento del cambio \n3- En caso de querer una nueva contraseña darle al botón 'N' para alternar entre confirmar y poner una nueva contraseña");
        }
    }
}
