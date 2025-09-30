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
            salasToolStripMenuItem = new ToolStripMenuItem();
            mesasToolStripMenuItem = new ToolStripMenuItem();
            cajasToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            procesosToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            usuariolabel = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            cerrarbtn = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.WindowFrame;
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, procesosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(857, 47);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, agregarClientesToolStripMenuItem, agregarCategoriasToolStripMenuItem, salasToolStripMenuItem, mesasToolStripMenuItem, cajasToolStripMenuItem, proveedoresToolStripMenuItem, productosToolStripMenuItem });
            toolStripMenuItem1.ForeColor = SystemColors.Control;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(203, 41);
            toolStripMenuItem1.Text = "Mantenimientos";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(234, 36);
            toolStripMenuItem2.Text = "Usuarios";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // agregarClientesToolStripMenuItem
            // 
            agregarClientesToolStripMenuItem.Name = "agregarClientesToolStripMenuItem";
            agregarClientesToolStripMenuItem.Size = new Size(234, 36);
            agregarClientesToolStripMenuItem.Text = "Clientes";
            agregarClientesToolStripMenuItem.Click += agregarClientesToolStripMenuItem_Click;
            // 
            // agregarCategoriasToolStripMenuItem
            // 
            agregarCategoriasToolStripMenuItem.Name = "agregarCategoriasToolStripMenuItem";
            agregarCategoriasToolStripMenuItem.Size = new Size(234, 36);
            agregarCategoriasToolStripMenuItem.Text = "Categorias";
            agregarCategoriasToolStripMenuItem.Click += agregarCategoriasToolStripMenuItem_Click;
            // 
            // salasToolStripMenuItem
            // 
            salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            salasToolStripMenuItem.Size = new Size(234, 36);
            salasToolStripMenuItem.Text = "Salas";
            salasToolStripMenuItem.Click += salasToolStripMenuItem_Click;
            // 
            // mesasToolStripMenuItem
            // 
            mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            mesasToolStripMenuItem.Size = new Size(234, 36);
            mesasToolStripMenuItem.Text = "Mesas";
            mesasToolStripMenuItem.Click += mesasToolStripMenuItem_Click;
            // 
            // cajasToolStripMenuItem
            // 
            cajasToolStripMenuItem.Name = "cajasToolStripMenuItem";
            cajasToolStripMenuItem.Size = new Size(234, 36);
            cajasToolStripMenuItem.Text = "Cajas";
            cajasToolStripMenuItem.Click += cajasToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Enabled = false;
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(234, 36);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Enabled = false;
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(234, 36);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // procesosToolStripMenuItem
            // 
            procesosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pedidosToolStripMenuItem, comprasToolStripMenuItem });
            procesosToolStripMenuItem.ForeColor = Color.White;
            procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            procesosToolStripMenuItem.Size = new Size(121, 41);
            procesosToolStripMenuItem.Text = "Procesos";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Enabled = false;
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(196, 36);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.Enabled = false;
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(196, 36);
            comprasToolStripMenuItem.Text = "Compras";
            comprasToolStripMenuItem.Click += comprasToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 51);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(856, 443);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // usuariolabel
            // 
            usuariolabel.AutoSize = true;
            usuariolabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuariolabel.Location = new Point(0, 23);
            usuariolabel.Name = "usuariolabel";
            usuariolabel.Size = new Size(181, 28);
            usuariolabel.TabIndex = 2;
            usuariolabel.Text = "USUARIO ACTUAL: ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(usuariolabel);
            panel1.Location = new Point(89, 497);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 75);
            panel1.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Lime;
            panel5.Location = new Point(-1, 56);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(602, 8);
            panel5.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(3, 497);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(87, 76);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.perfil_blanco;
            pictureBox2.Location = new Point(2, 3);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(697, 497);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 75);
            panel3.TabIndex = 5;
            // 
            // cerrarbtn
            // 
            cerrarbtn.BackColor = Color.Red;
            cerrarbtn.FlatStyle = FlatStyle.Flat;
            cerrarbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cerrarbtn.Location = new Point(698, 502);
            cerrarbtn.Margin = new Padding(3, 4, 3, 4);
            cerrarbtn.Name = "cerrarbtn";
            cerrarbtn.Size = new Size(152, 67);
            cerrarbtn.TabIndex = 1;
            cerrarbtn.Text = "Cerrar Sesión";
            cerrarbtn.UseVisualStyleBackColor = false;
            cerrarbtn.Click += cerrarbtn_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(857, 577);
            Controls.Add(cerrarbtn);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private ToolStripMenuItem salasToolStripMenuItem;
        private ToolStripMenuItem mesasToolStripMenuItem;
        private ToolStripMenuItem cajasToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private PictureBox pictureBox2;
        private Panel panel5;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem procesosToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem comprasToolStripMenuItem;
    }
}