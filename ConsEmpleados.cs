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
        }
        public int PersonaID = 0;
        private int EmpleadoID = 0;

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtapellido.Text) || string.IsNullOrEmpty(txtcedula.Text) || string.IsNullOrEmpty(txtsueldo.Text) || string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(idpuestotxt.Text))
            {
                MessageBox.Show("Error: No deje campos vacios.");
                return;
            }

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    if (string.IsNullOrEmpty(EmpleadoID.ToString()))
                    {
                        string nuevaPersona = "INSERT INTO Persona (Nombre, Apellido, NombreCompleto, Email, Activo, CreadoEn) VALUES (@Nombre, @Apellido, @NombreCompleto, @Email, @Activo, GETDATE())";
                        using (SqlCommand insertarCommand = new SqlCommand(nuevaPersona, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                            insertarCommand.Parameters.AddWithValue("@Apellido", txtapellido.Text);
                            insertarCommand.Parameters.AddWithValue("@NombreCompleto", txtnombre.Text + "" + txtapellido);
                            insertarCommand.Parameters.AddWithValue("@Email", txtapellido.Text);
                            insertarCommand.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Puesto registrado con éxito.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los datos.");
                            }
                        }

                        string nuevoEmpleado = "INSERT INTO Empleado (IdPersona, IdPuesto, FechaIngreso, Activo, Sueldo, TipoSueldo) VALUES (@IdPersona, @IdPuesto, @FechaIngreso, @Activo, @Sueldo, @TipoSueldo)";
                        using (SqlCommand insertarCommand = new SqlCommand(nuevoEmpleado, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@IdPuesto", idpuestotxt.Text);
                            insertarCommand.Parameters.AddWithValue("@Sueldo", Convert.ToDecimal(txtsueldo.Text));
                            insertarCommand.Parameters.AddWithValue("@FechaIngreso", fechaingreso.Value.ToString());
                            insertarCommand.Parameters.AddWithValue("@TipoSueldo", Convert.ToInt32(tiposueldocmbx.SelectedValue));
                            insertarCommand.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Puesto registrado con éxito.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los datos.");
                            }
                        }
                    }
                    else
                    {
                        string actualizarPersona = "UPDATE Persona SET Nombre = @Nombre, Apellido = @Apellido, NombreCompleto= @NombreCompleto, Email= @Email, Activo= @Activo where IdPersona= @IdPersona";
                        using (SqlCommand actualizarCommand = new SqlCommand(actualizarPersona, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@IdPersona", PersonaID.ToString());
                            actualizarCommand.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                            actualizarCommand.Parameters.AddWithValue("@Apellido", txtapellido.Text);
                            actualizarCommand.Parameters.AddWithValue("@NombreCompleto", txtnombre.Text + "" + txtapellido);
                            actualizarCommand.Parameters.AddWithValue("@Email", txtapellido.Text);
                            actualizarCommand.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                //MessageBox.Show("Departamento actualizado con éxito.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar los datos.");
                            }
                        }

                        string actualizarEmpleado = "UPDATE Empleado SET IdPuesto = @IdPuesto, Sueldo = @Sueldo, FechaIngreso= @FechaIngreso, TipoSueldo= @TipoSueldo, Activo= @Activo where IdPuesto= @IDPuesto";
                        using (SqlCommand actualizarCommand = new SqlCommand(actualizarEmpleado, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@IdEmpleado", EmpleadoID.ToString());
                            actualizarCommand.Parameters.AddWithValue("@IdPuesto", idpuestotxt.Text);
                            actualizarCommand.Parameters.AddWithValue("@Sueldo", Convert.ToDecimal(txtsueldo.Text));
                            actualizarCommand.Parameters.AddWithValue("@FechaIngreso", fechaingreso.Value.ToString());
                            actualizarCommand.Parameters.AddWithValue("@TipoSueldo", Convert.ToInt32(tiposueldocmbx.SelectedValue));
                            actualizarCommand.Parameters.AddWithValue("@Activo", estadochk.Checked ? 1 : 0);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Empleado actualizado con éxito.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar los datos.");
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
            string consulta = "SELECT TOP 1 IdPersona FROM Persona ORDER BY IdPersona DESC";

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, con))
                {
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        PersonaID = Convert.ToInt32(resultado) + 1;
                    }
                    else
                    {
                        //MessageBox.Show("No se encontraron pedidos.");
                        PersonaID = 0;
                    }
                }
            }

            string Empleado = "SELECT e.IdEmpleado, p.NombreCompleto,   pd.Numero AS Cedula FROM Empleado e INNER JOIN Persona p ON e.IdPersona = p.IdPersona INNER JOIN PersonaDocumento pd ON p.IdPersona = pd.IdPersona WHERE e.Activo = 1 AND p.Activo = 1 AND pd.EsPrincipal = 1;";

            SqlDataAdapter adaptador = new SqlDataAdapter(Empleado, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tabladatos.DataSource = dt;
        }

        private void puestoconsulta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idpuestotxt.Text = tabladatos.SelectedCells[0].Value.ToString();
            puestotxt.Text = tabladatos.SelectedCells[1].Value.ToString();
        }
    }
}
