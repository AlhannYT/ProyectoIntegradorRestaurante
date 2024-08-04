namespace Proyecto_restaurante
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            agregarClientesToolStripMenuItem = new ToolStripMenuItem();
            agregarCategoriasToolStripMenuItem = new ToolStripMenuItem();
            medidasToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            usuariolabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            cerrarbtn = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.WindowFrame;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, consultasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(126, 390);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, agregarClientesToolStripMenuItem, agregarCategoriasToolStripMenuItem, medidasToolStripMenuItem });
            toolStripMenuItem1.ForeColor = SystemColors.Control;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(113, 19);
            toolStripMenuItem1.Text = "Mantenimientos";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "Usuarios";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // agregarClientesToolStripMenuItem
            // 
            agregarClientesToolStripMenuItem.Name = "agregarClientesToolStripMenuItem";
            agregarClientesToolStripMenuItem.Size = new Size(180, 22);
            agregarClientesToolStripMenuItem.Text = "Clientes";
            agregarClientesToolStripMenuItem.Click += agregarClientesToolStripMenuItem_Click;
            // 
            // agregarCategoriasToolStripMenuItem
            // 
            agregarCategoriasToolStripMenuItem.Name = "agregarCategoriasToolStripMenuItem";
            agregarCategoriasToolStripMenuItem.Size = new Size(180, 22);
            agregarCategoriasToolStripMenuItem.Text = "Categorias";
            agregarCategoriasToolStripMenuItem.Click += agregarCategoriasToolStripMenuItem_Click;
            // 
            // medidasToolStripMenuItem
            // 
            medidasToolStripMenuItem.Name = "medidasToolStripMenuItem";
            medidasToolStripMenuItem.Size = new Size(180, 22);
            medidasToolStripMenuItem.Text = "Medidas";
            medidasToolStripMenuItem.Click += medidasToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem });
            consultasToolStripMenuItem.ForeColor = SystemColors.Control;
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(113, 19);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(116, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(128, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(621, 356);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // usuariolabel
            // 
            usuariolabel.AutoSize = true;
            usuariolabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuariolabel.Location = new Point(3, 6);
            usuariolabel.Name = "usuariolabel";
            usuariolabel.Size = new Size(145, 21);
            usuariolabel.TabIndex = 2;
            usuariolabel.Text = "USUARIO ACTUAL: ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(usuariolabel);
            panel1.Location = new Point(140, 357);
            panel1.Name = "panel1";
            panel1.Size = new Size(471, 31);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Location = new Point(128, 357);
            panel2.Name = "panel2";
            panel2.Size = new Size(14, 31);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(cerrarbtn);
            panel3.Location = new Point(612, 357);
            panel3.Name = "panel3";
            panel3.Size = new Size(136, 31);
            panel3.TabIndex = 5;
            // 
            // cerrarbtn
            // 
            cerrarbtn.BackColor = Color.Red;
            cerrarbtn.FlatStyle = FlatStyle.Flat;
            cerrarbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cerrarbtn.Location = new Point(2, 0);
            cerrarbtn.Name = "cerrarbtn";
            cerrarbtn.Size = new Size(133, 29);
            cerrarbtn.TabIndex = 0;
            cerrarbtn.Text = "Cerrar Sesión";
            cerrarbtn.UseVisualStyleBackColor = false;
            cerrarbtn.Click += cerrarbtn_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(750, 390);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem toolStripMenuItem1;
        private PictureBox pictureBox1;
        public MenuStrip menuStrip1;
        private ToolStripMenuItem agregarClientesToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem agregarCategoriasToolStripMenuItem;
        public Label usuariolabel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button cerrarbtn;
        public ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem medidasToolStripMenuItem;
    }
}