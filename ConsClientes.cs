using PdfSharp.Pdf.Filters;
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
    public partial class ConsClientes : Form
    {
        public ConsClientes()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        public int ClienteID;
        public int PersonaID;

        private System.Windows.Forms.ToolTip toolTip1;

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(recargarbtn, "Recargar");
            toolTip1.SetToolTip(filtrochk, "Estado");
            toolTip1.SetToolTip(eliminarbtn, "Limpiar filtros");

            string conexionString = ConexionBD.ConexionSQL();

            string consultaId = "SELECT ISNULL(MAX(IdCliente), 0) + 1 FROM Cliente";

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(consultaId, con))
                {
                    idclientetxt.Text = cmd.ExecuteScalar()?.ToString() ?? "1";
                }
            }

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();

                string consultaTipoDoc = "SELECT IdTipoDocumento, Nombre FROM TipoDocumento";

                SqlDataAdapter da = new SqlDataAdapter(consultaTipoDoc, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                tipodoccmbx.DataSource = null;
                tipodoccmbx.DataSource = dt;
                tipodoccmbx.DisplayMember = "Nombre";
                tipodoccmbx.ValueMember = "IdTipoDocumento";

                if (dt.Rows.Count > 0)
                    tipodoccmbx.SelectedIndex = 0;
            }

            try
            {
                string consultaCliente = @"
                SELECT 
                    e.IdCliente,
                    p.NombreCompleto,
                    pd.Numero AS Cedula
                FROM Cliente e
                LEFT JOIN Persona p ON e.IdPersona = p.IdPersona
                LEFT JOIN PersonaDocumento pd ON p.IdPersona = pd.IdPersona
                WHERE e.Activo = 1 AND p.Activo = 1 and IdCliente > 1;";

                using (SqlDataAdapter adaptador = new SqlDataAdapter(consultaCliente, conexionString))
                {
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    tabladatos.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los datos: {ex.Message}");
            }

            //if (filtrochk.Checked == true)
            //{
            //    string consulta = "select id, nombre_cliente, apellido_cliente, identificacion, telefono from cliente where estado = 1";

            //    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            //    DataTable dt = new DataTable();

            //    adaptador.Fill(dt);

            //    tabladatos.DataSource = dt;
            //}
            //else
            //{
            //    string consulta = "select id, nombre_cliente, apellido_cliente, identificacion, telefono from cliente where estado = 0";
            //    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);
            //    DataTable dt = new DataTable();
            //    adaptador.Fill(dt);
            //    tabladatos.DataSource = dt;
            //}
        }

        //private void FiltroDatosBusqueda(string busqueda)
        //{
        //    string conexionString = ConexionBD.ConexionSQL();

        //    using (SqlConnection conectar = new SqlConnection(conexionString))
        //    {
        //        if (filtrochk.Checked == true)
        //        {
        //            try
        //            {
        //                conectar.Open();

        //                string query = @"
        //                SELECT id, nombre_cliente, apellido_cliente, identificacion, telefono FROM cliente
        //                WHERE CAST(id AS VARCHAR) LIKE @buscar OR
        //                nombre_cliente LIKE @buscar OR
        //                apellido_cliente LIKE @buscar and estado = 1";

        //                using (SqlCommand comando = new SqlCommand(query, conectar))
        //                {
        //                    comando.Parameters.AddWithValue("@buscar", "%" + busqueda + "%");

        //                    SqlDataAdapter da = new SqlDataAdapter(comando);
        //                    DataTable dt = new DataTable();
        //                    da.Fill(dt);

        //                    tabladatos.DataSource = dt;
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"Error: {ex.Message}");
        //            }
        //        }
        //        else if (filtrochk.Checked == false)
        //        {
        //            try
        //            {
        //                conectar.Open();
        //                string query = @"
        //                SELECT id, nombre_cliente, apellido_cliente, identificacion, telefono FROM cliente
        //                WHERE CAST(id AS VARCHAR) LIKE @buscar OR
        //                nombre_cliente LIKE @buscar OR
        //                apellido_cliente LIKE @buscar and estado = 0";
        //                using (SqlCommand comando = new SqlCommand(query, conectar))
        //                {
        //                    comando.Parameters.AddWithValue("@buscar", "%" + busqueda + "%");
        //                    SqlDataAdapter da = new SqlDataAdapter(comando);
        //                    DataTable dt = new DataTable();
        //                    da.Fill(dt);
        //                    tabladatos.DataSource = dt;
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"Error: {ex.Message}");
        //            }
        //        }
        //    }
        //}

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            txtbuscador.Text = "(ID, Nombre, Apellido)";
            txtbuscador.ForeColor = Color.Gray;
            ConsultaClientes_Load(sender, e);
        }

        private void txtbuscador_Enter(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "(ID, Nombre, Apellido)")
            {
                txtbuscador.Text = "";
                txtbuscador.ForeColor = Color.Black;
            }
        }

        private void txtbuscador_Leave(object sender, EventArgs e)
        {
            if (txtbuscador.Text == "")
            {
                txtbuscador.Text = "(ID, Nombre, Apellido)";
                txtbuscador.ForeColor = Color.Gray;
                ConsultaClientes_Load(sender, e);
            }
        }

        private void txtbuscador_TextChanged(object sender, EventArgs e)
        {
            //FiltroDatosBusqueda(txtbuscador.Text);
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            //IDModificar = "";
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            Regex letrasRegex = new Regex(@"^[a-zA-Z\s]+$");
            Regex numerosRegex = new Regex(@"^[\d-]+$");

            if (string.IsNullOrWhiteSpace(txtnombre.Text) || string.IsNullOrWhiteSpace(txtapellido.Text) || string.IsNullOrWhiteSpace(emailtxt.Text))
            {
                MessageBox.Show("No debe dejar campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!letrasRegex.IsMatch(txtnombre.Text))
            {
                MessageBox.Show("El nombre solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!letrasRegex.IsMatch(txtapellido.Text))
            {
                MessageBox.Show("El apellido solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                SqlTransaction trans = conexion.BeginTransaction();

                try
                {
                    if (ClienteID == 0)
                    {
                        string nuevaPersona = @"
                        INSERT INTO Persona (Nombre, Apellido, Email, Activo, CreadoEn)
                        VALUES (@Nombre, @Apellido, @Email, @Activo, GETDATE());
                        SELECT SCOPE_IDENTITY();";

                        using (SqlCommand insertarPersona = new SqlCommand(nuevaPersona, conexion, trans))
                        {
                            insertarPersona.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                            insertarPersona.Parameters.AddWithValue("@Apellido", txtapellido.Text);
                            insertarPersona.Parameters.AddWithValue("@Email", emailtxt.Text);
                            insertarPersona.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);

                            PersonaID = Convert.ToInt32(insertarPersona.ExecuteScalar());
                        }

                        string nuevoCliente = @"
                        INSERT INTO Cliente (IdPersona, IdTipoDoc)
                        VALUES (@IdPersona, @IdTipoDoc)";

                        using (SqlCommand insertarCliente = new SqlCommand(nuevoCliente, conexion, trans))
                        {
                            insertarCliente.Parameters.AddWithValue("@IdPersona", PersonaID);
                            insertarCliente.Parameters.AddWithValue("@IdTipoDoc", Convert.ToInt32(tipodoccmbx.SelectedValue));

                            insertarCliente.ExecuteNonQuery();
                        }

                        foreach (DataGridViewRow fila in telefonocliente.Rows)
                        {
                            if (fila.IsNewRow) continue;

                            string queryReceta = @"
                                INSERT INTO Receta (IdProducto, IdIngrediente, IdUnidadMedida, Cantidad, Activo)
                                VALUES (@IdProducto, @IdIngrediente, @IdUnidadMedida, @Cantidad, 1)";

                            using (SqlCommand cmdReceta = new SqlCommand(queryReceta, conexion))
                            {
                                //cmdReceta.Parameters.AddWithValue("@IdProducto", nuevoIdProducto);
                                //cmdReceta.Parameters.AddWithValue("@IdIngrediente", idIngrediente);
                                //cmdReceta.Parameters.AddWithValue("@IdUnidadMedida", idUnidadMedida);
                                //cmdReceta.Parameters.AddWithValue("@Cantidad", cantidad);

                                cmdReceta.ExecuteNonQuery();
                            }
                        }


                        trans.Commit();
                        MessageBox.Show("Cliente registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RestablecerFormulario();
                        ConsultaClientes_Load(sender, e);
                    }
                    else
                    {
                        string actualizarPersona = @"
                        UPDATE Persona 
                        SET Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Activo = @Activo
                        WHERE IdPersona = @IdPersona";

                        using (SqlCommand actualizarCommand = new SqlCommand(actualizarPersona, conexion, trans))
                        {
                            actualizarCommand.Parameters.AddWithValue("@IdPersona", PersonaID);
                            actualizarCommand.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                            actualizarCommand.Parameters.AddWithValue("@Apellido", txtapellido.Text);
                            actualizarCommand.Parameters.AddWithValue("@Email", emailtxt.Text);
                            actualizarCommand.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);
                            actualizarCommand.ExecuteNonQuery();
                        }

                        string actualizarCliente = @"
                        UPDATE Cliente
                        SET IdTipoDoc = @IdTipoDoc
                        WHERE IdCliente = @IdCliente";

                        using (SqlCommand actualizarClienteCmd = new SqlCommand(actualizarCliente, conexion, trans))
                        {
                            actualizarClienteCmd.Parameters.AddWithValue("@IdCliente", ClienteID);
                            actualizarClienteCmd.Parameters.AddWithValue("@IdTipoDoc", Convert.ToInt32(tipodoccmbx.SelectedValue));
                            actualizarClienteCmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                        MessageBox.Show("Cliente actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RestablecerFormulario();
                        ConsultaClientes_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RestablecerFormulario()
        {
            imagencliente.Image = Proyecto_restaurante.Properties.Resources.perfilcliente;
            txtnombre.Text = "";
            identtxt.Text = "";

            txtapellido.Text = "";

            ClienteID = 0;
            PersonaID = 0;

            estadochk.Checked = true;
            txtnombre.Focus();
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            RestablecerFormulario();
            ConsultaClientes_Load(sender, e);
        }


        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            string posNum = numerotxt.Text;
            posNum = posNum.Replace("-", "");

            if (posNum.Length > 10)
            {
                posNum = posNum.Substring(0, 10);
            }

            if (posNum.Length > 3)
            {
                posNum = posNum.Insert(3, "-");
            }

            if (posNum.Length > 7)
            {
                posNum = posNum.Insert(7, "-");
            }

            numerotxt.Text = posNum;
            numerotxt.SelectionStart = numerotxt.Text.Length;
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtapellido.Focus();
                e.Handled = true;
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tipodoccmbx.Focus();
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaClientes_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            RestablecerFormulario();
        }

        private void seleccionimagenbtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Seleccionar imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string codigoCliente = idclientetxt.Text;
                    string destinoCarpeta = @"C:\SistemaArchivos\Clientes";
                    string extension = Path.GetExtension(openFileDialog.FileName);
                    string nuevaRuta = Path.Combine(destinoCarpeta, codigoCliente + extension);

                    try
                    {
                        imagencliente.Image = null;

                        if (File.Exists(nuevaRuta))
                        {
                            string tempFileName = Path.Combine(destinoCarpeta, Path.GetRandomFileName());
                            File.Move(nuevaRuta, tempFileName);

                            File.Delete(tempFileName);
                        }

                        File.Copy(openFileDialog.FileName, nuevaRuta, true);

                        imagencliente.Image = Image.FromFile(nuevaRuta);

                        MessageBox.Show("Imagen asociada al cliente con éxito.");
                        identtxt.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al copiar la imagen: " + ex.Message);
                    }
                }
            }
        }

        private int idCliente;

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = tabladatos.Rows[e.RowIndex];
                int idCliente = Convert.ToInt32(fila.Cells["IdCliente"].Value);

                string rutaImagenes = @"C:\SistemaArchivos\Clientes\";
                string rutaImagenCliente = Path.Combine(rutaImagenes, idCliente + ".jpg");

                if (File.Exists(rutaImagenCliente))
                {
                    clienteimg.Image = Image.FromFile(rutaImagenCliente);
                }
                else
                {
                    clienteimg.Image = Proyecto_restaurante.Properties.Resources.perfilcliente;
                }
            }
        }

        public string IDModificar = "";

        private void Editar_Click(object sender, EventArgs e)
        {
            if (tabladatos.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(tabladatos.SelectedRows[0].Cells["id"].Value);

                IDModificar = idCliente.ToString();

                //CargarDatosCliente(idCliente);

                tabControl1.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void filtro_CheckedChanged(object sender, EventArgs e)
        {
            if (filtrochk.Checked)
            {
                ConsultaClientes_Load(sender, e);
                filtrochk.Image = Proyecto_restaurante.Properties.Resources.sicheck;
            }
            else
            {
                ConsultaClientes_Load(sender, e);
                filtrochk.Image = Proyecto_restaurante.Properties.Resources.nocheck;
            }
        }

        private void estadochk_CheckedChanged(object sender, EventArgs e)
        {
            if (estadochk.Checked == true)
            {
                estadochk.Text = "Activo";
                estadochk.ForeColor = Color.Lime;
            }
            else if (estadochk.Checked == false)
            {

                estadochk.Text = "Inactivo";
                estadochk.ForeColor = Color.Red;
            }
        }

        private void identtxt_TextChanged(object sender, EventArgs e)
        {
            string posicion = identtxt.Text; posicion = posicion.Replace("-", "");

            if (posicion.Length > 11)
            {
                posicion = posicion.Substring(0, 11);
            }

            if (posicion.Length > 3)
            {
                posicion = posicion.Insert(3, "-");
            }
            if (posicion.Length > 11)
            {
                posicion = posicion.Insert(11, "-");
            }

            identtxt.Text = posicion; identtxt.SelectionStart = identtxt.Text.Length;
        }

        private void tipodoccmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            identtxt_TextChanged(null, null);
        }
    }
}
