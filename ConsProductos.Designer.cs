namespace Proyecto_restaurante
{
    partial class ConsProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsProductos));
            label11 = new Label();
            eliminarbtn = new Button();
            label12 = new Label();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            agregar = new Button();
            Editar = new Button();
            panel1 = new Panel();
            label2 = new Label();
            imagenproducto = new PictureBox();
            label1 = new Label();
            recargarbtn = new Button();
            tabControl1 = new TabControl();
            consulta = new TabPage();
            creacion = new TabPage();
            codigorandombtn = new Button();
            panel2 = new Panel();
            imagenprod = new PictureBox();
            seleccionimagenbtn = new Button();
            panel4 = new Panel();
            guardarbtn = new Button();
            limpiarbtn = new Button();
            button1 = new Button();
            proveedorcmbx = new ComboBox();
            ivacmbx = new ComboBox();
            categoriacmbx = new ComboBox();
            label13 = new Label();
            txtprecio_compra = new TextBox();
            txtnombre_prod = new TextBox();
            txtcodigo_barras = new TextBox();
            txtprecio_venta = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            txtcodigo_producto = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label10 = new Label();
            label14 = new Label();
            label15 = new Label();
            estadochk = new CheckBox();
            codigobarrarandombtn = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenproducto).BeginInit();
            tabControl1.SuspendLayout();
            consulta.SuspendLayout();
            creacion.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenprod).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(283, 5);
            label11.Name = "label11";
            label11.Size = new Size(273, 32);
            label11.TabIndex = 42;
            label11.Text = "Consulta de Productos";
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(635, 55);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 29);
            eliminarbtn.TabIndex = 41;
            eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.Control;
            label12.Image = Properties.Resources.busqueda1;
            label12.Location = new Point(608, 59);
            label12.Name = "label12";
            label12.Size = new Size(18, 21);
            label12.TabIndex = 38;
            label12.Text = "  ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.AllowUserToDeleteRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(8, 92);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.RowHeadersWidth = 51;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(656, 496);
            tabladatos.TabIndex = 39;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(8, 55);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(622, 29);
            txtbuscador.TabIndex = 40;
            txtbuscador.Text = "(ID, Codigo, Nombre, Categoria, Codigo de Barras, Proveedor)";
            // 
            // agregar
            // 
            agregar.Image = Properties.Resources.producto;
            agregar.Location = new Point(672, 92);
            agregar.Name = "agregar";
            agregar.Size = new Size(159, 72);
            agregar.TabIndex = 43;
            agregar.Text = "Nuevo";
            agregar.TextAlign = ContentAlignment.BottomCenter;
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // Editar
            // 
            Editar.Image = Properties.Resources.producto;
            Editar.Location = new Point(672, 170);
            Editar.Name = "Editar";
            Editar.Size = new Size(159, 72);
            Editar.TabIndex = 43;
            Editar.Text = "Editar";
            Editar.TextAlign = ContentAlignment.BottomCenter;
            Editar.UseVisualStyleBackColor = true;
            Editar.Click += Editar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(imagenproducto);
            panel1.Location = new Point(667, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 341);
            panel1.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(7, -2);
            label2.Name = "label2";
            label2.Size = new Size(155, 64);
            label2.TabIndex = 46;
            label2.Text = "Informacion\r\n    General";
            // 
            // imagenproducto
            // 
            imagenproducto.ErrorImage = Properties.Resources.paisaje;
            imagenproducto.Image = Properties.Resources.paisaje;
            imagenproducto.InitialImage = Properties.Resources.paisaje;
            imagenproducto.Location = new Point(5, 65);
            imagenproducto.Name = "imagenproducto";
            imagenproducto.Size = new Size(159, 159);
            imagenproducto.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenproducto.TabIndex = 0;
            imagenproducto.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(693, 50);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 45;
            label1.Text = "Acciones";
            // 
            // recargarbtn
            // 
            recargarbtn.Image = Properties.Resources.actualizar;
            recargarbtn.Location = new Point(8, 10);
            recargarbtn.Name = "recargarbtn";
            recargarbtn.Size = new Size(29, 29);
            recargarbtn.TabIndex = 46;
            recargarbtn.TabStop = false;
            recargarbtn.UseVisualStyleBackColor = true;
            recargarbtn.Click += recargarbtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(consulta);
            tabControl1.Controls.Add(creacion);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(847, 627);
            tabControl1.TabIndex = 47;
            // 
            // consulta
            // 
            consulta.BackColor = SystemColors.WindowFrame;
            consulta.Controls.Add(label12);
            consulta.Controls.Add(recargarbtn);
            consulta.Controls.Add(panel1);
            consulta.Controls.Add(Editar);
            consulta.Controls.Add(label1);
            consulta.Controls.Add(agregar);
            consulta.Controls.Add(tabladatos);
            consulta.Controls.Add(eliminarbtn);
            consulta.Controls.Add(label11);
            consulta.Controls.Add(txtbuscador);
            consulta.Location = new Point(4, 30);
            consulta.Name = "consulta";
            consulta.Padding = new Padding(3);
            consulta.Size = new Size(839, 593);
            consulta.TabIndex = 0;
            consulta.Text = "Consulta";
            // 
            // creacion
            // 
            creacion.BackColor = SystemColors.WindowFrame;
            creacion.Controls.Add(codigorandombtn);
            creacion.Controls.Add(panel2);
            creacion.Controls.Add(panel4);
            creacion.Controls.Add(button1);
            creacion.Controls.Add(proveedorcmbx);
            creacion.Controls.Add(ivacmbx);
            creacion.Controls.Add(categoriacmbx);
            creacion.Controls.Add(label13);
            creacion.Controls.Add(txtprecio_compra);
            creacion.Controls.Add(txtnombre_prod);
            creacion.Controls.Add(txtcodigo_barras);
            creacion.Controls.Add(txtprecio_venta);
            creacion.Controls.Add(label9);
            creacion.Controls.Add(label8);
            creacion.Controls.Add(label4);
            creacion.Controls.Add(label7);
            creacion.Controls.Add(txtcodigo_producto);
            creacion.Controls.Add(label5);
            creacion.Controls.Add(label3);
            creacion.Controls.Add(label10);
            creacion.Controls.Add(label14);
            creacion.Controls.Add(label15);
            creacion.Controls.Add(estadochk);
            creacion.Controls.Add(codigobarrarandombtn);
            creacion.Controls.Add(button2);
            creacion.Location = new Point(4, 30);
            creacion.Name = "creacion";
            creacion.Padding = new Padding(3);
            creacion.Size = new Size(839, 593);
            creacion.TabIndex = 1;
            creacion.Text = "Creacion";
            // 
            // codigorandombtn
            // 
            codigorandombtn.ForeColor = Color.Black;
            codigorandombtn.Image = Properties.Resources.barajar;
            codigorandombtn.Location = new Point(184, 98);
            codigorandombtn.Name = "codigorandombtn";
            codigorandombtn.Size = new Size(28, 29);
            codigorandombtn.TabIndex = 73;
            codigorandombtn.UseVisualStyleBackColor = true;
            codigorandombtn.Click += codigorandombtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(imagenprod);
            panel2.Controls.Add(seleccionimagenbtn);
            panel2.Location = new Point(603, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 265);
            panel2.TabIndex = 72;
            // 
            // imagenprod
            // 
            imagenprod.ErrorImage = Properties.Resources.paisaje;
            imagenprod.Image = Properties.Resources.paisaje;
            imagenprod.InitialImage = Properties.Resources.paisaje;
            imagenprod.Location = new Point(9, 9);
            imagenprod.Name = "imagenprod";
            imagenprod.Size = new Size(181, 181);
            imagenprod.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenprod.TabIndex = 13;
            imagenprod.TabStop = false;
            // 
            // seleccionimagenbtn
            // 
            seleccionimagenbtn.BackColor = Color.Lime;
            seleccionimagenbtn.Enabled = false;
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(guardarbtn);
            panel4.Controls.Add(limpiarbtn);
            panel4.Location = new Point(206, 477);
            panel4.Name = "panel4";
            panel4.Size = new Size(426, 74);
            panel4.TabIndex = 71;
            // 
            // guardarbtn
            // 
            guardarbtn.ForeColor = Color.Black;
            guardarbtn.Image = Properties.Resources.disco;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(12, 8);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(181, 58);
            guardarbtn.TabIndex = 13;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.ForeColor = Color.Black;
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(233, 8);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(181, 58);
            limpiarbtn.TabIndex = 14;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.actualizar;
            button1.Location = new Point(8, 10);
            button1.Name = "button1";
            button1.Size = new Size(29, 29);
            button1.TabIndex = 70;
            button1.TabStop = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // proveedorcmbx
            // 
            proveedorcmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            proveedorcmbx.FormattingEnabled = true;
            proveedorcmbx.Location = new Point(306, 252);
            proveedorcmbx.Name = "proveedorcmbx";
            proveedorcmbx.Size = new Size(163, 29);
            proveedorcmbx.TabIndex = 67;
            // 
            // ivacmbx
            // 
            ivacmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            ivacmbx.FormattingEnabled = true;
            ivacmbx.Location = new Point(306, 98);
            ivacmbx.Name = "ivacmbx";
            ivacmbx.Size = new Size(163, 29);
            ivacmbx.TabIndex = 64;
            // 
            // categoriacmbx
            // 
            categoriacmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            categoriacmbx.FormattingEnabled = true;
            categoriacmbx.Location = new Point(306, 329);
            categoriacmbx.Name = "categoriacmbx";
            categoriacmbx.Size = new Size(163, 29);
            categoriacmbx.TabIndex = 59;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(283, 9);
            label13.Name = "label13";
            label13.Size = new Size(268, 32);
            label13.TabIndex = 68;
            label13.Text = "Registro de Productos";
            // 
            // txtprecio_compra
            // 
            txtprecio_compra.Location = new Point(16, 252);
            txtprecio_compra.Name = "txtprecio_compra";
            txtprecio_compra.Size = new Size(163, 29);
            txtprecio_compra.TabIndex = 61;
            // 
            // txtnombre_prod
            // 
            txtnombre_prod.Location = new Point(16, 175);
            txtnombre_prod.Name = "txtnombre_prod";
            txtnombre_prod.Size = new Size(163, 29);
            txtnombre_prod.TabIndex = 58;
            txtnombre_prod.TextChanged += txtnombre_prod_TextChanged;
            // 
            // txtcodigo_barras
            // 
            txtcodigo_barras.Location = new Point(306, 175);
            txtcodigo_barras.Name = "txtcodigo_barras";
            txtcodigo_barras.Size = new Size(163, 29);
            txtcodigo_barras.TabIndex = 65;
            // 
            // txtprecio_venta
            // 
            txtprecio_venta.Location = new Point(16, 329);
            txtprecio_venta.Name = "txtprecio_venta";
            txtprecio_venta.Size = new Size(163, 29);
            txtprecio_venta.TabIndex = 62;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(306, 228);
            label9.Name = "label9";
            label9.Size = new Size(94, 21);
            label9.TabIndex = 57;
            label9.Text = "Proveedor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(306, 74);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 55;
            label8.Text = "ITBIS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 228);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 54;
            label4.Text = "Precio de Compra:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(306, 151);
            label7.Name = "label7";
            label7.Size = new Size(143, 21);
            label7.TabIndex = 53;
            label7.Text = "Codigo de Barras:";
            // 
            // txtcodigo_producto
            // 
            txtcodigo_producto.Location = new Point(16, 98);
            txtcodigo_producto.Name = "txtcodigo_producto";
            txtcodigo_producto.Size = new Size(163, 29);
            txtcodigo_producto.TabIndex = 47;
            txtcodigo_producto.TextChanged += txtcodigo_producto_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 305);
            label5.Name = "label5";
            label5.Size = new Size(133, 21);
            label5.TabIndex = 52;
            label5.Text = "Precio de Venta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 151);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 51;
            label3.Text = "Nombre:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(306, 305);
            label10.Name = "label10";
            label10.Size = new Size(88, 21);
            label10.TabIndex = 50;
            label10.Text = "Categoria:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(16, 393);
            label14.Name = "label14";
            label14.Size = new Size(65, 21);
            label14.TabIndex = 49;
            label14.Text = "Estado:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label15.Location = new Point(13, 74);
            label15.Name = "label15";
            label15.Size = new Size(69, 21);
            label15.TabIndex = 48;
            label15.Text = "Codigo:";
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(105, 393);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(72, 25);
            estadochk.TabIndex = 46;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            // 
            // codigobarrarandombtn
            // 
            codigobarrarandombtn.ForeColor = Color.Black;
            codigobarrarandombtn.Image = Properties.Resources.barajar;
            codigobarrarandombtn.Location = new Point(472, 175);
            codigobarrarandombtn.Name = "codigobarrarandombtn";
            codigobarrarandombtn.Size = new Size(28, 29);
            codigobarrarandombtn.TabIndex = 66;
            codigobarrarandombtn.UseVisualStyleBackColor = true;
            codigobarrarandombtn.Click += codigobarrarandombtn_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Image = Properties.Resources.busqueda;
            button2.Location = new Point(476, 329);
            button2.Name = "button2";
            button2.Size = new Size(28, 29);
            button2.TabIndex = 60;
            button2.UseVisualStyleBackColor = true;
            // 
            // ConsProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(847, 627);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsProductos";
            StartPosition = FormStartPosition.Manual;
            Text = "Productos";
            Load += ConsProductos_Load;
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenproducto).EndInit();
            tabControl1.ResumeLayout(false);
            consulta.ResumeLayout(false);
            consulta.PerformLayout();
            creacion.ResumeLayout(false);
            creacion.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagenprod).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label11;
        private Button eliminarbtn;
        private Label label12;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private Button agregar;
        private Button Editar;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox imagenproducto;
        public Button recargarbtn;
        private TabControl tabControl1;
        private TabPage consulta;
        private TabPage creacion;
        private Panel panel2;
        private Button seleccionimagenbtn;
        private Panel panel4;
        private Button guardarbtn;
        private Button limpiarbtn;
        public Button button1;
        private ComboBox proveedorcmbx;
        private ComboBox ivacmbx;
        private ComboBox categoriacmbx;
        private Label label13;
        private TextBox txtprecio_compra;
        private TextBox txtnombre_prod;
        private TextBox txtcodigo_barras;
        private TextBox txtprecio_venta;
        private Label label9;
        private Label label8;
        private Label label4;
        private Label label7;
        private TextBox txtcodigo_producto;
        private Label label5;
        private Label label3;
        private Label label10;
        private Label label14;
        private Label label15;
        private CheckBox estadochk;
        private Button codigobarrarandombtn;
        private Button button2;
        private Button codigorandombtn;
        private PictureBox imagenprod;
    }
}