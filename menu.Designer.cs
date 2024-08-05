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
            departamentosToolStripMenuItem = new ToolStripMenuItem();
            salasToolStripMenuItem = new ToolStripMenuItem();
            mesasToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            usuariolabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            cerrarbtn = new Button();
            configuracionbtn = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.WindowFrame;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(183, 390);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, agregarClientesToolStripMenuItem, agregarCategoriasToolStripMenuItem, medidasToolStripMenuItem, departamentosToolStripMenuItem, salasToolStripMenuItem, mesasToolStripMenuItem });
            toolStripMenuItem1.ForeColor = SystemColors.Control;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(176, 34);
            toolStripMenuItem1.Text = "Mantenimientos";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(229, 34);
            toolStripMenuItem2.Text = "Usuarios";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // agregarClientesToolStripMenuItem
            // 
            agregarClientesToolStripMenuItem.Name = "agregarClientesToolStripMenuItem";
            agregarClientesToolStripMenuItem.Size = new Size(229, 34);
            agregarClientesToolStripMenuItem.Text = "Clientes";
            agregarClientesToolStripMenuItem.Click += agregarClientesToolStripMenuItem_Click;
            // 
            // agregarCategoriasToolStripMenuItem
            // 
            agregarCategoriasToolStripMenuItem.Name = "agregarCategoriasToolStripMenuItem";
            agregarCategoriasToolStripMenuItem.Size = new Size(229, 34);
            agregarCategoriasToolStripMenuItem.Text = "Categorias";
            agregarCategoriasToolStripMenuItem.Click += agregarCategoriasToolStripMenuItem_Click;
            // 
            // medidasToolStripMenuItem
            // 
            medidasToolStripMenuItem.Name = "medidasToolStripMenuItem";
            medidasToolStripMenuItem.Size = new Size(229, 34);
            medidasToolStripMenuItem.Text = "Medidas";
            medidasToolStripMenuItem.Click += medidasToolStripMenuItem_Click;
            // 
            // departamentosToolStripMenuItem
            // 
            departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            departamentosToolStripMenuItem.Size = new Size(229, 34);
            departamentosToolStripMenuItem.Text = "Departamentos";
            departamentosToolStripMenuItem.Click += departamentosToolStripMenuItem_Click;
            // 
            // salasToolStripMenuItem
            // 
            salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            salasToolStripMenuItem.Size = new Size(229, 34);
            salasToolStripMenuItem.Text = "Salas";
            salasToolStripMenuItem.Click += salasToolStripMenuItem_Click;
            // 
            // mesasToolStripMenuItem
            // 
            mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            mesasToolStripMenuItem.Size = new Size(229, 34);
            mesasToolStripMenuItem.Text = "Mesas";
            mesasToolStripMenuItem.Click += mesasToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(186, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(563, 356);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // usuariolabel
            // 
            usuariolabel.AutoSize = true;
            usuariolabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuariolabel.Location = new Point(4, 5);
            usuariolabel.Name = "usuariolabel";
            usuariolabel.Size = new Size(145, 21);
            usuariolabel.TabIndex = 2;
            usuariolabel.Text = "USUARIO ACTUAL: ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(usuariolabel);
            panel1.Location = new Point(198, 357);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 31);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Location = new Point(186, 357);
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
            cerrarbtn.Location = new Point(2, 1);
            cerrarbtn.Name = "cerrarbtn";
            cerrarbtn.Size = new Size(133, 29);
            cerrarbtn.TabIndex = 0;
            cerrarbtn.Text = "Cerrar Sesión";
            cerrarbtn.UseVisualStyleBackColor = false;
            cerrarbtn.Click += cerrarbtn_Click;
            // 
            // configuracionbtn
            // 
            configuracionbtn.Image = Properties.Resources.ajustes;
            configuracionbtn.Location = new Point(704, 0);
            configuracionbtn.Name = "configuracionbtn";
            configuracionbtn.Size = new Size(45, 38);
            configuracionbtn.TabIndex = 6;
            configuracionbtn.UseVisualStyleBackColor = true;
            configuracionbtn.Click += configuracionbtn_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(750, 390);
            Controls.Add(configuracionbtn);
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
        }

        #endregion
        private ToolStripMenuItem toolStripMenuItem1;
        private PictureBox pictureBox1;
        public MenuStrip menuStrip1;
        private ToolStripMenuItem agregarClientesToolStripMenuItem;
        private ToolStripMenuItem agregarCategoriasToolStripMenuItem;
        public Label usuariolabel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button cerrarbtn;
        public ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem medidasToolStripMenuItem;
        private ToolStripMenuItem departamentosToolStripMenuItem;
        private ToolStripMenuItem salasToolStripMenuItem;
        private ToolStripMenuItem mesasToolStripMenuItem;
        private Button configuracionbtn;
    }
}