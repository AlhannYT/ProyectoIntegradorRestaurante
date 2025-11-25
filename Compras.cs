using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_restaurante
{
    public partial class Compras : Form
    {
        
        private readonly string conexionString = ConexionBD.ConexionSQL();

        
        private decimal subtotalAcumulado = 0;
        private decimal impuestosAcumulados = 0;
        private decimal totalAcumulado = 0;
        private int cantidadTotalUnidades = 0;

        
        private int productoSeleccionadoId = 0;
        private string unidadSeleccionada = "";
        private decimal itbisSeleccionadoPorciento = 0; // 0 = exento, 18 = 18%

        // Responsable que viene de la pantalla de login / menu principal (opcional)
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
            // Si se quiere mostrar el responsable base (ej admin)
            if (!string.IsNullOrWhiteSpace(responsableCompra))
            {
                ResponsableCompratxt.Text = responsableCompra;
            }

            FechaCompra.Value = DateTime.Now;
            CargarSiguienteNumeroCompra();
            LimpiarFormulario();
        }

        private void buscarprodbtn_Click(object sender, EventArgs e)
        {
            MostrarPanelIngredientes();
            CargarProductosEnPanel("");
        }

        private void txtbusquedapanelprod_TextChanged(object sender, EventArgs e)
        {
            string texto = txtbusquedapanelprod.Text.Trim();
            CargarProductosEnPanel(texto);
        }
        private void recargaringredbtn_Click(object sender, EventArgs e)
        {
            txtbusquedapanelprod.Clear();
            CargarProductosEnPanel("");
        }

        private void saliringredbtn_Click(object sender, EventArgs e)
        {
            OcultarPanelIngredientes();
        }

        private void tablaingrediente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = tablaingrediente.Rows[e.RowIndex];

            // Tomamos datos del producto (ProductoVenta)
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

            
            IdIngredientetxt.Text = productoSeleccionadoId.ToString();
            txtnombre.Text = nombre;
            txtpreciocompra.Text = precioCompra.ToString("0.00");
            itbisingredtxt.Text = itbisSeleccionadoPorciento.ToString("0.##");

            OcultarPanelIngredientes();

            NumericUpCantidad.Value = NumericUpCantidad.Minimum;
            AgregarBtn.Enabled = true;
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            AgregarLineaDetalle();
        }

        // Guardar compra (estado Pendiente)
        private void ComprarBtn_Click(object sender, EventArgs e)
        {
            GuardarCompraPendiente();
        }

        private void NuevoBtn_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void BusquedaProvBtn_Click(object sender, EventArgs e)
        {
            MostrarPanelProveedores();
            CargarProveedoresEnPanel("");
        }

        
        private void txtprovbusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtprovbusqueda.Text.Trim();
            CargarProveedoresEnPanel(filtro);
        }

        
        private void recargarprovbtn_Click(object sender, EventArgs e)
        {
            txtprovbusqueda.Clear();
            CargarProveedoresEnPanel("");
        }

       
        private void checkactivoprov_CheckedChanged(object sender, EventArgs e)
        {
            CargarProveedoresEnPanel(txtprovbusqueda.Text.Trim());
        }

        private void checkprovinformal_CheckedChanged(object sender, EventArgs e)
        {
            CargarProveedoresEnPanel(txtprovbusqueda.Text.Trim());
        }

        // Doble clic en proveedor se selecciona para cabecera de compra
        private void tablaprov_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = tablaprov.Rows[e.RowIndex];

            int idPersonaProveedor = Convert.ToInt32(row.Cells["IdPersona"].Value);
            string nombreCompleto = row.Cells["NombreCompleto"].Value.ToString();
            string telefono = row.Cells["Telefono"].Value?.ToString();
            string direccion = row.Cells["Direccion"].Value?.ToString();
            bool informal = Convert.ToBoolean(row.Cells["Informal"].Value);

            idproveedortxt.Text = idPersonaProveedor.ToString();
            txtnombrecompleto.Text = nombreCompleto;
            TelefProvTxt.Text = telefono;
            DireccionProvTxt.Text = direccion;
            ProvInformalChk.Checked = informal;

            OcultarPanelProveedores();
        }

        private void salirprovbtn_Click(object sender, EventArgs e)
        {
            OcultarPanelProveedores();
        }

        private void ConfigurarGridDetalle()
        {
            detallecompra.Columns.Clear();
            detallecompra.AutoGenerateColumns = false;
            detallecompra.AllowUserToAddRows = false;

            var colId = new DataGridViewTextBoxColumn
            {
                Name = "IdProducto",
                HeaderText = "ID",
                Width = 60
            };
            detallecompra.Columns.Add(colId);

            var colNombre = new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Ingrediente",
                Width = 180
            };
            detallecompra.Columns.Add(colNombre);

            var colUnidad = new DataGridViewTextBoxColumn
            {
                Name = "Unidad",
                HeaderText = "Unidad",
                Width = 80
            };
            detallecompra.Columns.Add(colUnidad);

            var colCant = new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cantidad",
                Width = 80
            };
            detallecompra.Columns.Add(colCant);

            var colCosto = new DataGridViewTextBoxColumn
            {
                Name = "CostoUnitario",
                HeaderText = "Costo",
                Width = 90
            };
            detallecompra.Columns.Add(colCosto);

            var colSub = new DataGridViewTextBoxColumn
            {
                Name = "Subtotal",
                HeaderText = "Subtotal",
                Width = 100
            };
            detallecompra.Columns.Add(colSub);

            var colItbis = new DataGridViewTextBoxColumn
            {
                Name = "ItbisPorciento",
                HeaderText = "ITBIS %",
                Visible = false
            };
            detallecompra.Columns.Add(colItbis);
        }

        private void MostrarPanelIngredientes()
        {
            PanelIngredientes.Location = new Point(0, 0);
            PanelIngredientes.Visible = true;
        }

        private void OcultarPanelIngredientes()
        {
            PanelIngredientes.Visible = false;
            PanelIngredientes.Location = new Point(4, 444);
        }

        private void MostrarPanelProveedores()
        {
            PanelProv.Location = new Point(0, 0);
            PanelProv.Visible = true;
        }

        private void OcultarPanelProveedores()
        {
            PanelProv.Visible = false;
            PanelProv.Location = new Point(4, 444);
        }

        
        private void LimpiarFormulario()
        {
            // Cabecera
            txtidcompra.Clear();

            idproveedortxt.Clear();
            txtnombrecompleto.Clear();
            TelefProvTxt.Clear();
            DireccionProvTxt.Clear();
            ProvInformalChk.Checked = false;

            
            IdRespoCompratxt.Clear();

            FechaCompra.Value = DateTime.Now;

           
            productoSeleccionadoId = 0;
            unidadSeleccionada = "";
            itbisSeleccionadoPorciento = 0;

            IdIngredientetxt.Clear();
            txtnombre.Clear();
            txtpreciocompra.Clear();
            itbisingredtxt.Clear();

            NumericUpCantidad.Value = NumericUpCantidad.Minimum;

            detallecompra.Rows.Clear();

            subtotalAcumulado = 0;
            impuestosAcumulados = 0;
            totalAcumulado = 0;
            cantidadTotalUnidades = 0;

            CantArticuloLabel.Text = "0";
            SubtotalLabel.Text = "0.00";
            ItbisLabel.Text = "0.00";
            TotalLabel.Text = "0.00";

            ComprarBtn.Enabled = false;
            AgregarBtn.Enabled = false;

            CargarSiguienteNumeroCompra();
        }

    
        private void RecalcularTotales()
        {
            subtotalAcumulado = 0;
            impuestosAcumulados = 0;
            totalAcumulado = 0;
            cantidadTotalUnidades = 0;

            foreach (DataGridViewRow row in detallecompra.Rows)
            {
                if (row.IsNewRow) continue;

                decimal cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                decimal costoUnit = Convert.ToDecimal(row.Cells["CostoUnitario"].Value);
                decimal subtotalLinea = cantidad * costoUnit;

                row.Cells["Subtotal"].Value = subtotalLinea;

                subtotalAcumulado += subtotalLinea;
                cantidadTotalUnidades += (int)cantidad;

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

            CantArticuloLabel.Text = cantidadTotalUnidades.ToString();
            SubtotalLabel.Text = subtotalAcumulado.ToString("F2");
            ItbisLabel.Text = impuestosAcumulados.ToString("F2");
            TotalLabel.Text = totalAcumulado.ToString("F2");

            ComprarBtn.Enabled = detallecompra.Rows.Count > 0;
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

        
        //  CARGA DE DATOS: INGREDIENTES Y PROVEEDORES
        // Ingredientes = ProductoVenta donde ProductoTipo.Ingrediente = 1
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
                AND (@soloActivos = 0 OR p.Activo = 1)
                AND (@f = '' OR p.Nombre LIKE '%' + @f + '%')
                ORDER BY p.Nombre;";

                using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@f", filtro ?? "");
                    da.SelectCommand.Parameters.AddWithValue("@soloActivos",
                        checkingredactivo.Checked ? 1 : 0);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    tablaingrediente.DataSource = dt;

                    if (tablaingrediente.Columns.Contains("IdProducto"))
                        tablaingrediente.Columns["IdProducto"].HeaderText = "ID";
                    if (tablaingrediente.Columns.Contains("Nombre"))
                        tablaingrediente.Columns["Nombre"].HeaderText = "Producto";
                    if (tablaingrediente.Columns.Contains("PrecioCompra"))
                        tablaingrediente.Columns["PrecioCompra"].HeaderText = "Precio compra";
                    if (tablaingrediente.Columns.Contains("Unidad"))
                        tablaingrediente.Columns["Unidad"].HeaderText = "Unidad";
                    if (tablaingrediente.Columns.Contains("Itbis"))
                        tablaingrediente.Columns["Itbis"].HeaderText = "ITBIS %";
                }
            }
        }

        
        private void CargarProveedoresEnPanel(string filtro)
        {
            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();

                bool soloActivos = checkactivoprov.Checked;
                bool soloInformales = checkprovinformal.Checked;

                string sql = @"
                    SELECT 
                        p.IdProveedor,
                        per.IdPersona,
                        per.NombreCompleto,
                        ISNULL(t.Numero, '') AS Telefono,
                        ISNULL(d.Direccion, '') AS Direccion,
                        p.Informal,
                        p.Activo
                    FROM Proveedor p
                    INNER JOIN Persona per ON p.IdPersona = per.IdPersona
                    LEFT JOIN PersonaTelefono t 
                        ON t.IdPersona = per.IdPersona AND t.EsPrincipal = 1
                    LEFT JOIN PersonaDireccion d 
                        ON d.IdPersona = per.IdPersona AND d.EsPrincipal = 1
                    WHERE (@f = '' OR per.NombreCompleto LIKE '%' + @f + '%' OR t.Numero LIKE '%' + @f + '%')
                      AND (@soloActivos = 0 OR p.Activo = 1)
                      AND (@soloInformales = 0 OR p.Informal = 1)
                    ORDER BY per.NombreCompleto;";

                using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@f", filtro ?? "");
                    da.SelectCommand.Parameters.AddWithValue("@soloActivos", soloActivos ? 1 : 0);
                    da.SelectCommand.Parameters.AddWithValue("@soloInformales", soloInformales ? 1 : 0);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    tablaprov.DataSource = dt;

                    if (tablaprov.Columns.Contains("IdProveedor"))
                        tablaprov.Columns["IdProveedor"].HeaderText = "Id Prov.";
                    if (tablaprov.Columns.Contains("IdPersona"))
                        tablaprov.Columns["IdPersona"].HeaderText = "Id Persona";
                    if (tablaprov.Columns.Contains("NombreCompleto"))
                        tablaprov.Columns["NombreCompleto"].HeaderText = "Nombre";
                    if (tablaprov.Columns.Contains("Telefono"))
                        tablaprov.Columns["Telefono"].HeaderText = "Teléfono";
                    if (tablaprov.Columns.Contains("Direccion"))
                        tablaprov.Columns["Direccion"].HeaderText = "Dirección";
                }
            }
        }

            //  LOGICA DEL DETALLE Y GUARDADO DE COMPRA
        
        private void AgregarLineaDetalle()
        {
            if (productoSeleccionadoId <= 0)
            {
                MessageBox.Show("Seleccione un ingrediente primero.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("El nombre del ingrediente está vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtpreciocompra.Text))
            {
                MessageBox.Show("Indique el costo de compra.");
                return;
            }

            if (!decimal.TryParse(txtpreciocompra.Text.Trim(), out decimal costoUnit) || costoUnit < 0)
            {
                MessageBox.Show("Costo inválido.");
                return;
            }

            decimal cantidad = NumericUpCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.");
                return;
            }

            
            int rowIndex = detallecompra.Rows.Add();
            DataGridViewRow rowDetalle = detallecompra.Rows[rowIndex];

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

            IdIngredientetxt.Clear();
            txtnombre.Clear();
            txtpreciocompra.Clear();
            itbisingredtxt.Clear();
            NumericUpCantidad.Value = NumericUpCantidad.Minimum;
            AgregarBtn.Enabled = false;
        }

        // Guarda compra en estado Pendiente (todavia no maneja stock)
        private void GuardarCompraPendiente()
        {
            if (detallecompra.Rows.Count == 0)
            {
                MessageBox.Show("No hay ingredientes en el detalle.");
                return;
            }

            
            if (!int.TryParse(idproveedortxt.Text, out int idProveedorPersona))
            {
                MessageBox.Show("Seleccione un proveedor válido.");
                return;
            }

            // Empleado responsable (opcional)
            int? idEmpleadoResponsable = null;
            if (int.TryParse(IdRespoCompratxt.Text, out int empId))
            {
                idEmpleadoResponsable = empId;
            }

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    
                    string sqlCompra = @"
                        INSERT INTO Compra
                        (Fecha, FechaRecepcion, IdProveedorPersona, Subtotal, Impuestos, Total, Estado, IdEmpleadoResponsable)
                        VALUES (@Fecha, NULL, @IdProveedor, @Subtotal, @Impuestos, @Total, 'Pendiente', @IdEmpleado);
                        SELECT SCOPE_IDENTITY();";

                    int idCompraGenerada;

                    using (SqlCommand cmdCompra = new SqlCommand(sqlCompra, con, tran))
                    {
                        cmdCompra.Parameters.AddWithValue("@Fecha", FechaCompra.Value);
                        cmdCompra.Parameters.AddWithValue("@IdProveedor", idProveedorPersona);
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

                    
                    string sqlDetalle = @"
                        INSERT INTO DetalleCompra
                        (IdCompra, IdProducto, Cantidad, CostoUnitario)
                        VALUES (@IdCompra, @IdProducto, @Cantidad, @CostoUnitario);";

                    foreach (DataGridViewRow row in detallecompra.Rows)
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

        private void checkingredactivo_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductosEnPanel(txtbusquedapanelprod.Text.Trim());
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            txtbusquedapanelprod.Clear();
            checkingredactivo.Checked = true;
            CargarProductosEnPanel("");
        }

        private void eliminarbtn2_Click(object sender, EventArgs e)
        {
            txtprovbusqueda.Clear();
            checkactivoprov.Checked = true;
            checkprovinformal.Checked = false;
            CargarProveedoresEnPanel("");
        }

        private void idproveedortxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
