using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_restaurante
{
    public partial class Compras : Form
    {
        
        private string conexionString = ConexionBD.ConexionSQL();

        
        private decimal subtotalAcumulado = 0;
        private decimal impuestosAcumulados = 0;
        private decimal totalAcumulado = 0;
        private int cantidadTotalUnidades = 0;

        
        private int productoSeleccionadoId = 0;
        private string unidadSeleccionada = "";
        private decimal itbisSeleccionadoPorciento = 0;   // 0 = exento, 18 = 18%

        public string responsableCompra;

        public Compras()
        {
            InitializeComponent();

            
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            ConfigurarGridDetalle();
        }


        private void Compras_Load(object sender, EventArgs e)
        {
            labelresponsable.Text = "Responsable de la compra: " + responsableCompra;
            CargarSiguienteNumeroCompra();
            LimpiarFormulario();
        }

        
        private void buscarprodbtn_Click(object sender, EventArgs e)
        {
            MostrarPanelBusqueda();
            CargarProductosEnPanel("");
        }

        private void salirprodbtn_Click(object sender, EventArgs e)
        {
            OcultarPanelBusqueda();
        }

        
        private void txtbusquedapanelprod_TextChanged(object sender, EventArgs e)
        {
            string texto = txtbusquedapanelprod.Text.Trim();
            CargarProductosEnPanel(texto);
        }

        
        private void tablapanelprod_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = tablapanelprod.Rows[e.RowIndex];

            // Tomamos datos del producto
            productoSeleccionadoId = Convert.ToInt32(row.Cells["IdProducto"].Value);
            string nombre = row.Cells["Nombre"].Value.ToString();
            decimal precioCompra = Convert.ToDecimal(row.Cells["PrecioCompra"].Value);

            unidadSeleccionada = row.Cells["Unidad"].Value.ToString();

            object itbisObj = row.Cells["Itbis"].Value;
            itbisSeleccionadoPorciento = 0;
            if (itbisObj != null && itbisObj != DBNull.Value)
            {
                itbisSeleccionadoPorciento = Convert.ToDecimal(itbisObj);  // ej. 0 o 18
            }

            
            txtcodigo.Text = productoSeleccionadoId.ToString();
            txtnombre.Text = nombre;
            txtpreciocompra.Text = precioCompra.ToString("0.00");

            OcultarPanelBusqueda();

            numCantidad.Value = numCantidad.Minimum;
            agregarbtn.Enabled = true;
        }

        
        private void agregarbtn_Click(object sender, EventArgs e)
        {
            AgregarLineaDetalle();
        }

        
        private void tablaproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        
        private void comprarbtn_Click(object sender, EventArgs e)
        {
            GuardarCompraPendiente();
        }

        
        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }


        private void ConfigurarGridDetalle()
        {
            tablaproductos.Columns.Clear();
            tablaproductos.AutoGenerateColumns = false;
            tablaproductos.AllowUserToAddRows = false;

            
            var colId = new DataGridViewTextBoxColumn();
            colId.Name = "IdProducto";
            colId.HeaderText = "ID";
            colId.Width = 60;
            tablaproductos.Columns.Add(colId);

            
            var colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "Producto";
            colNombre.Width = 180;
            tablaproductos.Columns.Add(colNombre);

            
            var colUnidad = new DataGridViewTextBoxColumn();
            colUnidad.Name = "Unidad";
            colUnidad.HeaderText = "Unidad";
            colUnidad.Width = 80;
            tablaproductos.Columns.Add(colUnidad);

            
            var colCant = new DataGridViewTextBoxColumn();
            colCant.Name = "Cantidad";
            colCant.HeaderText = "Cantidad";
            colCant.Width = 80;
            tablaproductos.Columns.Add(colCant);

            
            var colCosto = new DataGridViewTextBoxColumn();
            colCosto.Name = "CostoUnitario";
            colCosto.HeaderText = "Costo";
            colCosto.Width = 90;
            tablaproductos.Columns.Add(colCosto);

            
            var colSub = new DataGridViewTextBoxColumn();
            colSub.Name = "Subtotal";
            colSub.HeaderText = "Subtotal";
            colSub.Width = 100;
            tablaproductos.Columns.Add(colSub);

            
            var colItbis = new DataGridViewTextBoxColumn();
            colItbis.Name = "ItbisPorciento";
            colItbis.HeaderText = "ITBIS %";
            colItbis.Visible = false;
            tablaproductos.Columns.Add(colItbis);
        }

        private void MostrarPanelBusqueda()
        {
            panelprod.Location = new Point(0, 0);
            panelprod.Visible = true;
        }

        private void OcultarPanelBusqueda()
        {
            panelprod.Visible = false;
            panelprod.Location = new Point(4, 444);
        }

        private void LimpiarFormulario()
        {
            productoSeleccionadoId = 0;
            unidadSeleccionada = "";
            itbisSeleccionadoPorciento = 0;

            txtcodigo.Clear();
            txtnombre.Clear();
            txtpreciocompra.Clear();

            numCantidad.Value = numCantidad.Minimum;

            tablaproductos.Rows.Clear();

            subtotalAcumulado = 0;
            impuestosAcumulados = 0;
            totalAcumulado = 0;
            cantidadTotalUnidades = 0;

            labelcantidad.Text = "0";
            labeltotal.Text = "0.00";

            comprarbtn.Enabled = false;
            agregarbtn.Enabled = false;

            CargarSiguienteNumeroCompra();
        }

        private void RecalcularTotales()
        {
            subtotalAcumulado = 0;
            impuestosAcumulados = 0;
            totalAcumulado = 0;
            cantidadTotalUnidades = 0;

            foreach (DataGridViewRow row in tablaproductos.Rows)
            {
                if (row.IsNewRow) continue;

                decimal cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                decimal costoUnit = Convert.ToDecimal(row.Cells["CostoUnitario"].Value);
                decimal subtotalLinea = cantidad * costoUnit;

                row.Cells["Subtotal"].Value = subtotalLinea;

                subtotalAcumulado += subtotalLinea;
                cantidadTotalUnidades += (int)cantidad;

                // ITBIS por línea
                decimal itbisLineaPorc = 0;
                if (row.Cells["ItbisPorciento"].Value != null &&
                    row.Cells["ItbisPorciento"].Value != DBNull.Value)
                {
                    itbisLineaPorc = Convert.ToDecimal(row.Cells["ItbisPorciento"].Value);
                }

                if (itbisLineaPorc > 0)
                {
                    decimal impuestoLinea = subtotalLinea * (itbisLineaPorc / 100m);
                    impuestosAcumulados += impuestoLinea;
                }
            }

            totalAcumulado = subtotalAcumulado + impuestosAcumulados;

            labelcantidad.Text = cantidadTotalUnidades.ToString();
            labeltotal.Text = totalAcumulado.ToString("F2");

            comprarbtn.Enabled = tablaproductos.Rows.Count > 0;
        }

        private void CargarSiguienteNumeroCompra()
        {
            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();
                string sql = "SELECT ISNULL(MAX(IdCompra), 0) + 1 FROM Compra;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    object resultado = cmd.ExecuteScalar();
                    int nuevoId = Convert.ToInt32(resultado);
                    txtidcompra.Text = nuevoId.ToString();
                }
            }
        }


        private void CargarProductosEnPanel(string filtro)
        {
            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();

                string sql = @"
                    SELECT 
                        p.IdProducto,
                        p.Nombre,
                        ISNULL(p.PrecioCompra, 0) AS PrecioCompra,
                        ISNULL(p.Itbis, 0) AS Itbis,
                        u.Nombre AS Unidad
                        FROM ProductoVenta p
                        INNER JOIN ProductoTipo t   ON p.IdProductoTipo = t.IdProductoTipo
                        INNER JOIN UnidadMedida u   ON p.IdUnidadMedida = u.IdUnidadMedida
                        WHERE t.Ingrediente = 1
                        AND p.Activo = 1
                        AND (@f = '' OR p.Nombre LIKE '%' + @f + '%')
                        ORDER BY p.Nombre;";

                using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@f", filtro ?? "");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    tablapanelprod.DataSource = dt;

                    if (tablapanelprod.Columns.Contains("IdProducto"))
                        tablapanelprod.Columns["IdProducto"].HeaderText = "ID";
                    if (tablapanelprod.Columns.Contains("Nombre"))
                        tablapanelprod.Columns["Nombre"].HeaderText = "Producto";
                    if (tablapanelprod.Columns.Contains("PrecioCompra"))
                        tablapanelprod.Columns["PrecioCompra"].HeaderText = "Precio compra";
                    if (tablapanelprod.Columns.Contains("Unidad"))
                        tablapanelprod.Columns["Unidad"].HeaderText = "Unidad";
                    if (tablapanelprod.Columns.Contains("Itbis"))
                        tablapanelprod.Columns["Itbis"].HeaderText = "ITBIS %";
                }
            }
        }

        
        private void AgregarLineaDetalle()
        {
            
            if (productoSeleccionadoId <= 0)
            {
                MessageBox.Show("Seleccione un producto primero.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("El nombre del producto está vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtpreciocompra.Text))
            {
                MessageBox.Show("Indique el costo de compra.");
                return;
            }

            decimal costoUnit;
            if (!decimal.TryParse(txtpreciocompra.Text.Trim(), out costoUnit) || costoUnit < 0)
            {
                MessageBox.Show("Costo inválido.");
                return;
            }

            decimal cantidad = numCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.");
                return;
            }

            
            int rowIndex = tablaproductos.Rows.Add();
            DataGridViewRow rowDetalle = tablaproductos.Rows[rowIndex];

            rowDetalle.Cells["IdProducto"].Value = productoSeleccionadoId;
            rowDetalle.Cells["Nombre"].Value = txtnombre.Text.Trim();
            rowDetalle.Cells["Unidad"].Value = unidadSeleccionada;
            rowDetalle.Cells["Cantidad"].Value = cantidad;
            rowDetalle.Cells["CostoUnitario"].Value = costoUnit;
            rowDetalle.Cells["ItbisPorciento"].Value = itbisSeleccionadoPorciento;

            
            RecalcularTotales();

            
            productoSeleccionadoId = 0;
            unidadSeleccionada = "";
            itbisSeleccionadoPorciento = 0;

            txtcodigo.Clear();
            txtnombre.Clear();
            txtpreciocompra.Clear();
            numCantidad.Value = numCantidad.Minimum;
            agregarbtn.Enabled = false;
        }

        // Guarda compra como Pendiente (no toca stock todavia)
        private void GuardarCompraPendiente()
        {
            if (tablaproductos.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la compra.");
                return;
            }

            // proveedor fijo = 1 (luego se cambia)
            int idProveedor = 1;

            // Empleado responsable NULL por ahora
            int? idEmpleadoResponsable = null;

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    //Insertar cabecera Compra
                    string sqlCompra = @"
                        INSERT INTO Compra
                        (Fecha, FechaRecepcion, IdProveedorPersona, Subtotal, Impuestos, Total, Estado, IdEmpleadoResponsable)
                        VALUES (@Fecha, NULL, @IdProveedor, @Subtotal, @Impuestos, @Total, 'Pendiente', @IdEmpleado);
                        SELECT SCOPE_IDENTITY();";

                    int idCompraGenerada = 0;

                    using (SqlCommand cmdCompra = new SqlCommand(sqlCompra, con, tran))
                    {
                        cmdCompra.Parameters.AddWithValue("@Fecha", fechacompra.Value);
                        cmdCompra.Parameters.AddWithValue("@IdProveedor", idProveedor);
                        cmdCompra.Parameters.AddWithValue("@Subtotal", subtotalAcumulado);
                        cmdCompra.Parameters.AddWithValue("@Impuestos", impuestosAcumulados);
                        cmdCompra.Parameters.AddWithValue("@Total", totalAcumulado);

                        if (idEmpleadoResponsable.HasValue)
                            cmdCompra.Parameters.AddWithValue("@IdEmpleado", idEmpleadoResponsable.Value);
                        else
                            cmdCompra.Parameters.AddWithValue("@IdEmpleado", DBNull.Value);

                        object result = cmdCompra.ExecuteScalar();
                        idCompraGenerada = Convert.ToInt32(result);
                    }

                    // Insertar detalle
                    string sqlDetalle = @"
                        INSERT INTO DetalleCompra
                        (IdCompra, IdProducto, Cantidad, CostoUnitario)
                        VALUES (@IdCompra, @IdProducto, @Cantidad, @CostoUnitario);";

                    foreach (DataGridViewRow row in tablaproductos.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int idProd = Convert.ToInt32(row.Cells["IdProducto"].Value);
                        decimal cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                        decimal costoUnit = Convert.ToDecimal(row.Cells["CostoUnitario"].Value);

                        using (SqlCommand cmdDet = new SqlCommand(sqlDetalle, con, tran))
                        {
                            cmdDet.Parameters.AddWithValue("@IdCompra", idCompraGenerada);
                            cmdDet.Parameters.AddWithValue("@IdProducto", idProd);
                            cmdDet.Parameters.AddWithValue("@Cantidad", cantidad);
                            cmdDet.Parameters.AddWithValue("@CostoUnitario", costoUnit);

                            cmdDet.ExecuteNonQuery();
                        }
                    }

                    tran.Commit();

                    MessageBox.Show("Compra registrada como Pendiente.");
                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Error al guardar la compra: " + ex.Message);
                }
            }
        }
    }
}
