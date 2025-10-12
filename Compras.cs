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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }
        private int compraID;
        private int cantidadProd = 0;

        public string responsableCompra;


        private void buscarprodbtn_Click(object sender, EventArgs e)
        {
            panelprod.Location = new Point(0, 0);
            panelprod.Visible = true;

            string conexionString = ConexionBD.ConexionSQL();


            string consulta = "select codigo_producto, nombre_producto, categoria, precio_compra, existencia, codigo_de_barra from productos";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tablapanelprod.DataSource = dt;
        }

        private void salirprodbtn_Click(object sender, EventArgs e)
        {
            panelprod.Visible = false;
            panelprod.Location = new Point(4, 444);
        }

        private void tablapanelprod_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tablapanelprod.Rows[e.RowIndex];

                txtcodigo.Text = row.Cells["codigo_producto"].Value.ToString();
                txtnombre.Text = row.Cells["nombre_producto"].Value.ToString();
                txtpreciocompra.Text = row.Cells["precio_compra"].Value.ToString();
            }

            panelprod.Visible = false;
            panelprod.Location = new Point(4, 444);
            agregarbtn.Enabled = true;
            numCantidad.Value = numCantidad.Minimum;
        }

        private void tablaproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigoProducto = tablaproductos.SelectedCells[0].Value.ToString();

            string rutaImagenes = @"C:\CarpetaDeImagenesProductos\";
            string rutaImagenProducto = Path.Combine(rutaImagenes, codigoProducto + ".jpg");

            if (File.Exists(rutaImagenProducto))
            {
                imagenproducto.Image = Image.FromFile(rutaImagenProducto);
            }
            else
            {
                imagenproducto.Image = null;
                MessageBox.Show("Imagen no encontrada para el producto seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private decimal totalAcumulado = 0;

        private void agregarbtn_Click(object sender, EventArgs e)
        {
            if (tablaproductos.ColumnCount == 0)
            {
                tablaproductos.Columns.Add("codigoProducto", "Codigo");
                tablaproductos.Columns.Add("nombreProducto", "Nombre");
                tablaproductos.Columns.Add("precio", "Precio de Compra");
                tablaproductos.Columns.Add("cantidad", "Cantidad");
            }

            string codigoProducto = txtcodigo.Text;
            string nombreProducto = txtnombre.Text;
            decimal precio;

            int cantidad = (int)numCantidad.Value;

            if (!decimal.TryParse(txtpreciocompra.Text, out precio))
            {
                MessageBox.Show("Por favor, ingresa un valor válido para el precio.");
                return;
            }

            decimal total = precio * cantidad;

            totalAcumulado += total;

            labeltotal.Text = totalAcumulado.ToString("F2");

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(tablaproductos);
            row.Cells[0].Value = codigoProducto;
            row.Cells[1].Value = nombreProducto;
            row.Cells[2].Value = precio;
            row.Cells[3].Value = cantidad;

            tablaproductos.Rows.Add(row);

            cantidadProd += cantidad;

            labelcantidad.Text = cantidadProd.ToString();

            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtpreciocompra.Text = "";
            numCantidad.Value = numCantidad.Minimum;

            comprarbtn.Enabled = true;
        }

        private void comprarbtn_Click(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    foreach (DataGridViewRow row in tablaproductos.Rows)
                    {
                        if (row.Cells["codigoProducto"].Value != null && row.Cells["cantidad"].Value != null)
                        {
                            string codigoProducto = row.Cells["codigoProducto"].Value.ToString();
                            int cantidadSolicitada = Convert.ToInt32(row.Cells["cantidad"].Value);

                            string queryActualizarProducto = "UPDATE productos SET existencia = existencia + @cantidadSolicitada WHERE codigo_producto = @codigoProducto";
                            using (SqlCommand commandActualizarProducto = new SqlCommand(queryActualizarProducto, conexion))
                            {
                                commandActualizarProducto.Parameters.AddWithValue("@cantidadSolicitada", cantidadSolicitada);
                                commandActualizarProducto.Parameters.AddWithValue("@codigoProducto", codigoProducto);

                                int rowsAffectedProducto = commandActualizarProducto.ExecuteNonQuery();

                                if (rowsAffectedProducto > 0)
                                {
                                    //MessageBox.Show($"Existencia del producto {codigoProducto} actualizada con éxito.");
                                }
                                else
                                {
                                    MessageBox.Show($"No se pudo actualizar la existencia del producto {codigoProducto}.");
                                }
                            }
                        }
                    }

                    string queryInsertarCompra = "INSERT INTO compras (responsable_compra, total, fecha, cantidad_comprada) VALUES (@responsable, @total, @fechaCompra, @cantidadProductos)";
                    using (SqlCommand commandInsertarCompra = new SqlCommand(queryInsertarCompra, conexion))
                    {
                        commandInsertarCompra.Parameters.AddWithValue("@responsable", responsableCompra);
                        commandInsertarCompra.Parameters.AddWithValue("@total", totalAcumulado);
                        commandInsertarCompra.Parameters.AddWithValue("@fechaCompra", fechacompra.Value.ToString());
                        commandInsertarCompra.Parameters.AddWithValue("@cantidadProductos", cantidadProd);

                        int rowsAffectedCompra = commandInsertarCompra.ExecuteNonQuery();

                        if (rowsAffectedCompra > 0)
                        {
                            MessageBox.Show("Compra realizada con exito.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo realizar la compra.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
        }

        private void FiltroDatosProductos(string busqueda)
        {
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conectar = new SqlConnection(conexionString))
            {
                try
                {
                    conectar.Open();

                    string query = @"
                        SELECT codigo_producto, nombre_producto, categoria, precio_compra, existencia, codigo_de_barra FROM productos
                        WHERE CAST(id AS VARCHAR) LIKE @buscar OR
                        codigo_producto LIKE @buscar OR
                        nombre_producto LIKE @buscar OR
                        codigo_de_barra LIKE @buscar OR
                        categoria LIKE @buscar";

                    using (SqlCommand comando = new SqlCommand(query, conectar))
                    {
                        comando.Parameters.AddWithValue("@buscar", "%" + busqueda + "%");

                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        tablapanelprod.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            labelresponsable.Text = "Responsable de la compra: " + responsableCompra;

            string conexionString = ConexionBD.ConexionSQL();

            string consulta = "SELECT TOP 1 id FROM compras ORDER BY id DESC";

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, con))
                {
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        int nuevoId = Convert.ToInt32(resultado) + 1;
                        txtidcompra.Text = nuevoId.ToString();
                    }
                    else
                    {
                        //MessageBox.Show("No se encontraron pedidos.");
                        txtidcompra.Text = "1";
                    }
                }
            }
        }

        private void txtbusquedapanelprod_TextChanged(object sender, EventArgs e)
        {
            FiltroDatosProductos(txtbusquedapanelprod.Text);
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            compraID = 0;
            txtcodigo.Clear();
            txtnombre.Clear();
            txtpreciocompra.Clear();

            imagenproducto.Image = Proyecto_restaurante.Properties.Resources.paisaje;

            numCantidad.Value = numCantidad.Minimum;
            
            labeltotal.Text = "";
            labelcantidad.Text = "";
            agregarbtn.Enabled = false;
            tablaproductos.Rows.Clear();
            //tablapanelprod.Rows.Clear();

            totalAcumulado = 0;
            
            cantidadProd = 0;

            comprarbtn.Enabled = false;
        }
    }
}
