namespace Proyecto_restaurante
{
    partial class MantProductos
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
            components = new System.ComponentModel.Container();
            guardarbtn = new Button();
            estadochk = new CheckBox();
            label1 = new Label();
            imagenproducto = new PictureBox();
            txtcodigo_producto = new TextBox();
            limpiarbtn = new Button();
            label2 = new Label();
            txtnombre_prod = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtprecio_compra = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtprecio_venta = new TextBox();
            txtexistencia = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtcodigo_barras = new TextBox();
            label10 = new Label();
            label13 = new Label();
            panel2 = new Panel();
            categoriacmbx = new ComboBox();
            ivacmbx = new ComboBox();
            proveedorcmbx = new ComboBox();
            codigorandombtn = new Button();
            codigobarrarandombtn = new Button();
            toolTip1 = new ToolTip(components);
            recargarbtn = new Button();
            panel4 = new Panel();
            seleccionimagenbtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)imagenproducto).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guardarbtn
            // 
            guardarbtn.ForeColor = Color.Black;
            guardarbtn.Image = Properties.Resources.disco;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(10, 8);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(191, 43);
            guardarbtn.TabIndex = 13;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(142, 59);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(60, 19);
            estadochk.TabIndex = 0;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 92);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 2;
            label1.Text = "Codigo  -------------";
            // 
            // imagenproducto
            // 
            imagenproducto.Image = Properties.Resources.paisaje;
            imagenproducto.Location = new Point(9, 9);
            imagenproducto.Name = "imagenproducto";
            imagenproducto.Size = new Size(181, 181);
            imagenproducto.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenproducto.TabIndex = 3;
            imagenproducto.TabStop = false;
            // 
            // txtcodigo_producto
            // 
            txtcodigo_producto.Location = new Point(142, 88);
            txtcodigo_producto.Name = "txtcodigo_producto";
            txtcodigo_producto.Size = new Size(118, 23);
            txtcodigo_producto.TabIndex = 1;
            txtcodigo_producto.TextChanged += txtcodigo_producto_TextChanged;
            // 
            // limpiarbtn
            // 
            limpiarbtn.ForeColor = Color.Black;
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(223, 8);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(191, 43);
            limpiarbtn.TabIndex = 14;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 123);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre  ------------";
            // 
            // txtnombre_prod
            // 
            txtnombre_prod.Location = new Point(142, 120);
            txtnombre_prod.Name = "txtnombre_prod";
            txtnombre_prod.Size = new Size(118, 23);
            txtnombre_prod.TabIndex = 2;
            txtnombre_prod.TextChanged += txtnombre_prod_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 154);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 2;
            label3.Text = "Categoria -----------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 186);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 2;
            label4.Text = "Precio de Compra ---";
            // 
            // txtprecio_compra
            // 
            txtprecio_compra.Location = new Point(142, 184);
            txtprecio_compra.Name = "txtprecio_compra";
            txtprecio_compra.Size = new Size(118, 23);
            txtprecio_compra.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(10, 220);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 2;
            label5.Text = "Precio de Venta ----";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(10, 252);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 2;
            label6.Text = "Existencia ----------";
            // 
            // txtprecio_venta
            // 
            txtprecio_venta.Location = new Point(142, 217);
            txtprecio_venta.Name = "txtprecio_venta";
            txtprecio_venta.Size = new Size(118, 23);
            txtprecio_venta.TabIndex = 6;
            // 
            // txtexistencia
            // 
            txtexistencia.Location = new Point(142, 248);
            txtexistencia.Name = "txtexistencia";
            txtexistencia.Size = new Size(118, 23);
            txtexistencia.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 314);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 2;
            label7.Text = "Codigo de Barras --";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(10, 283);
            label8.Name = "label8";
            label8.Size = new Size(112, 15);
            label8.TabIndex = 2;
            label8.Text = "ITBIS----------------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(10, 346);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 2;
            label9.Text = "Proveedor ----------";
            // 
            // txtcodigo_barras
            // 
            txtcodigo_barras.Location = new Point(142, 312);
            txtcodigo_barras.Name = "txtcodigo_barras";
            txtcodigo_barras.Size = new Size(118, 23);
            txtcodigo_barras.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(10, 60);
            label10.Name = "label10";
            label10.Size = new Size(118, 15);
            label10.TabIndex = 2;
            label10.Text = "Estado: --------------";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(159, 2);
            label13.Name = "label13";
            label13.Size = new Size(268, 32);
            label13.TabIndex = 37;
            label13.Text = "Registro de Productos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Location = new Point(307, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 322);
            panel2.TabIndex = 39;
            // 
            // categoriacmbx
            // 
            categoriacmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            categoriacmbx.FormattingEnabled = true;
            categoriacmbx.Location = new Point(142, 152);
            categoriacmbx.Name = "categoriacmbx";
            categoriacmbx.Size = new Size(118, 23);
            categoriacmbx.TabIndex = 3;
            toolTip1.SetToolTip(categoriacmbx, "Click Derecho\r\npara crear nueva \r\ncategoria");
            categoriacmbx.MouseDown += categoriacmbx_MouseDown;
            // 
            // ivacmbx
            // 
            ivacmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            ivacmbx.FormattingEnabled = true;
            ivacmbx.Location = new Point(142, 280);
            ivacmbx.Name = "ivacmbx";
            ivacmbx.Size = new Size(118, 23);
            ivacmbx.TabIndex = 8;
            toolTip1.SetToolTip(ivacmbx, "Click derecho para\r\ncrear un nuevo\r\nimpuesto");
            ivacmbx.MouseDown += ivacmbx_MouseDown;
            // 
            // proveedorcmbx
            // 
            proveedorcmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            proveedorcmbx.FormattingEnabled = true;
            proveedorcmbx.Location = new Point(142, 344);
            proveedorcmbx.Name = "proveedorcmbx";
            proveedorcmbx.Size = new Size(118, 23);
            proveedorcmbx.TabIndex = 11;
            toolTip1.SetToolTip(proveedorcmbx, "Click Derecho para crear\r\nun nuevo proveedor");
            proveedorcmbx.MouseDown += proveedorcmbx_MouseDown;
            // 
            // codigorandombtn
            // 
            codigorandombtn.ForeColor = Color.Black;
            codigorandombtn.Image = Properties.Resources.barajar;
            codigorandombtn.Location = new Point(263, 88);
            codigorandombtn.Name = "codigorandombtn";
            codigorandombtn.Size = new Size(24, 23);
            codigorandombtn.TabIndex = 0;
            toolTip1.SetToolTip(codigorandombtn, "Genera un codigo\r\naleatorio");
            codigorandombtn.UseVisualStyleBackColor = true;
            codigorandombtn.Click += codigorandombtn_Click;
            // 
            // codigobarrarandombtn
            // 
            codigobarrarandombtn.ForeColor = Color.Black;
            codigobarrarandombtn.Image = Properties.Resources.barajar;
            codigobarrarandombtn.Location = new Point(263, 313);
            codigobarrarandombtn.Name = "codigobarrarandombtn";
            codigobarrarandombtn.Size = new Size(24, 23);
            codigobarrarandombtn.TabIndex = 10;
            toolTip1.SetToolTip(codigobarrarandombtn, "Genera un codigo de \r\nbarras aleatoriamente");
            codigobarrarandombtn.UseVisualStyleBackColor = true;
            codigobarrarandombtn.Click += codigobarrarandombtn_Click;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Ayuda";
            // 
            // recargarbtn
            // 
            recargarbtn.Image = Properties.Resources.actualizar;
            recargarbtn.Location = new Point(13, 11);
            recargarbtn.Name = "recargarbtn";
            recargarbtn.Size = new Size(24, 23);
            recargarbtn.TabIndex = 42;
            recargarbtn.TabStop = false;
            toolTip1.SetToolTip(recargarbtn, "Recargar Datos");
            recargarbtn.UseVisualStyleBackColor = true;
            recargarbtn.Click += recargarbtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(guardarbtn);
            panel4.Controls.Add(limpiarbtn);
            panel4.Location = new Point(98, 412);
            panel4.Name = "panel4";
            panel4.Size = new Size(426, 59);
            panel4.TabIndex = 43;
            // 
            // seleccionimagenbtn
            // 
            seleccionimagenbtn.BackColor = Color.Lime;
            seleccionimagenbtn.ForeColor = Color.Black;
            seleccionimagenbtn.Image = Properties.Resources.subir1;
            seleccionimagenbtn.Location = new Point(9, 200);
            seleccionimagenbtn.Name = "seleccionimagenbtn";
            seleccionimagenbtn.Size = new Size(181, 58);
            seleccionimagenbtn.TabIndex = 12;
            seleccionimagenbtn.Text = "Buscar Imagen";
            seleccionimagenbtn.TextAlign = ContentAlignment.BottomCenter;
            seleccionimagenbtn.UseVisualStyleBackColor = false;
            seleccionimagenbtn.Click += seleccionimagenbtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(imagenproducto);
            panel1.Controls.Add(seleccionimagenbtn);
            panel1.Location = new Point(359, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 265);
            panel1.TabIndex = 44;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.busqueda;
            button1.Location = new Point(263, 153);
            button1.Name = "button1";
            button1.Size = new Size(24, 23);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            // 
            // MantProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(586, 494);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(recargarbtn);
            Controls.Add(proveedorcmbx);
            Controls.Add(ivacmbx);
            Controls.Add(categoriacmbx);
            Controls.Add(panel2);
            Controls.Add(label13);
            Controls.Add(txtexistencia);
            Controls.Add(txtprecio_compra);
            Controls.Add(txtnombre_prod);
            Controls.Add(txtcodigo_barras);
            Controls.Add(txtprecio_venta);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(txtcodigo_producto);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(estadochk);
            Controls.Add(codigobarrarandombtn);
            Controls.Add(button1);
            Controls.Add(codigorandombtn);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MantProductos";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Mantenimiento de Productos || Creando...";
            Load += MantProductos_Load;
            ((System.ComponentModel.ISupportInitialize)imagenproducto).EndInit();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guardarbtn;
        private CheckBox estadochk;
        private Label label1;
        private PictureBox imagenproducto;
        private TextBox txtcodigo_producto;
        private Button limpiarbtn;
        private Label label2;
        private TextBox txtnombre_prod;
        private Label label3;
        private Label label4;
        private TextBox txtprecio_compra;
        private Label label5;
        private Label label6;
        private TextBox txtprecio_venta;
        private TextBox txtexistencia;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtcodigo_barras;
        private Label label10;
        private Label label13;
        private Panel panel2;
        private ComboBox categoriacmbx;
        private ComboBox ivacmbx;
        private ComboBox proveedorcmbx;
        private ToolTip toolTip1;
        private Button codigorandombtn;
        private Button codigobarrarandombtn;
        public Button recargarbtn;
        private Panel panel4;
        private Button seleccionimagenbtn;
        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private Button button1;
    }
}