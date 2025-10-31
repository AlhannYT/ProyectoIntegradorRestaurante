using PdfSharp.Pdf.Filters;
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
    public partial class MenuTipos : Form
    {
        public MenuTipos()
        {
            InitializeComponent();
        }

        string conexionString = ConexionBD.ConexionSQL();
        private string DepaID = "";
        private string PuestoID = "";
        private string TipoDocID = "";

        private void button4_Click(object sender, EventArgs e)
        {
            categpanel.Location = new Point(225, 12);
            textoinicial.Location = new Point(357, 875);
            categpanel.BringToFront();
            categpanel.Visible = true;

            //string consultaid = "SELECT TOP 1 IdCategoria FROM CategoriaProducto ORDER BY IdCategoria DESC";

            //using (SqlConnection con = new SqlConnection(conexionString))
            //{
            //    con.Open();
            //    using (SqlCommand cmd = new SqlCommand(consultaid, con))
            //    {
            //        object resultado = cmd.ExecuteScalar();

            //        if (resultado != null)
            //        {
            //            int nuevoId = Convert.ToInt32(resultado) + 1;
            //            idcateg.Text = nuevoId.ToString();
            //        }
            //        else
            //        {
            //            //MessageBox.Show("No se encontraron clientes.");
            //            idcateg.Text = "?";
            //        }
            //    }
            //}

            //if (categfiltrochk.Checked == true)
            //{
            //    string consulta = "select * from CategoriaProducto where Activo = 1";

            //    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            //    DataTable dt = new DataTable();

            //    adaptador.Fill(dt);

            //    categdt.DataSource = dt;
            //}
            //else
            //{
            //    string consulta = "select * from CategoriaProducto where Activo = 0";
            //    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);
            //    DataTable dt = new DataTable();
            //    adaptador.Fill(dt);
            //    categdt.DataSource = dt;
            //}
        }

        private void button8_Click(object sender, EventArgs e)
        {
            idenpanel.Location = new Point(225, 12);
            textoinicial.Location = new Point(357, 875);
            idenpanel.BringToFront();
            idenpanel.Visible = true;

            //string consultaid = "SELECT TOP 1 IdTipoDocumento FROM TipoDocumento ORDER BY IdTipoDocumento DESC";

            //using (SqlConnection con = new SqlConnection(conexionString))
            //{
            //    con.Open();
            //    using (SqlCommand cmd = new SqlCommand(consultaid, con))
            //    {
            //        object resultado = cmd.ExecuteScalar();

            //        if (resultado != null)
            //        {
            //            int nuevoId = Convert.ToInt32(resultado) + 1;
            //            iddocid.Text = nuevoId.ToString();
            //        }
            //        else
            //        {
            //            //MessageBox.Show("No se encontraron clientes.");
            //            iddocid.Text = "?";
            //        }
            //    }
            //}

            //if (categfiltrochk.Checked == true)
            //{
            //    string consulta = "select * from TipoDocumento where Activo = 1";

            //    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            //    DataTable dt = new DataTable();

            //    adaptador.Fill(dt);

            //    categdt.DataSource = dt;
            //}
            //else
            //{
            //    string consulta = "select * from TipoDocumento where Activo = 0";
            //    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);
            //    DataTable dt = new DataTable();
            //    adaptador.Fill(dt);
            //    identdt.DataSource = dt;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prodpanel.Location = new Point(225, 12);
            textoinicial.Location = new Point(357, 875);
            prodpanel.BringToFront();
            prodpanel.Visible = true;

            //string consultaid = "SELECT TOP 1 IdProductoTipo FROM ProductoTipo ORDER BY IdProductoTipo DESC";

            //using (SqlConnection con = new SqlConnection(conexionString))
            //{
            //    con.Open();
            //    using (SqlCommand cmd = new SqlCommand(consultaid, con))
            //    {
            //        object resultado = cmd.ExecuteScalar();

            //        if (resultado != null)
            //        {
            //            int nuevoId = Convert.ToInt32(resultado) + 1;
            //            idprod.Text = nuevoId.ToString();
            //        }
            //        else
            //        {
            //            //MessageBox.Show("No se encontraron clientes.");
            //            idprod.Text = "?";
            //        }
            //    }
            //}

            //if (categfiltrochk.Checked == true)
            //{
            //    string consulta = "select * from ProductoTipo where Activo = 1";

            //    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            //    DataTable dt = new DataTable();

            //    adaptador.Fill(dt);

            //    prodtidt.DataSource = dt;
            //}
            //else
            //{
            //    string consulta = "select * from ProductoTipo where Activo = 0";
            //    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);
            //    DataTable dt = new DataTable();
            //    adaptador.Fill(dt);
            //    prodtidt.DataSource = dt;
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            metodopanel.Location = new Point(225, 12);
            textoinicial.Location = new Point(357, 875);
            metodopanel.BringToFront();
            metodopanel.Visible = true;

            //string consultaid = "SELECT TOP 1 IdMetodoPago FROM MetodoPago ORDER BY IdMetodoPago DESC";

            //using (SqlConnection con = new SqlConnection(conexionString))
            //{
            //    con.Open();
            //    using (SqlCommand cmd = new SqlCommand(consultaid, con))
            //    {
            //        object resultado = cmd.ExecuteScalar();

            //        if (resultado != null)
            //        {
            //            int nuevoId = Convert.ToInt32(resultado) + 1;
            //            idmetpago.Text = nuevoId.ToString();
            //        }
            //        else
            //        {
            //            //MessageBox.Show("No se encontraron clientes.");
            //            idmetpago.Text = "?";
            //        }
            //    }
            //}

            //if (categfiltrochk.Checked == true)
            //{
            //    string consulta = "select * from MetodoPago where Activo = 1";

            //    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            //    DataTable dt = new DataTable();

            //    adaptador.Fill(dt);

            //    metododt.DataSource = dt;
            //}
            //else
            //{
            //    string consulta = "select * from MetodoPago where Activo = 0";
            //    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);
            //    DataTable dt = new DataTable();
            //    adaptador.Fill(dt);
            //    metododt.DataSource = dt;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            puestopanel.Location = new Point(225, 12);
            textoinicial.Location = new Point(357, 875);
            puestopanel.BringToFront();
            puestopanel.Visible = true;

            //string consultaid = "SELECT TOP 1 IdPuesto FROM Puesto ORDER BY IdPuesto DESC";

            //using (SqlConnection con = new SqlConnection(conexionString))
            //{
            //    con.Open();
            //    using (SqlCommand cmd = new SqlCommand(consultaid, con))
            //    {
            //        object resultado = cmd.ExecuteScalar();

            //        if (resultado != null)
            //        {
            //            int nuevoId = Convert.ToInt32(resultado) + 1;
            //            idpuesto.Text = nuevoId.ToString();
            //        }
            //        else
            //        {
            //            //MessageBox.Show("No se encontraron clientes.");
            //            idpuesto.Text = "?";
            //        }
            //    }
            //}

            //if (categfiltrochk.Checked == true)
            //{
            //    string consulta = "select * from Puesto where Activo = 1";

            //    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            //    DataTable dt = new DataTable();

            //    adaptador.Fill(dt);

            //    puestodt.DataSource = dt;
            //}
            //else
            //{
            //    string consulta = "select * from Puesto where Activo = 0";
            //    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);
            //    DataTable dt = new DataTable();
            //    adaptador.Fill(dt);
            //    puestodt.DataSource = dt;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            depapanel.Location = new Point(225, 12);
            textoinicial.Location = new Point(357, 875);
            depapanel.BringToFront();
            depapanel.Visible = true;

            string consultaid = "SELECT TOP 1 IdDepartamento FROM Departamento ORDER BY IdDepartamento DESC";

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(consultaid, con))
                {
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        int nuevoId = Convert.ToInt32(resultado) + 1;
                        iddepa.Text = nuevoId.ToString();
                    }
                    else
                    {
                        //MessageBox.Show("No se encontraron clientes.");
                        iddepa.Text = "?";
                    }
                }
            }

            if (categfiltrochk.Checked == true)
            {
                string consulta = "select * from Departamento where Activo = 1";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

                DataTable dt = new DataTable();

                adaptador.Fill(dt);

                departdt.DataSource = dt;
            }
            else
            {
                string consulta = "select * from Departamento where Activo = 0";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                departdt.DataSource = dt;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textoinicial.Location = new Point(396, 150);
            textoinicial.BringToFront();
            textoinicial.Visible = true;

            depapanel.Location = new Point(744, 428);
            depapanel.Visible = false;

            puestopanel.Location = new Point(225, 428);
            puestopanel.Visible = false;

            metodopanel.Location = new Point(225, 12);
            metodopanel.Visible = false;

            prodpanel.Location = new Point(1263, 12);
            prodpanel.Visible = false;

            idenpanel.Location = new Point(744, 12);
            idenpanel.Visible = false;

            categpanel.Location = new Point(1263, 428);
            categpanel.Visible = false;

            motivopanel.Location = new Point(744, 428);
            motivopanel.Visible = false;

            unidadpanel.Location = new Point(744, 428);
            unidadpanel.Visible = false;
        }

        private void metfiltrochk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metodotxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public int buscardepa = 1;

        private void button25_Click(object sender, EventArgs e)
        {
            if (buscardepa == 1)
            {
                btndepabuscar.Image = Proyecto_restaurante.Properties.Resources.cancelar1;
                toolTip1.SetToolTip(btndepabuscar, "Cancelar búsqueda");
                departdt.Location = new Point(13, 262);
                selectdepapuest.Location = new Point(363, 262);
                depapuestobuscar.Location = new Point(363, 332);
                puestodepafiltrochk.Location = new Point(363, 361);
                departdt.Visible = true;
                selectdepapuest.Visible = true;
                depapuestobuscar.Visible = true;
                puestodepafiltrochk.Visible = true;


                puestodt.Visible = false;
                selecpuest.Visible = false;
                puestobuscar.Visible = false;
                puestofiltrochk.Visible = false;

                buscardepa = 0;
            }
            else
            {
                btndepabuscar.Image = Proyecto_restaurante.Properties.Resources.busqueda1;
                toolTip1.SetToolTip(btndepabuscar, "Buscar departamento");
                puestodt.Location = new Point(13, 262);
                selecpuest.Location = new Point(363, 262);
                puestobuscar.Location = new Point(363, 332);
                puestofiltrochk.Location = new Point(363, 361);

                puestodt.Visible = true;
                selecpuest.Visible = true;
                puestobuscar.Visible = true;
                puestofiltrochk.Visible = true;

                departdt.Visible = false;
                selectdepapuest.Visible = false;
                depapuestobuscar.Visible = false;
                puestodepafiltrochk.Visible = false;

                buscardepa = 1;
            }
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            motivopanel.Location = new Point(225, 12);
            textoinicial.Location = new Point(357, 875);
            motivopanel.BringToFront();
            motivopanel.Visible = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            unidadpanel.Location = new Point(225, 12);
            textoinicial.Location = new Point(357, 875);
            unidadpanel.BringToFront();
            unidadpanel.Visible = true;
        }

        private void guardardepartamento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(depatxt.Text))
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

                    if (string.IsNullOrEmpty(DepaID.ToString()))
                    {
                        string queryInsertar = "INSERT INTO Departamento (Nombre, Activo) VALUES (@Nombre, @activo)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@Nombre", depatxt.Text);
                            insertarCommand.Parameters.AddWithValue("@Activo", estadodepa.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Departamento registrado con éxito.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los datos.");
                            }
                        }
                    }
                    else
                    {

                        string queryActualizar = "UPDATE departamento SET Nombre = @nuevoNombre, Activo= @activo where IdDepartamento= @IDDepa";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@IDDepa", DepaID);
                            actualizarCommand.Parameters.AddWithValue("@nuevoNombre", depatxt.Text);
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

        private void button15_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(puestotxt.Text) || string.IsNullOrEmpty(iddepapuestotxt.Text) || string.IsNullOrEmpty(depapuestotxt.Text))
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

                    if (string.IsNullOrEmpty(DepaID.ToString()))
                    {
                        string queryInsertar = "INSERT INTO Puesto (IdDepartamento, Nombre, Activo) VALUES (@IdDepartamento, @Nombre, @Activo)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@IdDepartamento", iddepapuestotxt.Text);
                            insertarCommand.Parameters.AddWithValue("@Nombre", depapuestotxt.Text);
                            insertarCommand.Parameters.AddWithValue("@Activo", estadopuesto.Checked ? 1 : 0);

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

                        string queryActualizar = "UPDATE Puesto SET IDDepa = @IDDepa, Nombre = @Nombre, Activo= @activo where IdPuesto= @IDPuesto";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@IDPuesto", PuestoID);
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

        private void button14_Click(object sender, EventArgs e)
        {
            PuestoID = "";
            puestotxt.Text = "";
            iddepapuestotxt.Text = "";
            depapuestotxt.Text = "";
            estadopuesto.Checked = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DepaID = "";
            depatxt.Text = "";
            estadodepa.Checked = true;
        }


        private void selecpuest_Click(object sender, EventArgs e)
        {
            //puestodt_CellContentDoubleClick(sender, e);
        }

        private void puestodt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            iddepapuestotxt.Text = puestodt.SelectedCells[0].Value.ToString();
            depapuestotxt.Text = puestodt.SelectedCells[1].Value.ToString();
        }

        private void puestodt_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void departdt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iddepapuestotxt.Text = departdt.SelectedCells[0].Value.ToString();
            depapuestotxt.Text = departdt.SelectedCells[1].Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(identtxt.Text))
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

                    if (string.IsNullOrEmpty(DepaID.ToString()))
                    {
                        string queryInsertar = "INSERT INTO TipoDocumento (Nombre, Activo) VALUES (@Nombre, @Activo)";
                        using (SqlCommand insertarCommand = new SqlCommand(queryInsertar, conexion))
                        {
                            insertarCommand.Parameters.AddWithValue("@Nombre", identtxt.Text);
                            insertarCommand.Parameters.AddWithValue("@Activo", estadopuesto.Checked ? 1 : 0);

                            int rowsAffected = insertarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Documento registrado con éxito.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar los datos.");
                            }
                        }
                    }
                    else
                    {
                        string queryActualizar = "UPDATE TipoDocumento SET Nombre = @Nombre, Activo= @Activo where IdTipoDocumento= @IdTipoDoc";
                        using (SqlCommand actualizarCommand = new SqlCommand(queryActualizar, conexion))
                        {
                            actualizarCommand.Parameters.AddWithValue("@IdTipoDoc", TipoDocID);
                            actualizarCommand.Parameters.AddWithValue("@Nombre", identtxt.Text);
                            actualizarCommand.Parameters.AddWithValue("@Activo", estadoiden.Checked ? 1 : 0);

                            int rowsAffected = actualizarCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Tipo de documento actualizado con éxito.");
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
    }
}
