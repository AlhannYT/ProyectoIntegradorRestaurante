namespace Proyecto_restaurante
{
    partial class MantCajas
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
            guardatbtn = new Button();
            estadochk = new CheckBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtnombrecaja = new TextBox();
            limpiarbtn = new Button();
            label2 = new Label();
            label3 = new Label();
            txtnumerocaja = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            eliminarbtn = new Button();
            label4 = new Label();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            label6 = new Label();
            label7 = new Label();
            responsablecmbx = new ComboBox();
            recargarbtn = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            SuspendLayout();
            // 
            // guardatbtn
            // 
            guardatbtn.Image = Properties.Resources.disco;
            guardatbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardatbtn.Location = new Point(44, 388);
            guardatbtn.Name = "guardatbtn";
            guardatbtn.Size = new Size(105, 48);
            guardatbtn.TabIndex = 0;
            guardatbtn.Text = "    Guardar";
            guardatbtn.UseVisualStyleBackColor = true;
            guardatbtn.Click += guardatbtn_Click;
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(163, 198);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(60, 19);
            estadochk.TabIndex = 1;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 334);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre de Caja";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cajero_automatico;
            pictureBox1.Location = new Point(102, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtnombrecaja
            // 
            txtnombrecaja.Location = new Point(163, 331);
            txtnombrecaja.Name = "txtnombrecaja";
            txtnombrecaja.Size = new Size(122, 23);
            txtnombrecaja.TabIndex = 4;
            txtnombrecaja.TextChanged += txtnombrecaja_TextChanged;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(180, 388);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(105, 48);
            limpiarbtn.TabIndex = 0;
            limpiarbtn.Text = "    Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(105, 198);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(44, 292);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "N° De Caja";
            // 
            // txtnumerocaja
            // 
            txtnumerocaja.Location = new Point(163, 289);
            txtnumerocaja.Name = "txtnumerocaja";
            txtnumerocaja.Size = new Size(122, 23);
            txtnumerocaja.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(495, 10);
            label5.Name = "label5";
            label5.Size = new Size(215, 32);
            label5.TabIndex = 39;
            label5.Text = "Consulta de Cajas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(320, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 456);
            panel2.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(325, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 10);
            panel1.TabIndex = 37;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(851, 76);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 24);
            eliminarbtn.TabIndex = 36;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(336, 78);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 33;
            label4.Text = "Buscador: ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(336, 126);
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(544, 308);
            tabladatos.TabIndex = 34;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(411, 77);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(434, 23);
            txtbuscador.TabIndex = 35;
            txtbuscador.Text = "(ID, Numero, Nombre Caja)";
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(56, 10);
            label6.Name = "label6";
            label6.Size = new Size(210, 32);
            label6.TabIndex = 39;
            label6.Text = "Registro de Cajas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(44, 247);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 2;
            label7.Text = "Responsable";
            // 
            // responsablecmbx
            // 
            responsablecmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            responsablecmbx.FormattingEnabled = true;
            responsablecmbx.Location = new Point(164, 244);
            responsablecmbx.Name = "responsablecmbx";
            responsablecmbx.Size = new Size(121, 23);
            responsablecmbx.TabIndex = 41;
            toolTip1.SetToolTip(responsablecmbx, "Usuario responsable\r\nde la caja seleccionada");
            // 
            // recargarbtn
            // 
            recargarbtn.Image = Properties.Resources.actualizar;
            recargarbtn.Location = new Point(12, 19);
            recargarbtn.Name = "recargarbtn";
            recargarbtn.Size = new Size(22, 23);
            recargarbtn.TabIndex = 42;
            recargarbtn.TabStop = false;
            toolTip1.SetToolTip(recargarbtn, "Regarcar Datos");
            recargarbtn.UseVisualStyleBackColor = true;
            recargarbtn.Click += recargarbtn_Click;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Ayuda";
            // 
            // MantCajas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(888, 446);
            Controls.Add(recargarbtn);
            Controls.Add(responsablecmbx);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(eliminarbtn);
            Controls.Add(label4);
            Controls.Add(tabladatos);
            Controls.Add(txtbuscador);
            Controls.Add(txtnumerocaja);
            Controls.Add(txtnombrecaja);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(estadochk);
            Controls.Add(limpiarbtn);
            Controls.Add(guardatbtn);
            Name = "MantCajas";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Cajas || Creando...";
            Load += MantCajas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guardatbtn;
        private CheckBox estadochk;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtnombrecaja;
        private Button limpiarbtn;
        private Label label2;
        private Label label3;
        private TextBox txtnumerocaja;
        private Label label5;
        private Panel panel2;
        private Panel panel1;
        private Button eliminarbtn;
        private Label label4;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private Label label6;
        private Label label7;
        private ComboBox responsablecmbx;
        public Button recargarbtn;
        private ToolTip toolTip1;
    }
}