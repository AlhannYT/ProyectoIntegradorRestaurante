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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_restaurante
{
    public partial class ConsProductos : Form
    {
        public ConsProductos()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        private string CodigoProductoActual;
        private int idProducto = 0;
        private int idCategoria = 0;

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idProducto = Convert.ToInt32(tabladatos.SelectedCells[0].Value);

            string codigoProducto = idProducto.ToString();

            string rutaImagenes = @"C:\SistemaArchivos\Productos";
            string rutaImagenProducto = Path.Combine(rutaImagenes, codigoProducto + ".jpg");

            if (File.Exists(rutaImagenProducto))
            {
                imagenproducto.Image = Image.FromFile(rutaImagenProducto);
            }
            else
            {
                imagenproducto.Image = Proyecto_restaurante.Properties.Resources.paisaje;
            }
        }

        private int ingrediente = 0;

        private void ConsProductos_Load(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();

            string consultaUltimoID = "SELECT ISNULL(MAX(IdProducto), 0) + 1 FROM ProductoVenta";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(consultaUltimoID, conexion))
                {
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        ultimoID.Text = resultado.ToString();
                    }
                    else
                    {
                        ultimoID.Text = "1";
                    }
                }
            }

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            string consulta = "SELECT IdProducto, CodigoBarra, Nombre, PrecioCompra, PrecioVenta, Existencia FROM ProductoVenta";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            tabladatos.DataSource = dt;

            tabladatos.Columns["IdProducto"].HeaderText = "ID";
            tabladatos.Columns["CodigoBarra"].HeaderText = "Código";
            tabladatos.Columns["Nombre"].HeaderText = "Nombre";
            tabladatos.Columns["PrecioCompra"].HeaderText = "Costo";
            tabladatos.Columns["PrecioVenta"].HeaderText = "Precio";
            tabladatos.Columns["Existencia"].HeaderText = "Existencia";

            CargarTiposProducto(conexionString);

            string codigoProducto = txtcodigo_barras.Text;
            string rutaImagenes = @"C:\SistemaArchivos\Productos";
            string rutaImagenProducto = Path.Combine(rutaImagenes, codigoProducto + ".jpg");

            if (File.Exists(rutaImagenProducto))
            {
                imagenproducto.Image = Image.FromFile(rutaImagenProducto);
            }
        }

        private void CargarTiposProducto(string conexionString)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                string consultaTipos = "SELECT IdProductoTipo, Nombre FROM ProductoTipo WHERE Activo = 1";
                string consultaUniMedida = "SELECT IdUnidadMedida, Nombre FROM UnidadMedida WHERE Activo = 1";
                SqlDataAdapter da = new SqlDataAdapter(consultaTipos, conexion);
                DataTable dtTipos = new DataTable();
                da.Fill(dtTipos);

                SqlDataAdapter uni = new SqlDataAdapter(consultaUniMedida, conexion);
                DataTable dtUni = new DataTable();
                uni.Fill(dtUni);

                tipoproductocmbx.DisplayMember = "Nombre";
                tipoproductocmbx.ValueMember = "IdProductoTipo";
                tipoproductocmbx.DataSource = dtTipos;

                unidadmedida.DisplayMember = "Nombre";
                unidadmedida.ValueMember = "IdUnidadMedida";
                unidadmedida.DataSource = dtUni;
            }

            tipoproductocmbx.SelectedIndexChanged += tipoproductocmbx_SelectedIndexChanged;
        }

        private void tipoproductocmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoproductocmbx.SelectedValue == null)
                return;

            if (tipoproductocmbx.SelectedValue is DataRowView)
                return;

            int idTipo = Convert.ToInt32(tipoproductocmbx.SelectedValue);
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                string consulta = "SELECT Ingrediente FROM ProductoTipo WHERE IdProductoTipo = @Id";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@Id", idTipo);

                conexion.Open();
                object resultado = cmd.ExecuteScalar();
                conexion.Close();

                if (resultado != null && resultado != DBNull.Value)
                {
                    ingrediente = Convert.ToInt32(resultado);
                }
                else
                {
                    ingrediente = 0;
                }
            }

            if (ingrediente == 1)
            {
                txtcodigo_barras.Enabled = true;
                codigobarrarandombtn.Enabled = true;
                txtnombre_prod.Enabled = true;
                txtprecio_compra.Enabled = true;
                ITBIS.Enabled = true;
                buscarcateg.Enabled = true;
                unidadmedida.Enabled = true;
                txtprecio_venta.Enabled = false;
                guardarbtn.Enabled = true;
                limpiarbtn.Enabled = true;

                seleccionpanel.Enabled = false;

                ingredientesconsulta.DataSource = null;

                recetaingredientes.Columns.Clear();
                recetaingredientes.Rows.Clear();
            }
            else
            {
                txtcodigo_barras.Enabled = true;
                codigobarrarandombtn.Enabled = true;
                txtnombre_prod.Enabled = true;
                txtprecio_compra.Enabled = true;
                ITBIS.Enabled = true;
                buscarcateg.Enabled = true;
                unidadmedida.Enabled = true;

                guardarbtn.Enabled = true;
                limpiarbtn.Enabled = true;

                seleccionpanel.Enabled = true;
                txtprecio_venta.Enabled = true;

                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    string consulta = "SELECT \r\n    PV.IdProducto,\r\n    PV.Nombre,\r\n    UM.Nombre as Medida\r\nFROM ProductoVenta PV\r\nINNER JOIN ProductoTipo PT\r\n    ON PV.IdProductoTipo = PT.IdProductoTipo\r\nINNER JOIN UnidadMedida UM\r\n    ON PV.IdUnidadMedida = UM.IdUnidadMedida\r\nWHERE PT.Ingrediente = 1;";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    ingredientesconsulta.DataSource = dt;

                    ingredientesconsulta.Columns["IdProducto"].HeaderText = "ID";
                    ingredientesconsulta.Columns["Nombre"].HeaderText = "Nombre";
                    ingredientesconsulta.Columns["Medida"].HeaderText = "Medida";

                    recetaingredientes.Columns.Clear();

                    recetaingredientes.Columns.Add("ID", "ID");
                    recetaingredientes.Columns.Add("Ingrediente", "Ingrediente");
                    recetaingredientes.Columns.Add("Medida", "Medida");
                    recetaingredientes.Columns.Add("Cantidad", "Cantidad");
                }
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            tipoproductocmbx.Focus();
        }

        private void recargarbtn_Click(object sender, EventArgs e)
        {
            ConsProductos_Load(sender, e);
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            //Pal futuro
        }

        private int ObtenerIdUnidadMedida(SqlConnection conexion, string nombreUM)
        {
            string query = "SELECT IdUnidadMedida FROM UnidadMedida WHERE Nombre = @Nombre";

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombreUM);
                object result = cmd.ExecuteScalar();

                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            Regex numerosRegex = new Regex(@"^\d+([.,]\d+)?$");

            if (ingrediente == 1)
            {
                if (string.IsNullOrWhiteSpace(txtcodigo_barras.Text) ||
                    string.IsNullOrWhiteSpace(txtnombre_prod.Text) ||
                    ITBIS.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(idcategoriatxt.Text) ||
                    unidadmedida.SelectedValue == null)
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios para ingredientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!numerosRegex.IsMatch(txtprecio_compra.Text))
                {
                    MessageBox.Show("El precio de compra solo admite números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtcodigo_barras.Text) ||
                    string.IsNullOrWhiteSpace(txtnombre_prod.Text) ||
                    ITBIS.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(idcategoriatxt.Text) ||
                    unidadmedida.SelectedValue == null)
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!numerosRegex.IsMatch(txtprecio_compra.Text) ||
                    !numerosRegex.IsMatch(txtprecio_venta.Text))
                {
                    MessageBox.Show("Los precios solo admiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(CodigoProductoActual))
                    {

                        decimal valorItbis;

                        if (ITBIS.SelectedIndex == 3)
                        {
                            valorItbis = 0;
                        }
                        else
                        {
                            valorItbis = Convert.ToDecimal(ITBIS.SelectedItem.ToString());
                        }

                        string queryInsertar = @"
                        INSERT INTO ProductoVenta
                        (Nombre, IdCategoria, IdProductoTipo, Activo, PrecioCompra, PrecioVenta, Itbis, CodigoBarra, IdUnidadMedida, Existencia)
                        OUTPUT INSERTED.IdProducto
                        VALUES (@Nombre, @IdCategoria, @IdProductoTipo, @Activo, @PrecioCompra, @PrecioVenta, @Itbis, @CodigoBarra, @IdUnidadMedida, @Existencia)";

                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@Nombre", txtnombre_prod.Text);
                            insertarCommand.Parameters.AddWithValue("@IdCategoria", Convert.ToInt32(idcategoriatxt.Text));
                            insertarCommand.Parameters.AddWithValue("@IdProductoTipo", Convert.ToInt32(tipoproductocmbx.SelectedValue));
                            insertarCommand.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);
                            insertarCommand.Parameters.AddWithValue("@PrecioCompra", Convert.ToDecimal(txtprecio_compra.Text));
                            insertarCommand.Parameters.AddWithValue("@CodigoBarra", txtcodigo_barras.Text);
                            insertarCommand.Parameters.AddWithValue("@IdUnidadMedida", Convert.ToInt32(unidadmedida.SelectedValue));
                            insertarCommand.Parameters.AddWithValue("@Existencia", 0);
                            insertarCommand.Parameters.AddWithValue("@Itbis", valorItbis);

                            insertarCommand.Parameters.AddWithValue("@PrecioVenta",
                                string.IsNullOrWhiteSpace(txtprecio_venta.Text)
                                ? (object)DBNull.Value
                                : Convert.ToDecimal(txtprecio_venta.Text));

                            int nuevoIdProducto = (int)insertarCommand.ExecuteScalar();

                            foreach (DataGridViewRow fila in recetaingredientes.Rows)
                            {
                                if (fila.IsNewRow) continue;

                                int idIngrediente = Convert.ToInt32(fila.Cells[0].Value);
                                string medidaTexto = fila.Cells[2].Value.ToString();
                                decimal cantidad = Convert.ToDecimal(fila.Cells[3].Value);

                                int idUnidadMedida = ObtenerIdUnidadMedida(conexion, medidaTexto);

                                string queryReceta = @"
                                INSERT INTO Receta (IdProducto, IdIngrediente, IdUnidadMedida, Cantidad, Activo)
                                VALUES (@IdProducto, @IdIngrediente, @IdUnidadMedida, @Cantidad, 1)";

                                using (SqlCommand cmdReceta = new SqlCommand(queryReceta, conexion))
                                {
                                    cmdReceta.Parameters.AddWithValue("@IdProducto", nuevoIdProducto);
                                    cmdReceta.Parameters.AddWithValue("@IdIngrediente", idIngrediente);
                                    cmdReceta.Parameters.AddWithValue("@IdUnidadMedida", idUnidadMedida);
                                    cmdReceta.Parameters.AddWithValue("@Cantidad", cantidad);

                                    cmdReceta.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Producto registrado con éxito.");

                            limpiarbtn_Click(sender, e);
                            ConsProductos_Load(sender, e);
                        }
                    }
                    else
                    {
                        string queryActualizar = @"
                        UPDATE ProductoVenta SET
                            Nombre = @Nombre,
                            IdCategoria = @IdCategoria,
                            IdProductoTipo = @IdProductoTipo,
                            Activo = @Activo,
                            PrecioCompra = @PrecioCompra,
                            PrecioVenta = @PrecioVenta,
                            Itbis = @Itbis,
                            CodigoBarra = @CodigoBarra,
                            IdUnidadMedida = @IdUnidadMedida
                        WHERE IdProducto = @IdProducto";

                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@IdProducto", idProducto);
                            actualizarCommand.Parameters.AddWithValue("@Nombre", txtnombre_prod.Text);
                            actualizarCommand.Parameters.AddWithValue("@IdCategoria", Convert.ToInt32(idcategoriatxt.Text));
                            actualizarCommand.Parameters.AddWithValue("@IdProductoTipo", Convert.ToInt32(tipoproductocmbx.SelectedValue));
                            actualizarCommand.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);
                            actualizarCommand.Parameters.AddWithValue("@PrecioCompra", Convert.ToDecimal(txtprecio_compra.Text));
                            actualizarCommand.Parameters.AddWithValue("@PrecioVenta", 0);
                            actualizarCommand.Parameters.AddWithValue("@Itbis", Convert.ToDecimal(ITBIS.SelectedItem.ToString()));
                            actualizarCommand.Parameters.AddWithValue("@CodigoBarra", txtcodigo_barras.Text);
                            actualizarCommand.Parameters.AddWithValue("@IdUnidadMedida", Convert.ToInt32(unidadmedida.SelectedValue));

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Producto actualizado con éxito.");
                                limpiarbtn_Click(sender, e);
                                ConsProductos_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar el producto.");
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
            imagenproducto.Image = Proyecto_restaurante.Properties.Resources.paisaje;
            categoriaconsultatxt.Text = "";

            txtcodigo_barras.Text = "";
            txtnombre_prod.Text = "";
            txtprecio_compra.Text = "";
            codigobarrarandombtn.Text = "";
            idcategoriatxt.Text = "";

            tipoproductocmbx.SelectedIndex = -1;
            ITBIS.SelectedIndex = -1;
            unidadmedida.SelectedIndex = -1;

            estadochk.Checked = true;

            CodigoProductoActual = string.Empty;
            idProducto = 0;
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

        private void codigobarrarandombtn_Click(object sender, EventArgs e)
        {
            string codigoBarras = CodBarraRandom();

            txtcodigo_barras.Text = codigoBarras;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ITBIS.Items.Clear();
            ConsProductos_Load(sender, e);
        }

        private void txtnombre_prod_TextChanged(object sender, EventArgs e)
        {
            int posicion = txtnombre_prod.SelectionStart;

            txtnombre_prod.Text = txtnombre_prod.Text.ToUpper();

            txtnombre_prod.SelectionStart = posicion;
        }

        private void seleccionimagenbtn_Click(object sender, EventArgs e)
        {
            buscarcatedt = 0;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Seleccionar imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string codigoProducto = ultimoID.Text;
                    string destinoCarpeta = @"C:\SistemaArchivos\Productos\";
                    string extension = Path.GetExtension(openFileDialog.FileName);
                    string nuevaRuta = Path.Combine(destinoCarpeta, codigoProducto + extension);

                    try
                    {
                        imagenprod.Image = null;

                        if (File.Exists(nuevaRuta))
                        {
                            string tempFileName = Path.Combine(destinoCarpeta, Path.GetRandomFileName());
                            File.Move(nuevaRuta, tempFileName);

                            File.Delete(tempFileName);
                        }

                        File.Copy(openFileDialog.FileName, nuevaRuta, true);

                        imagenprod.Image = Image.FromFile(nuevaRuta);

                        MessageBox.Show("Imagen asociada al producto con éxito.");
                        txtcodigo_barras.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al copiar la imagen: " + ex.Message);
                    }
                }
            }
        }

        public int buscarcatedt = 1;

        private void buscarcateg_Click(object sender, EventArgs e)
        {

            if (buscarcatedt == 1)
            {
                string conexionString = ConexionBD.ConexionSQL();
                string categoria = "select IdCategoria, Nombre from CategoriaProducto where Activo = 1";

                SqlDataAdapter adaptador = new SqlDataAdapter(categoria, conexionString);

                DataTable dt = new DataTable();

                adaptador.Fill(dt);

                categoriaconsulta.DataSource = dt;

                categoriaconsulta.Columns["IdCategoria"].HeaderText = "ID";
                categoriaconsulta.Columns["Nombre"].HeaderText = "Nombre";

                buscarcateg.Image = Proyecto_restaurante.Properties.Resources.cancelar1;
                categoriapanel.Visible = true;
                categoriapanel.BringToFront();
                categoriapanel.Location = new Point(432, 112);
                imagenpanel.Visible = false;
                buscarcatedt = 0;
            }
            else
            {
                buscarcateg.Image = Proyecto_restaurante.Properties.Resources.busqueda1;
                categoriapanel.Visible = false;
                imagenpanel.BringToFront();
                categoriapanel.Location = new Point(227, 245);
                imagenpanel.Visible = true;
                buscarcatedt = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            idcategoriatxt.Text = idconsultatxt.Text;
            categoriatxt.Text = categoriaconsultatxt.Text;
            buscarcateg_Click(sender, e);
        }

        private void filtrotodos_CheckedChanged(object sender, EventArgs e)
        {
            if (filtrotodos.Checked == true)
            {
                filtroingredientes.Checked = false;
                filtroplatos.Checked = false;
            }
        }

        private void filtroplatos_CheckedChanged(object sender, EventArgs e)
        {
            if (filtroplatos.Checked == true)
            {
                filtrotodos.Checked = false;
                filtroingredientes.Checked = false;
            }
        }

        private void filtroingredientes_CheckedChanged(object sender, EventArgs e)
        {
            if( filtroingredientes.Checked == true)
            {
                filtrotodos.Checked = false;
                filtroplatos.Checked = false;
            }
        }

        private void categoriaconsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idconsultatxt.Text = categoriaconsulta.SelectedCells[0].Value.ToString();
            categoriaconsultatxt.Text = categoriaconsulta.SelectedCells[1].Value.ToString();
        }

        private void ingredientesconsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idprodreceta.Text = ingredientesconsulta.SelectedCells[0].Value.ToString();
            nombreprodreceta.Text = ingredientesconsulta.SelectedCells[1].Value.ToString();
            unimedidareceta.Text = ingredientesconsulta.SelectedCells[2].Value.ToString();
        }

        private void agregarbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idprodreceta.Text) ||
            string.IsNullOrWhiteSpace(nombreprodreceta.Text))
            {
                MessageBox.Show("Seleccione el ingrediente para agregar.");
                return;
            }

            string id = idprodreceta.Text.Trim();
            string ingrediente = nombreprodreceta.Text.Trim();
            string medida = unimedidareceta.Text.Trim();
            decimal cantidad = numCantidad.Value;

            recetaingredientes.Rows.Add(id, ingrediente, medida, cantidad);

            idprodreceta.Clear();
            nombreprodreceta.Clear();
            unimedidareceta.Clear();
            numCantidad.Value = 1;
        }

        private void numCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                agregarbtn_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
