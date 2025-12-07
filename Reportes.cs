using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Proyecto_restaurante
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        public int TipoReporte = 0;

        private void repVentas_CheckedChanged(object sender, EventArgs e)
        {
            if (repVentas.Checked == true)
            {
                TipoReporte = 1;
                repPlatosVendidos.Checked = false;
                repStock.Checked = false;
                repCompras.Checked = false;
                repClientes.Checked = false;
                repProv.Checked = false;
                repEmpleados.Checked = false;
                generarPDFbtn.Enabled = true;

                repVentasPanel.Location = new Point(328, 2);
                repVentasPanel.BringToFront();
                repVentasPanel.Visible = true;
            }
        }

        private void repPlatosVendidos_CheckedChanged(object sender, EventArgs e)
        {
            if (repPlatosVendidos.Checked == true)
            {
                TipoReporte = 2;
                repVentas.Checked = false;
                repStock.Checked = false;
                repCompras.Checked = false;
                repClientes.Checked = false;
                repProv.Checked = false;
                repEmpleados.Checked = false;
                generarPDFbtn.Enabled = true;

                RepPlatosPanel.Location = new Point(328, 2);
                RepPlatosPanel.BringToFront();
                RepPlatosPanel.Visible = true;
            }
        }

        private void repStock_CheckedChanged(object sender, EventArgs e)
        {
            if (repStock.Checked == true)
            {
                TipoReporte = 3;
                repPlatosVendidos.Checked = false;
                repVentas.Checked = false;
                repCompras.Checked = false;
                repClientes.Checked = false;
                repProv.Checked = false;
                repEmpleados.Checked = false;
                generarPDFbtn.Enabled = true;

                RepStockPanel.Location = new Point(328, 2);
                RepStockPanel.BringToFront();
                RepStockPanel.Visible = true;
            }
        }

        private void repCompras_CheckedChanged(object sender, EventArgs e)
        {
            if (repCompras.Checked == true)
            {
                TipoReporte = 4;
                repPlatosVendidos.Checked = false;
                repStock.Checked = false;
                repVentas.Checked = false;
                repClientes.Checked = false;
                repProv.Checked = false;
                repEmpleados.Checked = false;
                generarPDFbtn.Enabled = true;

                RepComprasPanel.Location = new Point(328, 2);
                RepComprasPanel.BringToFront();
                RepComprasPanel.Visible = true;
            }
        }

        private void repClientes_CheckedChanged(object sender, EventArgs e)
        {
            if (repClientes.Checked == true)
            {
                TipoReporte = 5;
                repPlatosVendidos.Checked = false;
                repStock.Checked = false;
                repCompras.Checked = false;
                repVentas.Checked = false;
                repProv.Checked = false;
                repEmpleados.Checked = false;
                generarPDFbtn.Enabled = true;

                RepClientesPanel.Location = new Point(328, 2);
                RepClientesPanel.BringToFront();
                RepClientesPanel.Visible = true;
            }
        }

        private void repProv_CheckedChanged(object sender, EventArgs e)
        {
            if (repProv.Checked == true)
            {
                TipoReporte = 6;
                repPlatosVendidos.Checked = false;
                repStock.Checked = false;
                repCompras.Checked = false;
                repClientes.Checked = false;
                repVentas.Checked = false;
                repEmpleados.Checked = false;
                generarPDFbtn.Enabled = true;

                RepProvPanel.Location = new Point(328, 2);
                RepProvPanel.BringToFront();
                RepProvPanel.Visible = true;
            }
        }

        private void repEmpleados_CheckedChanged(object sender, EventArgs e)
        {
            if (repEmpleados.Checked == true)
            {
                TipoReporte = 7;
                repPlatosVendidos.Checked = false;
                repStock.Checked = false;
                repCompras.Checked = false;
                repClientes.Checked = false;
                repProv.Checked = false;
                repVentas.Checked = false;
                generarPDFbtn.Enabled = true;

                RepEmpleadosPanel.Location = new Point(328, 2);
                RepEmpleadosPanel.BringToFront();
                RepEmpleadosPanel.Visible = true;
            }
        }
    }
}
