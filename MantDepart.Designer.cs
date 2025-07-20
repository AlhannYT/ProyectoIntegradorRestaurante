namespace Proyecto_restaurante
{
    partial class MantDepart
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
            txtnombredepa = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            guardarbtn = new Button();
            label2 = new Label();
            txtprovincia = new TextBox();
            limpiarbtn = new Button();
            label3 = new Label();
            eliminarbtn = new Button();
            label4 = new Label();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            estadochk = new CheckBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            SuspendLayout();
            // 
            // txtnombredepa
            // 
            txtnombredepa.Location = new Point(185, 231);
            txtnombredepa.Name = "txtnombredepa";
            txtnombredepa.Size = new Size(161, 23);
            txtnombredepa.TabIndex = 0;
            txtnombredepa.TextChanged += txtnombredepa_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.departamento;
            pictureBox1.Location = new Point(128, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(29, 234);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre Departamento";
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.disco;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(29, 333);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(108, 45);
            guardarbtn.TabIndex = 3;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(29, 277);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Provincia";
            // 
            // txtprovincia
            // 
            txtprovincia.Location = new Point(185, 274);
            txtprovincia.Name = "txtprovincia";
            txtprovincia.Size = new Size(161, 23);
            txtprovincia.TabIndex = 1;
            txtprovincia.TextChanged += txtprovincia_TextChanged;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(238, 333);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(108, 45);
            limpiarbtn.TabIndex = 3;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(29, 9);
            label3.Name = "label3";
            label3.Size = new Size(317, 32);
            label3.TabIndex = 2;
            label3.Text = "Registro de Departamento";
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(803, 53);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 24);
            eliminarbtn.TabIndex = 7;
            eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(385, 55);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 4;
            label4.Text = "Buscador: ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(385, 102);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(447, 276);
            tabladatos.TabIndex = 5;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(456, 53);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(341, 23);
            txtbuscador.TabIndex = 6;
            txtbuscador.Text = "(ID, Nombre, Provincia)";
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(434, 9);
            label5.Name = "label5";
            label5.Size = new Size(322, 32);
            label5.TabIndex = 8;
            label5.Text = "Consulta de Departamento";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(377, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 10);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(369, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 403);
            panel2.TabIndex = 10;
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(185, 177);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(60, 19);
            estadochk.TabIndex = 11;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(137, 177);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 2;
            label6.Text = "Estado:";
            // 
            // MantDepart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(845, 390);
            Controls.Add(estadochk);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(eliminarbtn);
            Controls.Add(label4);
            Controls.Add(tabladatos);
            Controls.Add(txtbuscador);
            Controls.Add(limpiarbtn);
            Controls.Add(guardarbtn);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtprovincia);
            Controls.Add(txtnombredepa);
            Name = "MantDepart";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Departamento || Creando...";
            Load += MantDepart_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnombredepa;
        private PictureBox pictureBox1;
        private Label label1;
        private Button guardarbtn;
        private Label label2;
        private TextBox txtprovincia;
        private Button limpiarbtn;
        private Label label3;
        private Button eliminarbtn;
        private Label label4;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private CheckBox estadochk;
        private Label label6;
    }
}