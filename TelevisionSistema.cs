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
    public partial class TelevisionSistema : Form
    {
        public TelevisionSistema()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Timer Recargar;


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Recargar_Tick(object sender, EventArgs e)
        {
            CargarOrdenes();
        }

        private void TelevisionSistema_Load(object sender, EventArgs e)
        {
            Recargar = new System.Windows.Forms.Timer();
            Recargar.Interval = 10000;
            Recargar.Tick += Recargar_Tick;
            Recargar.Start();

            CargarOrdenes();
        }

        private void CargarOrdenes()
        {
            panelOrdenes.Controls.Clear();

            string conexionString = ConexionBD.ConexionSQL();

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();

                string query = @"
                SELECT DP.IdPedido, DP.IdProducto, PV.Nombre, DP.Cantidad
                FROM DetallePedido DP
                INNER JOIN ProductoVenta PV ON DP.IdProducto = PV.IdProducto
                WHERE DP.IdPedido IN (
                    SELECT IdPedido FROM Pedido WHERE Estado = 'Pendiente'
                )
                ORDER BY DP.IdPedido";


                SqlCommand cmd = new SqlCommand(query, conexion);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int idPedido = Convert.ToInt32(dr["IdPedido"]);
                        int idProducto = Convert.ToInt32(dr["IdProducto"]);
                        string nombre = dr["Nombre"].ToString();
                        int cantidad = Convert.ToInt32(dr["Cantidad"]);

                        Image img = CargarImagen(idProducto);

                        panelOrdenes.Controls.Add(
                            PanelComanda(idPedido, nombre, cantidad, img)
                        );
                    }

                }
            }
        }

        private Panel PanelComanda(int idPedido, string nombre, int cantidad, Image imagen)
        {
            Panel card = new Panel();
            card.Width = 170;
            card.Height = 230;
            card.BackColor = Color.White;
            card.Margin = new Padding(10);
            card.BorderStyle = BorderStyle.FixedSingle;

            Label lblPedido = new Label();
            lblPedido.Text = $"Orden: {idPedido}";
            lblPedido.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblPedido.AutoSize = true;
            lblPedido.Location = new Point(5, 5);

            PictureBox pic = new PictureBox();
            pic.Size = new Size(130, 100);
            pic.Location = new Point(20, 30);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Image = imagen;

            Label lblNombre = new Label();
            lblNombre.Text = nombre.ToUpper();
            lblNombre.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblNombre.AutoSize = false;
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            lblNombre.Width = 170;
            lblNombre.Location = new Point(0, 140);

            Label lblCantidad = new Label();
            lblCantidad.Text = $"CANTIDAD: {cantidad}";
            lblCantidad.Font = new Font("Segoe UI", 9);
            lblCantidad.AutoSize = false;
            lblCantidad.Width = 170;
            lblCantidad.TextAlign = ContentAlignment.MiddleCenter;
            lblCantidad.Location = new Point(0, 170);

            card.Controls.Add(lblPedido);
            card.Controls.Add(pic);
            card.Controls.Add(lblNombre);
            card.Controls.Add(lblCantidad);

            return card;
        }

        private Image CargarImagen(int idProducto)
        {
            string basePath = @"C:\SistemaArchivos\Productos\";
            string[] extensiones = { ".jpg", ".png", ".jpeg" };

            foreach (string ext in extensiones)
            {
                string ruta = Path.Combine(basePath, idProducto + ext);
                if (File.Exists(ruta))
                {
                    try
                    {
                        using (var temp = new Bitmap(ruta))
                        {
                            return new Bitmap(temp);
                        }
                    }
                    catch { }
                }
            }

            return null;
        }

    }
}
