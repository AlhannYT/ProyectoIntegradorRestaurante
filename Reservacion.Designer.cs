namespace Proyecto_restaurante
{
    partial class Reservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservacion));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel8 = new Panel();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            fecreservacion = new DateTimePicker();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel4 = new Panel();
            fechapedido = new DateTimePicker();
            limpiarbtn = new Button();
            label11 = new Label();
            guardarpedidobtn = new Button();
            txtnumero_cliente = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label20 = new Label();
            label1 = new Label();
            buscarclientebtn = new Button();
            txtidpedido = new TextBox();
            txtnombrecompleto = new TextBox();
            tabPage2 = new TabPage();
            label12 = new Label();
            label14 = new Label();
            label10 = new Label();
            todoschk = new CheckBox();
            canceladochk = new CheckBox();
            pendientechk = new CheckBox();
            txtbusquedafactura = new TextBox();
            panel3 = new Panel();
            cancelarpedido = new Button();
            label8 = new Label();
            facturarbtn = new Button();
            label9 = new Label();
            fecini = new DateTimePicker();
            fecfin = new DateTimePicker();
            dataGridView2 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 12F);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(847, 508);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(87, 128, 87);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel8);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = SystemColors.ControlText;
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(839, 474);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Reservar";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(833, 37);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(550, 1);
            label4.Name = "label4";
            label4.Size = new Size(255, 32);
            label4.TabIndex = 3;
            label4.Text = "Datos de reservación";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(146, 1);
            label3.Name = "label3";
            label3.Size = new Size(226, 32);
            label3.TabIndex = 3;
            label3.Text = "Mesas Disponibles";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Gray;
            panel8.Controls.Add(numericUpDown1);
            panel8.Controls.Add(label7);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(fecreservacion);
            panel8.Location = new Point(520, 199);
            panel8.Name = "panel8";
            panel8.Size = new Size(313, 270);
            panel8.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(181, 67);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(7, 114);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(7, 68);
            label6.Name = "label6";
            label6.Size = new Size(155, 20);
            label6.TabIndex = 3;
            label6.Text = "Numero de personas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(7, 19);
            label5.Name = "label5";
            label5.Size = new Size(159, 20);
            label5.TabIndex = 3;
            label5.Text = "Fecha de reservacion:";
            // 
            // fecreservacion
            // 
            fecreservacion.Format = DateTimePickerFormat.Short;
            fecreservacion.Location = new Point(181, 18);
            fecreservacion.Name = "fecreservacion";
            fecreservacion.Size = new Size(123, 23);
            fecreservacion.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(513, 270);
            dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(txtnumero_cliente);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buscarclientebtn);
            panel1.Controls.Add(txtidpedido);
            panel1.Controls.Add(txtnombrecompleto);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 149);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.WindowFrame;
            panel4.Controls.Add(fechapedido);
            panel4.Controls.Add(limpiarbtn);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(guardarpedidobtn);
            panel4.Location = new Point(517, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(313, 133);
            panel4.TabIndex = 5;
            // 
            // fechapedido
            // 
            fechapedido.Enabled = false;
            fechapedido.Format = DateTimePickerFormat.Short;
            fechapedido.Location = new Point(181, 8);
            fechapedido.Name = "fechapedido";
            fechapedido.Size = new Size(123, 23);
            fechapedido.TabIndex = 4;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            limpiarbtn.Image = Properties.Resources.nuevo;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(159, 70);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(147, 52);
            limpiarbtn.TabIndex = 0;
            limpiarbtn.Text = "Nuevo";
            limpiarbtn.TextAlign = ContentAlignment.MiddleRight;
            limpiarbtn.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(3, 9);
            label11.Name = "label11";
            label11.Size = new Size(136, 20);
            label11.TabIndex = 3;
            label11.Text = "Fecha de creacion:";
            // 
            // guardarpedidobtn
            // 
            guardarpedidobtn.BackColor = Color.FromArgb(128, 255, 128);
            guardarpedidobtn.Enabled = false;
            guardarpedidobtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guardarpedidobtn.Image = Properties.Resources.disco;
            guardarpedidobtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarpedidobtn.Location = new Point(6, 70);
            guardarpedidobtn.Name = "guardarpedidobtn";
            guardarpedidobtn.Size = new Size(147, 52);
            guardarpedidobtn.TabIndex = 0;
            guardarpedidobtn.Text = "Guardar Reservacion";
            guardarpedidobtn.TextAlign = ContentAlignment.MiddleRight;
            guardarpedidobtn.UseVisualStyleBackColor = false;
            // 
            // txtnumero_cliente
            // 
            txtnumero_cliente.Font = new Font("Segoe UI", 12F);
            txtnumero_cliente.Location = new Point(41, 107);
            txtnumero_cliente.Name = "txtnumero_cliente";
            txtnumero_cliente.Size = new Size(147, 29);
            txtnumero_cliente.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = Properties.Resources.telefono;
            pictureBox1.Location = new Point(5, 108);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(334, 8);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 3;
            label2.Text = "Reservar Mesa";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.Control;
            label20.Location = new Point(5, 10);
            label20.Name = "label20";
            label20.Size = new Size(29, 21);
            label20.TabIndex = 3;
            label20.Text = "N°";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(1, 46);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 3;
            label1.Text = "Datos cliente";
            // 
            // buscarclientebtn
            // 
            buscarclientebtn.Image = Properties.Resources.buscar;
            buscarclientebtn.Location = new Point(4, 75);
            buscarclientebtn.Name = "buscarclientebtn";
            buscarclientebtn.RightToLeft = RightToLeft.No;
            buscarclientebtn.Size = new Size(34, 29);
            buscarclientebtn.TabIndex = 2;
            buscarclientebtn.UseVisualStyleBackColor = true;
            // 
            // txtidpedido
            // 
            txtidpedido.Enabled = false;
            txtidpedido.Location = new Point(38, 9);
            txtidpedido.Name = "txtidpedido";
            txtidpedido.Size = new Size(87, 23);
            txtidpedido.TabIndex = 0;
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Font = new Font("Segoe UI", 12F);
            txtnombrecompleto.Location = new Point(41, 75);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new Size(314, 29);
            txtnombrecompleto.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(85, 151, 100);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(todoschk);
            tabPage2.Controls.Add(canceladochk);
            tabPage2.Controls.Add(pendientechk);
            tabPage2.Controls.Add(txtbusquedafactura);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(839, 474);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Reservaciones";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.Control;
            label12.Image = Properties.Resources.filtrar;
            label12.Location = new Point(523, 138);
            label12.Name = "label12";
            label12.Size = new Size(18, 21);
            label12.TabIndex = 17;
            label12.Text = "  ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.ForeColor = SystemColors.Control;
            label14.Image = Properties.Resources.busqueda;
            label14.Location = new Point(470, 138);
            label14.Name = "label14";
            label14.Size = new Size(18, 21);
            label14.TabIndex = 16;
            label14.Text = "  ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(287, 10);
            label10.Name = "label10";
            label10.Size = new Size(264, 32);
            label10.TabIndex = 15;
            label10.Text = "Reservacion de mesas";
            // 
            // todoschk
            // 
            todoschk.AutoSize = true;
            todoschk.Location = new Point(762, 136);
            todoschk.Name = "todoschk";
            todoschk.Size = new Size(69, 25);
            todoschk.TabIndex = 9;
            todoschk.Text = "Todos";
            todoschk.UseVisualStyleBackColor = true;
            // 
            // canceladochk
            // 
            canceladochk.AutoSize = true;
            canceladochk.Location = new Point(656, 136);
            canceladochk.Name = "canceladochk";
            canceladochk.Size = new Size(101, 25);
            canceladochk.TabIndex = 10;
            canceladochk.Text = "Cancelado";
            canceladochk.UseVisualStyleBackColor = true;
            // 
            // pendientechk
            // 
            pendientechk.AutoSize = true;
            pendientechk.Checked = true;
            pendientechk.CheckState = CheckState.Checked;
            pendientechk.Location = new Point(554, 136);
            pendientechk.Name = "pendientechk";
            pendientechk.Size = new Size(97, 25);
            pendientechk.TabIndex = 11;
            pendientechk.Text = "Pendiente";
            pendientechk.UseVisualStyleBackColor = true;
            // 
            // txtbusquedafactura
            // 
            txtbusquedafactura.ForeColor = Color.Gray;
            txtbusquedafactura.Location = new Point(7, 134);
            txtbusquedafactura.Name = "txtbusquedafactura";
            txtbusquedafactura.Size = new Size(485, 29);
            txtbusquedafactura.TabIndex = 8;
            txtbusquedafactura.Text = "(ID Reservacion, Cliente, Mesa, Total)";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.WindowFrame;
            panel3.Controls.Add(cancelarpedido);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(facturarbtn);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(fecini);
            panel3.Controls.Add(fecfin);
            panel3.Location = new Point(7, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(826, 74);
            panel3.TabIndex = 7;
            // 
            // cancelarpedido
            // 
            cancelarpedido.BackColor = Color.FromArgb(255, 128, 128);
            cancelarpedido.Image = Properties.Resources.cancelardoc;
            cancelarpedido.ImageAlign = ContentAlignment.MiddleLeft;
            cancelarpedido.Location = new Point(700, 9);
            cancelarpedido.Name = "cancelarpedido";
            cancelarpedido.Size = new Size(114, 56);
            cancelarpedido.TabIndex = 0;
            cancelarpedido.Text = "Cancelar";
            cancelarpedido.TextAlign = ContentAlignment.MiddleRight;
            cancelarpedido.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(8, 10);
            label8.Name = "label8";
            label8.Size = new Size(101, 21);
            label8.TabIndex = 6;
            label8.Text = "Fecha inicio";
            // 
            // facturarbtn
            // 
            facturarbtn.BackColor = Color.FromArgb(255, 192, 128);
            facturarbtn.Image = Properties.Resources.nuevo;
            facturarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            facturarbtn.Location = new Point(575, 9);
            facturarbtn.Name = "facturarbtn";
            facturarbtn.Size = new Size(114, 56);
            facturarbtn.TabIndex = 0;
            facturarbtn.Text = "Orden";
            facturarbtn.TextAlign = ContentAlignment.MiddleRight;
            facturarbtn.UseVisualStyleBackColor = false;
            facturarbtn.Click += facturarbtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(152, 10);
            label9.Name = "label9";
            label9.Size = new Size(79, 21);
            label9.TabIndex = 6;
            label9.Text = "Fecha fin";
            // 
            // fecini
            // 
            fecini.Format = DateTimePickerFormat.Short;
            fecini.Location = new Point(8, 34);
            fecini.Name = "fecini";
            fecini.Size = new Size(123, 29);
            fecini.TabIndex = 5;
            // 
            // fecfin
            // 
            fecfin.Format = DateTimePickerFormat.Short;
            fecfin.Location = new Point(152, 34);
            fecfin.Name = "fecfin";
            fecfin.Size = new Size(123, 29);
            fecfin.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(7, 171);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(826, 296);
            dataGridView2.TabIndex = 0;
            // 
            // Reservacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(850, 510);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Reservacion";
            StartPosition = FormStartPosition.Manual;
            Text = "Reservacion";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private TextBox txtnumero_cliente;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label20;
        private Label label1;
        private Button buscarclientebtn;
        private TextBox txtidpedido;
        private TextBox txtnombrecompleto;
        private DataGridView dataGridView1;
        private Panel panel4;
        private DateTimePicker fechapedido;
        private Button limpiarbtn;
        private Label label11;
        private Button guardarpedidobtn;
        private Panel panel8;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label5;
        private DateTimePicker fecreservacion;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private Label label6;
        private DataGridView dataGridView2;
        private Button cancelarpedido;
        private Button facturarbtn;
        private Label label9;
        private DateTimePicker fecfin;
        private Label label8;
        private DateTimePicker fecini;
        private Panel panel3;
        private CheckBox todoschk;
        private CheckBox canceladochk;
        private CheckBox pendientechk;
        private TextBox txtbusquedafactura;
        private Label label10;
        private Label label14;
        private Label label12;
    }
}