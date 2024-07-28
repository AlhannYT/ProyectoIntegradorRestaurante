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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passView_CheckedChanged(object sender, EventArgs e)
        {
            if (passView.Checked == true)
            {
                passView.Image = Proyecto_restaurante.Properties.Resources.ojos_cruzados;
                txtRegistroPass.UseSystemPasswordChar = false;
                txtnuevapass.UseSystemPasswordChar = false;
            }
            else if (passView.Checked == false)
            {
                passView.Image = Proyecto_restaurante.Properties.Resources.ojo;
                txtRegistroPass.UseSystemPasswordChar = true;
                txtnuevapass.UseSystemPasswordChar = true;
            }
        }

        private void estadochk_CheckedChanged(object sender, EventArgs e)
        {
            if (estadochk.Checked == true)
            {
                estadochk.Text = "Inactivo";
                estadochk.ForeColor = Color.Red;
            }
            else if (estadochk.Checked == false)
            {
                estadochk.Text = "Activo";
                estadochk.ForeColor = Color.Lime;
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
                                    nombreUsuarioActual = txtRegistroUsuario.Text;
                                    txtRegistroPass.Enabled = true;
                                    txtnuevapass.Visible = true;
                                    txtnuevapass.Enabled = true;
                                    confirmarpass.Text = "Nueva Contraseña";
                                    confirmarpass.Visible = true;
                                    guardarbtn.Visible = true;
                                    verificarbtn.Visible = false;
                                    passView.Enabled = true;
                                    txtRegistroPass.Focus();
                                    txtestado_datos.Text = "Editando";
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
                                txtRegistroPass.Enabled = true;
                                txtnuevapass.Visible = false;
                                txtnuevapass.Enabled = false;
                                confirmarpass.Visible = false;
                                guardarbtn.Visible = true;
                                verificarbtn.Visible = false;
                                txtestado_datos.Text = "Creando";
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
                                MessageBox.Show("La contraseña antigua no es correcta.");
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
                privilegiochk.ForeColor = Color.Black;
            }
        }


        private void RestablecerFormulario()
        {
            txtRegistroUsuario.Text = "";
            txtRegistroPass.Enabled = false;

            txtRegistroPass.Text = "";

            txtnuevapass.Text = "";
            txtnuevapass.Visible = false;
            txtnuevapass.Enabled = false;

            confirmarpass.Visible = false;

            verificarbtn.Visible = true;

            guardarbtn.Visible = false;

            txtestado_datos.Text = "Creando";

            nombreUsuarioActual = "";

            mensajeMostrado = false;

            txtRegistroUsuario.Focus();

            estadochk.Text = "Activo";
            estadochk.ForeColor = Color.Lime;
            estadochk.Checked = false;

            privilegiochk.Text = "Usuario";
            privilegiochk.ForeColor = Color.Black;
            privilegiochk.Checked = false;
        }
    }
}
