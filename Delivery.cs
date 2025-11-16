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
        private int IDMesa = 0;
        private int PedidoID;
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

            totalAcumulado = 0;
            subtotalAcumulado = 0;
            cantidadProd = 0;

            labelcantidadarticulos.Text = "0";

            txtcodigoproducto.Enabled = false;
            txtnombreproducto.Enabled = false;
            txtprecioproducto.Enabled = false;
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
                    INSERT INTO Pedido (Fecha, IdMesa, Origen, IdClientePersona, NombreCliente, Estado, Total, Nota, IdRepartidor)
                    VALUES (@Fecha, @IdMesa, @Origen, @IdClientePersona, @NombreCliente, @Estado, @Total, @Nota, @Repartidor);
                    SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdPedido = new SqlCommand(queryPedido, conexion, transaccion);
                    cmdPedido.Parameters.AddWithValue("@Fecha", fechapedido.Value);
                    cmdPedido.Parameters.AddWithValue("@Direccion", direccioncliente.Text);
                    cmdPedido.Parameters.AddWithValue("@Origen", "Delivery");
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

                    transaccion.Commit();
                    commitRealizado = true;

                    MessageBox.Show("Pedido guardado con éxito.");

                    limpiarbtn_Click(sender, e);
                    tabControl1.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el pedido: " + ex.Message);

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
    }
}
