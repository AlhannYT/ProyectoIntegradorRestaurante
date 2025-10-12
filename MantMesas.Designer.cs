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
            guardarbtn.Location = new Point(56, 465);
            guardarbtn.Margin = new Padding(3, 4, 3, 4);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(138, 57);
            guardarbtn.TabIndex = 0;
            guardarbtn.Text = "    Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(56, 311);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 1;
            label1.Text = "Sala";
            // 
            // txtnombreMesa
            // 
            txtnombreMesa.Location = new Point(223, 355);
            txtnombreMesa.Margin = new Padding(3, 4, 3, 4);
            txtnombreMesa.Name = "txtnombreMesa";
            txtnombreMesa.Size = new Size(138, 27);
            txtnombreMesa.TabIndex = 2;
            txtnombreMesa.TextChanged += txtnombreMesa_TextChanged;
            // 
            // salacmbx
            // 
            salacmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            salacmbx.FormattingEnabled = true;
            salacmbx.Location = new Point(223, 307);
            salacmbx.Margin = new Padding(3, 4, 3, 4);
            salacmbx.Name = "salacmbx";
            salacmbx.Size = new Size(138, 28);
            salacmbx.TabIndex = 3;
            toolTip1.SetToolTip(salacmbx, "En caso de no encontrar\r\nla sala que se acaba de\r\nhacer dele click al boton\r\nde \"Recargar\" arriba a la\r\nizquierda");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(56, 359);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre Mesa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(56, 409);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 1;
            label3.Text = "Numero de asientos";
            // 
            // txtNumAsientos
            // 
            txtNumAsientos.Location = new Point(223, 405);
            txtNumAsientos.Margin = new Padding(3, 4, 3, 4);
            txtNumAsientos.Name = "txtNumAsientos";
            txtNumAsientos.Size = new Size(138, 27);
            txtNumAsientos.TabIndex = 2;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(223, 465);
            limpiarbtn.Margin = new Padding(3, 4, 3, 4);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(138, 57);
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
            label4.Location = new Point(63, 12);
            label4.Name = "label4";
            label4.Size = new Size(337, 50);
            label4.TabIndex = 1;
            label4.Text = "Registro de Mesas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cena_de_bodas;
            pictureBox1.Location = new Point(125, 83);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // nuevaSalabtn
            // 
            nuevaSalabtn.Image = Properties.Resources.cuadrado_norte;
            nuevaSalabtn.Location = new Point(368, 306);
            nuevaSalabtn.Margin = new Padding(3, 4, 3, 4);
            nuevaSalabtn.Name = "nuevaSalabtn";
            nuevaSalabtn.Size = new Size(27, 31);
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
            recargarbtn.Location = new Point(17, 24);
            recargarbtn.Margin = new Padding(3, 4, 3, 4);
            recargarbtn.Name = "recargarbtn";
            recargarbtn.Size = new Size(28, 31);
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
            label5.Location = new Point(575, 12);
            label5.Name = "label5";
            label5.Size = new Size(343, 50);
            label5.TabIndex = 24;
            label5.Text = "Consulta de Mesas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(402, 1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 549);
            panel2.TabIndex = 23;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(1000, 97);
            eliminarbtn.Margin = new Padding(3, 4, 3, 4);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(33, 32);
            eliminarbtn.TabIndex = 22;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(421, 99);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 19;
            label6.Text = "Buscador: ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(421, 164);
            tabladatos.Margin = new Padding(3, 4, 3, 4);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.RowHeadersWidth = 51;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(613, 360);
            tabladatos.TabIndex = 20;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(512, 97);
            txtbuscador.Margin = new Padding(3, 4, 3, 4);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(482, 27);
            txtbuscador.TabIndex = 21;
            txtbuscador.Text = "(ID, Nombre, Sala, N° Asientos)";
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(410, 141);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 13);
            panel1.TabIndex = 25;
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(187, 260);
            estadochk.Margin = new Padding(3, 4, 3, 4);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(103, 24);
            estadochk.TabIndex = 26;
            estadochk.Text = "Disponible";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(134, 261);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 1;
            label7.Text = "Estado:";
            // 
            // MantMesas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1045, 538);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "MantMesas";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
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