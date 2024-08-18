namespace Proyecto_restaurante
{
    partial class MantSalas
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
            txtnombresala = new TextBox();
            label1 = new Label();
            label2 = new Label();
            limpiarbtn = new Button();
            label5 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            eliminarbtn = new Button();
            label4 = new Label();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            pictureBox1 = new PictureBox();
            estadochk = new CheckBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.disco;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(31, 228);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(102, 45);
            guardarbtn.TabIndex = 0;
            guardarbtn.Text = "     Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // txtnombresala
            // 
            txtnombresala.Location = new Point(179, 182);
            txtnombresala.Name = "txtnombresala";
            txtnombresala.Size = new Size(100, 23);
            txtnombresala.TabIndex = 1;
            txtnombresala.TextChanged += txtnombresala_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(31, 185);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre Sala";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(31, 9);
            label2.Name = "label2";
            label2.Size = new Size(250, 40);
            label2.TabIndex = 2;
            label2.Text = "Registro de Salas";
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(179, 228);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(102, 45);
            limpiarbtn.TabIndex = 0;
            limpiarbtn.Text = "     Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(328, 9);
            label5.Name = "label5";
            label5.Size = new Size(256, 40);
            label5.TabIndex = 25;
            label5.Text = "Consulta de Salas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(302, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 301);
            panel2.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(310, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 10);
            panel1.TabIndex = 23;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(647, 67);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 24);
            eliminarbtn.TabIndex = 22;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(319, 69);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 19;
            label4.Text = "Buscador: ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(317, 118);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(360, 155);
            tabladatos.TabIndex = 20;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(390, 68);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(251, 23);
            txtbuscador.TabIndex = 21;
            txtbuscador.Text = "(ID, Nombre Sala)";
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_sala_de_estar_96;
            pictureBox1.Location = new Point(101, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(156, 150);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(60, 19);
            estadochk.TabIndex = 27;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(105, 151);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Estado:";
            // 
            // MantSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(688, 285);
            Controls.Add(estadochk);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(eliminarbtn);
            Controls.Add(label4);
            Controls.Add(tabladatos);
            Controls.Add(txtbuscador);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtnombresala);
            Controls.Add(limpiarbtn);
            Controls.Add(guardarbtn);
            Name = "MantSalas";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Salas || Creando...";
            Load += MantSalas_Load;
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guardarbtn;
        private TextBox txtnombresala;
        private Label label1;
        private Label label2;
        private Button limpiarbtn;
        private Label label5;
        private Panel panel2;
        private Panel panel1;
        private Button eliminarbtn;
        private Label label4;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private PictureBox pictureBox1;
        private CheckBox estadochk;
        private Label label3;
    }
}