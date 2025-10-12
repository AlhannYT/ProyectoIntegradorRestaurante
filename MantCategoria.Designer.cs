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
            pictureBox1.Location = new Point(147, 75);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(98, 333);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtcategoria
            // 
            txtcategoria.Location = new Point(229, 333);
            txtcategoria.Margin = new Padding(3, 4, 3, 4);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.Size = new Size(182, 27);
            txtcategoria.TabIndex = 2;
            txtcategoria.TextChanged += txtcategoria_TextChanged;
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.disco;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(42, 400);
            guardarbtn.Margin = new Padding(3, 4, 3, 4);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(141, 65);
            guardarbtn.TabIndex = 3;
            guardarbtn.Text = "    Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(242, 400);
            limpiarbtn.Margin = new Padding(3, 4, 3, 4);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(141, 65);
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
            label5.Location = new Point(487, 12);
            label5.Name = "label5";
            label5.Size = new Size(342, 41);
            label5.TabIndex = 32;
            label5.Text = "Consulta de Categorias";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(427, -4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 492);
            panel2.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(433, 145);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 13);
            panel1.TabIndex = 30;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(829, 104);
            eliminarbtn.Margin = new Padding(3, 4, 3, 4);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(33, 29);
            eliminarbtn.TabIndex = 29;
            eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(446, 107);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 26;
            label4.Text = "Buscador: ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(446, 167);
            tabladatos.Margin = new Padding(3, 4, 3, 4);
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.RowHeadersWidth = 51;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(416, 299);
            tabladatos.TabIndex = 27;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(538, 105);
            txtbuscador.Margin = new Padding(3, 4, 3, 4);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(285, 27);
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
            label2.Location = new Point(62, 12);
            label2.Name = "label2";
            label2.Size = new Size(337, 41);
            label2.TabIndex = 33;
            label2.Text = "Registro de Categorias";
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(222, 269);
            estadochk.Margin = new Padding(3, 4, 3, 4);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(73, 24);
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
            label3.Location = new Point(147, 264);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 1;
            label3.Text = "Estado:";
            // 
            // MantCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(870, 481);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "MantCategoria";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
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