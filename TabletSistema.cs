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
    public partial class TabletSistema : Form
    {
        public TabletSistema()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TabletSistema_Load(object sender, EventArgs e)
        {
            string conexionString = ConexionBD.ConexionSQL();

            string consulta = "select IdMesa, IdSala, Numero, Capacidad, Ocupado, Estado from Mesa";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        panelMesas.Controls.Clear();

                        while (lector.Read())
                        {
                            Panel tarjeta = new Panel();
                            tarjeta.Width = 150;
                            tarjeta.Height = 100;
                            tarjeta.BorderStyle = BorderStyle.FixedSingle;
                            tarjeta.Margin = new Padding(10);

                            int estado = Convert.ToInt32(lector["Ocupado"]);
                            tarjeta.BackColor = (estado == 1) ? Color.LightCoral : Color.LightGreen;

                            tarjeta.Tag = new
                            {
                                Id = Convert.ToInt32(lector["IdMesa"]),
                                Estado = estado
                            };

                            Label lblMesa = new Label();
                            lblMesa.Text = "Mesa # " + lector["Numero"].ToString();
                            lblMesa.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                            lblMesa.AutoSize = false;
                            lblMesa.TextAlign = ContentAlignment.MiddleCenter;
                            lblMesa.Dock = DockStyle.Top;

                            Label lblSala = new Label();
                            lblSala.Text = "Sala: " + lector["IdSala"].ToString();
                            lblSala.Dock = DockStyle.Top;
                            lblSala.TextAlign = ContentAlignment.MiddleCenter;

                            Label lblAsientos = new Label();
                            lblAsientos.Text = "Asientos: " + lector["Capacidad"].ToString();
                            lblAsientos.Dock = DockStyle.Bottom;
                            lblAsientos.TextAlign = ContentAlignment.MiddleCenter;

                            tarjeta.Controls.Add(lblAsientos);
                            tarjeta.Controls.Add(lblSala);
                            tarjeta.Controls.Add(lblMesa);

                            tarjeta.Click += Tarjeta_Click;

                            panelMesas.Controls.Add(tarjeta);
                        }
                    }
                }
            }
        }

        private Color colorSeleccionado = Color.DodgerBlue;
        private int idMesaSeleccionada = -1;
        private Panel tarjetaActiva = null;

        private void Tarjeta_Click(object sender, EventArgs e)
        {
            Panel tarjetaSeleccionada = sender as Panel;

            if (tarjetaSeleccionada != null)
            {
                if (tarjetaActiva != null)
                {
                    dynamic anterior = tarjetaActiva.Tag;
                    tarjetaActiva.BackColor = (anterior.Estado == 1) ? Color.LightGreen : Color.LightCoral;
                }

                tarjetaActiva = tarjetaSeleccionada;
                tarjetaSeleccionada.BackColor = Color.DodgerBlue;

                dynamic mesa = tarjetaSeleccionada.Tag;
                idMesaSeleccionada = mesa.Id;
            }
        }

    }
}
