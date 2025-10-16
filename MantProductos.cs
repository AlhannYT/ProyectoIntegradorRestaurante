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
    public partial class MantProductos : Form
    {
        public MantProductos()
        {
            InitializeComponent();
        }

        public string CodigoProductoActual;
        private int idProducto = 0;

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            Regex numerosRegex = new Regex(@"^[\d.-]+$");

            if (txtcodigo_producto.Text.Equals("") ||
                txtnombre_prod.Text.Equals("") ||
                categoriacmbx.SelectedItem == null ||
                txtprecio_compra.Text.Equals("") ||
                txtprecio_venta.Text.Equals("") ||
                txtexistencia.Text.Equals("") ||
                ivacmbx.SelectedItem == null ||
                txtcodigo_barras.Text.Equals("") ||
                proveedorcmbx.SelectedItem == null)
            {
                MessageBox.Show("No debe dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!numerosRegex.IsMatch(txtprecio_compra.Text) ||
                !numerosRegex.IsMatch(txtprecio_venta.Text) ||
                !numerosRegex.IsMatch(txtexistencia.Text) ||
                !numerosRegex.IsMatch(txtcodigo_producto.Text))
            {
                MessageBox.Show("Codigo, Precio de Compra / Venta y Existencia solo admiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(CodigoProductoActual))
                    {
                        string queryInsertar = "INSERT INTO productos (codigo_producto, nombre_producto, categoria, precio_compra, precio_venta, existencia, iva, codigo_de_barra, proveedor, estado) VALUES (@codigo, @nombre, @categoria, @precioCompra, @precioVenta, @existencia, @iva, @codigoBarra, @proveedor, @estado)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            decimal ValorIva = Convert.ToDecimal(ivacmbx.SelectedItem) / 100;

                            insertarCommand.Parameters.AddWithValue("@codigo", txtcodigo_producto.Text);
                            insertarCommand.Parameters.AddWithValue("@nombre", txtnombre_prod.Text);
                            insertarCommand.Parameters.AddWithValue("@categoria", categoriacmbx.SelectedItem.ToString());
                            insertarCommand.Parameters.AddWithValue("@precioCompra", Convert.ToDecimal(txtprecio_compra.Text));
                            insertarCommand.Parameters.AddWithValue("@precioVenta", Convert.ToDecimal(txtprecio_venta.Text));
                            insertarCommand.Parameters.AddWithValue("@existencia", txtexistencia.Text);
                            insertarCommand.Parameters.AddWithValue("@iva", ValorIva);
                            insertarCommand.Parameters.AddWithValue("@codigoBarra", txtcodigo_barras.Text);
                            insertarCommand.Parameters.AddWithValue("@proveedor", proveedorcmbx.SelectedItem.ToString());
                            insertarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Producto registrado con éxito.");
                                imagenproducto.Image = Proyecto_restaurante.Properties.Resources.paisaje;
                                recargarbtn_Click(sender, e);
                                limpiarbtn_Click(sender, e);
                                MantProductos_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los datos.");
                            }
                        }
                    }
                    else
                    {
                        string verificarQuery = "SELECT COUNT(*) FROM productos WHERE codigo_producto = @codigoActual AND id = @IDProducto";
                        using (SqlCommand verificarCommand = new SqlCommand(verificarQuery, conexion))
                        {
                            verificarCommand.Parameters.AddWithValue("@codigoActual", CodigoProductoActual);
                            verificarCommand.Parameters.AddWithValue("@IDProducto", idProducto);
                        }

                        string queryActualizar = "UPDATE productos SET codigo_producto = @codigo, nombre_producto = @nombre, categoria = @categoria, precio_compra = @precioCompra, precio_venta = @precioVenta, existencia = @existencia, iva = @iva, codigo_de_barra = @codigoBarra, proveedor = @proveedor, estado = @estado WHERE id = @IDProducto AND codigo_producto = @codigoActual";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            decimal ValorIva = Convert.ToDecimal(ivacmbx.SelectedItem) / 100;

                            actualizarCommand.Parameters.AddWithValue("@IDProducto", idProducto);
                            actualizarCommand.Parameters.AddWithValue("@codigo", txtcodigo_producto.Text);
                            actualizarCommand.Parameters.AddWithValue("@nombre", txtnombre_prod.Text);
                            actualizarCommand.Parameters.AddWithValue("@categoria", categoriacmbx.SelectedItem.ToString());
                            actualizarCommand.Parameters.AddWithValue("@precioCompra", Convert.ToDecimal(txtprecio_compra.Text));
                            actualizarCommand.Parameters.AddWithValue("@precioVenta", Convert.ToDecimal(txtprecio_venta.Text));
                            actualizarCommand.Parameters.AddWithValue("@existencia", Convert.ToInt32(txtexistencia.Text));
                            actualizarCommand.Parameters.AddWithValue("@iva", ValorIva);
                            actualizarCommand.Parameters.AddWithValue("@codigoBarra", txtcodigo_barras.Text);
                            actualizarCommand.Parameters.AddWithValue("@proveedor", proveedorcmbx.SelectedItem.ToString());
                            actualizarCommand.Parameters.AddWithValue("@codigoActual", CodigoProductoActual);
                            actualizarCommand.Parameters.AddWithValue("@estado", estadochk.Checked ? 1 : 0);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Producto actualizado con éxito.");

                                limpiarbtn_Click(sender, e);
                                MantProductos_Load(sender, e);
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
            this.Text = "Mantenimiento de Productos || Creando...";
            imagenproducto.Image = Proyecto_restaurante.Properties.Resources.paisaje;

            txtcodigo_producto.Text = "";
            txtnombre_prod.Text = "";
            txtprecio_compra.Text = "";
            txtprecio_venta.Text = "";
            txtexistencia.Text = "";
            txtcodigo_barras.Text = "";

            categoriacmbx.SelectedIndex = -1;
            ivacmbx.SelectedIndex = -1;
            proveedorcmbx.SelectedIndex = -1;

            estadochk.Checked = true;
        }

        private void MantProductos_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string queryCategoria = "SELECT nombre_categoria FROM categoria where estado = 1";
                    string queryIva = "SELECT porcentaje FROM impuestos where estado = 1";
                    string queryProveedor = "SELECT nombre_proveedor FROM proveedor where estado = 1";
                    using (SqlCommand comando = new SqlCommand(queryCategoria, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                categoriacmbx.Items.Add(lector["nombre_categoria"].ToString());
                            }
                        }
                    }

                    using (SqlCommand comando = new SqlCommand(queryIva, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                ivacmbx.Items.Add(lector["porcentaje"].ToString());
                            }
                        }
                    }

                    using (SqlCommand comando = new SqlCommand(queryProveedor, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                proveedorcmbx.Items.Add(lector["nombre_proveedor"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al cargar los datos: {ex.Message}");
                }
            }

            string codigoProducto = txtcodigo_producto.Text;
            string rutaImagenes = @"C:\CarpetaDeImagenesProductos\";
            string rutaImagenProducto = Path.Combine(rutaImagenes, codigoProducto + ".jpg");

            if (File.Exists(rutaImagenProducto))
            {
                imagenproducto.Image = Image.FromFile(rutaImagenProducto);
            }
            else
            {
                //MessageBox.Show("Imagen no encontrada para el producto seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        private void recargarbtn_Click(object sender, EventArgs e)
        {
            categoriacmbx.Items.Clear();
            ivacmbx.Items.Clear();
            proveedorcmbx.Items.Clear();
            MantProductos_Load(sender, e);
        }

        private void codigobarrarandombtn_Click(object sender, EventArgs e)
        {
            string codigoBarras = CodBarraRandom();

            txtcodigo_barras.Text = codigoBarras;
        }

        private string CodBarraRandom()
        {
            const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            Random random = new Random();

            int longitudCodBarras = 12;

            char[] codigoBarrasArray = new char[longitudCodBarras];
            for (int i = 0; i < longitudCodBarras; i++)
            {
                codigoBarrasArray[i] = caracteresPermitidos[random.Next(caracteresPermitidos.Length)];
            }

            return new string(codigoBarrasArray);
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



        private void txtnombre_prod_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtnombre_prod.SelectionStart;

            txtnombre_prod.Text = txtnombre_prod.Text.ToUpper();

            txtnombre_prod.SelectionStart = posicion;
        }

        private void seleccionimagenbtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Seleccionar imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string codigoProducto = txtcodigo_producto.Text;
                    string destinoCarpeta = @"C:\CarpetaDeImagenesProductos\";
                    string extension = Path.GetExtension(openFileDialog.FileName);
                    string nuevaRuta = Path.Combine(destinoCarpeta, codigoProducto + extension);

                    try
                    {
                        imagenproducto.Image = null;

                        if (File.Exists(nuevaRuta))
                        {
                            string tempFileName = Path.Combine(destinoCarpeta, Path.GetRandomFileName());
                            File.Move(nuevaRuta, tempFileName);

                            File.Delete(tempFileName);
                        }

                        File.Copy(openFileDialog.FileName, nuevaRuta, true);

                        imagenproducto.Image = Image.FromFile(nuevaRuta);

                        MessageBox.Show("Imagen asociada al producto con éxito.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al copiar la imagen: " + ex.Message);
                    }
                }
            }
        }

        private void codigorandombtn_Click(object sender, EventArgs e)
        {
            string codigoBarras = CodRandom();

            txtcodigo_producto.Text = codigoBarras;
        }

        private string CodRandom()
        {
            const string caracteresPermitidos = "0123456789";

            Random random = new Random();

            int longitudCod = 8;

            char[] codigoArray = new char[longitudCod];
            for (int i = 0; i < longitudCod; i++)
            {
                codigoArray[i] = caracteresPermitidos[random.Next(caracteresPermitidos.Length)];
            }

            return new string(codigoArray);
        }

        private void categoriacmbx_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MantCategoria categoria = new MantCategoria();
                categoria.Show();
            }
        }

        private void ivacmbx_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MantImpuestos mantImpuestos = new MantImpuestos();
                mantImpuestos.Show();
            }
        }

        private void proveedorcmbx_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MantProveedor proveedor = new MantProveedor();
                proveedor.Show();
            }
        }

        private void txtcodigo_producto_TextChanged(object sender, EventArgs e)
        {
            seleccionimagenbtn.Enabled = !string.IsNullOrWhiteSpace(txtcodigo_barras.Text);
        }
    }
}
