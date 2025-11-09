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
            WHERE e.Activo = 1 AND p.Activo = 1 and IdCliente > 1;"; //Esto es para que no traiga al contado directamente sino que traiga los demas clientes

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

        private void guardarordenbtn_Click(object sender, EventArgs e)
        {
            bool commitRealizado = false;

            if (idMesaSeleccionada == 0)
            {
                MessageBox.Show("Debe seleccionar una mesa.");
                return;
            }

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    string queryPedido = @"
                    INSERT INTO Pedido (Fecha, IdMesa, Origen, IdClientePersona, NombreCliente, Estado, Total, Nota)
                    VALUES (@Fecha, @IdMesa, @Origen, @IdClientePersona, @NombreCliente, @Estado, @Total, @Nota);
                    SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdPedido = new SqlCommand(queryPedido, conexion, transaccion);
                    cmdPedido.Parameters.AddWithValue("@Fecha", fechapedido.Value);
                    cmdPedido.Parameters.AddWithValue("@IdMesa", idMesaSeleccionada);
                    cmdPedido.Parameters.AddWithValue("@Origen", "Local");
                    cmdPedido.Parameters.AddWithValue("@IdClientePersona", Convert.ToInt32(idclientetxt.Text));
                    cmdPedido.Parameters.AddWithValue("@NombreCliente", txtnombrecompleto.Text);
                    cmdPedido.Parameters.AddWithValue("@Estado", "Pendiente");
                    cmdPedido.Parameters.AddWithValue("@Total", Convert.ToDecimal(labeltotal.Text));
                    cmdPedido.Parameters.AddWithValue("@Nota", notatxt.Text);

                    int idPedidoGenerado = Convert.ToInt32(cmdPedido.ExecuteScalar());

                    string queryDetalle = @"
                    INSERT INTO DetallePedido (IdPedido, IdProducto, Cantidad, PrecioUnitario)
                    VALUES (@IdPedido, @IdProducto, @Cantidad, @PrecioUnitario);";

                    foreach (DataGridViewRow fila in detalleorden.Rows)
                    {
                        if (fila.IsNewRow) continue;

                        SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conexion, transaccion);
                        cmdDetalle.Parameters.AddWithValue("@IdPedido", idPedidoGenerado);
                        cmdDetalle.Parameters.AddWithValue("@IdProducto", Convert.ToInt32(fila.Cells["codigoProducto"].Value));
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(fila.Cells["Cantidad"].Value));
                        cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", Convert.ToDecimal(fila.Cells["Precio"].Value));

                        cmdDetalle.ExecuteNonQuery();
                    }

                    string queryMesa = "UPDATE Mesa SET Ocupado = 1 WHERE IdMesa = @IdMesa";
                    SqlCommand cmdMesa = new SqlCommand(queryMesa, conexion, transaccion);
                    cmdMesa.Parameters.AddWithValue("@IdMesa", idMesaSeleccionada);
                    cmdMesa.ExecuteNonQuery();

                    transaccion.Commit();
                    commitRealizado = true;

                    MessageBox.Show("Orden guardada con éxito.");

                    limpiarbtn_Click(sender, e);
                    panelmesas.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la orden: " + ex.Message);

                    if (!commitRealizado) 
                    {
                        try
                        {
                            transaccion.Rollback();
                        }
                        catch { }
                    }
                }
            }
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

                string nombreCompleto = row.Cells["NombreCompleto"].Value.ToString();
                txtnombrecompleto.Text = nombreCompleto;

                //txtnumero_cliente.Text = row.Cells["telefono"].Value.ToString();
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
            decimal itbis = 0;
            int cantidad = (int)numCantidad.Value;

            if (!decimal.TryParse(txtiva.Text, out itbis))
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
            decimal total = subtotal + (subtotal * (itbis / 100));

            subtotalAcumulado += subtotal;
            totalAcumulado += total;

            labelsubtotal.Text = subtotalAcumulado.ToString("F2");
            labeltotal.Text = totalAcumulado.ToString("F2");

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(detalleorden);
            row.Cells[0].Value = codigoProducto;
            row.Cells[1].Value = nombreProducto;
            row.Cells[2].Value = precio;
            row.Cells[3].Value = itbis;
            row.Cells[4].Value = cantidad;
            row.Cells[5].Value = (precio + itbis) * cantidad;

            detalleorden.Rows.Add(row);

            cantidadProd += cantidad;

            labelcantidadarticulos.Text = cantidadProd.ToString();

            txtcodigoproducto.Clear();
            txtnombreproducto.Clear();
            txtprecioproducto.Clear();
            txtiva.Clear();
            numCantidad.Value = numCantidad.Minimum;

            guardarordenbtn.Enabled = true;
        }

        private Button botonActivo = null;
        private int idMesaSeleccionada = 0;

        private void BtnMesa_Click(object sender, EventArgs e)
        {
            Button btnSeleccionado = sender as Button;
            if (btnSeleccionado == null) return;

            if (botonActivo != null)
            {
                dynamic anterior = botonActivo.Tag;

                botonActivo.BackColor =
                    (anterior.Estado == 1) ? Color.LightCoral : Color.LightGreen;
            }

            botonActivo = btnSeleccionado;
            btnSeleccionado.BackColor = Color.DodgerBlue;

            dynamic mesa = btnSeleccionado.Tag;
            idMesaSeleccionada = mesa.Id;

        }

        private void pasosiguiente_Click(object sender, EventArgs e)
        {
            if (detalleorden.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar productos al pedido.");
                return;
            }

            panelmesas.Visible = true;
            panelmesas.BringToFront();
            panelmesas.Location = new Point(0, 0);
            notapanel.Visible = false;

            string consulta = "Select IdMesa, IdSala, Numero, Capacidad, Ocupado, Estado from Mesa where Ocupado = 0 and Reservado = 0";

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
                            Button btnMesa = new Button();
                            btnMesa.Width = 150;
                            btnMesa.Height = 100;
                            btnMesa.Margin = new Padding(10);
                            btnMesa.TextAlign = ContentAlignment.MiddleCenter;
                            btnMesa.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                            int estado = Convert.ToInt32(lector["Ocupado"]);

                            btnMesa.BackColor = (estado == 1) ? Color.LightCoral : Color.LightGreen;

                            btnMesa.Tag = new
                            {
                                Id = Convert.ToInt32(lector["IdMesa"]),
                                Estado = estado
                            };

                            string numero = lector["Numero"].ToString();
                            string sala = lector["IdSala"].ToString();
                            string capacidad = lector["Capacidad"].ToString();

                            btnMesa.Text =
                                "Mesa #" + numero +
                                "\nSala: " + sala +
                                "\nAsientos: " + capacidad;

                            btnMesa.Click += BtnMesa_Click;

                            flowmesas.Controls.Add(btnMesa);
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

            if (detalleorden.ColumnCount == 0)
            {
                detalleorden.Columns.Add("codigoProducto", "Codigo");
                detalleorden.Columns.Add("nombreProducto", "Nombre");
                detalleorden.Columns.Add("precio", "Precio");
                detalleorden.Columns.Add("ITBIS", "ITBIS");
                detalleorden.Columns.Add("cantidad", "Cantidad");
                detalleorden.Columns.Add("subtotal", "Importe");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();

            string consultaBase = @"
            SELECT 
                p.IdPedido,
                p.IdMesa,
                p.NombreCliente AS [Cliente],
                m.Numero AS [Mesa], 
	            m.IdSala as [Sala],
                p.Fecha,
                p.Total,
                p.Estado
            FROM Pedido p
            INNER JOIN Mesa m ON p.IdMesa = m.IdMesa";

            string filtro = "";

            if (facturadochk.Checked)
                filtro = " WHERE p.Estado = 'Facturado'";
            else if (pendientechk.Checked)
                filtro = " WHERE p.Estado = 'Pendiente'";
            else if (canceladochk.Checked)
                filtro = " WHERE p.Estado = 'Cancelado'";
            else if (todoschk.Checked)
                filtro = "";

            string consultaFinal = consultaBase + filtro + " ORDER BY p.IdPedido DESC";

            SqlDataAdapter adaptador = new SqlDataAdapter(consultaFinal, conexionString);
            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tabladatospedidos.DataSource = dt;
            tabladatospedidos.Columns["IdMesa"].Visible = false;
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            IDMesa = 0;
            PedidoID = 0;
            IDMesa = 0;
            txtnombrecompleto.Clear();
            txtnumero_cliente.Clear();


            txtcodigoproducto.Clear();
            txtnombreproducto.Clear();
            txtprecioproducto.Clear();
            numCantidad.Value = numCantidad.Minimum;
            txtiva.Clear();
            labelsubtotal.Text = "0";
            labeltotal.Text = "0";

            detalleorden.Rows.Clear();
            tablaclientes.Rows.Clear();
            tablapanelproducto.Rows.Clear();

            totalAcumulado = 0;
            subtotalAcumulado = 0;
            cantidadProd = 0;

            labelcantidadarticulos.Text = "0";

            buscarproductobtn.Enabled = false;
            txtcodigoproducto.Enabled = false;
            txtnombreproducto.Enabled = false;
            txtprecioproducto.Enabled = false;
            bajarproductobtn.Enabled = false;
            guardarordenbtn.Enabled = false;

            pasosiguiente.Enabled = false;
        }

        private int PedidoID;

        private void tabladatospedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tabladatospedidos.Rows[e.RowIndex];

                PedidoID = Convert.ToInt32(row.Cells["IdPedido"].Value);
                IDMesa = Convert.ToInt32(row.Cells["IdMesa"].Value);
            }
        }

        private int TipoPago = 0;
        private decimal TotalPedido = 0m;
        private decimal TotalAplicado = 0m;

        private void facturarbtn_Click(object sender, EventArgs e)
        {
            if (PedidoID <= 0)
            {
                MessageBox.Show("Seleccione un pedido válido.");
                return;
            }

            detallepanelcompleto.Visible = true;
            detallepanelcompleto.BringToFront();
            detallepanelcompleto.Location = new Point(0, 0);
            detallepagopanel.Visible = true;

            if (efectivodt.ColumnCount == 0)
            {
                efectivodt.Columns.Add("TipoDetalle", "Tipo");
                efectivodt.Columns.Add("Total", "Monto");
                efectivodt.Columns.Add("Efectivo", "Monto Aplicado");

                TotalPedido = Convert.ToDecimal(labeltotal.Text);
                totalrealef.Text = TotalPedido.ToString("N2");
            }

            if (tarjetadt.ColumnCount == 0)
            {
                tarjetadt.Columns.Add("TipoDetalle", "Tipo");
                tarjetadt.Columns.Add("Referencia", "Referencia");
                tarjetadt.Columns.Add("Tarjeta", "Tarjeta");
            }

            if (transferenciadt.ColumnCount == 0)
            {
                transferenciadt.Columns.Add("TipoDetalle", "Tipo");
                transferenciadt.Columns.Add("Referencia", "Referencia");
                transferenciadt.Columns.Add("Tarjeta", "Banco");
            }

        }

        private void FacturarPedido()
        {
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                SqlTransaction trans = conexion.BeginTransaction();

                try
                {
                    string queryEstado = "SELECT Estado FROM Pedido WHERE IdPedido = @id";

                    SqlCommand cmdEstado = new SqlCommand(queryEstado, conexion, trans);
                    cmdEstado.Parameters.AddWithValue("@id", PedidoID);

                    string estadoActual = cmdEstado.ExecuteScalar()?.ToString();

                    if (estadoActual == null)
                    {
                        MessageBox.Show("El pedido no existe.");
                        trans.Rollback();
                        return;
                    }

                    if (estadoActual == "Facturado")
                    {
                        MessageBox.Show("Este pedido ya está facturado.");
                        trans.Rollback();
                        return;
                    }

                    if (estadoActual == "Cancelado")
                    {
                        MessageBox.Show("Este pedido está cancelado y no puede ser facturado.");
                        trans.Rollback();
                        return;
                    }

                    if (estadoActual != "Pendiente")
                    {
                        MessageBox.Show("El pedido debe estar en estado Pendiente para facturarlo.");
                        trans.Rollback();
                        return;
                    }

                    string queryMesa = "SELECT IdMesa FROM Pedido WHERE IdPedido = @id";

                    SqlCommand cmdMesa = new SqlCommand(queryMesa, conexion, trans);
                    cmdMesa.Parameters.AddWithValue("@id", PedidoID);

                    object mesaObj = cmdMesa.ExecuteScalar();
                    if (mesaObj == null)
                    {
                        MessageBox.Show("El pedido no tiene mesa asignada.");
                        trans.Rollback();
                        return;
                    }

                    int idMesa = Convert.ToInt32(mesaObj);

                    string queryFacturar = @"
                    UPDATE Pedido
                    SET Estado = 'Facturado'
                    WHERE IdPedido = @id";

                    SqlCommand cmdFacturar = new SqlCommand(queryFacturar, conexion, trans);
                    cmdFacturar.Parameters.AddWithValue("@id", PedidoID);
                    cmdFacturar.ExecuteNonQuery();

                    string queryLiberarMesa = @"
                    UPDATE Mesa
                    SET Ocupado = 0
                    WHERE IdMesa = @mesa";

                    SqlCommand cmdLiberar = new SqlCommand(queryLiberarMesa, conexion, trans);
                    cmdLiberar.Parameters.AddWithValue("@mesa", idMesa);
                    cmdLiberar.ExecuteNonQuery();

                    trans.Commit();

                    MessageBox.Show("Pedido facturado con éxito.");

                    //tabControl1_SelectedIndexChanged(sender, e);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cancelarpedido_Click(object sender, EventArgs e)
        {
            DialogResult editar = MessageBox.Show("¿Desea cancelar este pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (editar == DialogResult.Yes)
            {
                if (PedidoID > 0)
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
                                command.Parameters.AddWithValue("@idPedido", PedidoID);

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
                PedidoID = 0;
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
                PedidoID = 0;
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
                PedidoID = 0;
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
                PedidoID = 0;
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
            if (PedidoID > 0)
            {
                try
                {
                    GenerarFacturaPDF(PedidoID);
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

        private void txtnombrecompleto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnombrecompleto.Text))
            {
                habilitarbotones(sender, e);
            }
        }


        private void pagarefectivo_Click(object sender, EventArgs e)
        {
            detallepagopanel.Visible = false;
            detallepagopanel.Location = new Point(1617, 6);
            devueltapanel.Visible = true;
            devueltapanel.Location = new Point(466, 0);
        }

        public int EstadoNota = 0;

        private void nota_Click(object sender, EventArgs e)
        {
            if (EstadoNota == 1)
            {
                notapanel.Visible = false;
                notapanel.Location = new Point(1617, 50);

                EstadoNota = 0;
            }
            else
            {
                notapanel.Visible = true;
                notapanel.Location = new Point(513, 277);

                EstadoNota = 1;
            }
        }

        private void aplicarefectivo_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(efectivotxt.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Monto inválido.");
                return;
            }
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(efectivodt);
            row.Cells[0].Value = "Efectivo";
            row.Cells[1].Value = totalrealef.Text;
            row.Cells[2].Value = monto;

            efectivodt.Rows.Add(row);

            TipoPago = 1;
            MostrarDevuelta();
        }

        private void MostrarDevuelta()
        {
            if (TotalAplicado >= TotalPedido)
                devueltatxt.Text = (TotalAplicado - TotalPedido).ToString("N2");
            else
                devueltatxt.Text = "0.00";
        }

        private void aplicartarjeta_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(tarjetaref.Text) || tarjetacmbx.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar Tarjeta y referencia.");
                return;
            }
            
            tarjetadt.Rows.Add("Tarjeta", tarjetaref.Text, tarjetacmbx.Text);
            TipoPago = 2;
        }

        private void aplicartransf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bancoref.Text)||bancocmbx.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar banco y referencia.");
                return;
            }
            transferenciadt.Rows.Add("Transferencia", totalrealef.Text, bancocmbx.Text);
            TipoPago = 3;
        }
    }
}
