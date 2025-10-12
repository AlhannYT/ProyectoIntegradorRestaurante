namespace Proyecto_restaurante
{
    partial class Compras
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
            panel1 = new Panel();
            fechacompra = new DateTimePicker();
            limpiarbtn = new Button();
            labelresponsable = new Label();
            comprarbtn = new Button();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            tablaproductos = new DataGridView();
            panel3 = new Panel();
            labelcantidad = new Label();
            labeltotal = new Label();
            label2 = new Label();
            label1 = new Label();
            imagenproducto = new PictureBox();
            panel5 = new Panel();
            numCantidad = new NumericUpDown();
            txtnombre = new TextBox();
            buscarprodbtn = new Button();
            agregarbtn = new Button();
            txtpreciocompra = new TextBox();
            txtcodigo = new TextBox();
            panelprod = new Panel();
            label7 = new Label();
            label3 = new Label();
            txtbusquedapanelprod = new TextBox();
            salirprodbtn = new Button();
            tablapanelprod = new DataGridView();
            txtidcompra = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaproductos).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenproducto).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            panelprod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablapanelprod).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(fechacompra);
            panel1.Controls.Add(limpiarbtn);
            panel1.Controls.Add(labelresponsable);
            panel1.Controls.Add(comprarbtn);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(5, 60);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 89);
            panel1.TabIndex = 0;
            // 
            // fechacompra
            // 
            fechacompra.Enabled = false;
            fechacompra.Format = DateTimePickerFormat.Short;
            fechacompra.Location = new Point(161, 49);
            fechacompra.Margin = new Padding(3, 4, 3, 4);
            fechacompra.Name = "fechacompra";
            fechacompra.Size = new Size(121, 27);
            fechacompra.TabIndex = 1;
            // 
            // limpiarbtn
            // 
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(755, 11);
            limpiarbtn.Margin = new Padding(3, 4, 3, 4);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(127, 67);
            limpiarbtn.TabIndex = 0;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // labelresponsable
            // 
            labelresponsable.AutoSize = true;
            labelresponsable.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelresponsable.ForeColor = SystemColors.Control;
            labelresponsable.Location = new Point(1, 12);
            labelresponsable.Name = "labelresponsable";
            labelresponsable.Size = new Size(253, 25);
            labelresponsable.TabIndex = 1;
            labelresponsable.Text = "Responsable de la compra: ";
            // 
            // comprarbtn
            // 
            comprarbtn.BackColor = Color.FromArgb(128, 255, 128);
            comprarbtn.Enabled = false;
            comprarbtn.Image = Properties.Resources.carrito;
            comprarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            comprarbtn.Location = new Point(608, 11);
            comprarbtn.Margin = new Padding(3, 4, 3, 4);
            comprarbtn.Name = "comprarbtn";
            comprarbtn.Size = new Size(127, 67);
            comprarbtn.TabIndex = 0;
            comprarbtn.Text = "Comprar";
            comprarbtn.TextAlign = ContentAlignment.MiddleRight;
            comprarbtn.UseVisualStyleBackColor = false;
            comprarbtn.Click += comprarbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(3, 49);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 1;
            label5.Text = "Fecha de compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(294, 9);
            label4.Name = "label4";
            label4.Size = new Size(323, 41);
            label4.TabIndex = 1;
            label4.Text = "Compra de productos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(tablaproductos);
            panel2.Location = new Point(5, 217);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(639, 367);
            panel2.TabIndex = 0;
            // 
            // tablaproductos
            // 
            tablaproductos.AllowUserToAddRows = false;
            tablaproductos.AllowUserToDeleteRows = false;
            tablaproductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaproductos.Location = new Point(3, 4);
            tablaproductos.Margin = new Padding(3, 4, 3, 4);
            tablaproductos.MultiSelect = false;
            tablaproductos.Name = "tablaproductos";
            tablaproductos.RowHeadersWidth = 51;
            tablaproductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaproductos.Size = new Size(632, 359);
            tablaproductos.TabIndex = 0;
            tablaproductos.CellClick += tablaproductos_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(labelcantidad);
            panel3.Controls.Add(labeltotal);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(imagenproducto);
            panel3.Location = new Point(650, 217);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 367);
            panel3.TabIndex = 0;
            // 
            // labelcantidad
            // 
            labelcantidad.AutoSize = true;
            labelcantidad.Font = new Font("Segoe UI", 11.25F);
            labelcantidad.ForeColor = SystemColors.Control;
            labelcantidad.Location = new Point(192, 268);
            labelcantidad.Name = "labelcantidad";
            labelcantidad.Size = new Size(0, 25);
            labelcantidad.TabIndex = 1;
            // 
            // labeltotal
            // 
            labeltotal.AutoSize = true;
            labeltotal.Font = new Font("Segoe UI", 11.25F);
            labeltotal.ForeColor = SystemColors.Control;
            labeltotal.Location = new Point(72, 316);
            labeltotal.Name = "labeltotal";
            labeltotal.Size = new Size(0, 25);
            labeltotal.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(14, 315);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 1;
            label2.Text = "Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(14, 267);
            label1.Name = "label1";
            label1.Size = new Size(200, 25);
            label1.TabIndex = 1;
            label1.Text = "Cantidad de articulos: ";
            // 
            // imagenproducto
            // 
            imagenproducto.Image = Properties.Resources.paisaje;
            imagenproducto.Location = new Point(14, 16);
            imagenproducto.Margin = new Padding(3, 4, 3, 4);
            imagenproducto.Name = "imagenproducto";
            imagenproducto.Size = new Size(223, 235);
            imagenproducto.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenproducto.TabIndex = 0;
            imagenproducto.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.Controls.Add(numCantidad);
            panel5.Controls.Add(txtnombre);
            panel5.Controls.Add(buscarprodbtn);
            panel5.Controls.Add(agregarbtn);
            panel5.Controls.Add(txtpreciocompra);
            panel5.Controls.Add(txtcodigo);
            panel5.Location = new Point(5, 159);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(896, 51);
            panel5.TabIndex = 0;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(723, 11);
            numCantidad.Margin = new Padding(3, 4, 3, 4);
            numCantidad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(123, 27);
            numCantidad.TabIndex = 1;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtnombre
            // 
            txtnombre.Enabled = false;
            txtnombre.Location = new Point(142, 11);
            txtnombre.Margin = new Padding(3, 4, 3, 4);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(442, 27);
            txtnombre.TabIndex = 0;
            // 
            // buscarprodbtn
            // 
            buscarprodbtn.Image = Properties.Resources.carrito_de_compras;
            buscarprodbtn.Location = new Point(7, 11);
            buscarprodbtn.Margin = new Padding(3, 4, 3, 4);
            buscarprodbtn.Name = "buscarprodbtn";
            buscarprodbtn.Size = new Size(30, 27);
            buscarprodbtn.TabIndex = 0;
            buscarprodbtn.UseVisualStyleBackColor = true;
            buscarprodbtn.Click += buscarprodbtn_Click;
            // 
            // agregarbtn
            // 
            agregarbtn.Enabled = false;
            agregarbtn.Image = Properties.Resources.angulo_hacia_abajo;
            agregarbtn.Location = new Point(854, 10);
            agregarbtn.Margin = new Padding(3, 4, 3, 4);
            agregarbtn.Name = "agregarbtn";
            agregarbtn.Size = new Size(30, 28);
            agregarbtn.TabIndex = 0;
            agregarbtn.UseVisualStyleBackColor = true;
            agregarbtn.Click += agregarbtn_Click;
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Location = new Point(592, 11);
            txtpreciocompra.Margin = new Padding(3, 4, 3, 4);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(123, 27);
            txtpreciocompra.TabIndex = 0;
            // 
            // txtcodigo
            // 
            txtcodigo.Enabled = false;
            txtcodigo.Location = new Point(44, 11);
            txtcodigo.Margin = new Padding(3, 4, 3, 4);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(90, 27);
            txtcodigo.TabIndex = 0;
            // 
            // panelprod
            // 
            panelprod.BackColor = Color.FromArgb(64, 64, 64);
            panelprod.Controls.Add(label7);
            panelprod.Controls.Add(label3);
            panelprod.Controls.Add(txtbusquedapanelprod);
            panelprod.Controls.Add(salirprodbtn);
            panelprod.Controls.Add(tablapanelprod);
            panelprod.Location = new Point(5, 592);
            panelprod.Margin = new Padding(3, 4, 3, 4);
            panelprod.Name = "panelprod";
            panelprod.Size = new Size(896, 636);
            panelprod.TabIndex = 1;
            panelprod.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(14, 125);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 3;
            label7.Text = "Busqueda: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(289, 20);
            label3.Name = "label3";
            label3.Size = new Size(350, 41);
            label3.TabIndex = 1;
            label3.Text = "Busqueda de productos";
            // 
            // txtbusquedapanelprod
            // 
            txtbusquedapanelprod.Location = new Point(89, 121);
            txtbusquedapanelprod.Margin = new Padding(3, 4, 3, 4);
            txtbusquedapanelprod.Name = "txtbusquedapanelprod";
            txtbusquedapanelprod.Size = new Size(787, 27);
            txtbusquedapanelprod.TabIndex = 2;
            txtbusquedapanelprod.TextChanged += txtbusquedapanelprod_TextChanged;
            // 
            // salirprodbtn
            // 
            salirprodbtn.Location = new Point(766, 20);
            salirprodbtn.Margin = new Padding(3, 4, 3, 4);
            salirprodbtn.Name = "salirprodbtn";
            salirprodbtn.Size = new Size(112, 59);
            salirprodbtn.TabIndex = 1;
            salirprodbtn.Text = "Salir";
            salirprodbtn.UseVisualStyleBackColor = true;
            salirprodbtn.Click += salirprodbtn_Click;
            // 
            // tablapanelprod
            // 
            tablapanelprod.AllowUserToAddRows = false;
            tablapanelprod.AllowUserToDeleteRows = false;
            tablapanelprod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablapanelprod.Location = new Point(14, 160);
            tablapanelprod.Margin = new Padding(3, 4, 3, 4);
            tablapanelprod.MultiSelect = false;
            tablapanelprod.Name = "tablapanelprod";
            tablapanelprod.RowHeadersWidth = 51;
            tablapanelprod.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablapanelprod.Size = new Size(864, 404);
            tablapanelprod.TabIndex = 0;
            tablapanelprod.CellDoubleClick += tablapanelprod_CellDoubleClick;
            // 
            // txtidcompra
            // 
            txtidcompra.Enabled = false;
            txtidcompra.Location = new Point(43, 19);
            txtidcompra.Margin = new Padding(3, 4, 3, 4);
            txtidcompra.Name = "txtidcompra";
            txtidcompra.Size = new Size(97, 27);
            txtidcompra.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(8, 20);
            label6.Name = "label6";
            label6.Size = new Size(33, 25);
            label6.TabIndex = 1;
            label6.Text = "N°";
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(906, 589);
            Controls.Add(panelprod);
            Controls.Add(txtidcompra);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Compras";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Compras";
            Load += Compras_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaproductos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenproducto).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            panelprod.ResumeLayout(false);
            panelprod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablapanelprod).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button limpiarbtn;
        private Button comprarbtn;
        private Panel panel2;
        private Panel panel3;
        private PictureBox imagenproducto;
        private Panel panel5;
        private Label label1;
        private NumericUpDown numCantidad;
        private TextBox txtcodigo;
        private DataGridView tablaproductos;
        private TextBox txtnombre;
        private TextBox txtpreciocompra;
        private Button buscarprodbtn;
        private Button agregarbtn;
        private Label label2;
        private Panel panelprod;
        private TextBox txtbusquedapanelprod;
        private DataGridView tablapanelprod;
        private Button salirprodbtn;
        private Label label3;
        private Label label4;
        private Label labelcantidad;
        private Label labeltotal;
        private DateTimePicker fechacompra;
        private Label label5;
        private TextBox txtidcompra;
        private Label label6;
        private Label labelresponsable;
        private Label label7;
    }
}