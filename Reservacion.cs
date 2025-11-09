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
    public partial class Reservacion : Form
    {
        public Reservacion()
        {
            InitializeComponent();
        }

        private void facturarbtn_Click(object sender, EventArgs e)
        {

        }

        private Button botonActivo = null;
        private int idMesaSeleccionada = -1;

        private void BtnMesa_Click(object sender, EventArgs e)
        {
            Button btnSeleccionado = sender as Button;

            if (botonActivo != null)
            {
                dynamic anterior = botonActivo.Tag;
                botonActivo.BackColor = (anterior.Estado == 1) ?
                    Color.LightCoral : Color.LightGreen;
            }

            botonActivo = btnSeleccionado;
            btnSeleccionado.BackColor = Color.DodgerBlue;

            dynamic mesa = btnSeleccionado.Tag;
            idMesaSeleccionada = mesa.Id;
        }

        private void Reservacion_Load(object sender, EventArgs e)
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
                        flowmesa.Controls.Clear();

                        while (lector.Read())
                        {
                            Button btnMesa = new Button();
                            btnMesa.Width = 150;
                            btnMesa.Height = 100;
                            btnMesa.Margin = new Padding(10);
                            btnMesa.TextAlign = ContentAlignment.MiddleCenter;
                            btnMesa.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                            int estado = Convert.ToInt32(lector["Ocupado"]);

                            btnMesa.BackColor = (estado == 1) ? Color.LightCoral : Color.LightGreen;

                            btnMesa.Tag = new
                            {
                                Id = Convert.ToInt32(lector["IdMesa"]),
                                Estado = estado
                            };

                            string numero = lector["Numero"].ToString();
                            string sala = lector["IdSala"].ToString();
                            string capacidad = lector["Capacidad"].ToString();

                            btnMesa.Text =
                                "Mesa #" + numero +
                                "\nSala: " + sala +
                                "\nAsientos: " + capacidad;

                            btnMesa.Click += BtnMesa_Click;

                            flowmesa.Controls.Add(btnMesa);
                        }

                    }
                }
            }
        }
    }
}
