namespace Proyecto_restaurante
{
    partial class ConsProductos
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
            label11 = new Label();
            eliminarbtn = new Button();
            label12 = new Label();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            agregar = new Button();
            Editar = new Button();
            panel1 = new Panel();
            label2 = new Label();
            imagenproducto = new PictureBox();
            label1 = new Label();
            recargarbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenproducto).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(284, 4);
            label11.Name = "label11";
            label11.Size = new Size(273, 32);
            label11.TabIndex = 42;
            label11.Text = "Consulta de Productos";
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(634, 51);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 24);
            eliminarbtn.TabIndex = 41;
            eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(7, 52);
            label12.Name = "label12";
            label12.Size = new Size(69, 17);
            label12.TabIndex = 38;
            label12.Text = "Buscador: ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.AllowUserToDeleteRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(7, 80);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.RowHeadersWidth = 51;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(656, 499);
            tabladatos.TabIndex = 39;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(75, 51);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(554, 23);
            txtbuscador.TabIndex = 40;
            txtbuscador.Text = "(ID, Codigo, Nombre, Categoria, Codigo de Barras, Proveedor)";
            // 
            // agregar
            // 
            agregar.Image = Properties.Resources.producto;
            agregar.Location = new Point(671, 82);
            agregar.Name = "agregar";
            agregar.Size = new Size(159, 72);
            agregar.TabIndex = 43;
            agregar.Text = "Nuevo";
            agregar.TextAlign = ContentAlignment.BottomCenter;
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // Editar
            // 
            Editar.Image = Properties.Resources.producto;
            Editar.Location = new Point(671, 160);
            Editar.Name = "Editar";
            Editar.Size = new Size(159, 72);
            Editar.TabIndex = 43;
            Editar.Text = "Editar";
            Editar.TextAlign = ContentAlignment.BottomCenter;
            Editar.UseVisualStyleBackColor = true;
            Editar.Click += Editar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(imagenproducto);
            panel1.Location = new Point(666, 236);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 343);
            panel1.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(7, 6);
            label2.Name = "label2";
            label2.Size = new Size(155, 64);
            label2.TabIndex = 46;
            label2.Text = "Informacion\r\n    General";
            // 
            // imagenproducto
            // 
            imagenproducto.Location = new Point(5, 76);
            imagenproducto.Name = "imagenproducto";
            imagenproducto.Size = new Size(159, 144);
            imagenproducto.TabIndex = 0;
            imagenproducto.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(694, 45);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 45;
            label1.Text = "Acciones";
            // 
            // recargarbtn
            // 
            recargarbtn.Image = Properties.Resources.actualizar;
            recargarbtn.Location = new Point(5, 9);
            recargarbtn.Name = "recargarbtn";
            recargarbtn.Size = new Size(24, 23);
            recargarbtn.TabIndex = 46;
            recargarbtn.TabStop = false;
            recargarbtn.UseVisualStyleBackColor = true;
            recargarbtn.Click += recargarbtn_Click;
            // 
            // ConsProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(841, 585);
            Controls.Add(recargarbtn);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(Editar);
            Controls.Add(agregar);
            Controls.Add(label11);
            Controls.Add(eliminarbtn);
            Controls.Add(label12);
            Controls.Add(tabladatos);
            Controls.Add(txtbuscador);
            Name = "ConsProductos";
            StartPosition = FormStartPosition.Manual;
            Text = "Consulta de Productos";
            Load += ConsProductos_Load;
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenproducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Button eliminarbtn;
        private Label label12;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private Button agregar;
        private Button Editar;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox imagenproducto;
        public Button recargarbtn;
    }
}