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

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();
            string consulta = "select id, nombre_cliente, apellido_cliente, identificacion, telefono from cliente";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tabladatos.DataSource = dt;
        }

        private void FiltroDatosBusqueda(string busqueda)
        {
            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conectar = new SqlConnection(conexionString))
            {
                try
                {
                    conectar.Open();

                    string query = @"
                        SELECT * FROM cliente
                        WHERE CAST(id AS VARCHAR) LIKE @buscar OR
                        nombre_cliente LIKE @buscar OR
                        apellido_cliente LIKE @buscar";

                    using (SqlCommand comando = new SqlCommand(query, conectar))
                    {
                        comando.Parameters.AddWithValue("@buscar", "%" + busqueda + "%");

                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        tabladatos.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

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
            FiltroDatosBusqueda(txtbuscador.Text);
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is MantClientes)
                {
                    f.BringToFront();
                    return;
                }
            }
            MantClientes mantClientes = new MantClientes();
            mantClientes.Location = new Point(561, 50);
            //CodigoProductoActual = "";
            mantClientes.Show();
        }
    }
}
