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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MantUsuarios mantUsuarios = new MantUsuarios();
            mantUsuarios.adminlabel.Text = "Administrador: " + usuarioActual;
            mantUsuarios.UsuarioAdministrador = usuarioActual;
            mantUsuarios.Show();
        }

        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantClientes mantClientes = new MantClientes();

            mantClientes.Show();
        }

        private void agregarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantCategoria mantCategoria = new MantCategoria();
            mantCategoria.Show();
        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            inicio cerrarsesion = new inicio();
            cerrarsesion.Show();
            this.Close();
        }

        private void medidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantMedidas medidas = new MantMedidas();
            medidas.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantDepart mantDepart = new MantDepart();
            //mantDepart.Show();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantSalas mantSalas = new MantSalas();
            mantSalas.Show();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantMesas mantMesas = new MantMesas();
            mantMesas.Show();
        }

        private void monedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantMonedas mantMone = new MantMonedas();
            mantMone.Show();
        }

        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantCajas mantCaj = new MantCajas();
            mantCaj.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantProveedor mantProv = new MantProveedor();
            //mantProv.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantProductos mantProductos = new MantProductos();
            //mantProductos.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pedidos pedidos = new Pedidos();
            //pedidos.NombreResponsable = usuarioActual;
            //pedidos.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Compras compras = new Compras();
            //compras.responsableCompra = usuarioActual;
            //compras.Show();
        }
    }
}
