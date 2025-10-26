namespace Proyecto_restaurante
{
    partial class MantProveedor
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
            estadochk = new CheckBox();
            guardarbtn = new Button();
            label1 = new Label();
            txtnumerodoc = new TextBox();
            txtnombre_prov = new TextBox();
            txtnumero_prov = new TextBox();
            txtprovincia = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            limpiarbtn = new Button();
            txtdireccion = new TextBox();
            txtcorreo = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtnombrevendedor = new TextBox();
            label10 = new Label();
            txttelefonovend = new TextBox();
            label11 = new Label();
            label12 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            eliminarbtn = new Button();
            label13 = new Label();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            tipodoccmbx = new ComboBox();
            departamentocmbx = new ComboBox();
            button1 = new Button();
            recargarbtn = new Button();
            toolTip1 = new ToolTip(components);
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(158, 167);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(60, 19);
            estadochk.TabIndex = 0;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.disco;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(14, 497);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(105, 46);
            guardarbtn.TabIndex = 1;
            guardarbtn.Text = "    Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(14, 201);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 3;
            label1.Text = "Tipo de Documento";
            // 
            // txtnumerodoc
            // 
            txtnumerodoc.Enabled = false;
            txtnumerodoc.Location = new Point(168, 227);
            txtnumerodoc.Name = "txtnumerodoc";
            txtnumerodoc.Size = new Size(126, 23);
            txtnumerodoc.TabIndex = 2;
            txtnumerodoc.TextChanged += txtnumerodoc_TextChanged;
            // 
            // txtnombre_prov
            // 
            txtnombre_prov.Location = new Point(168, 256);
            txtnombre_prov.Name = "txtnombre_prov";
            txtnombre_prov.Size = new Size(126, 23);
            txtnombre_prov.TabIndex = 2;
            txtnombre_prov.TextChanged += txtnombre_prov_TextChanged;
            // 
            // txtnumero_prov
            // 
            txtnumero_prov.Location = new Point(168, 285);
            txtnumero_prov.Name = "txtnumero_prov";
            txtnumero_prov.Size = new Size(126, 23);
            txtnumero_prov.TabIndex = 2;
            txtnumero_prov.TextChanged += txtnumero_prov_TextChanged;
            // 
            // txtprovincia
            // 
            txtprovincia.Location = new Point(168, 343);
            txtprovincia.Name = "txtprovincia";
            txtprovincia.Size = new Size(126, 23);
            txtprovincia.TabIndex = 2;
            txtprovincia.TextChanged += txtprovincia_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(14, 230);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "N° Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(14, 259);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre de Proveedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(14, 288);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "N° de telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(14, 346);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 3;
            label5.Text = "Provincia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(14, 317);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 3;
            label6.Text = "Departamento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(103, 168);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 3;
            label7.Text = "Estado: ";
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(189, 497);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(105, 46);
            limpiarbtn.TabIndex = 1;
            limpiarbtn.Text = "    Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(168, 372);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(126, 23);
            txtdireccion.TabIndex = 2;
            txtdireccion.TextChanged += txtdireccion_TextChanged;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(168, 401);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(126, 23);
            txtcorreo.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(14, 375);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 3;
            label8.Text = "Direccion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(14, 404);
            label9.Name = "label9";
            label9.Size = new Size(105, 15);
            label9.TabIndex = 3;
            label9.Text = "Correo electronico";
            // 
            // txtnombrevendedor
            // 
            txtnombrevendedor.Location = new Point(168, 430);
            txtnombrevendedor.Name = "txtnombrevendedor";
            txtnombrevendedor.Size = new Size(126, 23);
            txtnombrevendedor.TabIndex = 2;
            txtnombrevendedor.TextChanged += txtnombrevendedor_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(14, 433);
            label10.Name = "label10";
            label10.Size = new Size(104, 15);
            label10.TabIndex = 3;
            label10.Text = "Nombre Vendedor";
            // 
            // txttelefonovend
            // 
            txttelefonovend.Location = new Point(168, 460);
            txttelefonovend.Name = "txttelefonovend";
            txttelefonovend.Size = new Size(126, 23);
            txttelefonovend.TabIndex = 2;
            txttelefonovend.TextChanged += txttelefonovend_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(14, 463);
            label11.Name = "label11";
            label11.Size = new Size(105, 15);
            label11.TabIndex = 3;
            label11.Text = "Telefono Vendedor";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(558, 9);
            label12.Name = "label12";
            label12.Size = new Size(299, 32);
            label12.TabIndex = 46;
            label12.Text = "Consulta de Proveedores";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(335, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 562);
            panel2.TabIndex = 45;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(336, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 10);
            panel1.TabIndex = 44;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(989, 53);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 23);
            eliminarbtn.TabIndex = 43;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(350, 54);
            label13.Name = "label13";
            label13.Size = new Size(69, 17);
            label13.TabIndex = 40;
            label13.Text = "Buscador: ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.AllowUserToDeleteRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(349, 98);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.RowHeadersWidth = 51;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(669, 452);
            tabladatos.TabIndex = 41;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(431, 53);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(554, 23);
            txtbuscador.TabIndex = 42;
            txtbuscador.Text = "(ID, N° Doc, Nombre, Departamento, Provincia, Direccion, Correo, Nombre Vendedor)";
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(10, 9);
            label14.Name = "label14";
            label14.Size = new Size(294, 32);
            label14.TabIndex = 46;
            label14.Text = "Registro de Proveedores";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.proveedor;
            pictureBox1.Location = new Point(103, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // tipodoccmbx
            // 
            tipodoccmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            tipodoccmbx.FormattingEnabled = true;
            tipodoccmbx.Items.AddRange(new object[] { "RNC", "Cedula" });
            tipodoccmbx.Location = new Point(168, 198);
            tipodoccmbx.Name = "tipodoccmbx";
            tipodoccmbx.Size = new Size(126, 23);
            tipodoccmbx.TabIndex = 48;
            tipodoccmbx.SelectedIndexChanged += tipodoccmbx_SelectedIndexChanged;
            // 
            // departamentocmbx
            // 
            departamentocmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            departamentocmbx.FormattingEnabled = true;
            departamentocmbx.Location = new Point(168, 314);
            departamentocmbx.Name = "departamentocmbx";
            departamentocmbx.Size = new Size(126, 23);
            departamentocmbx.TabIndex = 49;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.cuadrado_norte;
            button1.Location = new Point(300, 314);
            button1.Name = "button1";
            button1.Size = new Size(27, 24);
            button1.TabIndex = 50;
            toolTip1.SetToolTip(button1, "Crear nuevo departamento");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // recargarbtn
            // 
            recargarbtn.Image = Properties.Resources.actualizar;
            recargarbtn.Location = new Point(350, 9);
            recargarbtn.Name = "recargarbtn";
            recargarbtn.Size = new Size(26, 23);
            recargarbtn.TabIndex = 51;
            recargarbtn.TabStop = false;
            toolTip1.SetToolTip(recargarbtn, "Recargar Datos");
            recargarbtn.UseVisualStyleBackColor = true;
            recargarbtn.Click += recargarbtn_Click;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Ayuda";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Red;
            label15.Location = new Point(3, 201);
            label15.Name = "label15";
            label15.Size = new Size(12, 15);
            label15.TabIndex = 52;
            label15.Text = "*";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Red;
            label16.Location = new Point(3, 230);
            label16.Name = "label16";
            label16.Size = new Size(12, 15);
            label16.TabIndex = 52;
            label16.Text = "*";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Red;
            label17.Location = new Point(3, 259);
            label17.Name = "label17";
            label17.Size = new Size(12, 15);
            label17.TabIndex = 52;
            label17.Text = "*";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Red;
            label18.Location = new Point(3, 288);
            label18.Name = "label18";
            label18.Size = new Size(12, 15);
            label18.TabIndex = 52;
            label18.Text = "*";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Red;
            label19.Location = new Point(3, 319);
            label19.Name = "label19";
            label19.Size = new Size(12, 15);
            label19.TabIndex = 52;
            label19.Text = "*";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.Red;
            label20.Location = new Point(3, 346);
            label20.Name = "label20";
            label20.Size = new Size(12, 15);
            label20.TabIndex = 52;
            label20.Text = "*";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.Red;
            label21.Location = new Point(3, 375);
            label21.Name = "label21";
            label21.Size = new Size(12, 15);
            label21.TabIndex = 52;
            label21.Text = "*";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.Red;
            label22.Location = new Point(3, 404);
            label22.Name = "label22";
            label22.Size = new Size(12, 15);
            label22.TabIndex = 52;
            label22.Text = "*";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.Red;
            label23.Location = new Point(3, 433);
            label23.Name = "label23";
            label23.Size = new Size(12, 15);
            label23.TabIndex = 52;
            label23.Text = "*";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = Color.Red;
            label24.Location = new Point(3, 463);
            label24.Name = "label24";
            label24.Size = new Size(12, 15);
            label24.TabIndex = 52;
            label24.Text = "*";
            // 
            // MantProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1024, 554);
            Controls.Add(label24);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(recargarbtn);
            Controls.Add(button1);
            Controls.Add(departamentocmbx);
            Controls.Add(tipodoccmbx);
            Controls.Add(pictureBox1);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(eliminarbtn);
            Controls.Add(label13);
            Controls.Add(tabladatos);
            Controls.Add(txtbuscador);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(txttelefonovend);
            Controls.Add(txtnombrevendedor);
            Controls.Add(txtcorreo);
            Controls.Add(txtdireccion);
            Controls.Add(txtprovincia);
            Controls.Add(txtnumero_prov);
            Controls.Add(txtnombre_prov);
            Controls.Add(txtnumerodoc);
            Controls.Add(limpiarbtn);
            Controls.Add(guardarbtn);
            Controls.Add(estadochk);
            Name = "MantProveedor";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Mantenimiento de Proveedores || Creando...";
            Load += MantProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox estadochk;
        private Button guardarbtn;
        private Label label1;
        private TextBox txtnumerodoc;
        private TextBox txtnombre_prov;
        private TextBox txtnumero_prov;
        private TextBox txtprovincia;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button limpiarbtn;
        private TextBox txtdireccion;
        private TextBox txtcorreo;
        private Label label8;
        private Label label9;
        private TextBox txtnombrevendedor;
        private Label label10;
        private TextBox txttelefonovend;
        private Label label11;
        private Label label12;
        private Panel panel2;
        private Panel panel1;
        private Button eliminarbtn;
        private Label label13;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private Label label14;
        private PictureBox pictureBox1;
        private ComboBox tipodoccmbx;
        private ComboBox departamentocmbx;
        private Button button1;
        public Button recargarbtn;
        private ToolTip toolTip1;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
    }
}