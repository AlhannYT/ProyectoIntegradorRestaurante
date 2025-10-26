namespace Proyecto_restaurante
{
    partial class ConsProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsProveedor));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            filtro = new CheckBox();
            label11 = new Label();
            clienteimg = new PictureBox();
            label3 = new Label();
            Editar = new Button();
            agregar = new Button();
            recargarbtn = new Button();
            label12 = new Label();
            eliminarbtn = new Button();
            txtbuscador = new TextBox();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            limpiarbtn = new Button();
            guardarbtn = new Button();
            departamentocmbx = new ComboBox();
            tipodoccmbx = new ComboBox();
            label1 = new Label();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label13 = new Label();
            label14 = new Label();
            txttelefonovend = new TextBox();
            txtnombrevendedor = new TextBox();
            txtcorreo = new TextBox();
            txtdireccion = new TextBox();
            txtprovincia = new TextBox();
            txtnumero_prov = new TextBox();
            txtnombre_prov = new TextBox();
            txtnumerodoc = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clienteimg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 580);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.WindowFrame;
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(filtro);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(clienteimg);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(Editar);
            tabPage1.Controls.Add(agregar);
            tabPage1.Controls.Add(recargarbtn);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(eliminarbtn);
            tabPage1.Controls.Add(txtbuscador);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(906, 546);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consultar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Image = Properties.Resources.busqueda;
            label2.Location = new Point(619, 66);
            label2.Name = "label2";
            label2.Size = new Size(18, 21);
            label2.TabIndex = 63;
            label2.Text = "  ";
            // 
            // filtro
            // 
            filtro.AutoSize = true;
            filtro.Checked = true;
            filtro.CheckState = CheckState.Checked;
            filtro.Cursor = Cursors.Hand;
            filtro.Font = new Font("Segoe UI", 13F);
            filtro.Image = Properties.Resources.sicheck;
            filtro.Location = new Point(656, 62);
            filtro.Name = "filtro";
            filtro.Size = new Size(41, 29);
            filtro.TabIndex = 62;
            filtro.Text = "  ";
            filtro.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(741, 421);
            label11.Name = "label11";
            label11.Size = new Size(107, 21);
            label11.TabIndex = 61;
            label11.Text = "RNC/Cedula:";
            // 
            // clienteimg
            // 
            clienteimg.ErrorImage = Properties.Resources.perfilcliente;
            clienteimg.Image = Properties.Resources.perfilcliente;
            clienteimg.InitialImage = Properties.Resources.perfilcliente;
            clienteimg.Location = new Point(742, 255);
            clienteimg.Name = "clienteimg";
            clienteimg.Size = new Size(158, 158);
            clienteimg.SizeMode = PictureBoxSizeMode.StretchImage;
            clienteimg.TabIndex = 60;
            clienteimg.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(764, 59);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 59;
            label3.Text = "Acciones";
            // 
            // Editar
            // 
            Editar.Image = Properties.Resources.editarcliente1;
            Editar.Location = new Point(741, 178);
            Editar.Name = "Editar";
            Editar.Size = new Size(159, 72);
            Editar.TabIndex = 57;
            Editar.Text = "Editar";
            Editar.TextAlign = ContentAlignment.BottomCenter;
            Editar.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            agregar.Image = Properties.Resources.cliente1;
            agregar.Location = new Point(741, 101);
            agregar.Name = "agregar";
            agregar.Size = new Size(159, 72);
            agregar.TabIndex = 58;
            agregar.Text = "Nuevo";
            agregar.TextAlign = ContentAlignment.BottomCenter;
            agregar.UseVisualStyleBackColor = true;
            // 
            // recargarbtn
            // 
            recargarbtn.Image = Properties.Resources.actualizar;
            recargarbtn.Location = new Point(8, 6);
            recargarbtn.Name = "recargarbtn";
            recargarbtn.Size = new Size(29, 29);
            recargarbtn.TabIndex = 56;
            recargarbtn.TabStop = false;
            recargarbtn.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(304, 6);
            label12.Name = "label12";
            label12.Size = new Size(299, 32);
            label12.TabIndex = 55;
            label12.Text = "Consulta de Proveedores";
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(706, 62);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 29);
            eliminarbtn.TabIndex = 54;
            eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(8, 62);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(634, 29);
            txtbuscador.TabIndex = 53;
            txtbuscador.Text = "(ID, Nombre)";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(729, 439);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.WindowFrame;
            tabPage2.Controls.Add(limpiarbtn);
            tabPage2.Controls.Add(guardarbtn);
            tabPage2.Controls.Add(departamentocmbx);
            tabPage2.Controls.Add(tipodoccmbx);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(txttelefonovend);
            tabPage2.Controls.Add(txtnombrevendedor);
            tabPage2.Controls.Add(txtcorreo);
            tabPage2.Controls.Add(txtdireccion);
            tabPage2.Controls.Add(txtprovincia);
            tabPage2.Controls.Add(txtnumero_prov);
            tabPage2.Controls.Add(txtnombre_prov);
            tabPage2.Controls.Add(txtnumerodoc);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(906, 546);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Creacion";
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(472, 462);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(141, 62);
            limpiarbtn.TabIndex = 70;
            limpiarbtn.Text = "    Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.disco;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(297, 462);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(134, 62);
            guardarbtn.TabIndex = 71;
            guardarbtn.Text = "    Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            // 
            // departamentocmbx
            // 
            departamentocmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            departamentocmbx.FormattingEnabled = true;
            departamentocmbx.Location = new Point(21, 393);
            departamentocmbx.Name = "departamentocmbx";
            departamentocmbx.Size = new Size(126, 29);
            departamentocmbx.TabIndex = 69;
            // 
            // tipodoccmbx
            // 
            tipodoccmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            tipodoccmbx.FormattingEnabled = true;
            tipodoccmbx.Items.AddRange(new object[] { "RNC", "Cedula" });
            tipodoccmbx.Location = new Point(21, 65);
            tipodoccmbx.Name = "tipodoccmbx";
            tipodoccmbx.Size = new Size(126, 29);
            tipodoccmbx.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(222, 369);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 66;
            label1.Text = "Telefono Vendedor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(222, 284);
            label10.Name = "label10";
            label10.Size = new Size(151, 21);
            label10.TabIndex = 65;
            label10.Text = "Nombre Vendedor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(222, 204);
            label9.Name = "label9";
            label9.Size = new Size(151, 21);
            label9.TabIndex = 64;
            label9.Text = "Correo electronico";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(21, 369);
            label6.Name = "label6";
            label6.Size = new Size(121, 21);
            label6.TabIndex = 63;
            label6.Text = "Departamento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(222, 127);
            label8.Name = "label8";
            label8.Size = new Size(83, 21);
            label8.TabIndex = 62;
            label8.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(222, 41);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 61;
            label5.Text = "Provincia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(21, 284);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 67;
            label4.Text = "N° de telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(21, 204);
            label7.Name = "label7";
            label7.Size = new Size(179, 21);
            label7.TabIndex = 60;
            label7.Text = "Nombre de Proveedor";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(21, 127);
            label13.Name = "label13";
            label13.Size = new Size(123, 21);
            label13.TabIndex = 59;
            label13.Text = "N° Documento";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(21, 41);
            label14.Name = "label14";
            label14.Size = new Size(161, 21);
            label14.TabIndex = 58;
            label14.Text = "Tipo de Documento";
            // 
            // txttelefonovend
            // 
            txttelefonovend.Location = new Point(222, 393);
            txttelefonovend.Name = "txttelefonovend";
            txttelefonovend.Size = new Size(126, 29);
            txttelefonovend.TabIndex = 56;
            // 
            // txtnombrevendedor
            // 
            txtnombrevendedor.Location = new Point(222, 308);
            txtnombrevendedor.Name = "txtnombrevendedor";
            txtnombrevendedor.Size = new Size(126, 29);
            txtnombrevendedor.TabIndex = 55;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(222, 228);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(126, 29);
            txtcorreo.TabIndex = 54;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(222, 151);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(126, 29);
            txtdireccion.TabIndex = 53;
            // 
            // txtprovincia
            // 
            txtprovincia.Location = new Point(222, 65);
            txtprovincia.Name = "txtprovincia";
            txtprovincia.Size = new Size(126, 29);
            txtprovincia.TabIndex = 52;
            // 
            // txtnumero_prov
            // 
            txtnumero_prov.Location = new Point(21, 308);
            txtnumero_prov.Name = "txtnumero_prov";
            txtnumero_prov.Size = new Size(126, 29);
            txtnumero_prov.TabIndex = 51;
            // 
            // txtnombre_prov
            // 
            txtnombre_prov.Location = new Point(21, 228);
            txtnombre_prov.Name = "txtnombre_prov";
            txtnombre_prov.Size = new Size(126, 29);
            txtnombre_prov.TabIndex = 57;
            // 
            // txtnumerodoc
            // 
            txtnumerodoc.Enabled = false;
            txtnumerodoc.Location = new Point(21, 151);
            txtnumerodoc.Name = "txtnumerodoc";
            txtnumerodoc.Size = new Size(126, 29);
            txtnumerodoc.TabIndex = 50;
            // 
            // ConsProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(914, 580);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConsProveedor";
            Text = "Proveedores";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clienteimg).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        public Button recargarbtn;
        private Label label12;
        private Button eliminarbtn;
        private TextBox txtbuscador;
        private Label label11;
        private PictureBox clienteimg;
        private Label label3;
        private Button Editar;
        private Button agregar;
        private CheckBox filtro;
        private Label label2;
        private ComboBox departamentocmbx;
        private ComboBox tipodoccmbx;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label6;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label13;
        private Label label14;
        private TextBox txttelefonovend;
        private TextBox txtnombrevendedor;
        private TextBox txtcorreo;
        private TextBox txtdireccion;
        private TextBox txtprovincia;
        private TextBox txtnumero_prov;
        private TextBox txtnombre_prov;
        private TextBox txtnumerodoc;
        private Button limpiarbtn;
        private Button guardarbtn;
    }
}