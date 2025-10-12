namespace Proyecto_restaurante
{
    partial class MantClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantClientes));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            guardarbtn = new Button();
            limpiarbtn = new Button();
            label5 = new Label();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtcedula = new TextBox();
            txtnumero = new TextBox();
            pictureBox1 = new PictureBox();
            tabladatos = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            txtbuscador = new TextBox();
            eliminarbtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            estadochk = new CheckBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(43, 265);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(43, 328);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 0;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(43, 454);
            label3.Name = "label3";
            label3.Size = new Size(189, 28);
            label3.TabIndex = 0;
            label3.Text = "Numero de telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(43, 391);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 0;
            label4.Text = "Cedula";
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.disco;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(103, 525);
            guardarbtn.Margin = new Padding(3, 4, 3, 4);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(123, 56);
            guardarbtn.TabIndex = 1;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(267, 525);
            limpiarbtn.Margin = new Padding(3, 4, 3, 4);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(123, 56);
            limpiarbtn.TabIndex = 1;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(73, 0);
            label5.Name = "label5";
            label5.Size = new Size(317, 46);
            label5.TabIndex = 0;
            label5.Text = "Registro de Clientes";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(247, 263);
            txtnombre.Margin = new Padding(3, 4, 3, 4);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(196, 27);
            txtnombre.TabIndex = 0;
            txtnombre.TextChanged += txtnombre_TextChanged;
            txtnombre.KeyPress += txtnombre_KeyPress;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(247, 326);
            txtapellido.Margin = new Padding(3, 4, 3, 4);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(196, 27);
            txtapellido.TabIndex = 2;
            txtapellido.TextChanged += txtapellido_TextChanged;
            txtapellido.KeyPress += txtapellido_KeyPress;
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(247, 389);
            txtcedula.Margin = new Padding(3, 4, 3, 4);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(196, 27);
            txtcedula.TabIndex = 2;
            txtcedula.TextChanged += txtcedula_TextChanged;
            txtcedula.KeyPress += txtcedula_KeyPress;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(247, 452);
            txtnumero.Margin = new Padding(3, 4, 3, 4);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(196, 27);
            txtnumero.TabIndex = 2;
            txtnumero.TextChanged += txtnumero_TextChanged;
            txtnumero.KeyPress += txtnumero_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(147, 56);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(491, 147);
            tabladatos.Margin = new Padding(3, 4, 3, 4);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.RowHeadersWidth = 51;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(726, 444);
            tabladatos.TabIndex = 4;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(491, 84);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 5;
            label6.Text = "Buscador: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(681, -2);
            label7.Name = "label7";
            label7.Size = new Size(356, 50);
            label7.TabIndex = 7;
            label7.Text = "Consulta de Clientes";
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(583, 83);
            txtbuscador.Margin = new Padding(3, 4, 3, 4);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(591, 27);
            txtbuscador.TabIndex = 6;
            txtbuscador.Text = "(ID, Nombre, Apellido)";
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(1180, 81);
            eliminarbtn.Margin = new Padding(3, 4, 3, 4);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(33, 30);
            eliminarbtn.TabIndex = 8;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(483, 121);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 13);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.ForeColor = Color.Red;
            panel2.Location = new Point(473, -3);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 619);
            panel2.TabIndex = 10;
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(247, 217);
            estadochk.Margin = new Padding(3, 4, 3, 4);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(73, 24);
            estadochk.TabIndex = 11;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(173, 212);
            label8.Name = "label8";
            label8.Size = new Size(75, 28);
            label8.TabIndex = 0;
            label8.Text = "Estado:";
            // 
            // MantClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1226, 607);
            Controls.Add(estadochk);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(eliminarbtn);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtbuscador);
            Controls.Add(tabladatos);
            Controls.Add(pictureBox1);
            Controls.Add(txtnumero);
            Controls.Add(txtcedula);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(limpiarbtn);
            Controls.Add(guardarbtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MantClientes";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Registro de Clientes";
            Load += MantClientes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button guardarbtn;
        private Button limpiarbtn;
        private Label label5;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtcedula;
        private TextBox txtnumero;
        private PictureBox pictureBox1;
        private DataGridView tabladatos;
        private Label label6;
        private Label label7;
        private TextBox txtbuscador;
        private Button eliminarbtn;
        private Panel panel1;
        private Panel panel2;
        private CheckBox estadochk;
        private Label label8;
    }
}