namespace Proyecto_restaurante
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            usuariolabel = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            cerrarbtn = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label1 = new Label();
            button9 = new Button();
            button10 = new Button();
            label2 = new Label();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            reservacion = new Button();
            button11 = new Button();
            ajustestxt = new Label();
            ajustesbtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // usuariolabel
            // 
            usuariolabel.AutoSize = true;
            usuariolabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuariolabel.Location = new Point(2, 2);
            usuariolabel.Margin = new Padding(2, 0, 2, 0);
            usuariolabel.Name = "usuariolabel";
            usuariolabel.Size = new Size(145, 21);
            usuariolabel.TabIndex = 2;
            usuariolabel.Text = "USUARIO ACTUAL: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(usuariolabel);
            panel1.Location = new Point(79, 10);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 60);
            panel1.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Lime;
            panel5.Location = new Point(-1, 49);
            panel5.Margin = new Padding(2, 3, 2, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(226, 6);
            panel5.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(10, 10);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(70, 61);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.perfil_blanco;
            pictureBox2.Location = new Point(2, 2);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Location = new Point(45, 62);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(0, 0);
            panel3.TabIndex = 5;
            // 
            // cerrarbtn
            // 
            cerrarbtn.BackColor = Color.Red;
            cerrarbtn.FlatStyle = FlatStyle.Flat;
            cerrarbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cerrarbtn.Location = new Point(309, 9);
            cerrarbtn.Margin = new Padding(2, 3, 2, 3);
            cerrarbtn.Name = "cerrarbtn";
            cerrarbtn.Size = new Size(114, 62);
            cerrarbtn.TabIndex = 13;
            cerrarbtn.Text = "Cerrar Sesión";
            cerrarbtn.UseVisualStyleBackColor = false;
            cerrarbtn.Click += cerrarbtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Image = Properties.Resources.persona1;
            button1.Location = new Point(328, 138);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(104, 65);
            button1.TabIndex = 8;
            button1.Text = "Usuarios";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.cliente1;
            button2.Location = new Point(113, 56);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(104, 65);
            button2.TabIndex = 2;
            button2.Text = "Clientes";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.categoria;
            button3.Location = new Point(221, 56);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(104, 65);
            button3.TabIndex = 3;
            button3.Text = "Categorias";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.sala;
            button4.Location = new Point(328, 56);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(104, 65);
            button4.TabIndex = 4;
            button4.Text = "Salas";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.producto;
            button5.Location = new Point(6, 56);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(104, 65);
            button5.TabIndex = 1;
            button5.Text = "Articulos";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Image = Properties.Resources.proveedor1;
            button6.Location = new Point(221, 138);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(104, 65);
            button6.TabIndex = 7;
            button6.Text = "Proveedores";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Image = Properties.Resources.caja;
            button7.Location = new Point(113, 138);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(104, 65);
            button7.TabIndex = 6;
            button7.Text = "Cajas";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Image = Properties.Resources.mesa;
            button8.Location = new Point(6, 138);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(104, 65);
            button8.TabIndex = 5;
            button8.Text = "Mesas";
            button8.TextAlign = ContentAlignment.BottomCenter;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 14;
            label1.Text = "Mantenimientos";
            // 
            // button9
            // 
            button9.Image = Properties.Resources.carrito32x;
            button9.Location = new Point(114, 275);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(104, 65);
            button9.TabIndex = 10;
            button9.Text = "Compras";
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Image = Properties.Resources.pedido;
            button10.Location = new Point(6, 275);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(104, 65);
            button10.TabIndex = 9;
            button10.Text = "Pedidos";
            button10.TextAlign = ContentAlignment.BottomCenter;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 231);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 17;
            label2.Text = "Procesos";
            // 
            // panel4
            // 
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(cerrarbtn);
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1266, 85);
            panel4.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logo_completo;
            pictureBox1.Location = new Point(668, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(596, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel6.BackColor = SystemColors.WindowFrame;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(reservacion);
            panel6.Controls.Add(button11);
            panel6.Controls.Add(ajustestxt);
            panel6.Controls.Add(ajustesbtn);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(button1);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(button9);
            panel6.Controls.Add(button3);
            panel6.Controls.Add(button10);
            panel6.Controls.Add(button4);
            panel6.Controls.Add(button8);
            panel6.Controls.Add(button5);
            panel6.Controls.Add(button7);
            panel6.Controls.Add(button6);
            panel6.Location = new Point(0, 85);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(444, 565);
            panel6.TabIndex = 19;
            // 
            // reservacion
            // 
            reservacion.Image = Properties.Resources.recepcion;
            reservacion.Location = new Point(222, 275);
            reservacion.Margin = new Padding(2);
            reservacion.Name = "reservacion";
            reservacion.Size = new Size(104, 65);
            reservacion.TabIndex = 20;
            reservacion.Text = "Reservación";
            reservacion.TextAlign = ContentAlignment.BottomCenter;
            reservacion.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button11.Image = Properties.Resources.ajuste;
            button11.Location = new Point(7, 477);
            button11.Margin = new Padding(2);
            button11.Name = "button11";
            button11.Size = new Size(104, 65);
            button11.TabIndex = 11;
            button11.Text = "Generales";
            button11.TextAlign = ContentAlignment.BottomCenter;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // ajustestxt
            // 
            ajustestxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ajustestxt.AutoSize = true;
            ajustestxt.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            ajustestxt.ForeColor = Color.White;
            ajustestxt.Location = new Point(3, 434);
            ajustestxt.Margin = new Padding(2, 0, 2, 0);
            ajustestxt.Name = "ajustestxt";
            ajustestxt.Size = new Size(232, 32);
            ajustestxt.TabIndex = 19;
            ajustestxt.Text = "Ajustes del sistema";
            // 
            // ajustesbtn
            // 
            ajustesbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ajustesbtn.BackColor = Color.Gold;
            ajustesbtn.Image = Properties.Resources.seguro;
            ajustesbtn.Location = new Point(114, 477);
            ajustesbtn.Margin = new Padding(2);
            ajustesbtn.Name = "ajustesbtn";
            ajustesbtn.Size = new Size(104, 65);
            ajustesbtn.TabIndex = 12;
            ajustesbtn.Text = "Administrativos";
            ajustesbtn.TextAlign = ContentAlignment.BottomCenter;
            ajustesbtn.UseVisualStyleBackColor = false;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.tenedor1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1266, 650);
            Controls.Add(panel6);
            Controls.Add(panel4);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(2, 3, 2, 3);
            Name = "menu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            Load += menu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Label usuariolabel;
        private Panel panel2;
        private Panel panel3;
        private Button cerrarbtn;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label1;
        private Button button9;
        private Button button10;
        private Label label2;
        public Button button1;
        private Panel panel4;
        private Panel panel6;
        public Label ajustestxt;
        public Button ajustesbtn;
        public Button button11;
        public Panel panel1;
        public Panel panel5;
        private PictureBox pictureBox1;
        private Button reservacion;
    }
}