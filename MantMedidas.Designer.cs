namespace Proyecto_restaurante
{
    partial class MantMedidas
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
            guardarbtn = new Button();
            limpiarbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            txtabreviatura = new TextBox();
            txtmedida = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            verificarbtn = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            eliminarbtn = new Button();
            label4 = new Label();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            label5 = new Label();
            estadochk = new CheckBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            SuspendLayout();
            // 
            // guardarbtn
            // 
            guardarbtn.Enabled = false;
            guardarbtn.Location = new Point(39, 322);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(121, 44);
            guardarbtn.TabIndex = 0;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Visible = false;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Location = new Point(222, 322);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(121, 44);
            limpiarbtn.TabIndex = 0;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(39, 230);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Abreviatura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(39, 271);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Medida";
            // 
            // txtabreviatura
            // 
            txtabreviatura.Location = new Point(176, 227);
            txtabreviatura.Name = "txtabreviatura";
            txtabreviatura.Size = new Size(167, 23);
            txtabreviatura.TabIndex = 2;
            txtabreviatura.TextChanged += txtabreviatura_TextChanged;
            txtabreviatura.KeyPress += txtabreviatura_KeyPress;
            // 
            // txtmedida
            // 
            txtmedida.Enabled = false;
            txtmedida.Location = new Point(176, 268);
            txtmedida.Name = "txtmedida";
            txtmedida.Size = new Size(167, 23);
            txtmedida.TabIndex = 2;
            txtmedida.TextChanged += txtmedida_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cinta_metrica;
            pictureBox1.Location = new Point(114, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(45, 9);
            label3.Name = "label3";
            label3.Size = new Size(298, 40);
            label3.TabIndex = 1;
            label3.Text = "Registro de Medidas";
            // 
            // verificarbtn
            // 
            verificarbtn.Location = new Point(39, 322);
            verificarbtn.Name = "verificarbtn";
            verificarbtn.Size = new Size(121, 44);
            verificarbtn.TabIndex = 0;
            verificarbtn.Text = "Verificar";
            verificarbtn.UseVisualStyleBackColor = true;
            verificarbtn.Click += verificarbtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(378, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 380);
            panel2.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(385, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 10);
            panel1.TabIndex = 16;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(806, 71);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 24);
            eliminarbtn.TabIndex = 14;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(394, 74);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 11;
            label4.Text = "Buscador: ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(394, 123);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(441, 243);
            tabladatos.TabIndex = 12;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(469, 73);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(331, 23);
            txtbuscador.TabIndex = 13;
            txtbuscador.Text = "(ID, Abreviatura, Nombre)";
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(420, 9);
            label5.Name = "label5";
            label5.Size = new Size(304, 40);
            label5.TabIndex = 18;
            label5.Text = "Consulta de Medidas";
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(188, 190);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(60, 19);
            estadochk.TabIndex = 19;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(136, 191);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 1;
            label6.Text = "Estado: ";
            // 
            // MantMedidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(844, 378);
            Controls.Add(estadochk);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(eliminarbtn);
            Controls.Add(label4);
            Controls.Add(tabladatos);
            Controls.Add(txtbuscador);
            Controls.Add(verificarbtn);
            Controls.Add(pictureBox1);
            Controls.Add(txtmedida);
            Controls.Add(txtabreviatura);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(limpiarbtn);
            Controls.Add(guardarbtn);
            Name = "MantMedidas";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Medidas || Creando...";
            Load += MantMedidas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guardarbtn;
        private Button limpiarbtn;
        private Label label1;
        private Label label2;
        private TextBox txtabreviatura;
        private TextBox txtmedida;
        private PictureBox pictureBox1;
        private Label label3;
        private Button verificarbtn;
        private Panel panel2;
        private Panel panel1;
        private Button eliminarbtn;
        private Label label4;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private Label label5;
        private CheckBox estadochk;
        private Label label6;
    }
}