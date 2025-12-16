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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto_restaurante
{
    public partial class ConsEmpleados : Form
    {
        public ConsEmpleados()
        {
            InitializeComponent();

            toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(recargarbtn, "Recargar");
            toolTip1.SetToolTip(filtro, "Estado");
            toolTip1.SetToolTip(eliminarbtn, "Limpiar filtros");
        }

        public int PersonaID;
        private int EmpleadoID;

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtapellido.Text) ||
            string.IsNullOrEmpty(txtcedula.Text) || string.IsNullOrEmpty(txtsueldo.Text) ||
            string.IsNullOrEmpty(idpuestotxt.Text))
            {
                MessageBox.Show("Error: No deje campos vacíos.");
                return;
            }

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                SqlTransaction trans = conexion.BeginTransaction();

                try
                {
                    if (EmpleadoID == 0)
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

                        string nuevoEmpleado = @"
                        INSERT INTO Empleado (IdPersona, IdPuesto, FechaIngreso, Activo, Sueldo, TipoSueldo, IdRolempleado)
                        VALUES (@IdPersona, @IdPuesto, @FechaIngreso, @Activo, @Sueldo, @TipoSueldo, @IdRol)";

                        using (SqlCommand insertarEmpleado = new SqlCommand(nuevoEmpleado, conexion, trans))
                        {
                            insertarEmpleado.Parameters.AddWithValue("@IdPersona", PersonaID);
                            insertarEmpleado.Parameters.AddWithValue("@IdPuesto", Convert.ToInt32(idpuestotxt.Text));
                            insertarEmpleado.Parameters.AddWithValue("@Sueldo", Convert.ToDecimal(txtsueldo.Text));
                            insertarEmpleado.Parameters.AddWithValue("@FechaIngreso", fechaingreso.Value);
                            insertarEmpleado.Parameters.AddWithValue("@TipoSueldo", Convert.ToInt32(tiposueldocmbx.SelectedValue));
                            insertarEmpleado.Parameters.AddWithValue("@IdRol", Convert.ToInt32(rolcmbx.SelectedValue));
                            insertarEmpleado.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);

                            insertarEmpleado.ExecuteNonQuery();
                        }

                        trans.Commit();
                        MessageBox.Show("Empleado registrado con éxito.");
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

                        string actualizarEmpleado = @"
                        UPDATE Empleado 
                        SET IdPuesto = @IdPuesto, Sueldo = @Sueldo, FechaIngreso = @FechaIngreso, 
                            TipoSueldo = @TipoSueldo, Activo = @Activo, IdRolempleado = @IdRol 
                        WHERE IdEmpleado = @IdEmpleado";

                        using (SqlCommand actualizarCommand = new SqlCommand(actualizarEmpleado, conexion, trans))
                        {
                            actualizarCommand.Parameters.AddWithValue("@IdEmpleado", EmpleadoID);
                            actualizarCommand.Parameters.AddWithValue("@IdPuesto", Convert.ToInt32(idpuestotxt.Text));
                            actualizarCommand.Parameters.AddWithValue("@Sueldo", Convert.ToDecimal(txtsueldo.Text));
                            actualizarCommand.Parameters.AddWithValue("@FechaIngreso", fechaingreso.Value);
                            actualizarCommand.Parameters.AddWithValue("@TipoSueldo", Convert.ToInt32(tiposueldocmbx.SelectedValue));
                            actualizarCommand.Parameters.AddWithValue("@IdRol", Convert.ToInt32(rolcmbx.SelectedValue));
                            actualizarCommand.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);
                            actualizarCommand.ExecuteNonQuery();
                        }

                        trans.Commit();
                        MessageBox.Show("Empleado actualizado con éxito.");
                    }
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
        }

        public int Estadobuscarpuesto = 1;

        private void buscarpuesto_Click(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();
            string puesto = "select IdPuesto, Nombre from Puesto";

            SqlDataAdapter adaptador = new SqlDataAdapter(puesto, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            puestoconsulta.DataSource = dt;

            if (Estadobuscarpuesto == 1)
            {
                buscarpuesto.Image = Proyecto_restaurante.Properties.Resources.cancelar1;
                toolTip1.SetToolTip(buscarpuesto, "Cancelar búsqueda");
                puestopanel.Visible = true;

                Estadobuscarpuesto = 0;
            }
            else
            {
                buscarpuesto.Image = Proyecto_restaurante.Properties.Resources.busqueda1;
                toolTip1.SetToolTip(buscarpuesto, "Buscar departamento");
                puestopanel.Visible = false;

                Estadobuscarpuesto = 1;
            }
        }

        private void ConsEmpleados_Load(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();

            try
            {
                string consultaEmpleados = @"
                SELECT 
                    e.IdEmpleado,
                    p.NombreCompleto,
                    pd.Numero AS Cedula
                FROM Empleado e
                LEFT JOIN Persona p ON e.IdPersona = p.IdPersona
                LEFT JOIN PersonaDocumento pd ON p.IdPersona = pd.IdPersona
                WHERE e.Activo = 1 AND p.Activo = 1;";

                using (SqlDataAdapter adaptador = new SqlDataAdapter(consultaEmpleados, conexionString))
                {
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    tabladatos.DataSource = dt;
                }

                string consultaUltimoID = "SELECT ISNULL(MAX(IdEmpleado) + 1, 0) FROM Empleado";

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
                            ultimoID.Text = "?";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los datos: {ex.Message}");
            }
        }

        private void puestoconsulta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            puestoconsulta_CellClick(sender, e);
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            string posicion = txtcedula.Text;
            posicion = posicion.Replace("-", "");

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

            txtcedula.Text = posicion;
            txtcedula.SelectionStart = txtcedula.Text.Length;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            txtcedula.Focus();
            EmpleadoID = 0;
            PersonaID = 0;
        }

        private void puestoconsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idconsultatxt.Text = puestoconsulta.SelectedCells[0].Value.ToString();
            puestoconsultatxt.Text = puestoconsulta.SelectedCells[1].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            idpuestotxt.Text = idconsultatxt.Text;
            puestotxt.Text = puestoconsultatxt.Text;
            buscarpuesto_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            limpiarbtn_Click(sender, e);
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {

        }

        private void seleccionimagenbtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Seleccionar imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string idCliente = ultimoID.Text;
                    string destinoCarpeta = @"C:\SistemaArchivos\Empleados\";
                    string extension = Path.GetExtension(openFileDialog.FileName);
                    string nuevaRuta = Path.Combine(destinoCarpeta, idCliente + extension);

                    try
                    {
                        imagenempleado.Image = Proyecto_restaurante.Properties.Resources.perfilcliente;

                        if (File.Exists(nuevaRuta))
                        {
                            string tempFileName = Path.Combine(destinoCarpeta, Path.GetRandomFileName());
                            File.Move(nuevaRuta, tempFileName);

                            File.Delete(tempFileName);
                        }

                        File.Copy(openFileDialog.FileName, nuevaRuta, true);

                        imagenempleado.Image = Image.FromFile(nuevaRuta);

                        MessageBox.Show("Imagen asociada al producto con éxito.");
                        limpiarbtn.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al copiar la imagen: " + ex.Message);
                    }
                }
            }
        }

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = tabladatos.Rows[e.RowIndex];
                int idEmpleado = Convert.ToInt32(fila.Cells["IdEmpleado"].Value);

                string rutaImagenes = @"C:\SistemaArchivos\Empleados\";
                string rutaImagenCliente = Path.Combine(rutaImagenes, idEmpleado + ".jpg");

                if (File.Exists(rutaImagenCliente))
                {
                    empleadoimg.Image = Image.FromFile(rutaImagenCliente);
                }
                else
                {
                    empleadoimg.Image = Proyecto_restaurante.Properties.Resources.perfilcliente;
                }
            }
        }
    }
}
