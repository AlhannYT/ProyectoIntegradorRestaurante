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

        private string nombreClienteActual;

        private void RestablecerFormulario()
        {
            txtnombre.Text = "";

            txtapellido.Text = "";

            txtcedula.Text = "";

            nombreClienteActual = "";

            txtnumero.Text = "";
            estadochk.Checked=true;
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

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(nombreClienteActual))
                    {
                        string queryInsertar = "INSERT INTO cliente (nombre_cliente, apellido_cliente, identificacion, telefono, estado) VALUES (@nombre_cliente, @apellido_cliente, @identificacion, @telefono, @estado)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@nombre_cliente", txtnombre.Text);
                            insertarCommand.Parameters.AddWithValue("@apellido_cliente", txtapellido.Text);
                            insertarCommand.Parameters.AddWithValue("@identificacion", txtcedula.Text);
                            insertarCommand.Parameters.AddWithValue("@telefono", txtnumero.Text);
                            insertarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cliente registrado con éxito.");
                                limpiarbtn_Click(sender, e);
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
                        string queryActualizar = "UPDATE cliente SET nombre_cliente = @nuevoNombre, apellido_cliente = @apellido, identificacion= @identificacion, telefono = @telefono, estado= @estado WHERE nombre_cliente = @nombreActual";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@nuevoNombre", txtnombre.Text);
                            actualizarCommand.Parameters.AddWithValue("@apellido", txtapellido.Text);
                            actualizarCommand.Parameters.AddWithValue("@identificacion", txtcedula.Text);
                            actualizarCommand.Parameters.AddWithValue("@telefono", txtnumero.Text);
                            actualizarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);
                            actualizarCommand.Parameters.AddWithValue("@nombreActual", nombreClienteActual);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cliente actualizado con éxito.");
                                limpiarbtn_Click(sender, e);
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


        private void MantClientes_Load(object sender, EventArgs e)
        {
            
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

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtnombre.Text = tabladatos.SelectedCells[1].Value.ToString();
            //nombreClienteActual=txtnombre.Text;
            //txtapellido.Text = tabladatos.SelectedCells[2].Value.ToString();
            //txtcedula.Text = tabladatos.SelectedCells[3].Value.ToString();
            //txtnumero.Text = tabladatos.SelectedCells[4].Value.ToString();
            //estadochk.Checked = Convert.ToBoolean(tabladatos.SelectedCells[5].Value);
        }
    }
}
