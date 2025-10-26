using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
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
            barraizq.BringToFront();
            barrasup.BringToFront();

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
                if (f is ConsClientes)
                {
                    f.BringToFront();
                    return;
                }
            }

            ConsClientes consClientes = new ConsClientes();
            consClientes.Location = new Point(561, 50);
            consClientes.MdiParent = this;
            consClientes.Show();
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

        public int estadobarra = 1;

        private void button12_Click(object sender, EventArgs e)
        {

            if (estadobarra == 1)
            {
                barraizq.Width = 63;

                foreach (Control ctrl in barraizq.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.Width = 42;
                        btn.Text = "";
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        label1.Text = "  ";
                        label2.Text = "  ";
                        ajustestxt.Text = "  ";
                        label1.ImageAlign = ContentAlignment.MiddleCenter;
                        label2.ImageAlign = ContentAlignment.MiddleCenter;
                        ajustestxt.ImageAlign = ContentAlignment.MiddleCenter;
                    }
                }

                estadobarra = 0;
            }
            else
            {
                barraizq.Width = 241;

                foreach (Control ctrl in barraizq.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.Width = 217;
                        button12.Width = 42;
                        button5.Text = "Articulos";
                        button8.Text = "Mesas";
                        button2.Text = "Clientes";
                        button7.Text = "Cajas";
                        button4.Text = "Salas";
                        button5.Text = "Articulos";
                        button6.Text = "Proveedores";
                        button1.Text = "Usuarios";
                        button10.Text = "Pedidos";
                        button14.Text = "Tipos";
                        button9.Text = "Compras";
                        reservacion.Text = "Reservacion";
                        button11.Text = "Generales";
                        btn.ImageAlign = ContentAlignment.MiddleRight;
                        button12.ImageAlign = ContentAlignment.MiddleCenter;
                        label1.Text = "Mantenimientos    ";
                        label2.Text = "Procesos    ";
                        ajustestxt.Text = "Ajustes    ";
                        label1.ImageAlign = ContentAlignment.MiddleRight;
                        label2.ImageAlign = ContentAlignment.MiddleRight;
                        ajustestxt.ImageAlign = ContentAlignment.MiddleRight;
                    }
                }

                estadobarra = 1;
            }
        }


        public void agregarproducto(object sender, EventArgs e)
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
            mantProductos.Location = new Point(561, 70);
            mantProductos.Show();
        }

        private void reservacion_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is Reservacion)
                {
                    f.BringToFront();
                    return;
                }
            }
            Reservacion reservacion = new Reservacion();
            reservacion.Location = new Point(561, 50);
            reservacion.MdiParent = this;
            reservacion.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is MenuTipos)
                {
                    f.BringToFront();
                    return;
                }
            }
            MenuTipos menuTipos = new MenuTipos();
            menuTipos.Location = new Point(561, 50);
            menuTipos.textoinicial.Location = new Point(396, 150);
            menuTipos.textoinicial.Visible = true;
            menuTipos.MdiParent = this;
            menuTipos.Show();
        }
    }
}
