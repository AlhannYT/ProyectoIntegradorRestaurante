namespace Proyecto_restaurante
{
    partial class MantCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantCategoria));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtcategoria = new TextBox();
            guardarbtn = new Button();
            limpiarbtn = new Button();
            label5 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            eliminarbtn = new Button();
            label4 = new Label();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            label2 = new Label();
            estadochk = new CheckBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(129, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 248);
            label1.Name = "label1";
            label1.Size = new Size(160, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre de Categoria";
            // 
            // txtcategoria
            // 
            txtcategoria.Location = new Point(200, 250);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.Size = new Size(160, 23);
            txtcategoria.TabIndex = 2;
            txtcategoria.TextChanged += txtcategoria_TextChanged;
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.disco;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(37, 300);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(123, 49);
            guardarbtn.TabIndex = 3;
            guardarbtn.Text = "    Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(212, 300);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(123, 49);
            limpiarbtn.TabIndex = 3;
            limpiarbtn.Text = "     Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(426, 9);
            label5.Name = "label5";
            label5.Size = new Size(277, 32);
            label5.TabIndex = 32;
            label5.Text = "Consulta de Categorias";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(374, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 369);
            panel2.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(379, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 10);
            panel1.TabIndex = 30;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(725, 76);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 24);
            eliminarbtn.TabIndex = 29;
            eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(390, 77);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 26;
            label4.Text = "Buscador: ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(390, 125);
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(364, 224);
            tabladatos.TabIndex = 27;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(465, 76);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(256, 23);
            txtbuscador.TabIndex = 28;
            txtbuscador.Text = "(ID, Nombre Categoria)";
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(54, 9);
            label2.Name = "label2";
            label2.Size = new Size(272, 32);
            label2.TabIndex = 33;
            label2.Text = "Registro de Categorias";
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(194, 202);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(60, 19);
            estadochk.TabIndex = 34;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(129, 198);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 1;
            label3.Text = "Estado:";
            // 
            // MantCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(761, 361);
            Controls.Add(estadochk);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(eliminarbtn);
            Controls.Add(label4);
            Controls.Add(tabladatos);
            Controls.Add(txtbuscador);
            Controls.Add(limpiarbtn);
            Controls.Add(guardarbtn);
            Controls.Add(txtcategoria);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "MantCategoria";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Categoria || Creando...";
            Load += MantCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtcategoria;
        private Button guardarbtn;
        private Button limpiarbtn;
        private Label label5;
        private Panel panel2;
        private Panel panel1;
        private Button eliminarbtn;
        private Label label4;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private Label label2;
        private CheckBox estadochk;
        private Label label3;
    }
}