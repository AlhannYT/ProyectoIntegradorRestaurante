namespace Proyecto_restaurante
{
    partial class MantImpuestos
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
            txtnombreimpuesto = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            guardarbtn = new Button();
            fecharegistro = new DateTimePicker();
            txtvalorimpuesto = new TextBox();
            label2 = new Label();
            limpiarbtn = new Button();
            estado = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            eliminarbtn = new Button();
            label7 = new Label();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            SuspendLayout();
            // 
            // txtnombreimpuesto
            // 
            txtnombreimpuesto.Location = new Point(167, 250);
            txtnombreimpuesto.Name = "txtnombreimpuesto";
            txtnombreimpuesto.Size = new Size(212, 23);
            txtnombreimpuesto.TabIndex = 1;
            txtnombreimpuesto.TextChanged += txtnombreimpuesto_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.alt_de_impuestos;
            pictureBox1.Location = new Point(167, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(57, 253);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.disco;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(57, 409);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(127, 46);
            guardarbtn.TabIndex = 3;
            guardarbtn.Text = "     Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // fecharegistro
            // 
            fecharegistro.DropDownAlign = LeftRightAlignment.Right;
            fecharegistro.Enabled = false;
            fecharegistro.Location = new Point(167, 347);
            fecharegistro.Name = "fecharegistro";
            fecharegistro.Size = new Size(212, 23);
            fecharegistro.TabIndex = 4;
            fecharegistro.Value = new DateTime(2024, 8, 13, 0, 0, 0, 0);
            // 
            // txtvalorimpuesto
            // 
            txtvalorimpuesto.Location = new Point(167, 298);
            txtvalorimpuesto.Name = "txtvalorimpuesto";
            txtvalorimpuesto.Size = new Size(212, 23);
            txtvalorimpuesto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(57, 301);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor en %";
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(252, 409);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(127, 46);
            limpiarbtn.TabIndex = 4;
            limpiarbtn.Text = "     Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // estado
            // 
            estado.AutoSize = true;
            estado.Checked = true;
            estado.CheckState = CheckState.Checked;
            estado.ForeColor = Color.Lime;
            estado.Location = new Point(233, 213);
            estado.Name = "estado";
            estado.Size = new Size(60, 19);
            estado.TabIndex = 5;
            estado.Text = "Activo";
            estado.UseVisualStyleBackColor = true;
            estado.CheckedChanged += estado_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(57, 353);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de registro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(179, 214);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 2;
            label4.Text = "Estado: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(449, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 475);
            panel2.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(456, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 10);
            panel1.TabIndex = 36;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(988, 80);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(27, 24);
            eliminarbtn.TabIndex = 35;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(472, 83);
            label7.Name = "label7";
            label7.Size = new Size(69, 17);
            label7.TabIndex = 32;
            label7.Text = "Buscador: ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(472, 128);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(543, 327);
            tabladatos.TabIndex = 33;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(544, 80);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(438, 23);
            txtbuscador.TabIndex = 34;
            txtbuscador.Text = "(ID, Nombre, Porcentaje)";
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(582, 17);
            label6.Name = "label6";
            label6.Size = new Size(330, 40);
            label6.TabIndex = 38;
            label6.Text = "Consulta de Impuestos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(16, 17);
            label5.Name = "label5";
            label5.Size = new Size(423, 40);
            label5.TabIndex = 38;
            label5.Text = "Mantenimiento de Impuestos";
            // 
            // MantImpuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1023, 464);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(eliminarbtn);
            Controls.Add(label7);
            Controls.Add(tabladatos);
            Controls.Add(txtbuscador);
            Controls.Add(estado);
            Controls.Add(fecharegistro);
            Controls.Add(limpiarbtn);
            Controls.Add(guardarbtn);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtvalorimpuesto);
            Controls.Add(txtnombreimpuesto);
            Name = "MantImpuestos";
            Text = "MantImpuestos";
            Load += MantImpuestos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnombreimpuesto;
        private PictureBox pictureBox1;
        private Label label1;
        private Button guardarbtn;
        private DateTimePicker fecharegistro;
        private TextBox txtvalorimpuesto;
        private Label label2;
        private Button limpiarbtn;
        private CheckBox estado;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Panel panel1;
        private Button eliminarbtn;
        private Label label7;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private Label label6;
        private Label label5;
    }
}