using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

