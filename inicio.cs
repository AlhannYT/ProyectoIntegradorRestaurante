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
        }

        private void iniciobtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusuario.Text) || string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Error: Campos vacíos.");
                return;
            }
            //cambia lo que dice "Server= Tu servidor", y los datos tuyos donde van, la base de datos va a ser la misma, pero el login y la contra es el tuyo
            string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                menu menu = new menu();
                try
                {
                    conexion.Open();

                    string query = "SELECT COUNT(*) FROM login_usuario WHERE usuario = @usuario AND pass = @pass";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@usuario", txtusuario.Text);
                        comando.Parameters.AddWithValue("@pass", txtpass.Text);

                        int cont = (int)comando.ExecuteScalar();

                        if (cont > 0)
                        {

                            MessageBox.Show("Usuario autenticado con éxito.");
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.");
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
    }
}

