namespace Proyecto_restaurante
{
    partial class MantMonedas
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
            button1 = new Button();
            limpiarbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtnombremoneda = new TextBox();
            txtsiglasmoneda = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            eliminarbtn = new Button();
            label4 = new Label();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            label3 = new Label();
            label6 = new Label();
            txtsimbolomon = new TextBox();
            panel1 = new Panel();
            estadochk = new CheckBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = Properties.Resources.disco;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(67, 371);
            button1.Name = "button1";
            button1.Size = new Size(128, 45);
            button1.TabIndex = 0;
            button1.Text = "     Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(242, 371);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(128, 45);
            limpiarbtn.TabIndex = 0;
            limpiarbtn.Text = "     Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(67, 231);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre Moneda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(67, 273);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Siglas de la Moneda";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.billete_de_banco;
            pictureBox1.Location = new Point(134, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtnombremoneda
            // 
            txtnombremoneda.Location = new Point(221, 228);
            txtnombremoneda.Name = "txtnombremoneda";
            txtnombremoneda.Size = new Size(149, 23);
            txtnombremoneda.TabIndex = 3;
            txtnombremoneda.TextChanged += txtnombremoneda_TextChanged;
            // 
            // txtsiglasmoneda
            // 
            txtsiglasmoneda.Location = new Point(221, 270);
            txtsiglasmoneda.Name = "txtsiglasmoneda";
            txtsiglasmoneda.Size = new Size(149, 23);
            txtsiglasmoneda.TabIndex = 3;
            txtsiglasmoneda.TextChanged += txtsiglasmoneda_TextChanged;
            txtsiglasmoneda.KeyPress += txtsiglasmoneda_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(579, 9);
            label5.Name = "label5";
            label5.Size = new Size(314, 40);
            label5.TabIndex = 31;
            label5.Text = "Consulta de Monedas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(442, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 435);
            panel2.TabIndex = 30;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(979, 63);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 24);
            eliminarbtn.TabIndex = 29;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(463, 66);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 26;
            label4.Text = "Buscador: ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(463, 120);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(545, 300);
            tabladatos.TabIndex = 27;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(538, 63);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(435, 23);
            txtbuscador.TabIndex = 28;
            txtbuscador.Text = "(ID, Nombre, Siglas)";
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(29, 9);
            label3.Name = "label3";
            label3.Size = new Size(407, 40);
            label3.TabIndex = 32;
            label3.Text = "Mantenimiento de Monedas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(67, 318);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 1;
            label6.Text = "Simbolo";
            // 
            // txtsimbolomon
            // 
            txtsimbolomon.Location = new Point(221, 315);
            txtsimbolomon.Name = "txtsimbolomon";
            txtsimbolomon.Size = new Size(149, 23);
            txtsimbolomon.TabIndex = 3;
            txtsimbolomon.KeyPress += txtsimbolomon_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(449, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 10);
            panel1.TabIndex = 24;
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(210, 194);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(60, 19);
            estadochk.TabIndex = 33;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(150, 195);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 1;
            label7.Text = "Estado:";
            // 
            // MantMonedas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1018, 432);
            Controls.Add(estadochk);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(eliminarbtn);
            Controls.Add(label4);
            Controls.Add(tabladatos);
            Controls.Add(txtbuscador);
            Controls.Add(txtsimbolomon);
            Controls.Add(txtsiglasmoneda);
            Controls.Add(txtnombremoneda);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(limpiarbtn);
            Controls.Add(button1);
            Name = "MantMonedas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Monedas || Creando...";
            Load += MantMonedas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button limpiarbtn;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtnombremoneda;
        private TextBox txtsiglasmoneda;
        private Label label5;
        private Panel panel2;
        private Button eliminarbtn;
        private Label label4;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private Label label3;
        private Label label6;
        private TextBox txtsimbolomon;
        private Panel panel1;
        private CheckBox estadochk;
        private Label label7;
    }
}