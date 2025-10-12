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
            label11 = new Label();
            eliminarbtn = new Button();
            label12 = new Label();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            label13 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
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
            ((System.ComponentModel.ISupportInitialize)imagenproducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // guardarbtn
            // 
            guardarbtn.ForeColor = Color.Black;
            guardarbtn.Image = Properties.Resources.disco;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(11, 11);
            guardarbtn.Margin = new Padding(3, 4, 3, 4);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(218, 57);
            guardarbtn.TabIndex = 0;
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
            estadochk.Location = new Point(162, 79);
            estadochk.Margin = new Padding(3, 4, 3, 4);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(73, 24);
            estadochk.TabIndex = 1;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 122);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 2;
            label1.Text = "Codigo  -------------";
            // 
            // imagenproducto
            // 
            imagenproducto.Image = Properties.Resources.paisaje;
            imagenproducto.Location = new Point(697, 72);
            imagenproducto.Margin = new Padding(3, 4, 3, 4);
            imagenproducto.Name = "imagenproducto";
            imagenproducto.Size = new Size(169, 159);
            imagenproducto.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenproducto.TabIndex = 3;
            imagenproducto.TabStop = false;
            // 
            // txtcodigo_producto
            // 
            txtcodigo_producto.Location = new Point(162, 118);
            txtcodigo_producto.Margin = new Padding(3, 4, 3, 4);
            txtcodigo_producto.Name = "txtcodigo_producto";
            txtcodigo_producto.Size = new Size(134, 27);
            txtcodigo_producto.TabIndex = 4;
            // 
            // limpiarbtn
            // 
            limpiarbtn.ForeColor = Color.Black;
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(255, 11);
            limpiarbtn.Margin = new Padding(3, 4, 3, 4);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(218, 57);
            limpiarbtn.TabIndex = 0;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 164);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre  ------------";
            // 
            // txtnombre_prod
            // 
            txtnombre_prod.Location = new Point(162, 160);
            txtnombre_prod.Margin = new Padding(3, 4, 3, 4);
            txtnombre_prod.Name = "txtnombre_prod";
            txtnombre_prod.Size = new Size(134, 27);
            txtnombre_prod.TabIndex = 4;
            txtnombre_prod.TextChanged += txtnombre_prod_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 206);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 2;
            label3.Text = "Categoria -----------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(11, 248);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 2;
            label4.Text = "Precio de Compra ---";
            // 
            // txtprecio_compra
            // 
            txtprecio_compra.Location = new Point(162, 245);
            txtprecio_compra.Margin = new Padding(3, 4, 3, 4);
            txtprecio_compra.Name = "txtprecio_compra";
            txtprecio_compra.Size = new Size(134, 27);
            txtprecio_compra.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(354, 80);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 2;
            label5.Text = "Precio de Venta ----";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(354, 122);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 2;
            label6.Text = "Existencia ----------";
            // 
            // txtprecio_venta
            // 
            txtprecio_venta.Location = new Point(496, 76);
            txtprecio_venta.Margin = new Padding(3, 4, 3, 4);
            txtprecio_venta.Name = "txtprecio_venta";
            txtprecio_venta.Size = new Size(134, 27);
            txtprecio_venta.TabIndex = 4;
            // 
            // txtexistencia
            // 
            txtexistencia.Location = new Point(496, 118);
            txtexistencia.Margin = new Padding(3, 4, 3, 4);
            txtexistencia.Name = "txtexistencia";
            txtexistencia.Size = new Size(134, 27);
            txtexistencia.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(354, 206);
            label7.Name = "label7";
            label7.Size = new Size(140, 20);
            label7.TabIndex = 2;
            label7.Text = "Codigo de Barras --";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(354, 164);
            label8.Name = "label8";
            label8.Size = new Size(138, 20);
            label8.TabIndex = 2;
            label8.Text = "ITBIS----------------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(354, 248);
            label9.Name = "label9";
            label9.Size = new Size(141, 20);
            label9.TabIndex = 2;
            label9.Text = "Proveedor ----------";
            // 
            // txtcodigo_barras
            // 
            txtcodigo_barras.Location = new Point(496, 203);
            txtcodigo_barras.Margin = new Padding(3, 4, 3, 4);
            txtcodigo_barras.Name = "txtcodigo_barras";
            txtcodigo_barras.Size = new Size(134, 27);
            txtcodigo_barras.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(11, 80);
            label10.Name = "label10";
            label10.Size = new Size(145, 20);
            label10.TabIndex = 2;
            label10.Text = "Estado: --------------";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(267, 423);
            label11.Name = "label11";
            label11.Size = new Size(334, 41);
            label11.TabIndex = 37;
            label11.Text = "Consulta de Productos";
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(830, 477);
            eliminarbtn.Margin = new Padding(3, 4, 3, 4);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(33, 31);
            eliminarbtn.TabIndex = 36;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(13, 480);
            label12.Name = "label12";
            label12.Size = new Size(89, 23);
            label12.TabIndex = 33;
            label12.Text = "Buscador: ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.AllowUserToDeleteRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(14, 517);
            tabladatos.Margin = new Padding(3, 4, 3, 4);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.RowHeadersWidth = 51;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(850, 189);
            tabladatos.TabIndex = 34;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(104, 479);
            txtbuscador.Margin = new Padding(3, 4, 3, 4);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(721, 27);
            txtbuscador.TabIndex = 35;
            txtbuscador.Text = "(ID, Codigo, Nombre, Categoria, Codigo de Barras, Proveedor)";
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(271, 3);
            label13.Name = "label13";
            label13.Size = new Size(329, 41);
            label13.TabIndex = 37;
            label13.Text = "Registro de Productos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(-5, 412);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 12);
            panel1.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Location = new Point(338, 72);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 211);
            panel2.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Location = new Point(676, 72);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(11, 211);
            panel3.TabIndex = 40;
            // 
            // categoriacmbx
            // 
            categoriacmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            categoriacmbx.FormattingEnabled = true;
            categoriacmbx.Location = new Point(162, 202);
            categoriacmbx.Margin = new Padding(3, 4, 3, 4);
            categoriacmbx.Name = "categoriacmbx";
            categoriacmbx.Size = new Size(134, 28);
            categoriacmbx.TabIndex = 41;
            toolTip1.SetToolTip(categoriacmbx, "Click Derecho\r\npara crear nueva \r\ncategoria");
            categoriacmbx.MouseDown += categoriacmbx_MouseDown;
            // 
            // ivacmbx
            // 
            ivacmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            ivacmbx.FormattingEnabled = true;
            ivacmbx.Location = new Point(496, 160);
            ivacmbx.Margin = new Padding(3, 4, 3, 4);
            ivacmbx.Name = "ivacmbx";
            ivacmbx.Size = new Size(134, 28);
            ivacmbx.TabIndex = 41;
            toolTip1.SetToolTip(ivacmbx, "Click derecho para\r\ncrear un nuevo\r\nimpuesto");
            ivacmbx.MouseDown += ivacmbx_MouseDown;
            // 
            // proveedorcmbx
            // 
            proveedorcmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            proveedorcmbx.FormattingEnabled = true;
            proveedorcmbx.Location = new Point(496, 245);
            proveedorcmbx.Margin = new Padding(3, 4, 3, 4);
            proveedorcmbx.Name = "proveedorcmbx";
            proveedorcmbx.Size = new Size(134, 28);
            proveedorcmbx.TabIndex = 41;
            toolTip1.SetToolTip(proveedorcmbx, "Click Derecho para crear\r\nun nuevo proveedor");
            proveedorcmbx.MouseDown += proveedorcmbx_MouseDown;
            // 
            // codigorandombtn
            // 
            codigorandombtn.ForeColor = Color.Black;
            codigorandombtn.Image = Properties.Resources.barajar;
            codigorandombtn.Location = new Point(301, 118);
            codigorandombtn.Margin = new Padding(3, 4, 3, 4);
            codigorandombtn.Name = "codigorandombtn";
            codigorandombtn.Size = new Size(27, 29);
            codigorandombtn.TabIndex = 0;
            toolTip1.SetToolTip(codigorandombtn, "Genera un codigo\r\naleatorio");
            codigorandombtn.UseVisualStyleBackColor = true;
            codigorandombtn.Click += codigorandombtn_Click;
            // 
            // codigobarrarandombtn
            // 
            codigobarrarandombtn.ForeColor = Color.Black;
            codigobarrarandombtn.Image = Properties.Resources.barajar;
            codigobarrarandombtn.Location = new Point(637, 204);
            codigobarrarandombtn.Margin = new Padding(3, 4, 3, 4);
            codigobarrarandombtn.Name = "codigobarrarandombtn";
            codigobarrarandombtn.Size = new Size(27, 28);
            codigobarrarandombtn.TabIndex = 0;
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
            recargarbtn.Location = new Point(17, 15);
            recargarbtn.Margin = new Padding(3, 4, 3, 4);
            recargarbtn.Name = "recargarbtn";
            recargarbtn.Size = new Size(28, 31);
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
            panel4.Location = new Point(192, 308);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(485, 79);
            panel4.TabIndex = 43;
            // 
            // seleccionimagenbtn
            // 
            seleccionimagenbtn.BackColor = Color.Lime;
            seleccionimagenbtn.ForeColor = Color.Black;
            seleccionimagenbtn.Location = new Point(697, 243);
            seleccionimagenbtn.Margin = new Padding(3, 4, 3, 4);
            seleccionimagenbtn.Name = "seleccionimagenbtn";
            seleccionimagenbtn.Size = new Size(169, 35);
            seleccionimagenbtn.TabIndex = 0;
            seleccionimagenbtn.Text = "Buscar Imagen";
            seleccionimagenbtn.UseVisualStyleBackColor = false;
            seleccionimagenbtn.Click += seleccionimagenbtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MantProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(876, 719);
            Controls.Add(panel4);
            Controls.Add(recargarbtn);
            Controls.Add(proveedorcmbx);
            Controls.Add(ivacmbx);
            Controls.Add(categoriacmbx);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(eliminarbtn);
            Controls.Add(label12);
            Controls.Add(tabladatos);
            Controls.Add(txtbuscador);
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
            Controls.Add(imagenproducto);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(estadochk);
            Controls.Add(seleccionimagenbtn);
            Controls.Add(codigobarrarandombtn);
            Controls.Add(codigorandombtn);
            ForeColor = Color.White;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MantProductos";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Mantenimiento de Productos || Creando...";
            Load += MantProductos_Load;
            ((System.ComponentModel.ISupportInitialize)imagenproducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            panel4.ResumeLayout(false);
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
        private Label label11;
        private Button eliminarbtn;
        private Label label12;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private Label label13;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
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
    }
}