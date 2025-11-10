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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
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
            panel1.Location = new Point(4, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 67);
            panel1.TabIndex = 0;
            // 
            // fechacompra
            // 
            fechacompra.Enabled = false;
            fechacompra.Format = DateTimePickerFormat.Short;
            fechacompra.Location = new Point(153, 37);
            fechacompra.Name = "fechacompra";
            fechacompra.Size = new Size(106, 23);
            fechacompra.TabIndex = 1;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.nuevo;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(661, 9);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(111, 50);
            limpiarbtn.TabIndex = 0;
            limpiarbtn.Text = "Nuevo";
            limpiarbtn.TextAlign = ContentAlignment.MiddleRight;
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // labelresponsable
            // 
            labelresponsable.AutoSize = true;
            labelresponsable.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelresponsable.ForeColor = SystemColors.Control;
            labelresponsable.Location = new Point(1, 9);
            labelresponsable.Name = "labelresponsable";
            labelresponsable.Size = new Size(217, 21);
            labelresponsable.TabIndex = 1;
            labelresponsable.Text = "Responsable de la compra: ";
            // 
            // comprarbtn
            // 
            comprarbtn.BackColor = Color.FromArgb(128, 255, 128);
            comprarbtn.Enabled = false;
            comprarbtn.Image = Properties.Resources.comprar1;
            comprarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            comprarbtn.Location = new Point(532, 9);
            comprarbtn.Name = "comprarbtn";
            comprarbtn.Size = new Size(111, 50);
            comprarbtn.TabIndex = 0;
            comprarbtn.Text = "Comprar";
            comprarbtn.TextAlign = ContentAlignment.MiddleRight;
            comprarbtn.UseVisualStyleBackColor = false;
            comprarbtn.Click += comprarbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(3, 37);
            label5.Name = "label5";
            label5.Size = new Size(143, 21);
            label5.TabIndex = 1;
            label5.Text = "Fecha de compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(265, 5);
            label4.Name = "label4";
            label4.Size = new Size(263, 32);
            label4.TabIndex = 1;
            label4.Text = "Compra de productos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(tablaproductos);
            panel2.Location = new Point(4, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(559, 275);
            panel2.TabIndex = 0;
            // 
            // tablaproductos
            // 
            tablaproductos.AllowUserToAddRows = false;
            tablaproductos.AllowUserToDeleteRows = false;
            tablaproductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaproductos.Location = new Point(3, 3);
            tablaproductos.MultiSelect = false;
            tablaproductos.Name = "tablaproductos";
            tablaproductos.RowHeadersWidth = 51;
            tablaproductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaproductos.Size = new Size(553, 269);
            tablaproductos.TabIndex = 0;
            tablaproductos.CellClick += tablaproductos_CellClick;
            tablaproductos.CellContentClick += tablaproductos_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(labelcantidad);
            panel3.Controls.Add(labeltotal);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(imagenproducto);
            panel3.Location = new Point(569, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 275);
            panel3.TabIndex = 0;
            // 
            // labelcantidad
            // 
            labelcantidad.AutoSize = true;
            labelcantidad.Font = new Font("Segoe UI", 11.25F);
            labelcantidad.ForeColor = SystemColors.Control;
            labelcantidad.Location = new Point(168, 201);
            labelcantidad.Name = "labelcantidad";
            labelcantidad.Size = new Size(0, 20);
            labelcantidad.TabIndex = 1;
            // 
            // labeltotal
            // 
            labeltotal.AutoSize = true;
            labeltotal.Font = new Font("Segoe UI", 11.25F);
            labeltotal.ForeColor = SystemColors.Control;
            labeltotal.Location = new Point(63, 237);
            labeltotal.Name = "labeltotal";
            labeltotal.Size = new Size(0, 20);
            labeltotal.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 236);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 200);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 1;
            label1.Text = "Cantidad de articulos: ";
            // 
            // imagenproducto
            // 
            imagenproducto.Image = Properties.Resources.paisaje;
            imagenproducto.Location = new Point(12, 12);
            imagenproducto.Name = "imagenproducto";
            imagenproducto.Size = new Size(195, 176);
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
            panel5.Location = new Point(4, 119);
            panel5.Name = "panel5";
            panel5.Size = new Size(784, 44);
            panel5.TabIndex = 0;
            // 
            // numCantidad
            // 
            numCantidad.Font = new Font("Segoe UI", 12F);
            numCantidad.Location = new Point(633, 8);
            numCantidad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(108, 29);
            numCantidad.TabIndex = 1;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtnombre
            // 
            txtnombre.Enabled = false;
            txtnombre.Font = new Font("Segoe UI", 12F);
            txtnombre.Location = new Point(126, 8);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(387, 29);
            txtnombre.TabIndex = 0;
            // 
            // buscarprodbtn
            // 
            buscarprodbtn.Image = Properties.Resources.carrito_de_compras;
            buscarprodbtn.Location = new Point(6, 8);
            buscarprodbtn.Name = "buscarprodbtn";
            buscarprodbtn.Size = new Size(29, 29);
            buscarprodbtn.TabIndex = 0;
            buscarprodbtn.UseVisualStyleBackColor = true;
            buscarprodbtn.Click += buscarprodbtn_Click;
            // 
            // agregarbtn
            // 
            agregarbtn.Enabled = false;
            agregarbtn.Image = Properties.Resources.angulo_hacia_abajo;
            agregarbtn.Location = new Point(747, 8);
            agregarbtn.Name = "agregarbtn";
            agregarbtn.Size = new Size(29, 29);
            agregarbtn.TabIndex = 0;
            agregarbtn.UseVisualStyleBackColor = true;
            agregarbtn.Click += agregarbtn_Click;
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Font = new Font("Segoe UI", 12F);
            txtpreciocompra.Location = new Point(519, 8);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(108, 29);
            txtpreciocompra.TabIndex = 0;
            // 
            // txtcodigo
            // 
            txtcodigo.Enabled = false;
            txtcodigo.Font = new Font("Segoe UI", 12F);
            txtcodigo.Location = new Point(41, 8);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(79, 29);
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
            panelprod.Location = new Point(4, 444);
            panelprod.Name = "panelprod";
            panelprod.Size = new Size(784, 477);
            panelprod.TabIndex = 1;
            panelprod.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(12, 94);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 3;
            label7.Text = "Busqueda: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(253, 15);
            label3.Name = "label3";
            label3.Size = new Size(285, 32);
            label3.TabIndex = 1;
            label3.Text = "Busqueda de productos";
            label3.Click += label3_Click;
            // 
            // txtbusquedapanelprod
            // 
            txtbusquedapanelprod.Location = new Point(78, 91);
            txtbusquedapanelprod.Name = "txtbusquedapanelprod";
            txtbusquedapanelprod.Size = new Size(689, 23);
            txtbusquedapanelprod.TabIndex = 2;
            txtbusquedapanelprod.TextChanged += txtbusquedapanelprod_TextChanged;
            // 
            // salirprodbtn
            // 
            salirprodbtn.Location = new Point(670, 15);
            salirprodbtn.Name = "salirprodbtn";
            salirprodbtn.Size = new Size(98, 44);
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
            tablapanelprod.Location = new Point(12, 120);
            tablapanelprod.MultiSelect = false;
            tablapanelprod.Name = "tablapanelprod";
            tablapanelprod.RowHeadersWidth = 51;
            tablapanelprod.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablapanelprod.Size = new Size(756, 303);
            tablapanelprod.TabIndex = 0;
            tablapanelprod.CellDoubleClick += tablapanelprod_CellDoubleClick;
            // 
            // txtidcompra
            // 
            txtidcompra.Enabled = false;
            txtidcompra.Location = new Point(38, 10);
            txtidcompra.Name = "txtidcompra";
            txtidcompra.Size = new Size(85, 23);
            txtidcompra.TabIndex = 2;
            txtidcompra.TextChanged += txtidcompra_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(7, 11);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 1;
            label6.Text = "N°";
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1518, 932);
            Controls.Add(panelprod);
            Controls.Add(txtidcompra);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
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