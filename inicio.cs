using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proyecto_restaurante
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void iniciobtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusuario.Text) || string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Error: Campos vacíos.");
                return;
            }

            string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";
            //string conexionString = "Server=LENOVO\\SQLEXPRESS;Database=RestauranteDB;integrated security=true";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                menu menu = new menu();

                try
                {
                    conexion.Open();

                    string query = "SELECT privilegio FROM login_usuario WHERE usuario = @usuario AND pass = @pass AND estado = 1";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@usuario", txtusuario.Text);
                        comando.Parameters.AddWithValue("@pass", txtpass.Text);

                        object result = comando.ExecuteScalar();

                        if (result != null)
                        {
                            int privilegio = Convert.ToInt32(result);

                            if (privilegio == 1)
                            {
                                menu.toolStripMenuItem2.Enabled = true; 
                            }
                            else
                            {
                                menu.toolStripMenuItem2.Enabled = false; 
                            }

                            menu.usuariolabel.Text = "USUARIO ACTUAL: " + txtusuario.Text;
                            menu.usuarioActual = txtusuario.Text;
                            menu.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos, o el usuario está inactivo.");
                            txtpass.Text = "";
                            txtpass.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
        }


        private void passView_CheckedChanged(object sender, EventArgs e)
        {
            if (passView.Checked == true)
            {
                passView.Image = Proyecto_restaurante.Properties.Resources.ojos_cruzados;
                txtpass.UseSystemPasswordChar = false;
            }
            else if (passView.Checked == false)
            {
                passView.Image = Proyecto_restaurante.Properties.Resources.ojo;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtpass.Focus();
                e.Handled = true;
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                iniciobtn.Focus();
                e.Handled = true;
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtusuario.SelectionStart;

            txtusuario.Text = txtusuario.Text.ToUpper();

            txtusuario.SelectionStart = posicion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int step = 5;
        int direction = 1;
        int leftLimit = 0; 
        int rightLimit = 450;

        private void timer1_Tick(object sender, EventArgs e)
        {
            iniciolabel.Left += step * direction;

            if (iniciolabel.Left + iniciolabel.Width >= rightLimit || iniciolabel.Left <= leftLimit)
            {
                direction *= -1;
            }
        }
    }
}

