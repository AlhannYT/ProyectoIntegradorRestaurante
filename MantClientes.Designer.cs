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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(38, 193);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(38, 243);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 0;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(38, 336);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 0;
            label3.Text = "Numero de telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(38, 290);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 0;
            label4.Text = "Cedula";
            // 
            // guardarbtn
            // 
            guardarbtn.Location = new Point(90, 394);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(108, 42);
            guardarbtn.TabIndex = 1;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Location = new Point(234, 394);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(108, 42);
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
            label5.Location = new Point(90, 0);
            label5.Name = "label5";
            label5.Size = new Size(252, 37);
            label5.TabIndex = 0;
            label5.Text = "Registro de Clientes";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(216, 191);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(172, 23);
            txtnombre.TabIndex = 0;
            txtnombre.TextChanged += txtnombre_TextChanged;
            txtnombre.KeyPress += txtnombre_KeyPress;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(216, 241);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(172, 23);
            txtapellido.TabIndex = 2;
            txtapellido.TextChanged += txtapellido_TextChanged;
            txtapellido.KeyPress += txtapellido_KeyPress;
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(216, 288);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(172, 23);
            txtcedula.TabIndex = 2;
            txtcedula.TextChanged += txtcedula_TextChanged;
            txtcedula.KeyPress += txtcedula_KeyPress;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(216, 334);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(172, 23);
            txtnumero.TabIndex = 2;
            txtnumero.TextChanged += txtnumero_TextChanged;
            txtnumero.KeyPress += txtnumero_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(129, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(430, 110);
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(544, 333);
            tabladatos.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(430, 63);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 5;
            label6.Text = "Buscador: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(572, -3);
            label7.Name = "label7";
            label7.Size = new Size(276, 40);
            label7.TabIndex = 7;
            label7.Text = "Consulta de Clientes";
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(498, 62);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(443, 23);
            txtbuscador.TabIndex = 6;
            txtbuscador.Text = "(ID, Nombre, Apellido)";
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.basura;
            eliminarbtn.Location = new Point(945, 61);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 24);
            eliminarbtn.TabIndex = 8;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(423, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 10);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.ForeColor = Color.Red;
            panel2.Location = new Point(414, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 464);
            panel2.TabIndex = 10;
            // 
            // MantClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(980, 455);
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
            Controls.Add(label5);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MantClientes";
            StartPosition = FormStartPosition.CenterScreen;
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
    }
}