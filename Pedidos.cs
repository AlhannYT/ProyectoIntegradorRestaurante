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
using System.Drawing;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Proyecto_restaurante
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private int cantidadProd = 0;
        private string pedidoActual;
        private string nombreMesa;
        public string NombreResponsable;
        private int IDMesa = 0;

        private void buscarclientebtn_Click(object sender, EventArgs e)
        {
            panelclientes.Location = new Point(0, 0);
            panelclientes.Visible = true;

            string conexionString = ConexionBD.ConexionSQL();

            string consulta = "select id, nombre_cliente, apellido_cliente, identificacion, telefono from cliente";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tablaclientes.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelclientes.Visible = false;
            panelclientes.Location = new Point(803, 532);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelproducto.Visible = false;
            panelproducto.Location = new Point(3, 499);
        }

        private void buscarproductobtn_Click(object sender, EventArgs e)
        {
            panelproducto.Location = new Point(0, 0);
            panelproducto.Visible = true;

            string conexionString = ConexionBD.ConexionSQL();

            string consulta = "select id, codigo_producto, nombre_producto, categoria, precio_venta, iva, existencia, codigo_de_barra from productos where existencia > 0";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tablapanelproducto.DataSource = dt;
        }

        private void asignarmesabtn_Click(object sender, EventArgs e)
        {
            panelmesas.Location = new Point(0, 0);
            panelmesas.Visible = true;

            string conexionString = ConexionBD.ConexionSQL();

            string consulta = "select id, sala, nombre_mesa, num_asientos, estado from mesas";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tablaseleccionmesas.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelmesas.Visible = false;
            panelmesas.Location = new Point(803, 33);
        }

        public void habilitarbotones(object sender, EventArgs e)
        {
            buscarproductobtn.Enabled = true;
            txtcodigoproducto.Enabled = true;
            txtnombreproducto.Enabled = true;
            txtprecioproducto.Enabled = true;
            bajarproductobtn.Enabled = true;
            numCantidad.Enabled = true;
        }

        private void tablapanelproducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tablapanelproducto.Rows[e.RowIndex];

                txtcodigoproducto.Text = row.Cells["codigo_producto"].Value.ToString();
                txtnombreproducto.Text = row.Cells["nombre_producto"].Value.ToString();
                txtprecioproducto.Text = row.Cells["precio_venta"].Value.ToString();
                txtiva.Text = row.Cells["iva"].Value.ToString();
            }

            panelproducto.Visible = false;
            panelproducto.Location = new Point(3, 499);
            numCantidad.Value = numCantidad.Minimum;
        }

        private void tablaclientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tablaclientes.Rows[e.RowIndex];

                string nombreCompleto = row.Cells["nombre_cliente"].Value.ToString() + " " + row.Cells["apellido_cliente"].Value.ToString();
                txtnombrecompleto.Text = nombreCompleto;
                txtnumero_cliente.Text = row.Cells["telefono"].Value.ToString();
            }

            panelclientes.Visible = false;
            panelclientes.Location = new Point(803, 532);

            habilitarbotones(sender, e);
        }

        private void tablaseleccionmesas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tablaseleccionmesas.Rows[e.RowIndex];
                IDMesa = Convert.ToInt32(row.Cells["id"].Value);

                string conexionString = ConexionBD.ConexionSQL();

                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    try
                    {
                        conexion.Open();

                        string query = "SELECT estado FROM mesas WHERE id = @idMesa";
                        using (SqlCommand command = new SqlCommand(query, conexion))
                        {
                            command.Parameters.AddWithValue("@idMesa", IDMesa);

                            bool estadoMesa = (bool)command.ExecuteScalar();

                            if (!estadoMesa)
                            {
                                MessageBox.Show("La mesa está ocupada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                labelmesa.Text = row.Cells["nombre_mesa"].Value.ToString();
                                labelsalamesa.Text = row.Cells["sala"].Value.ToString();

                                panelmesas.Visible = false;
                                panelmesas.Location = new Point(803, 33);
                                guardarpedidobtn.Enabled = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al verificar la mesa: {ex.Message}");
                    }
                }
            }
        }

        private decimal totalAcumulado = 0;
        private decimal subtotalAcumulado = 0;

        private void bajarproductobtn_Click(object sender, EventArgs e)
        {
            if (tabladatosconsultaprod.ColumnCount == 0)
            {
                tabladatosconsultaprod.Columns.Add("codigoProducto", "Codigo");
                tabladatosconsultaprod.Columns.Add("nombreProducto", "Nombre");
                tabladatosconsultaprod.Columns.Add("precio", "Precio");
                tabladatosconsultaprod.Columns.Add("cantidad", "Cantidad");
            }

            string codigoProducto = txtcodigoproducto.Text;
            string nombreProducto = txtnombreproducto.Text;
            decimal precio;
            decimal iva = 0;
            int cantidad = (int)numCantidad.Value;

            if (!decimal.TryParse(txtiva.Text, out iva))
            {
                MessageBox.Show("Por favor, ingresa un valor válido para el IVA.");
                return;
            }

            if (!decimal.TryParse(txtprecioproducto.Text, out precio))
            {
                MessageBox.Show("Por favor, ingresa un valor válido para el precio.");
                return;
            }

            decimal subtotal = precio * cantidad;
            decimal total = subtotal + (subtotal * iva);

            subtotalAcumulado += subtotal;
            totalAcumulado += total;

            labelsubtotal.Text = subtotalAcumulado.ToString("F2");
            labeltotal.Text = totalAcumulado.ToString("F2");

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(tabladatosconsultaprod);
            row.Cells[0].Value = codigoProducto;
            row.Cells[1].Value = nombreProducto;
            row.Cells[2].Value = precio;
            row.Cells[3].Value = cantidad;

            tabladatosconsultaprod.Rows.Add(row);

            cantidadProd += cantidad;

            labelcantidadarticulos.Text = cantidadProd.ToString();

            txtcodigoproducto.Text = "";
            txtnombreproducto.Text = "";
            txtprecioproducto.Text = "";
            txtiva.Text = "";
            numCantidad.Value = numCantidad.Minimum;

            asignarmesabtn.Enabled = true;
        }

        private void tabladatosconsultaprod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigoProducto = tabladatosconsultaprod.SelectedCells[0].Value.ToString();

            string rutaImagenes = @"C:\SistemaArchivos\Productos\";
            string rutaImagenProducto = Path.Combine(rutaImagenes, codigoProducto + ".jpg");

            if (File.Exists(rutaImagenProducto))
            {
                imagenproducto.Image = System.Drawing.Image.FromFile(rutaImagenProducto);
            }
            else
            {
                imagenproducto.Image = null;
                MessageBox.Show("Imagen no encontrada para el producto seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guardarpedidobtn_Click(object sender, EventArgs e)
        {
            Regex numerosRegex = new Regex(@"^[\d.-]+$");

            if (txtnombrecompleto.Text.Equals("") ||
                txtnumero_cliente.Text.Equals(""))
            {
                MessageBox.Show("No debe dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(pedidoActual))
                    {
                        string queryInsertar = "INSERT INTO facturas (id_pedido, nombre_cliente, mesa, fecha, total, estado) VALUES (@idPedido, @nombreCliente, @mesa, @fecha, @total, 'Pendiente')";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            decimal totalValor;

                            insertarCommand.Parameters.AddWithValue("@idPedido", txtidpedido.Text);
                            insertarCommand.Parameters.AddWithValue("@nombreCliente", txtnombrecompleto.Text);
                            insertarCommand.Parameters.AddWithValue("@mesa", labelmesa.Text);
                            insertarCommand.Parameters.AddWithValue("@fecha", fechapedido.Value.ToString());

                            if (decimal.TryParse(labeltotal.Text, out totalValor))
                            {
                                insertarCommand.Parameters.AddWithValue("@total", totalValor);
                            }
                            else
                            {
                                MessageBox.Show("El valor en el label 'Total' no es un número válido.");
                                return;
                            }

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Pedido registrado con éxito.");
                                imagenproducto.Image = Proyecto_restaurante.Properties.Resources.paisaje;

                                foreach (DataGridViewRow row in tabladatosconsultaprod.Rows)
                                {
                                    string codigoProducto = row.Cells["codigoProducto"].Value.ToString();
                                    int cantidadPedida = Convert.ToInt32(row.Cells["cantidad"].Value);

                                    string queryActualizarExistencia = "UPDATE productos SET existencia = existencia - @cantidadPedida WHERE codigo_producto = @codigoProducto";
                                    using (SqlCommand actualizarExistenciaCommand = new SqlCommand(queryActualizarExistencia, conexion))
                                    {
                                        actualizarExistenciaCommand.Parameters.AddWithValue("@cantidadPedida", cantidadPedida);
                                        actualizarExistenciaCommand.Parameters.AddWithValue("@codigoProducto", codigoProducto);

                                        actualizarExistenciaCommand.ExecuteNonQuery();
                                    }
                                }

                                string queryActualizarMesa = "UPDATE mesas SET estado = 0 WHERE nombre_mesa = @mesa";
                                using (SqlCommand actualizarMesaCommand = new SqlCommand(queryActualizarMesa, conexion))
                                {
                                    actualizarMesaCommand.Parameters.AddWithValue("@mesa", labelmesa.Text);

                                    int rowsAffectedMesa = actualizarMesaCommand.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        buscarclientebtn.Focus();
                                        limpiarbtn_Click(sender, e);
                                        Pedidos_Load(sender, e);
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo Actualizar la mesa.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los datos.");
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

        private void Pedidos_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            string conexionString = ConexionBD.ConexionSQL();

            string consulta = "SELECT TOP 1 id FROM facturas ORDER BY id DESC";
            string busquedaCaja = "SELECT nombre_caja, numero_caja from cajas where responsable = @responsable";

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, con))
                {
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        int nuevoId = Convert.ToInt32(resultado) + 1;
                        txtidpedido.Text = nuevoId.ToString();
                    }
                    else
                    {
                        //MessageBox.Show("No se encontraron pedidos.");
                        txtidpedido.Text = "1";
                    }
                }
            }

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();
                using (SqlCommand cmdBusCaja = new SqlCommand(busquedaCaja, con))
                {
                    cmdBusCaja.Parameters.AddWithValue("@responsable", NombreResponsable);

                    using (SqlDataReader reader = cmdBusCaja.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombreCaja = reader["nombre_caja"].ToString();
                            string numeroCaja = reader["numero_caja"].ToString();
                            labelcaja.Text = $"Caja: {nombreCaja} - {numeroCaja}";
                        }
                        else
                        {
                            labelcaja.Text = "Caja no encontrada.";
                        }
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();

            string consultaBase = "select id_pedido, nombre_cliente, mesa, fecha, total, estado from facturas";
            string filtro = "";

            if (facturadochk.Checked)
            {
                filtro = " where estado = 'Facturado'";
            }
            else if (pendientechk.Checked)
            {
                filtro = " where estado = 'Pendiente'";
            }
            else if (canceladochk.Checked)
            {
                filtro = " where estado = 'Cancelado'";
            }
            else if (todoschk.Checked)
            {
                filtro = "";
            }

            string consultaFinal = consultaBase + filtro;

            SqlDataAdapter adaptador = new SqlDataAdapter(consultaFinal, conexionString);

            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            tabladatospedidos.DataSource = dt;
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            IDMesa = 0;
            facturaID = 0;
            nombreMesa = "";
            txtnombrecompleto.Clear();
            txtnumero_cliente.Clear();

            imagenproducto.Image = Proyecto_restaurante.Properties.Resources.paisaje;

            txtcodigoproducto.Clear();
            txtnombreproducto.Clear();
            txtprecioproducto.Clear();
            numCantidad.Value = numCantidad.Minimum;
            txtiva.Clear();
            labelsubtotal.Text = "0";
            labeltotal.Text = "0";

            tabladatosconsultaprod.Rows.Clear();
            //tablaclientes.Rows.Clear();
            //tablaseleccionmesas.Rows.Clear();
            //tablapanelproducto.Rows.Clear();

            totalAcumulado = 0;
            subtotalAcumulado = 0;
            cantidadProd = 0;
            labelmesa.Text = "";
            labelsalamesa.Text = "";

            labelcantidadarticulos.Text = "0";

            buscarproductobtn.Enabled = false;
            txtcodigoproducto.Enabled = false;
            txtnombreproducto.Enabled = false;
            txtprecioproducto.Enabled = false;
            bajarproductobtn.Enabled = false;
            asignarmesabtn.Enabled = false;

            guardarpedidobtn.Enabled = false;
        }

        private int facturaID;

        private void tabladatospedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tabladatospedidos.Rows[e.RowIndex];
                facturaID = Convert.ToInt32(row.Cells["id_pedido"].Value);
                nombreMesa = row.Cells["mesa"].Value.ToString();
            }
        }

        private void facturarbtn_Click(object sender, EventArgs e)
        {
            if (facturaID > 0)
            {
                string conexionString = ConexionBD.ConexionSQL();

                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    try
                    {
                        conexion.Open();

                        string queryVerificarEstado = "SELECT estado FROM facturas WHERE id_pedido = @idPedido";
                        using (SqlCommand comandoVerificar = new SqlCommand(queryVerificarEstado, conexion))
                        {
                            comandoVerificar.Parameters.AddWithValue("@idPedido", facturaID);
                            string estadoFactura = comandoVerificar.ExecuteScalar()?.ToString();

                            if (estadoFactura == "Cancelado")
                            {
                                MessageBox.Show("No se puede facturar porque la factura está cancelada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else if (estadoFactura == "Facturado")
                            {
                                MessageBox.Show("Este pedido ya está facturado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        string query = "UPDATE facturas SET estado = @nuevoEstado WHERE id_pedido = @idPedido";

                        using (SqlCommand command = new SqlCommand(query, conexion))
                        {
                            command.Parameters.AddWithValue("@nuevoEstado", "Facturado");
                            command.Parameters.AddWithValue("@idPedido", facturaID);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Pedido facturado con éxito.");
                                tabControl1_SelectedIndexChanged(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar el estado de la factura.");
                            }
                        }

                        string queryActualizarMesa = "UPDATE mesas SET estado = 1 WHERE nombre_mesa = @mesa";
                        using (SqlCommand actualizarMesaCommand = new SqlCommand(queryActualizarMesa, conexion))
                        {
                            actualizarMesaCommand.Parameters.AddWithValue("@mesa", nombreMesa);

                            int rowsAffectedMesa = actualizarMesaCommand.ExecuteNonQuery();

                            if (rowsAffectedMesa > 0)
                            {
                                //MessageBox.Show("Mesa actualizada con éxito.", "Éxito");
                                tabControl1_SelectedIndexChanged(sender, e);
                                limpiarbtn_Click(sender, e);
                                Pedidos_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar la mesa.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una factura válida.");
            }
        }

        private void cancelarpedido_Click(object sender, EventArgs e)
        {
            DialogResult editar = MessageBox.Show("¿Desea cancelar este pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (editar == DialogResult.Yes)
            {
                if (facturaID > 0)
                {
                    string conexionString = ConexionBD.ConexionSQL();

                    using (SqlConnection conexion = new SqlConnection(conexionString))
                    {
                        try
                        {
                            conexion.Open();
                            string query = "UPDATE facturas SET estado = @nuevoEstado WHERE id_pedido = @idPedido";
                            using (SqlCommand command = new SqlCommand(query, conexion))
                            {
                                command.Parameters.AddWithValue("@nuevoEstado", "Cancelado");
                                command.Parameters.AddWithValue("@idPedido", facturaID);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Pedido cancelado con éxito.");
                                    limpiarbtn_Click(sender, e);
                                    tabControl1_SelectedIndexChanged(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo actualizar el estado de la factura.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ocurrió un error: {ex.Message}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una factura válida.");
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }

        private void pendientechk_CheckedChanged(object sender, EventArgs e)
        {
            if (pendientechk.Checked == true)
            {
                canceladochk.Checked = false;
                facturadochk.Checked = false;
                todoschk.Checked = false;
                facturaID = 0;
                cancelarpedido.Enabled = true;
                tabControl1_SelectedIndexChanged(sender, e);
            }
        }

        private void facturadochk_CheckedChanged(object sender, EventArgs e)
        {
            if (facturadochk.Checked == true)
            {
                canceladochk.Checked = false;
                pendientechk.Checked = false;
                todoschk.Checked = false;
                facturaID = 0;
                cancelarpedido.Enabled = true;
                tabControl1_SelectedIndexChanged(sender, e);
            }
        }

        private void canceladochk_CheckedChanged(object sender, EventArgs e)
        {
            if (canceladochk.Checked == true)
            {
                facturadochk.Checked = false;
                pendientechk.Checked = false;
                todoschk.Checked = false;
                facturaID = 0;
                cancelarpedido.Enabled = false;
                tabControl1_SelectedIndexChanged(sender, e);
            }
        }

        private void todoschk_CheckedChanged(object sender, EventArgs e)
        {
            if (todoschk.Checked == true)
            {
                facturadochk.Checked = false;
                pendientechk.Checked = false;
                canceladochk.Checked = false;
                facturaID = 0;
                cancelarpedido.Enabled = false;
                tabControl1_SelectedIndexChanged(sender, e);
            }
        }

        private void buscarproductobtn_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void txtbusquedafactura_TextChanged(object sender, EventArgs e)
        {
            FiltroDatosBusqueda(txtbusquedafactura.Text);
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
                    SELECT * FROM facturas
                    WHERE id_pedido LIKE @buscar OR
                    nombre_cliente LIKE @buscar OR
                    mesa LIKE @buscar OR
                    total LIKE @buscar";

                    using (SqlCommand comando = new SqlCommand(query, conectar))
                    {
                        comando.Parameters.AddWithValue("@buscar", "%" + busqueda + "%");

                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        tabladatospedidos.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }
        }

        private void txtbusquedafactura_Enter(object sender, EventArgs e)
        {
            todoschk.Checked = true;
            if (txtbusquedafactura.Text == "(ID Pedido, Cliente, Mesa, Total)")
            {
                txtbusquedafactura.Text = "";
                txtbusquedafactura.ForeColor = Color.Black;
            }
        }

        private void txtbusquedafactura_Leave(object sender, EventArgs e)
        {
            pendientechk.Checked = true;

            if (txtbusquedafactura.Text == "")
            {
                txtbusquedafactura.Text = "(ID Pedido, Cliente, Mesa, Total)";
                txtbusquedafactura.ForeColor = Color.Gray;
                tabControl1_SelectedIndexChanged(sender, e);
            }
        }

        private void asignarmesabtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MantMesas mesas = new MantMesas();
                mesas.Show();
            }
        }
        private void GenerarFacturaPDF(int facturaId)
        {
            try
            {
                string folderPath = @"C:\SistemaArchivos\Facturas\";

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string filePath = Path.Combine(folderPath, $"factura_{facturaId}.pdf");


                PdfSharp.Pdf.PdfDocument document = new PdfSharp.Pdf.PdfDocument();
                document.Info.Title = $"Factura {facturaId}";


                PdfSharp.Pdf.PdfPage page = document.AddPage();


                XGraphics gfx = XGraphics.FromPdfPage(page);


                XFont titleFont = new XFont("Verdana", 20);
                XFont textFont = new XFont("Verdana", 14);
                XFont smallFont = new XFont("Verdana", 12);


                double marginLeft = 40;
                double marginTop = 40;
                double lineHeight = 25;
                double currentY = marginTop;


                gfx.DrawString("Factura", titleFont, XBrushes.Black,
                    new XRect(marginLeft, currentY, page.Width - marginLeft * 2, page.Height),
                    XStringFormats.TopCenter);

                currentY += lineHeight * 2;

                string conexionString = ConexionBD.ConexionSQL();

                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    conexion.Open();

                    string queryFactura = "SELECT id_pedido, nombre_cliente, mesa, fecha, total FROM facturas WHERE id = @idFactura";
                    SqlCommand cmdFactura = new SqlCommand(queryFactura, conexion);
                    cmdFactura.Parameters.AddWithValue("@idFactura", facturaId);

                    SqlDataReader readerFactura = cmdFactura.ExecuteReader();
                    if (readerFactura.Read())
                    {
                        string idPedido = readerFactura["id_pedido"].ToString();
                        string nombreCliente = readerFactura["nombre_cliente"].ToString();
                        string nombreMesa = readerFactura["mesa"].ToString();
                        string fecha = readerFactura["fecha"].ToString();
                        decimal total = Convert.ToDecimal(readerFactura["total"]);

                        gfx.DrawString($"ID Pedido: {idPedido}", textFont, XBrushes.Black,
                            new XRect(marginLeft, currentY, page.Width - marginLeft * 2, page.Height), XStringFormats.TopLeft);
                        currentY += lineHeight;

                        gfx.DrawString($"Cliente: {nombreCliente}", textFont, XBrushes.Black,
                            new XRect(marginLeft, currentY, page.Width - marginLeft * 2, page.Height), XStringFormats.TopLeft);
                        currentY += lineHeight;

                        gfx.DrawString($"Mesa: {nombreMesa}", textFont, XBrushes.Black,
                            new XRect(marginLeft, currentY, page.Width - marginLeft * 2, page.Height), XStringFormats.TopLeft);
                        currentY += lineHeight;

                        gfx.DrawString($"Fecha: {fecha}", textFont, XBrushes.Black,
                            new XRect(marginLeft, currentY, page.Width - marginLeft * 2, page.Height), XStringFormats.TopLeft);
                        currentY += lineHeight;


                        gfx.DrawLine(XPens.Black, marginLeft, currentY, page.Width - marginLeft, currentY);
                        currentY += lineHeight;

                        gfx.DrawString($"Total: {total.ToString("C")}", textFont, XBrushes.Black,
                            new XRect(marginLeft, currentY, page.Width - marginLeft * 2, page.Height), XStringFormats.TopLeft);
                        currentY += lineHeight;

                        gfx.DrawLine(XPens.Black, marginLeft, currentY, page.Width - marginLeft, currentY);
                        currentY += lineHeight;


                        gfx.DrawString("Gracias por su visita.", smallFont, XBrushes.Black,
                            new XRect(marginLeft, currentY, page.Width - marginLeft * 2, page.Height), XStringFormats.TopLeft);
                        currentY += lineHeight;

                        gfx.DrawString("¡Vuelva pronto!", smallFont, XBrushes.Black,
                            new XRect(marginLeft, currentY, page.Width - marginLeft * 2, page.Height), XStringFormats.TopLeft);
                    }

                    readerFactura.Close();
                }

                document.Save(filePath);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}\nDetalles: {ex.StackTrace}");
            }
        }

        private void imprimirbtn_Click(object sender, EventArgs e)
        {
            if (facturaID > 0)
            {
                try
                {
                    GenerarFacturaPDF(facturaID);
                    MessageBox.Show("Factura generada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar el PDF: {ex.Message}\nDetalles: {ex.StackTrace}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una factura válida para imprimir.");
            }
        }

        private void txtproductobusqueda_TextChanged(object sender, EventArgs e)
        {
            FiltroDatosProducto(txtproductobusqueda.Text);
        }

        private void FiltroDatosProducto(string busqueda)
        {
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conectar = new SqlConnection(conexionString))
            {
                try
                {
                    conectar.Open();

                    string query = @"
                            SELECT id, codigo_producto, nombre_producto, categoria, precio_venta, iva, existencia, codigo_de_barra 
                            FROM productos
                            WHERE (CAST(id AS VARCHAR) LIKE @buscar OR
                            codigo_producto LIKE @buscar OR
                            nombre_producto LIKE @buscar OR
                            categoria LIKE @buscar OR
                            codigo_de_barra LIKE @buscar)
                            AND existencia > 0";

                    using (SqlCommand comando = new SqlCommand(query, conectar))
                    {
                        comando.Parameters.AddWithValue("@buscar", "%" + busqueda + "%");

                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        tablapanelproducto.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void FiltroDatosClientes(string busqueda)
        {
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conectar = new SqlConnection(conexionString))
            {
                try
                {
                    conectar.Open();

                    string query = @"
                            SELECT id, nombre_cliente, apellido_cliente, identificacion, telefono
                            FROM cliente
                            WHERE (CAST(id AS VARCHAR) LIKE @buscar OR
                            nombre_cliente LIKE @buscar OR
                            apellido_cliente LIKE @buscar OR
                            identificacion LIKE @buscar OR
                            telefono LIKE @buscar)
                            AND estado = 1";

                    using (SqlCommand comando = new SqlCommand(query, conectar))
                    {
                        comando.Parameters.AddWithValue("@buscar", "%" + busqueda + "%");

                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        tablaclientes.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void txtclientebusqueda_TextChanged(object sender, EventArgs e)
        {
            FiltroDatosClientes(txtclientebusqueda.Text);
        }

        private void txtmesabusqueda_TextChanged(object sender, EventArgs e)
        {
            FiltroDatosMesa(txtmesabusqueda.Text);
        }

        private void FiltroDatosMesa(string busqueda)
        {
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conectar = new SqlConnection(conexionString))
            {
                try
                {
                    conectar.Open();

                    string query = @"
                            SELECT id, sala, nombre_mesa, num_asientos, estado
                            FROM mesas
                            WHERE (CAST(id AS VARCHAR) LIKE @buscar OR
                            sala LIKE @buscar OR
                            nombre_mesa LIKE @buscar";

                    using (SqlCommand comando = new SqlCommand(query, conectar))
                    {
                        comando.Parameters.AddWithValue("@buscar", "%" + busqueda + "%");

                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        tablaclientes.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tablaseleccionmesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtidpedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txtnombrecompleto_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtnombrecompleto.Text))
            {
                habilitarbotones(sender, e);
            }
        }
    }
}
