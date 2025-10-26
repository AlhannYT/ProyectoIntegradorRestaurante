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
    public partial class MantProveedor : Form
    {
        public MantProveedor()
        {
            InitializeComponent();
        }

        private string nombreProvActual;
        private int idProveedor = 0;

        private void button1_Click(object sender, EventArgs e) //Boton que te manda a hacer un departamento nuevo
        {
            MantDepart mantDepart = new MantDepart();
            mantDepart.Show();
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            Regex letrasRegex = new Regex(@"^[a-zA-Z\s]+$");
            Regex numerosRegex = new Regex(@"^\d{3}-\d{3}-\d{4}$");

            if (txtnombre_prov.Text.Equals("") ||
                txtnombrevendedor.Text.Equals("") ||
                tipodoccmbx.SelectedItem == null ||
                txtnumerodoc.Text.Equals("") ||
                txtnumero_prov.Text.Equals("") ||
                txtprovincia.Text.Equals("") ||
                departamentocmbx.SelectedItem == null ||
                txtdireccion.Text.Equals("") ||
                txtcorreo.Text.Equals("") ||
                txttelefonovend.Text.Equals(""))
            {
                MessageBox.Show("No debe dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!letrasRegex.IsMatch(txtnombrevendedor.Text) ||
                !letrasRegex.IsMatch(txtprovincia.Text) ||
                !letrasRegex.IsMatch(txtdireccion.Text) ||
                !letrasRegex.IsMatch(txtnombrevendedor.Text))
            {
                MessageBox.Show("Los siguientes campos deben tener solo letras: Nombre Proveedor, Provincia, Dirección, Nombre Vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string telefonoVendSinGuiones = txttelefonovend.Text.Replace("-", "");
            string telefonoProvSinGuiones = txtnumero_prov.Text.Replace("-", "");

            if (!numerosRegex.IsMatch(txtnumero_prov.Text) || telefonoProvSinGuiones.Length != 10 ||
                !numerosRegex.IsMatch(txttelefonovend.Text) || telefonoVendSinGuiones.Length != 10)
            {
                MessageBox.Show("Los teléfonos deben tener el formato 000-000-0000 y contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(nombreProvActual))
                    {
                        string queryInsertar = "INSERT INTO proveedor (nombre_proveedor, tipo_documento, documento, numero_telefono, provincia, departamento, direccion, correo_electronico, nombre_vendedor, numerotel_vendedor, estado) VALUES (@nombre_proveedor, @tipo_documento, @documento, @numero_telefono, @provincia, @departamento, @direccion, @correo_electronico, @nombre_vendedor, @numerotel_vendedor, @estado)";

                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@nombre_proveedor", txtnombrevendedor.Text);
                            insertarCommand.Parameters.AddWithValue("@tipo_documento", tipodoccmbx.SelectedItem.ToString());
                            insertarCommand.Parameters.AddWithValue("@documento", txtnumerodoc.Text);
                            insertarCommand.Parameters.AddWithValue("@numero_telefono", txtnumero_prov.Text);
                            insertarCommand.Parameters.AddWithValue("@provincia", txtprovincia.Text);
                            insertarCommand.Parameters.AddWithValue("@departamento", departamentocmbx.SelectedItem.ToString());
                            insertarCommand.Parameters.AddWithValue("@direccion", txtdireccion.Text);
                            insertarCommand.Parameters.AddWithValue("@correo_electronico", txtcorreo.Text);
                            insertarCommand.Parameters.AddWithValue("@nombre_vendedor", txtnombrevendedor.Text);
                            insertarCommand.Parameters.AddWithValue("@numerotel_vendedor", txttelefonovend.Text);
                            insertarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Proveedor registrado con éxito.");
                                limpiarbtn_Click(sender, e);
                                MantProveedor_Load(sender, e);
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
                        string queryActualizar = "UPDATE proveedor SET nombre_proveedor = @nuevoNombreProveedor, tipo_documento = @tipoDocumento, documento = @documento, numero_telefono = @numeroTelefono, provincia = @provincia, departamento = @departamento, direccion = @direccion, correo_electronico = @correoElectronico, nombre_vendedor = @nombreVendedor, numerotel_vendedor = @numerotelVendedor, estado = @estado WHERE id = @idProveedor and nombre_proveedor = @ActualNombreProveedor";

                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@nuevoNombreProveedor", txtnombrevendedor.Text);
                            actualizarCommand.Parameters.AddWithValue("@ActualNombreProveedor", nombreProvActual);
                            actualizarCommand.Parameters.AddWithValue("@tipoDocumento", tipodoccmbx.SelectedItem.ToString());
                            actualizarCommand.Parameters.AddWithValue("@documento", txtnumerodoc.Text);
                            actualizarCommand.Parameters.AddWithValue("@numeroTelefono", txtnumero_prov.Text);
                            actualizarCommand.Parameters.AddWithValue("@provincia", txtprovincia.Text);
                            actualizarCommand.Parameters.AddWithValue("@departamento", departamentocmbx.SelectedItem.ToString());
                            actualizarCommand.Parameters.AddWithValue("@direccion", txtdireccion.Text);
                            actualizarCommand.Parameters.AddWithValue("@correoElectronico", txtcorreo.Text);
                            actualizarCommand.Parameters.AddWithValue("@nombreVendedor", txtnombrevendedor.Text);
                            actualizarCommand.Parameters.AddWithValue("@numerotelVendedor", txttelefonovend.Text);
                            actualizarCommand.Parameters.AddWithValue("@idProveedor", idProveedor);
                            actualizarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Proveedor actualizado con éxito.");
                                limpiarbtn_Click(sender, e);
                                MantProveedor_Load(sender, e);
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
            this.Text = "Mantenimiento de Proveedores || Creando...";

            txtnumerodoc.TextChanged -= txtnumerodoc_TextChanged;

            txtnombre_prov.Text = "";
            txtnombrevendedor.Text = "";
            tipodoccmbx.SelectedIndex = -1;
            txtnumerodoc.Text = "";
            txtnumerodoc.Enabled = false;
            txtnumero_prov.Text = "";
            txtprovincia.Text = "";
            departamentocmbx.SelectedIndex = -1;
            txtdireccion.Text = "";
            txtcorreo.Text = "";
            txtnombrevendedor.Text = "";
            txttelefonovend.Text = "";
            estadochk.Checked = true;
            idProveedor = 0;

            txtnumerodoc.TextChanged += txtnumerodoc_TextChanged;
        }

        private void MantProveedor_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT nombre_depa FROM departamento where estado = 1";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                departamentocmbx.Items.Add(lector["nombre_depa"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al cargar las salas: {ex.Message}");
                }
            }

            string consulta = "select  id, nombre_proveedor, documento, numero_telefono, correo_electronico from proveedor";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tabladatos.DataSource = dt;
        }

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idProveedor = Convert.ToInt32(tabladatos.SelectedCells[0].Value);
            txtnombre_prov.Text = tabladatos.SelectedCells[1].Value.ToString();
            nombreProvActual = txtnombre_prov.Text;
            tipodoccmbx.Text = tabladatos.SelectedCells[2].Value.ToString();
            txtnumerodoc.Text = tabladatos.SelectedCells[3].Value.ToString();
            txtnumero_prov.Text = tabladatos.SelectedCells[4].Value.ToString();
            txtprovincia.Text = tabladatos.SelectedCells[5].Value.ToString();
            departamentocmbx.Text = tabladatos.SelectedCells[6].Value.ToString();
            txtdireccion.Text = tabladatos.SelectedCells[7].Value.ToString();
            txtcorreo.Text = tabladatos.SelectedCells[8].Value.ToString();
            txtnombrevendedor.Text = tabladatos.SelectedCells[9].Value.ToString();
            txttelefonovend.Text = tabladatos.SelectedCells[10].Value.ToString();
            estadochk.Checked = Convert.ToBoolean(tabladatos.SelectedCells[11].Value);
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            txtbuscador.Text = "(ID, N° Doc, Nombre, Departamento, Provincia, Direccion, Correo, Nombre Vendedor)";
            limpiarbtn_Click(sender, e);
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

        private void txtbuscador_Enter(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "(ID, N° Doc, Nombre, Departamento, Provincia, Direccion, Correo, Nombre Vendedor)")
            {
                txtbuscador.Text = "";
                txtbuscador.ForeColor = Color.Black;
            }
        }

        private void txtbuscador_Leave(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "")
            {
                txtbuscador.Text = "(ID, N° Doc, Nombre, Departamento, Provincia, Direccion, Correo, Nombre Vendedor)";
                txtbuscador.ForeColor = Color.Gray;
                MantProveedor_Load(sender, e);
            }
        }

        private void recargarbtn_Click(object sender, EventArgs e)
        {
            departamentocmbx.Items.Clear();
            MantProveedor_Load(sender, e);
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
                        SELECT * FROM proveedor
                        WHERE CAST(id AS VARCHAR) LIKE @buscar OR
                        documento LIKE @buscar OR
                        numero_telefono LIKE @buscar OR
                        provincia LIKE @buscar OR
                        departamento LIKE @buscar OR
                        dirección LIKE @buscar OR
                        correo_electronico LIKE @buscar OR
                        nombre_vendedor LIKE @buscar";

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
        }

        private void txttelefonovend_TextChanged(object sender, EventArgs e)
        {
            string posNum = txttelefonovend.Text;
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

            txttelefonovend.Text = posNum;
            txttelefonovend.SelectionStart = txttelefonovend.Text.Length;
        }

        private void txtnumero_prov_TextChanged(object sender, EventArgs e)
        {
            string posNum = txtnumero_prov.Text;
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

            txtnumero_prov.Text = posNum;
            txtnumero_prov.SelectionStart = txtnumero_prov.Text.Length;
        }

        private void txtnumerodoc_TextChanged(object sender, EventArgs e)
        {
            string posicion = txtnumerodoc.Text;
            posicion = posicion.Replace("-", "");

            if (tipodoccmbx.SelectedItem != null)
            {
                if (tipodoccmbx.SelectedItem.ToString() == "Cedula")
                {
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
                }
                else if (tipodoccmbx.SelectedItem.ToString() == "RNC")
                {
                    if (posicion.Length > 9)
                    {
                        posicion = posicion.Substring(0, 9);
                    }

                    if (posicion.Length > 1)
                    {
                        posicion = posicion.Insert(1, "-");
                    }

                    if (posicion.Length > 3)
                    {
                        posicion = posicion.Insert(3, "-");
                    }
                }
                else
                {
                    MessageBox.Show("Debe colocar un tipo de documento");
                }
            }
            else
            {
                txtnumerodoc.Clear();
            }

            txtnumerodoc.Text = posicion;
            txtnumerodoc.SelectionStart = txtnumerodoc.Text.Length;
        }

        private void tipodoccmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtnumerodoc.Text = "";
            txtnumerodoc.Enabled = true;
        }

        private void txtnombre_prov_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtnombre_prov.SelectionStart;

            txtnombre_prov.Text = txtnombre_prov.Text.ToUpper();

            txtnombre_prov.SelectionStart = posicion;
        }

        private void txtprovincia_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtprovincia.SelectionStart;

            txtprovincia.Text = txtprovincia.Text.ToUpper();

            txtprovincia.SelectionStart = posicion;
        }

        private void txtnombrevendedor_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtnombrevendedor.SelectionStart;

            txtnombrevendedor.Text = txtnombrevendedor.Text.ToUpper();

            txtnombrevendedor.SelectionStart = posicion;
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtdireccion.SelectionStart;

            txtdireccion.Text = txtdireccion.Text.ToUpper();

            txtdireccion.SelectionStart = posicion;
        }
    }
}
