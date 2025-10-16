using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_restaurante
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        public string usuarioActual;


        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            inicio cerrarsesion = new inicio();
            cerrarsesion.Show();
            this.Close();
        }

        private void medidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is MantMedidas)
                {
                    f.BringToFront();
                    return;
                }
            }
            MantMedidas medidas = new MantMedidas();
            medidas.Location = new Point(561, 50);
            medidas.MdiParent = this;
            medidas.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is MantUsuarios)
                {
                    f.BringToFront();
                    return;
                }
            }

            MantUsuarios mantUsuarios = new MantUsuarios();
            mantUsuarios.Location = new Point(561, 50);
            mantUsuarios.adminlabel.Text = "Administrador: " + usuarioActual;
            mantUsuarios.UsuarioAdministrador = usuarioActual;
            mantUsuarios.MdiParent = this;
            mantUsuarios.Show();
        }

        private void button2_Click(object sender, EventArgs e)
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
            mantClientes.MdiParent = this;
            mantClientes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is MantCategoria)
                {
                    f.BringToFront();
                    return;
                }
            }

            MantCategoria mantCategoria = new MantCategoria();
            mantCategoria.Location = new Point(561, 50);
            mantCategoria.MdiParent = this;
            mantCategoria.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is MantSalas)
                {
                    f.BringToFront();
                    return;
                }
            }
            MantSalas mantSalas = new MantSalas();
            mantSalas.Location = new Point(561, 50);
            mantSalas.MdiParent = this;
            mantSalas.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is MantMesas)
                {
                    f.BringToFront();
                    return;
                }
            }
            MantMesas mantMesas = new MantMesas();
            mantMesas.Location = new Point(561, 50);
            mantMesas.MdiParent = this;
            mantMesas.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is MantProveedor)
                {
                    f.BringToFront();
                    return;
                }
            }
            MantProveedor mantProv = new MantProveedor();
            mantProv.Location = new Point(561, 50);
            mantProv.MdiParent = this;
            mantProv.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is ConsProductos)
                {
                    f.BringToFront();
                    return;
                }
            }
            ConsProductos ConsProductos = new ConsProductos();
            ConsProductos.Location = new Point(561, 50);
            ConsProductos.MdiParent = this;
            ConsProductos.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is Pedidos)
                {
                    f.BringToFront();
                    return;
                }
            }

            Pedidos pedidos = new Pedidos();
            pedidos.NombreResponsable = usuarioActual;
            pedidos.Location = new Point(561, 50);
            pedidos.MdiParent = this;
            pedidos.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is Compras)
                {
                    f.BringToFront();
                    return;
                }
            }
            Compras compras = new Compras();
            compras.responsableCompra = usuarioActual;
            compras.Location = new Point(561, 50);
            compras.MdiParent = this;
            compras.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is MantCajas)
                {
                    f.BringToFront();
                    return;
                }
            }
            MantCajas mantCaj = new MantCajas();
            mantCaj.Location = new Point(561, 50);
            mantCaj.MdiParent = this;
            mantCaj.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
