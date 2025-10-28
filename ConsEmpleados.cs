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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto_restaurante
{
    public partial class ConsEmpleados : Form
    {
        public ConsEmpleados()
        {
            InitializeComponent();
        }
        private int EmpleadoID;

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
                        string queryInsertar = "INSERT INTO Empleado (IdDepartamento, nombre, Activo) VALUES (@IdDepartamento, @nombre, @activo)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@IdDepartamento", iddepapuestotxt.Text);
                            insertarCommand.Parameters.AddWithValue("@nombre", depapuestotxt.Text);
                            insertarCommand.Parameters.AddWithValue("@activo", estadopuesto.Checked ? 1 : 0);

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

                        string queryActualizar = "UPDATE puesto SET IDDepa = @IDDepa, Nombre = @Nombre, Activo= @activo where IdPuesto= @IDPuesto";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@IDPuesto", PuestoID.ToString());
                            actualizarCommand.Parameters.AddWithValue("@IDDepa", iddepapuestotxt.Text);
                            actualizarCommand.Parameters.AddWithValue("@Nombre", depatxt.Text);
                            actualizarCommand.Parameters.AddWithValue("@activo", estadodepa.Checked ? 1 : 0);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Departamento actualizado con éxito.");
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

        private void buscarpuesto_Click(object sender, EventArgs e)
        {

        }
    }
}
