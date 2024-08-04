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
    public partial class MantClientes : Form
    {
        public MantClientes()
        {
            InitializeComponent();
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            string posicion = txtcedula.Text;
            posicion = posicion.Replace("-", "");

            if (posicion.Length > 11)
            {
                posicion = posicion.Substring(0, 11);
            }

            if (posicion.Length > 3)
            {
                posicion = posicion.Insert(3, "-");
            }

            if (posicion.Length > 11)
            {
                posicion = posicion.Insert(11, "-");
            }

            txtcedula.Text = posicion;
            txtcedula.SelectionStart = txtcedula.Text.Length;
        }

        private string nombreUsuarioActual;

        private void RestablecerFormulario()
        {
            txtnombre.Text = "";
            
            txtapellido.Text = "";

            txtcedula.Text = "";

            nombreUsuarioActual = "";

            txtnumero.Text = "";

            txtnombre.Focus();
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            Regex letrasRegex = new Regex(@"^[a-zA-Z\s]+$");
            Regex numerosRegex = new Regex(@"^[\d-]+$");

            if (txtnombre.Text.Equals("") || txtapellido.Text.Equals("") || txtcedula.Text.Equals("") || txtnumero.Text.Equals(""))
            {
                MessageBox.Show("No debe dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!letrasRegex.IsMatch(txtnombre.Text))
            {
                MessageBox.Show("El nombre solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!letrasRegex.IsMatch(txtapellido.Text))
            {
                MessageBox.Show("El apellido solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string cedulaSinGuiones = txtcedula.Text.Replace("-", "");
            if (!numerosRegex.IsMatch(txtcedula.Text) || cedulaSinGuiones.Length != 11)
            {
                MessageBox.Show("La cédula debe tener el formato 000-0000000-0 y contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string telefonoSinGuiones = txtnumero.Text.Replace("-", "");
            if (!numerosRegex.IsMatch(txtnumero.Text) || telefonoSinGuiones.Length != 10)
            {
                MessageBox.Show("El teléfono debe tener el formato 000-000-0000 y contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //cambia lo que dice "Server= Tu servidor", y los datos tuyos donde van, la base de datos va a ser la misma, pero el login y la contra es el tuyo
            string conexionString = "Server=ALHANNYT-PC\\ALHANNSQLSERVER;Database=RestauranteDB;User Id=alhann;Password=123456;";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(nombreUsuarioActual))
                    {
                        string queryInsertar = "INSERT INTO cliente (nombre_cliente, apellido_cliente, identificacion, telefono) VALUES (@nombre_cliente, @apellido_cliente, @identificacion, @telefono)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@nombre_cliente", txtnombre.Text);
                            insertarCommand.Parameters.AddWithValue("@apellido_cliente", txtapellido.Text);
                            insertarCommand.Parameters.AddWithValue("@identificacion", txtcedula.Text);
                            insertarCommand.Parameters.AddWithValue("@telefono", txtnumero.Text);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cliente registrado con éxito.");
                                RestablecerFormulario();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los datos.");
                            }
                        }
                    }

                    /*Esto es una parte de codigo que tenia de otro registro que es para editar, 
                     solo lo tengo ahi para no borrarlo si uno lo llegara a necesitar*/

                    /*else
                    {
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
                    }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            RestablecerFormulario();
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtapellido.Focus();
                e.Handled = true;
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtcedula.Focus();
                e.Handled = true;
            }
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtnumero.Focus();
                e.Handled = true;
            }
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                guardarbtn.Focus();
                e.Handled = true;
            }
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            string posNum = txtnumero.Text;
            posNum = posNum.Replace("-", "");

            if (posNum.Length > 10)
            {
                posNum = posNum.Substring(0, 10);
            }

            if (posNum.Length > 3)
            {
                posNum = posNum.Insert(3, "-");
            }

            if (posNum.Length > 7)
            {
                posNum = posNum.Insert(7, "-");
            }

            txtnumero.Text = posNum;
            txtnumero.SelectionStart = txtnumero.Text.Length;
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtnombre.SelectionStart;

            txtnombre.Text = txtnombre.Text.ToUpper();

            txtnombre.SelectionStart = posicion;
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtapellido.SelectionStart;

            txtapellido.Text = txtapellido.Text.ToUpper();

            txtapellido.SelectionStart = posicion;
        }
    }
}
