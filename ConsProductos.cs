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
    public partial class ConsProductos : Form
    {
        public ConsProductos()
        {
            InitializeComponent();
        }

        private string CodigoProductoActual;
        private int idProducto = 0;

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idProducto = Convert.ToInt32(tabladatos.SelectedCells[0].Value);

            string codigoProducto = idProducto.ToString();

            string rutaImagenes = @"C:\CarpetaDeImagenesProductos\";
            string rutaImagenProducto = Path.Combine(rutaImagenes, codigoProducto + ".jpg");

            if (File.Exists(rutaImagenProducto))
            {
                imagenproducto.Image = Image.FromFile(rutaImagenProducto);
            }
            else
            {
                imagenproducto.Image = null;
            }
        }

        private void ConsProductos_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            string conexionString = ConexionBD.ConexionSQL();


            string consulta = "select id, codigo_producto, nombre_producto, categoria, precio_venta, existencia from productos";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionString);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            tabladatos.DataSource = dt;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is MantProductos)
                {
                    f.BringToFront();
                    return;
                }
            }
            MantProductos mantProductos = new MantProductos();
            mantProductos.Location = new Point(561, 50);
            CodigoProductoActual = "";
            mantProductos.Show();
        }

        private void recargarbtn_Click(object sender, EventArgs e)
        {
            ConsProductos_Load(sender, e);
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            this.Text = "Mantenimiento de Productos || Editando...";

            idProducto = Convert.ToInt32(tabladatos.SelectedCells[0].Value);
            CodigoProductoActual = idProducto.ToString();

            foreach (Form f in this.MdiChildren)
            {
                if (f is MantProductos)
                {
                    f.BringToFront();
                    return;
                }
            }
            MantProductos mantProductos = new MantProductos();
            mantProductos.Location = new Point(561, 50);
            mantProductos.Show();
        }
    }
}
