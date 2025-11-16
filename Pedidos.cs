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
        private int PedidoID;
        private decimal Total;
        private int TipoPago = 0;
        private decimal TotalPedido = 0m;
        private decimal TotalAplicado = 0m;
        private decimal totalAcumulado = 0;
        private decimal subtotalAcumulado = 0;

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
            WHERE e.Activo = 1 AND p.Activo = 1 and IdCliente > 1;"; //Esto es para que no traiga AL CONTADO directamente sino que traiga los demas clientes

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
                    tabControl1.SelectedIndex = 0;
                    Pedidos_Load(sender, e);

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

            labelcantidadarticulos.Text = detalleorden.Rows.Count.ToString();

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
            int estadoMesa = mesa.Estado;


            if (estadoMesa == 1)
            {
                EditarOrden.Enabled = true;
                FacturarOrden.Enabled = true;

                CrearOrden.Enabled = false;
            }
            else
            {
                EditarOrden.Enabled = false;
                FacturarOrden.Enabled = false;

                CrearOrden.Enabled = true;
            }
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            string conexionString = ConexionBD.ConexionSQL();

            string consultaMesa = "Select IdMesa, IdSala, Numero, Capacidad, Ocupado, Estado from Mesa";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(consultaMesa, conexion))
                {
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        mesasprincipal.Controls.Clear();

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

                            mesasprincipal.Controls.Add(btnMesa);
                        }

                    }
                }
            }

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
            volverdetalle_Click(sender, e);
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            IDMesa = 0;
            PedidoID = 0;
            txtnombrecompleto.Text = "AL CONTADO";
            idclientetxt.Text = "1";
            txtnumero_cliente.Clear();


            txtcodigoproducto.Clear();
            txtnombreproducto.Clear();
            txtprecioproducto.Clear();
            numCantidad.Value = numCantidad.Minimum;
            txtiva.Clear();
            labelsubtotal.Text = "0";
            labeltotal.Text = "0";

            detalleorden.Rows.Clear();
            //tablaclientes.Rows.Clear();
            //tablapanelproducto.Rows.Clear();

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

            buscarclientebtn.Enabled = false;
            nota.Enabled = false;

            guardarordenbtn.Enabled = false;
            MesaLabel.Text = "     Mesa asignada: ";
        }

        private void tabladatospedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tabladatospedidos.Rows[e.RowIndex];

                PedidoID = Convert.ToInt32(row.Cells["IdPedido"].Value);
                IDMesa = Convert.ToInt32(row.Cells["IdMesa"].Value);
            }
        }

        private void facturarbtn_Click(object sender, EventArgs e)
        {
            if (PedidoID <= 0)
            {
                MessageBox.Show("Seleccione un pedido válido.");
                return;
            }

            Total = Convert.ToDecimal(tabladatospedidos.CurrentRow.Cells["Total"].Value);

            string estadoPedido = "";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();

                string query = "SELECT Estado FROM Pedido WHERE IdPedido = @id";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", PedidoID);
                    estadoPedido = cmd.ExecuteScalar()?.ToString();
                }
            }

            if (estadoPedido == null)
            {
                MessageBox.Show("El pedido no existe.");
                return;
            }

            if (estadoPedido == "Facturado")
            {
                MessageBox.Show("Este pedido ya está facturado.");
                return;
            }

            if (estadoPedido == "Cancelado")
            {
                MessageBox.Show("Este pedido está cancelado y no puede facturarse.");
                return;
            }

            if (estadoPedido != "Pendiente")
            {
                MessageBox.Show("El pedido debe estar en estado Pendiente.");
                return;
            }

            detallepanelcompleto.Visible = true;
            detallepanelcompleto.BringToFront();
            detallepanelcompleto.Location = new Point(0, 0);
            detallepagopanel.Visible = true;
            eliminar_Click(sender, e);

            if (efectivodt.ColumnCount == 0)
            {
                efectivodt.Columns.Add("TipoDetalle", "Tipo");
                efectivodt.Columns.Add("Total", "Monto");
                efectivodt.Columns.Add("Efectivo", "Aplicado");

                TotalPedido = Convert.ToDecimal(Total);
                totalrealef.Text = TotalPedido.ToString("N2");
            }

            if (tarjetadt.ColumnCount == 0)
            {
                tarjetadt.Columns.Add("TipoDetalle", "Tipo");
                tarjetadt.Columns.Add("Referencia", "Referencia");
                tarjetadt.Columns.Add("Tarjeta", "Tarjeta");

                TotalPedido = Convert.ToDecimal(Total);
                totalrealtar.Text = TotalPedido.ToString("N2");
            }

            if (transferenciadt.ColumnCount == 0)
            {
                transferenciadt.Columns.Add("TipoDetalle", "Tipo");
                transferenciadt.Columns.Add("Referencia", "Referencia");
                transferenciadt.Columns.Add("Tarjeta", "Banco");

                TotalPedido = Convert.ToDecimal(Total);
                totalrealtransf.Text = TotalPedido.ToString("N2");
            }

            totalrealef.Text = Total.ToString();
            totalrealtar.Text = Total.ToString();
            totalrealtransf.Text = Total.ToString();
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

                    if (estadoActual != "Pendiente")
                    {
                        trans.Rollback();
                        MessageBox.Show("El pedido no está pendiente.");
                        return;
                    }

                    string queryMesa = "SELECT IdMesa FROM Pedido WHERE IdPedido = @id";
                    SqlCommand cmdMesa = new SqlCommand(queryMesa, conexion, trans);
                    cmdMesa.Parameters.AddWithValue("@id", PedidoID);

                    int idMesa = Convert.ToInt32(cmdMesa.ExecuteScalar());

                    SqlCommand cmdFacturar = new SqlCommand(
                        "UPDATE Pedido SET Estado='Facturado' WHERE IdPedido=@id",
                        conexion, trans);
                    cmdFacturar.Parameters.AddWithValue("@id", PedidoID);
                    cmdFacturar.ExecuteNonQuery();

                    SqlCommand cmdLiberar = new SqlCommand(
                        "UPDATE Mesa SET Ocupado=0 WHERE IdMesa=@mesa",
                        conexion, trans);
                    cmdLiberar.Parameters.AddWithValue("@mesa", idMesa);
                    cmdLiberar.ExecuteNonQuery();

                    RegistrarPago(conexion, trans);
                    RebajarInventario(conexion, trans, PedidoID);

                    trans.Commit();

                    //MessageBox.Show("Pedido facturado y pago registrado.");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void RebajarInventario(SqlConnection conexion, SqlTransaction trans, int idPedido)
        {
            string query = @"
            SELECT IdProducto, Cantidad 
            FROM DetallePedido 
            WHERE IdPedido = @idPedido";

            SqlCommand cmd = new SqlCommand(query, conexion, trans);
            cmd.Parameters.AddWithValue("@idPedido", idPedido);

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    int idProducto = Convert.ToInt32(dr["IdProducto"]);
                    decimal cantidad = Convert.ToDecimal(dr["Cantidad"]);

                    string queryUpdate = @"
                    UPDATE ProductoVenta
                    SET Existencia = Existencia - @cantidad
                    WHERE IdProducto = @idProducto";

                    SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conexion, trans);
                    cmdUpdate.Parameters.AddWithValue("@cantidad", cantidad);
                    cmdUpdate.Parameters.AddWithValue("@idProducto", idProducto);

                    cmdUpdate.ExecuteNonQuery();
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
            totalpagar.Text = totalrealef.Text;


            FacturarPedido();
            MostrarDevuelta();

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
            if (!decimal.TryParse(efectivotxt.Text, out decimal monto))
            {
                MessageBox.Show("Monto inválido.");
                return;
            }

            decimal totalReal = decimal.Parse(totalrealef.Text);

            if (monto < totalReal)
            {
                MessageBox.Show("El monto ingresado no puede ser menor que el total.");
                return;
            }

            if (monto <= 0)
            {
                MessageBox.Show("Monto inválido.");
                return;
            }

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(efectivodt);
            row.Cells[0].Value = "Efectivo";
            row.Cells[1].Value = totalrealef.Text;
            row.Cells[2].Value = monto;

            pagadotxt.Text = efectivotxt.Text;

            efectivodt.Rows.Add(row);
            efectivotxt.Clear();
            efectivotxt.Enabled = false;
            aplicarefectivo.Enabled = false;
            TipoPago = 1;
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
            tarjetaref.Clear();
            tarjetaref.Enabled = false;
            tarjetacmbx.Enabled = false;
            aplicartarjeta.Enabled = false;
            TipoPago = 2;
        }

        private void aplicartransf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bancoref.Text) || bancocmbx.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar banco y referencia.");
                return;
            }
            transferenciadt.Rows.Add("Transferencia", bancoref.Text, bancocmbx.Text);
            bancoref.Clear();
            bancoref.Enabled = false;
            bancocmbx.Enabled = false;
            aplicartransf.Enabled = false;
            TipoPago = 3;
        }

        private void RegistrarPago(SqlConnection conexion, SqlTransaction trans)
        {
            try
            {
                string sql = @"
                INSERT INTO DetallePago
                (IdPedido, TipoDetalle, Efectivo, Devuelta, Tarjeta, TarjetaNombre, Transferencia, Banco, Total, Estado, Referencia)
                VALUES
                (@IdPedido, @TipoDetalle, @Efectivo, @Devuelta, @Tarjeta, @TarjetaNombre, @Transferencia, @Banco, @Total, @Estado, @Referencia)";

                SqlCommand cmd = new SqlCommand(sql, conexion, trans);
                cmd.Parameters.AddWithValue("@IdPedido", PedidoID);
                cmd.Parameters.AddWithValue("@Total", TotalPedido);
                cmd.Parameters.AddWithValue("@Estado", 1);

                decimal devuelta = 0;

                if (TotalAplicado >= TotalPedido)
                {
                    devuelta = TotalAplicado - TotalPedido;
                }
                else
                {
                    devuelta = 0;
                }

                if (TipoPago == 1)
                {
                    decimal monto = 0;
                    foreach (DataGridViewRow fila in efectivodt.Rows)
                        if (!fila.IsNewRow)
                            monto += Convert.ToDecimal(fila.Cells["Efectivo"].Value);

                    cmd.Parameters.AddWithValue("@TipoDetalle", "Efectivo");
                    cmd.Parameters.AddWithValue("@Efectivo", monto);
                    cmd.Parameters.AddWithValue("@Devuelta", devuelta);
                    cmd.Parameters.AddWithValue("@Tarjeta", 0);
                    cmd.Parameters.AddWithValue("@TarjetaNombre", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Transferencia", 0);
                    cmd.Parameters.AddWithValue("@Banco", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Referencia", DBNull.Value);

                }
                else if (TipoPago == 2)
                {
                    string referencia = "";
                    string tarjetaNombre = "";
                    decimal monto = 0;

                    foreach (DataGridViewRow fila in tarjetadt.Rows)
                    {
                        if (fila.IsNewRow) continue;
                        referencia = fila.Cells["Referencia"].Value.ToString();
                        monto += Convert.ToDecimal(fila.Cells["Tarjeta"].Value);
                        tarjetaNombre = fila.Cells["TarjetaNombre"].Value.ToString();
                    }

                    cmd.Parameters.AddWithValue("@TipoDetalle", "Tarjeta");
                    cmd.Parameters.AddWithValue("@Efectivo", 0);
                    cmd.Parameters.AddWithValue("@Devuelta", 0);
                    cmd.Parameters.AddWithValue("@Tarjeta", monto);
                    cmd.Parameters.AddWithValue("@TarjetaNombre", tarjetaNombre);
                    cmd.Parameters.AddWithValue("@Transferencia", 0);
                    cmd.Parameters.AddWithValue("@Banco", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Referencia", referencia);
                }

                else if (TipoPago == 3)
                {
                    string referencia = "";
                    string banco = "";
                    decimal monto = 0;

                    foreach (DataGridViewRow fila in transferenciadt.Rows)
                    {
                        if (fila.IsNewRow) continue;
                        referencia = fila.Cells["Referencia"].Value.ToString();
                        monto += Convert.ToDecimal(fila.Cells["Transferencia"].Value);
                        banco = fila.Cells["Banco"].Value.ToString();
                    }

                    cmd.Parameters.AddWithValue("@TipoDetalle", "Transferencia");
                    cmd.Parameters.AddWithValue("@Efectivo", 0);
                    cmd.Parameters.AddWithValue("@Devuelta", 0);
                    cmd.Parameters.AddWithValue("@Tarjeta", 0);
                    cmd.Parameters.AddWithValue("@TarjetaNombre", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Transferencia", monto);
                    cmd.Parameters.AddWithValue("@Banco", banco);
                    cmd.Parameters.AddWithValue("@Referencia", referencia);
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error registrando pago: " + ex.Message);
            }
        }

        private void CrearOrden_Click(object sender, EventArgs e)
        {
            if (idMesaSeleccionada == 0)
            {
                MessageBox.Show("Debe seleccionar una mesa.");
                return;
            }

            tabControl1.SelectedIndex = 1;
            IDMesa = idMesaSeleccionada;

            MesaLabel.Text = $"     Mesa asignada: {idMesaSeleccionada}";

            buscarclientebtn.Enabled = true;
            guardarordenbtn.Enabled = true;
            buscarproductobtn.Enabled = true;
            bajarproductobtn.Enabled = true;
            nota.Enabled = true;
        }

        private void FacturarOrden_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void pagartarjeta_Click(object sender, EventArgs e)
        {
            detallepagopanel.Visible = false;
            detallepagopanel.Location = new Point(1617, 6);
            FacturarPedido();
        }

        private void volverdetalle_Click(object sender, EventArgs e)
        {
            detallepanelcompleto.Visible = false;
            detallepanelcompleto.Location = new Point(1617, 6);
            efectivodt.Rows.Clear();
            tarjetadt.Rows.Clear();
            transferenciadt.Rows.Clear();
            efectivotxt.Clear();
            tarjetaref.Clear();
            bancoref.Clear();
            TipoPago = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            volverdetalle_Click(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            volverdetalle_Click(sender, e);
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            efectivodt.Rows.Clear();
            tarjetadt.Rows.Clear();
            transferenciadt.Rows.Clear();
            bancoref.Clear();
            bancoref.Enabled = true;
            bancocmbx.Enabled = true;
            aplicartransf.Enabled = true;
            efectivotxt.Clear();
            efectivotxt.Enabled = true;
            aplicarefectivo.Enabled = true;
            tarjetaref.Clear();
            tarjetaref.Enabled = true;
            tarjetacmbx.Enabled = true;
            aplicartarjeta.Enabled = true;
            TipoPago = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eliminar_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eliminar_Click(sender, e);
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tab = tabControl2.SelectedIndex;

            bloqueopanel.Visible = false;

            if (TipoPago == 1 && (tab == 1 || tab == 2))
            {
                MostrarBloqueo();
                return;
            }

            if (TipoPago == 2 && (tab == 0 || tab == 2))
            {
                MostrarBloqueo();
                return;
            }

            if (TipoPago == 3 && (tab == 0 || tab == 1))
            {
                MostrarBloqueo();
                return;
            }
        }

        private void MostrarBloqueo()
        {
            bloqueopanel.Visible = true;
            bloqueopanel.BringToFront();
            bloqueopanel.Location = new Point(476, 79);
        }

        private void pagartransf_Click(object sender, EventArgs e)
        {
            detallepagopanel.Visible = false;
            detallepagopanel.Location = new Point(1617, 6);
            FacturarPedido();
        }

        private void finalizarbtn_Click(object sender, EventArgs e)
        {
            volverdetalle_Click(sender, e);
        }

        private void numCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bajarproductobtn_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}