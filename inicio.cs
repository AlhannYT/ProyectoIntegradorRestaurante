using System;
using System.Data;
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

        private static string rutaUsuario = @"C:\SistemaArchivos\Usuarios\Usuarios.txt";
        public string rutaArchivo = @"C:\SistemaArchivos\Conexion\ConexionesSQL.txt";

        private void iniciobtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusuario.Text) || string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Error: Campos vacíos.");
                return;
            }

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                menu menu = new menu();
                Configuracion config = new Configuracion();

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
                                menu.administrador = 1;
                                menu.panel5.BackColor = Color.Gold;
                            }
                            else
                            {
                                menu.administrador = 0;
                                menu.panel5.BackColor = Color.Green;
                            }

                            menu.usuariolabel.Text = "USUARIO ACTUAL: \n" + txtusuario.Text;
                            menu.usuarioActual = txtusuario.Text;

                            Directory.CreateDirectory(Path.GetDirectoryName(rutaUsuario));

                            if (recordarchk.Checked)
                            {
                                try
                                {
                                    File.WriteAllText(rutaUsuario, txtusuario.Text);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("No se pudo guardar el usuario recordado: " + ex.Message);
                                }
                            }
                            else
                            {
                                try
                                {
                                    if (File.Exists(rutaUsuario))
                                        File.Delete(rutaUsuario);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("No se pudo eliminar el archivo del usuario recordado: " + ex.Message);
                                }
                            }

                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos o usuario inactivo.");
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
                iniciobtn_Click(sender, e);
                e.Handled = true;
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtusuario.SelectionStart;

            txtusuario.Text = txtusuario.Text.ToUpper();

            txtusuario.SelectionStart = posicion;

            recordarchk.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sqlbtn_Click(object sender, EventArgs e)
        {
            conexionpanel.Location = new Point(0, 33);
            conexionpanel.BringToFront();
            conexionpanel.Visible = true;
        }


        private void salirsqlbtn_Click(object sender, EventArgs e)
        {
            conexionpanel.Location = new Point(605, 45);
            conexionpanel.Visible = false;
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            string servidor = servidortxt.Text.Trim();
            string usuario = usuarioservidortxt.Text.Trim();
            string contraseña = contservidortxt.Text.Trim();
            string porDefecto = defectochk.Checked ? "1" : "0";

            if (string.IsNullOrEmpty(servidor) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> lineas = new List<string>();
            bool reemplazoHecho = false;
            bool actualizada = false;

            if (File.Exists(rutaArchivo))
            {
                var lineasOriginales = File.ReadAllLines(rutaArchivo);

                foreach (var linea in lineasOriginales)
                {
                    var partes = linea.Split('|');
                    if (partes.Length == 4)
                    {
                        bool mismaConexion = partes[0] == servidor && partes[1] == usuario;

                        if (mismaConexion)
                        {
                            lineas.Add($"{servidor}|{usuario}|{contraseña}|{porDefecto}");
                            actualizada = true;
                        }
                        else
                        {
                            if (partes[3] == "1" && porDefecto == "1" && !reemplazoHecho)
                            {
                                partes[3] = "0";
                                reemplazoHecho = true;
                            }

                            lineas.Add(string.Join("|", partes));
                        }
                    }
                }
            }

            if (!actualizada)
                lineas.Add($"{servidor}|{usuario}|{contraseña}|{porDefecto}");

            File.WriteAllLines(rutaArchivo, lineas);

            MessageBox.Show(actualizada ? "Conexión actualizada correctamente." : "Conexión guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button6_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexiones.Location = new Point(0, 33);
            conexiones.BringToFront();
            conexiones.Visible = true;

            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El archivo de conexiones no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Servidor");
            tabla.Columns.Add("Usuario");
            tabla.Columns.Add("Contraseña");
            tabla.Columns.Add("PorDefecto");

            var lineas = File.ReadAllLines(rutaArchivo);

            foreach (var linea in lineas)
            {
                var partes = linea.Split('|');
                if (partes.Length == 4)
                {
                    tabla.Rows.Add(partes[0], partes[1], partes[2], partes[3] == "1" ? "Sí" : "No");
                }
            }

            txtsql.DataSource = tabla;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            conexiones.Location = new Point(605, 45);
            conexiones.Visible = false; conexiones.Location = new Point(605, 435);
            conexiones.Visible = false;
        }

        private void txtsql_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = txtsql.Rows[e.RowIndex];

                servidortxt.Text = fila.Cells["Servidor"].Value?.ToString();
                usuarioservidortxt.Text = fila.Cells["Usuario"].Value?.ToString();
                contservidortxt.Text = fila.Cells["Contraseña"].Value?.ToString();

                string porDefecto = fila.Cells["PorDefecto"].Value?.ToString();
                defectochk.Checked = porDefecto == "Sí";
                button5_Click(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtsql_CellDoubleClick(sender, new DataGridViewCellEventArgs(0, 0));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            servidortxt.Text = "";
            usuarioservidortxt.Text = "";
            contservidortxt.Text = "";
            defectochk.Checked = false;
        }

        private void borrarconex_Click(object sender, EventArgs e)
        {
            if (txtsql.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una conexión para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow fila = txtsql.SelectedRows[0];
            string servidor = fila.Cells["Servidor"].Value?.ToString();
            string usuario = fila.Cells["Usuario"].Value?.ToString();
            string contraseña = fila.Cells["Contraseña"].Value?.ToString();
            string porDefecto = fila.Cells["PorDefecto"].Value?.ToString() == "Sí" ? "1" : "0";

            string lineaEliminar = $"{servidor}|{usuario}|{contraseña}|{porDefecto}";

            var lineas = File.ReadAllLines(rutaArchivo).ToList();
            bool eliminada = lineas.Remove(lineaEliminar);

            if (eliminada)
            {
                File.WriteAllLines(rutaArchivo, lineas);
                MessageBox.Show("Conexión eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button3_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la conexión. Verifica los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(rutaUsuario))
                {
                    string usuarioGuardado = File.ReadAllText(rutaUsuario).Trim();

                    if (!string.IsNullOrEmpty(usuarioGuardado))
                    {
                        txtusuario.Text = usuarioGuardado;
                        recordarchk.Checked = true;
                        txtpass.Focus();
                    }
                }
                else
                {
                    txtusuario.Text = string.Empty;
                    recordarchk.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo leer el usuario recordado: " + ex.Message);
            }
        }

        private void inicio_Shown(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtusuario.Text))
                txtpass.Focus();
        }
    }
}

