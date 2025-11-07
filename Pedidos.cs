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
        public string NombrePC;
        private int IDMesa = 0;

        string conexionString = ConexionBD.ConexionSQL();

        private void buscarclientebtn_Click(object sender, EventArgs e)
        {
            panelclientes.Location = new Point(0, 0);
            panelclientes.Visible = true;

            string consultaCliente = @"
                SELECT 
                    e.IdCliente,
                    p.NombreCompleto,
                    pd.Numero AS Cedula
                FROM Cliente e
                LEFT JOIN Persona p ON e.IdPersona = p.IdPersona
                LEFT JOIN PersonaDocumento pd ON p.IdPersona = pd.IdPersona
                WHERE e.Activo = 1 AND p.Activo = 1;";

            using (SqlDataAdapter adaptador = new SqlDataAdapter(consultaCliente, conexionString))
            {
                DataTable dt = new DataTable();

                adaptador.Fill(dt);

                tablaclientes.DataSource = dt;
            }
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

            string consulta = "SELECT \r\n    pv.IdProducto,\r\n    pv.CodigoBarra,\r\n    pv.Nombre,\r\n    pv.PrecioVenta,\r\n    pv.Itbis,\r\n    pv.Existencia\r\nFROM ProductoVenta pv\r\nINNER JOIN ProductoTipo pt\r\n    ON pv.IdProductoTipo = pt.IdProductoTipo\r\nWHERE \r\n    pv.Activo = 1\r\n    AND pt.Ingrediente = 0;";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            tablapanelproducto.DataSource = dt;

            tablapanelproducto.Columns["IdProducto"].HeaderText = "ID";
            tablapanelproducto.Columns["CodigoBarra"].HeaderText = "Código";
            tablapanelproducto.Columns["Nombre"].HeaderText = "Nombre";
            tablapanelproducto.Columns["PrecioVenta"].HeaderText = "Venta";
            tablapanelproducto.Columns["ITBIS"].HeaderText = "ITBIS";
            tablapanelproducto.Columns["Existencia"].HeaderText = "Existencia";

        }

        private void asignarmesabtn_Click(object sender, EventArgs e)
        {
            detallepagopanel.Visible = true;
            detallepagopanel.Location = new Point(466, 0);
            panelmesas.Visible = false;

            //string conexionString = ConexionBD.ConexionSQL();

            //string consulta = "select id, sala, nombre_mesa, num_asientos, estado from mesas";

            //SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            //DataTable dt = new DataTable();

            //adaptador.Fill(dt);

            //tablaseleccionmesas.DataSource = dt;
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

                txtcodigoproducto.Text = row.Cells["IdProducto"].Value.ToString();
                txtnombreproducto.Text = row.Cells["Nombre"].Value.ToString();
                txtprecioproducto.Text = row.Cells["PrecioVenta"].Value.ToString();
                txtiva.Text = row.Cells["ITBIS"].Value.ToString();
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

        private decimal totalAcumulado = 0;
        private decimal subtotalAcumulado = 0;

        private void bajarproductobtn_Click(object sender, EventArgs e)
        {
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
            decimal total = subtotal + (subtotal * (iva / 100));

            subtotalAcumulado += subtotal;
            totalAcumulado += total;

            labelsubtotal.Text = subtotalAcumulado.ToString("F2");
            labeltotal.Text = totalAcumulado.ToString("F2");

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(tabladatosconsultaprod);
            row.Cells[0].Value = codigoProducto;
            row.Cells[1].Value = nombreProducto;
            row.Cells[2].Value = precio;
            row.Cells[3].Value = iva;
            row.Cells[4].Value = cantidad;

            tabladatosconsultaprod.Rows.Add(row);

            cantidadProd += cantidad;

            labelcantidadarticulos.Text = cantidadProd.ToString();

            txtcodigoproducto.Clear();
            txtnombreproducto.Clear();
            txtprecioproducto.Clear();
            txtiva.Clear();
            numCantidad.Value = numCantidad.Minimum;

            asignarmesabtn.Enabled = true;
        }

        private void tabladatosconsultaprod_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Color colorSeleccionado = Color.DodgerBlue;
        private int idMesaSeleccionada = -1;
        private Panel tarjetaActiva = null;

        private void Tarjeta_Click(object sender, EventArgs e)
        {
            Panel tarjetaSeleccionada = sender as Panel;

            if (tarjetaSeleccionada != null)
            {
                if (tarjetaActiva != null)
                {
                    dynamic anterior = tarjetaActiva.Tag;
                    tarjetaActiva.BackColor = (anterior.Estado == 1) ? Color.LightGreen : Color.LightCoral;
                }

                tarjetaActiva = tarjetaSeleccionada;
                tarjetaSeleccionada.BackColor = Color.DodgerBlue;

                dynamic mesa = tarjetaSeleccionada.Tag;
                idMesaSeleccionada = mesa.Id;
            }
        }

        private void guardarpedidobtn_Click(object sender, EventArgs e)
        {
            panelmesas.Visible = true;
            panelmesas.Location = new Point(0, 0);

            string consulta = "select IdMesa, IdSala, Numero, Capacidad, Ocupado, Estado from Mesa";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        flowmesas.Controls.Clear();

                        while (lector.Read())
                        {
                            Panel tarjeta = new Panel();
                            tarjeta.Width = 150;
                            tarjeta.Height = 100;
                            tarjeta.BorderStyle = BorderStyle.FixedSingle;
                            tarjeta.Margin = new Padding(10);

                            int estado = Convert.ToInt32(lector["Ocupado"]);
                            tarjeta.BackColor = (estado == 1) ? Color.LightCoral : Color.LightGreen;

                            tarjeta.Tag = new
                            {
                                Id = Convert.ToInt32(lector["IdMesa"]),
                                Estado = estado
                            };

                            Label lblMesa = new Label();
                            lblMesa.Text = "Mesa # " + lector["Numero"].ToString();
                            lblMesa.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                            lblMesa.AutoSize = false;
                            lblMesa.TextAlign = ContentAlignment.MiddleCenter;
                            lblMesa.Dock = DockStyle.Top;

                            Label lblSala = new Label();
                            lblSala.Text = "Sala: " + lector["IdSala"].ToString();
                            lblSala.Dock = DockStyle.Top;
                            lblSala.TextAlign = ContentAlignment.MiddleCenter;

                            Label lblAsientos = new Label();
                            lblAsientos.Text = "Asientos: " + lector["Capacidad"].ToString();
                            lblAsientos.Dock = DockStyle.Bottom;
                            lblAsientos.TextAlign = ContentAlignment.MiddleCenter;

                            tarjeta.Controls.Add(lblAsientos);
                            tarjeta.Controls.Add(lblSala);
                            tarjeta.Controls.Add(lblMesa);

                            tarjeta.Click += Tarjeta_Click;

                            flowmesas.Controls.Add(tarjeta);
                        }
                    }
                }
            }

            panelmesas.Visible = true;
            panelmesas.Location = new Point(0, 0);
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            string conexionString = ConexionBD.ConexionSQL();

            string consulta = "SELECT TOP 1 IdPedido FROM Pedido ORDER BY IdPedido DESC";
            string busquedaCaja = @"
            SELECT 
                c.Nombre AS nombre_caja,
                c.Numero AS numero_caja
            FROM Configuracion conf
            INNER JOIN Caja c
                ON conf.IdCaja = c.IdCaja
            WHERE conf.NombrePC = @NombrePC";

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
                    cmdBusCaja.Parameters.AddWithValue("@NombrePC", NombrePC);

                    using (SqlDataReader reader = cmdBusCaja.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombreCaja = reader["nombre_caja"].ToString();
                            labelcaja.Text = $"{nombreCaja}";
                        }
                        else
                        {
                            labelcaja.Text = "Caja no encontrada.";
                        }
                    }
                }
            }

            if (tabladatosconsultaprod.ColumnCount == 0)
            {
                tabladatosconsultaprod.Columns.Add("codigoProducto", "Codigo");
                tabladatosconsultaprod.Columns.Add("nombreProducto", "Nombre");
                tabladatosconsultaprod.Columns.Add("precio", "Precio");
                tabladatosconsultaprod.Columns.Add("ITBIS", "ITBIS");
                tabladatosconsultaprod.Columns.Add("cantidad", "Cantidad");
            }

            if (tablareceta.ColumnCount == 0)
            {
                tablareceta.Columns.Add("IdIngrediente", "ID");
                tablareceta.Columns.Add("nombreIngrediente", "Ingrediente");
                tablareceta.Columns.Add("cantidad", "Cantidad");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();

            string consultaBase = "select IdPedido, IdClientePersona, IdMesa, Fecha, Estado from Pedido";
            string filtro = "";

            if (facturadochk.Checked)
                filtro = " where estado = 'Facturado'";
            else if (pendientechk.Checked)
                filtro = " where estado = 'Pendiente'";
            else if (canceladochk.Checked)
                filtro = " where estado = 'Cancelado'";
            else if (todoschk.Checked)
                filtro = "";

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
            if (!string.IsNullOrEmpty(txtnombrecompleto.Text))
            {
                habilitarbotones(sender, e);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pagarefectivo_Click(object sender, EventArgs e)
        {
            detallepagopanel.Visible = false;
            detallepagopanel.Location = new Point(1617, 6);
            devueltapanel.Visible = true;
            devueltapanel.Location = new Point(466, 0);
        }

        private void txtnumero_cliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
