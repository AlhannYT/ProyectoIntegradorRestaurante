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
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label1 = new Label();
            button9 = new Button();
            button10 = new Button();
            label2 = new Label();
            barrasup = new Panel();
            pictureBox1 = new PictureBox();
            barraizq = new Panel();
            button12 = new Button();
            reservacion = new Button();
            button11 = new Button();
            ajustestxt = new Label();
            button14 = new Button();
            button13 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            barrasup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            barraizq.SuspendLayout();
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
            cerrarbtn.Image = Properties.Resources.salida;
            cerrarbtn.ImageAlign = ContentAlignment.MiddleRight;
            cerrarbtn.Location = new Point(309, 9);
            cerrarbtn.Margin = new Padding(2, 3, 2, 3);
            cerrarbtn.Name = "cerrarbtn";
            cerrarbtn.Size = new Size(132, 62);
            cerrarbtn.TabIndex = 20;
            cerrarbtn.Text = "Cerrar Sesión";
            cerrarbtn.TextAlign = ContentAlignment.MiddleLeft;
            cerrarbtn.UseVisualStyleBackColor = false;
            cerrarbtn.Click += cerrarbtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Image = Properties.Resources.usuario;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(9, 383);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(217, 38);
            button1.TabIndex = 9;
            button1.Text = "Usuarios";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.cliente31;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(9, 149);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(217, 38);
            button2.TabIndex = 4;
            button2.Text = "Clientes";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.sala;
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(9, 227);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(217, 38);
            button4.TabIndex = 7;
            button4.Text = "Salas";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.productonuevo1;
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(9, 71);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(217, 38);
            button5.TabIndex = 2;
            button5.Text = "Articulos";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Image = Properties.Resources.proveedor2;
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.Location = new Point(9, 266);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(217, 38);
            button6.TabIndex = 8;
            button6.Text = "Proveedores";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Image = Properties.Resources.caja;
            button7.ImageAlign = ContentAlignment.MiddleRight;
            button7.Location = new Point(9, 188);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(217, 38);
            button7.TabIndex = 6;
            button7.Text = "Cajas";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Image = Properties.Resources.mesa;
            button8.ImageAlign = ContentAlignment.MiddleRight;
            button8.Location = new Point(9, 110);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(217, 38);
            button8.TabIndex = 3;
            button8.Text = "Mesas";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Image = Properties.Resources.mantenimiento1;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(5, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 32);
            label1.TabIndex = 14;
            label1.Text = "Mantenimientos    ";
            // 
            // button9
            // 
            button9.Image = Properties.Resources.carrito32x;
            button9.ImageAlign = ContentAlignment.MiddleRight;
            button9.Location = new Point(10, 576);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(217, 38);
            button9.TabIndex = 11;
            button9.Text = "Compras";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Image = Properties.Resources.pedido;
            button10.ImageAlign = ContentAlignment.MiddleRight;
            button10.Location = new Point(10, 537);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(217, 38);
            button10.TabIndex = 10;
            button10.Text = "Pedidos";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Image = Properties.Resources.proceso;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(5, 498);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 17;
            label2.Text = "Procesos    ";
            // 
            // barrasup
            // 
            barrasup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            barrasup.BackColor = Color.FromArgb(64, 64, 64);
            barrasup.BorderStyle = BorderStyle.FixedSingle;
            barrasup.Controls.Add(panel1);
            barrasup.Controls.Add(panel2);
            barrasup.Controls.Add(panel3);
            barrasup.Controls.Add(cerrarbtn);
            barrasup.Controls.Add(pictureBox1);
            barrasup.Dock = DockStyle.Top;
            barrasup.Location = new Point(0, 0);
            barrasup.Margin = new Padding(2);
            barrasup.Name = "barrasup";
            barrasup.Size = new Size(1266, 85);
            barrasup.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logo_completo;
            pictureBox1.Location = new Point(858, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // barraizq
            // 
            barraizq.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            barraizq.BackColor = SystemColors.WindowFrame;
            barraizq.BorderStyle = BorderStyle.FixedSingle;
            barraizq.Controls.Add(button12);
            barraizq.Controls.Add(reservacion);
            barraizq.Controls.Add(button11);
            barraizq.Controls.Add(ajustestxt);
            barraizq.Controls.Add(label1);
            barraizq.Controls.Add(button1);
            barraizq.Controls.Add(label2);
            barraizq.Controls.Add(button14);
            barraizq.Controls.Add(button13);
            barraizq.Controls.Add(button2);
            barraizq.Controls.Add(button9);
            barraizq.Controls.Add(button10);
            barraizq.Controls.Add(button4);
            barraizq.Controls.Add(button8);
            barraizq.Controls.Add(button5);
            barraizq.Controls.Add(button7);
            barraizq.Controls.Add(button6);
            barraizq.Location = new Point(0, 85);
            barraizq.Margin = new Padding(2);
            barraizq.Name = "barraizq";
            barraizq.Size = new Size(241, 839);
            barraizq.TabIndex = 19;
            // 
            // button12
            // 
            button12.Image = Properties.Resources._3_rayas;
            button12.Location = new Point(9, 2);
            button12.Name = "button12";
            button12.Size = new Size(42, 29);
            button12.TabIndex = 1;
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // reservacion
            // 
            reservacion.Image = Properties.Resources.calendario_reloj;
            reservacion.ImageAlign = ContentAlignment.MiddleRight;
            reservacion.Location = new Point(10, 615);
            reservacion.Margin = new Padding(2);
            reservacion.Name = "reservacion";
            reservacion.Size = new Size(217, 38);
            reservacion.TabIndex = 12;
            reservacion.Text = "Reservación";
            reservacion.TextAlign = ContentAlignment.MiddleLeft;
            reservacion.UseVisualStyleBackColor = true;
            reservacion.Click += reservacion_Click;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button11.Image = Properties.Resources.ajuste;
            button11.ImageAlign = ContentAlignment.MiddleRight;
            button11.Location = new Point(10, 787);
            button11.Margin = new Padding(2);
            button11.Name = "button11";
            button11.Size = new Size(217, 38);
            button11.TabIndex = 13;
            button11.Text = "Generales";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // ajustestxt
            // 
            ajustestxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ajustestxt.AutoSize = true;
            ajustestxt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ajustestxt.ForeColor = Color.White;
            ajustestxt.Image = Properties.Resources.opciones;
            ajustestxt.ImageAlign = ContentAlignment.MiddleRight;
            ajustestxt.Location = new Point(5, 745);
            ajustestxt.Margin = new Padding(2, 0, 2, 0);
            ajustestxt.Name = "ajustestxt";
            ajustestxt.Size = new Size(125, 32);
            ajustestxt.TabIndex = 19;
            ajustestxt.Text = "Ajustes    ";
            // 
            // button14
            // 
            button14.Image = Properties.Resources.types;
            button14.ImageAlign = ContentAlignment.MiddleRight;
            button14.Location = new Point(9, 344);
            button14.Margin = new Padding(2);
            button14.Name = "button14";
            button14.Size = new Size(217, 38);
            button14.TabIndex = 4;
            button14.Text = "Tipos";
            button14.TextAlign = ContentAlignment.MiddleLeft;
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.Image = Properties.Resources.empleado;
            button13.ImageAlign = ContentAlignment.MiddleRight;
            button13.Location = new Point(9, 305);
            button13.Margin = new Padding(2);
            button13.Name = "button13";
            button13.Size = new Size(217, 38);
            button13.TabIndex = 4;
            button13.Text = "Empleados";
            button13.TextAlign = ContentAlignment.MiddleLeft;
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(924, 894);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(331, 21);
            label3.TabIndex = 2;
            label3.Text = "Wilder (2-21-0179) / Alhann (2-21-0018) ©";
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
            ClientSize = new Size(1266, 924);
            Controls.Add(barraizq);
            Controls.Add(barrasup);
            Controls.Add(label3);
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
            barrasup.ResumeLayout(false);
            barrasup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            barraizq.ResumeLayout(false);
            barraizq.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label usuariolabel;
        private Panel panel2;
        private Panel panel3;
        private Button cerrarbtn;
        private PictureBox pictureBox2;
        private Button button2;
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
        public Label ajustestxt;
        public Button button11;
        public Panel panel1;
        public Panel panel5;
        private PictureBox pictureBox1;
        private Button reservacion;
        public Panel barrasup;
        public Panel barraizq;
        public Label label3;
        private Button button12;
        private Button button13;
        private Button button14;
    }
}