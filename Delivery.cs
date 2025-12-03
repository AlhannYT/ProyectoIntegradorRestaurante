using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_restaurante
{
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private int cantidadProd = 0;
        private string pedidoActual;
        public string NombrePC;
        private int PedidoID;
        private int EditarEstado = 0;
        private decimal Total;
        private int TipoPago = 0;
        private decimal TotalPedido = 0m;
        private decimal TotalAplicado = 0m;
        private decimal totalAcumulado = 0;
        private decimal subtotalAcumulado = 0;

        string conexionString = ConexionBD.ConexionSQL();

        private void Delivery_Load(object sender, EventArgs e)
        {
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

        private void buscarproductobtn_Click(object sender, EventArgs e)
        {
            panelproducto.Location = new Point(0, 0);
            panelproducto.BringToFront();
            panelproducto.Visible = true;

            string consulta = @"
                SELECT 
                    pv.IdProducto,
                    pv.CodigoBarra,
                    pv.Nombre,
                    pv.PrecioVenta,
                    pv.Itbis,
                    pv.Existencia
                FROM ProductoVenta pv
                INNER JOIN ProductoTipo pt
                ON pv.IdProductoTipo = pt.IdProductoTipo
                WHERE 
                pv.Activo = 1
                AND pt.Ingrediente = 0;";
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

        private void buscarclientebtn_Click(object sender, EventArgs e)
        {
            panelclientes.Location = new Point(0, 0);
            panelclientes.BringToFront();
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

        private void bajarproductobtn_Click(object sender, EventArgs e)
        {
            string codigoProducto = txtcodigoproducto.Text;
            string nombreProducto = txtnombreproducto.Text;

            decimal precio;
            decimal itbis = 0;
            int cantidad = (int)numCantidad.Value;

            if (txtcodigoproducto.Text == "")
            {
                MessageBox.Show("Agregar producto.");
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

            guardarpedidobtn.Enabled = true;
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {

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

            totalAcumulado = 0;
            subtotalAcumulado = 0;
            cantidadProd = 0;

            labelcantidadarticulos.Text = "0";

            txtcodigoproducto.Enabled = false;
            txtnombreproducto.Enabled = false;
            txtprecioproducto.Enabled = false;
            numCantidad.Enabled = false;
            guardarpedidobtn.Enabled = false;
            Delivery_Load(sender, e);
        }

        private void guardarpedidobtn_Click(object sender, EventArgs e)
        {
            if (txtnombrecompleto.Text == "AL CONTADO" || txtnumero_cliente.Text == "" || direccioncliente.Text == "")
            {
                MessageBox.Show("Nombre, Dirección y Teléfono deben tener información.");
                return;
            }

            if (idrepartidor.Text == "")
            {
                MessageBox.Show("Debe seleccionar un repartidor.");
                return;
            }

            if (detalleorden.Rows.Count == 0)
            {
                MessageBox.Show("El pedido no tiene productos agregados.");
                return;
            }

            bool commitRealizado = false;

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    int idPedidoGenerado = 0;

                    if (EditarEstado == 0)
                    {
                        string queryInsert = @"
                        INSERT INTO Pedido
                        (Fecha, Origen, IdClientePersona, NombreCliente, Estado, Total, Nota, Direccion, IdRepartidor)
                        VALUES
                        (@Fecha, @Origen, @IdClientePersona, @NombreCliente, @Estado, @Total, @Nota, @Direccion, @Repartidor);
                        SELECT SCOPE_IDENTITY();";

                        SqlCommand cmdInsert = new SqlCommand(queryInsert, conexion, transaccion);

                        cmdInsert.Parameters.AddWithValue("@Fecha", fechapedido.Value);
                        cmdInsert.Parameters.AddWithValue("@Origen", "Delivery");
                        cmdInsert.Parameters.AddWithValue("@IdClientePersona", Convert.ToInt32(idclientetxt.Text));
                        cmdInsert.Parameters.AddWithValue("@NombreCliente", txtnombrecompleto.Text);
                        cmdInsert.Parameters.AddWithValue("@Estado", "Pendiente");
                        cmdInsert.Parameters.AddWithValue("@Total", Convert.ToDecimal(labeltotal.Text));
                        cmdInsert.Parameters.AddWithValue("@Nota", notatxt.Text);
                        cmdInsert.Parameters.AddWithValue("@Direccion", direccioncliente.Text);
                        cmdInsert.Parameters.AddWithValue("@Repartidor", idrepartidor.Text);

                        idPedidoGenerado = Convert.ToInt32(cmdInsert.ExecuteScalar());
                    }

                    else if (EditarEstado == 1)
                    {
                        idPedidoGenerado = PedidoID;

                        string queryUpdate = @"
                        UPDATE Pedido SET
                            Fecha = @Fecha,
                            IdClientePersona = @IdClientePersona,
                            NombreCliente = @NombreCliente,
                            Total = @Total,
                            Nota = @Nota,
                            Direccion = @Direccion,
                            IdRepartidor = @Repartidor
                        WHERE IdPedido = @IdPedido";

                        SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conexion, transaccion);

                        cmdUpdate.Parameters.AddWithValue("@Fecha", fechapedido.Value);
                        cmdUpdate.Parameters.AddWithValue("@IdClientePersona", Convert.ToInt32(idclientetxt.Text));
                        cmdUpdate.Parameters.AddWithValue("@NombreCliente", txtnombrecompleto.Text);
                        cmdUpdate.Parameters.AddWithValue("@Total", Convert.ToDecimal(labeltotal.Text));
                        cmdUpdate.Parameters.AddWithValue("@Nota", notatxt.Text);
                        cmdUpdate.Parameters.AddWithValue("@Direccion", direccioncliente.Text);
                        cmdUpdate.Parameters.AddWithValue("@Repartidor", idrepartidor.Text);
                        cmdUpdate.Parameters.AddWithValue("@IdPedido", PedidoID);

                        cmdUpdate.ExecuteNonQuery();

                        SqlCommand cmdDel = new SqlCommand(
                            "DELETE FROM DetallePedido WHERE IdPedido = @IdPedido",
                            conexion, transaccion);

                        cmdDel.Parameters.AddWithValue("@IdPedido", PedidoID);
                        cmdDel.ExecuteNonQuery();
                    }

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

                    transaccion.Commit();
                    commitRealizado = true;

                    if (EditarEstado == 0)
                        MessageBox.Show("Pedido guardado con éxito.");
                    else
                        MessageBox.Show("Pedido actualizado con éxito.");

                    EditarEstado = 0;
                    limpiarbtn_Click(sender, e);
                    tabControl1.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el pedido: " + ex.Message);

                    if (!commitRealizado)
                    {
                        try { transaccion.Rollback(); } catch { }
                    }
                }
            }
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
                notapanel.Location = new Point(513, 273);

                EstadoNota = 1;
            }
        }

        private void repartidorbtn_Click(object sender, EventArgs e)
        {
            panelrepartidor.Location = new Point(0, 0);
            panelrepartidor.BringToFront();
            panelrepartidor.Visible = true;

            string consultaCliente = @"
                SELECT 
                e.IdEmpleado,
                p.NombreCompleto
            FROM Empleado e
            LEFT JOIN Persona p ON e.IdPersona = p.IdPersona
            LEFT JOIN PersonaDocumento pd ON p.IdPersona = pd.IdPersona
            WHERE e.Activo = 1 AND p.Activo = 1 and e.IdRolEmpleado=6;";

            using (SqlDataAdapter adaptador = new SqlDataAdapter(consultaCliente, conexionString))
            {
                DataTable dt = new DataTable();

                adaptador.Fill(dt);

                tabladelivery.DataSource = dt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelproducto.Visible = false;
            panelproducto.Location = new Point(3, 499);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelclientes.Visible = false;
            panelclientes.Location = new Point(803, 532);
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
        }

        private void tabladelivery_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tabladelivery.Rows[e.RowIndex];

                string nombreCompleto = row.Cells["NombreCompleto"].Value.ToString();
                string idRepartidor = row.Cells["IdEmpleado"].Value.ToString();
                nombrerepartidor.Text = nombreCompleto;
                idrepartidor.Text = idRepartidor;
            }

            panelrepartidor.Visible = false;
            panelrepartidor.Location = new Point(803, 532);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelrepartidor.Visible = false;
            panelrepartidor.Location = new Point(803, 532);
        }

        private void facturarbtn_Click(object sender, EventArgs e)
        {
            if (PedidoID <= 0)
            {
                MessageBox.Show("Seleccione un pedido válido.");
                return;
            }

            if (tabladatospedidos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una factura.");
                return;
            }

            object valorTotal = tabladatospedidos.CurrentRow.Cells["Total"].Value;

            if (valorTotal == null || valorTotal == DBNull.Value || valorTotal.ToString() == "")
            {
                MessageBox.Show("El valor del total no es válido.");
                return;
            }

            Total = Convert.ToDecimal(valorTotal);

            if (Total <= 0)
            {
                using (SqlConnection cn = new SqlConnection(conexionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT Total FROM Pedido WHERE IdPedido = @id",
                        cn
                    );
                    cmd.Parameters.AddWithValue("@id", PedidoID);
                    object vTotal = cmd.ExecuteScalar();

                    if (vTotal == null || vTotal == DBNull.Value)
                    {
                        MessageBox.Show("No se pudo obtener el total del pedido.");
                        return;
                    }

                    Total = Convert.ToDecimal(vTotal);
                }
            }

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

        private void MostrarDevuelta()
        {
            if (TotalAplicado >= TotalPedido)
                devueltatxt.Text = (TotalAplicado - TotalPedido).ToString("N2");
            else
                devueltatxt.Text = "0.00";
        }

        private void FacturarPedido()
        {
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

                    SqlCommand cmdLiberarComanda = new SqlCommand(
                        "UPDATE Comanda SET Estado='Entregado' WHERE IdPedido=@id",
                        conexion, trans);
                    cmdLiberarComanda.Parameters.AddWithValue("@id", PedidoID);
                    cmdLiberarComanda.ExecuteNonQuery();

                    RegistrarPago(conexion, trans);
                    RebajarInventario(conexion, trans, PedidoID);

                    trans.Commit();

                    MessageBox.Show("Facturacion completada!.");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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

        private void RebajarInventario(SqlConnection conexion, SqlTransaction trans, int idPedido)
        {
            string queryDetalle = @"
            SELECT IdProducto, Cantidad 
            FROM DetallePedido
            WHERE IdPedido = @pedido";

            SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conexion, trans);
            cmdDetalle.Parameters.AddWithValue("@pedido", idPedido);

            using (SqlDataReader drDetalle = cmdDetalle.ExecuteReader())
            {
                List<(int idProducto, decimal cantidadVendida)> lista = new();

                while (drDetalle.Read())
                {
                    lista.Add((
                        Convert.ToInt32(drDetalle["IdProducto"]),
                        Convert.ToDecimal(drDetalle["Cantidad"])
                    ));
                }

                drDetalle.Close();

                foreach (var item in lista)
                {
                    int idProd = item.idProducto;
                    decimal cantidadVendida = item.cantidadVendida;

                    string queryIngredientes = @"
                    SELECT IdIngrediente, Cantidad
                    FROM Receta
                    WHERE IdProducto = @prod";

                    SqlCommand cmdIng = new SqlCommand(queryIngredientes, conexion, trans);
                    cmdIng.Parameters.AddWithValue("@prod", idProd);

                    using (SqlDataReader drIng = cmdIng.ExecuteReader())
                    {
                        List<(int idIng, decimal cantidadIng)> ingredientes = new();

                        while (drIng.Read())
                        {
                            ingredientes.Add((
                                Convert.ToInt32(drIng["IdIngrediente"]),
                                Convert.ToDecimal(drIng["Cantidad"])
                            ));
                        }

                        drIng.Close();

                        foreach (var ing in ingredientes)
                        {
                            int idIngrediente = ing.idIng;
                            decimal cantPorUnidad = ing.cantidadIng;

                            decimal rebaja = cantPorUnidad * cantidadVendida;

                            string queryUpdate = @"
                            UPDATE ProductoVenta
                            SET Existencia = Existencia - @rebaja
                            WHERE IdProducto = @idIng";

                            SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conexion, trans);
                            cmdUpdate.Parameters.AddWithValue("@rebaja", rebaja);
                            cmdUpdate.Parameters.AddWithValue("@idIng", idIngrediente);

                            cmdUpdate.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            FiltroDatosBusqueda();
        }

        private void FiltroDatosBusqueda()
        {
            using (SqlConnection conectar = new SqlConnection(conexionString))
            {
                try
                {
                    conectar.Open();

                    string estado = "";
                    if (facturadochk.Checked) estado = "Facturado";
                    else if (pendientechk.Checked) estado = "Pendiente";
                    else if (canceladochk.Checked) estado = "Cancelado";

                    string query = @"
                    SELECT 
                        IdPedido,
                        NombreCliente,
                        IdMesa,
                        Total,
                        Estado,
                        Fecha
                    FROM Pedido
                    WHERE
                        (NombreCliente LIKE @buscar
                        OR CAST(IdPedido AS VARCHAR) LIKE @buscar
                        OR CAST(IdMesa AS VARCHAR) LIKE @buscar
                        OR CAST(Total AS VARCHAR) LIKE @buscar)
                        AND Fecha >= @inicio
                        AND Fecha <= @fin
                        AND (@estado = '' OR Estado = @estado)
                    ORDER BY Fecha DESC";

                    using (SqlCommand comando = new SqlCommand(query, conectar))
                    {
                        comando.Parameters.AddWithValue("@buscar", "%" + txtbusquedafactura.Text + "%");
                        comando.Parameters.AddWithValue("@inicio", fecini.Value.Date);
                        comando.Parameters.AddWithValue("@fin", fecfin.Value.Date.AddDays(1).AddSeconds(-1));
                        comando.Parameters.AddWithValue("@estado", estado);

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
    }
}
