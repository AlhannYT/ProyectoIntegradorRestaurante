namespace Proyecto_restaurante
{
    partial class MantMesas
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
            components = new System.ComponentModel.Container();
            guardarbtn = new Button();
            label1 = new Label();
            txtnombreMesa = new TextBox();
            salacmbx = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtNumAsientos = new TextBox();
            limpiarbtn = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            nuevaSalabtn = new Button();
            toolTip1 = new ToolTip(components);
            recargarbtn = new Button();
            label5 = new Label();
            panel2 = new Panel();
            eliminarbtn = new Button();
            label6 = new Label();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            panel1 = new Panel();
            estadochk = new CheckBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            SuspendLayout();
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.disco;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(49, 349);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(121, 43);
            guardarbtn.TabIndex = 0;
            guardarbtn.Text = "    Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(49, 233);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "Sala";
            // 
            // txtnombreMesa
            // 
            txtnombreMesa.Location = new Point(195, 266);
            txtnombreMesa.Name = "txtnombreMesa";
            txtnombreMesa.Size = new Size(121, 23);
            txtnombreMesa.TabIndex = 2;
            txtnombreMesa.TextChanged += txtnombreMesa_TextChanged;
            // 
            // salacmbx
            // 
            salacmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            salacmbx.FormattingEnabled = true;
            salacmbx.Location = new Point(195, 230);
            salacmbx.Name = "salacmbx";
            salacmbx.Size = new Size(121, 23);
            salacmbx.TabIndex = 3;
            toolTip1.SetToolTip(salacmbx, "En caso de no encontrar\r\nla sala que se acaba de\r\nhacer dele click al boton\r\nde \"Recargar\" arriba a la\r\nizquierda");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(49, 269);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Mesa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(49, 307);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 1;
            label3.Text = "Numero de asientos";
            // 
            // txtNumAsientos
            // 
            txtNumAsientos.Location = new Point(195, 304);
            txtNumAsientos.Name = "txtNumAsientos";
            txtNumAsientos.Size = new Size(121, 23);
            txtNumAsientos.TabIndex = 2;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(195, 349);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(121, 43);
            limpiarbtn.TabIndex = 0;
            limpiarbtn.Text = "    Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(55, 9);
            label4.Name = "label4";
            label4.Size = new Size(267, 40);
            label4.TabIndex = 1;
            label4.Text = "Registro de Mesas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cena_de_bodas;
            pictureBox1.Location = new Point(109, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // nuevaSalabtn
            // 
            nuevaSalabtn.Image = Properties.Resources.cuadrado_norte;
            nuevaSalabtn.Location = new Point(322, 230);
            nuevaSalabtn.Name = "nuevaSalabtn";
            nuevaSalabtn.Size = new Size(24, 24);
            nuevaSalabtn.TabIndex = 5;
            toolTip1.SetToolTip(nuevaSalabtn, "Agregar Nueva sala");
            nuevaSalabtn.UseVisualStyleBackColor = true;
            nuevaSalabtn.Click += nuevaSalabtn_Click;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Ayuda";
            // 
            // recargarbtn
            // 
            recargarbtn.Image = Properties.Resources.actualizar;
            recargarbtn.Location = new Point(15, 18);
            recargarbtn.Name = "recargarbtn";
            recargarbtn.Size = new Size(22, 23);
            recargarbtn.TabIndex = 6;
            recargarbtn.TabStop = false;
            toolTip1.SetToolTip(recargarbtn, "Recargar Datos");
            recargarbtn.UseVisualStyleBackColor = true;
            recargarbtn.Click += recargarbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(503, 9);
            label5.Name = "label5";
            label5.Size = new Size(273, 40);
            label5.TabIndex = 24;
            label5.Text = "Consulta de Mesas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(352, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 412);
            panel2.TabIndex = 23;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(875, 73);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 24);
            eliminarbtn.TabIndex = 22;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(368, 76);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 19;
            label6.Text = "Buscador: ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(368, 123);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(536, 270);
            tabladatos.TabIndex = 20;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(438, 73);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(431, 23);
            txtbuscador.TabIndex = 21;
            txtbuscador.Text = "(ID, Nombre, Sala, N° Asientos)";
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(359, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 10);
            panel1.TabIndex = 25;
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(164, 195);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(82, 19);
            estadochk.TabIndex = 26;
            estadochk.Text = "Disponible";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(117, 196);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 1;
            label7.Text = "Estado:";
            // 
            // MantMesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(916, 405);
            Controls.Add(estadochk);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(eliminarbtn);
            Controls.Add(label6);
            Controls.Add(tabladatos);
            Controls.Add(txtbuscador);
            Controls.Add(recargarbtn);
            Controls.Add(nuevaSalabtn);
            Controls.Add(pictureBox1);
            Controls.Add(salacmbx);
            Controls.Add(txtNumAsientos);
            Controls.Add(label3);
            Controls.Add(txtnombreMesa);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(limpiarbtn);
            Controls.Add(guardarbtn);
            Name = "MantMesas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Mesas || Creando...";
            Load += MantMesas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guardarbtn;
        private Label label1;
        private TextBox txtnombreMesa;
        private ComboBox salacmbx;
        private Label label2;
        private Label label3;
        private TextBox txtNumAsientos;
        private Button limpiarbtn;
        private Label label4;
        private PictureBox pictureBox1;
        private Button nuevaSalabtn;
        private ToolTip toolTip1;
        public Button recargarbtn;
        private Label label5;
        private Panel panel2;
        private Button eliminarbtn;
        private Label label6;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private Panel panel1;
        private CheckBox estadochk;
        private Label label7;
    }
}