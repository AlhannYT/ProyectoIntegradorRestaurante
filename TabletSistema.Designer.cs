namespace Proyecto_restaurante
{
    partial class TabletSistema
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
            panelMesas = new FlowLayoutPanel();
            label5 = new Label();
            seleccionarmesapanel = new Panel();
            button1 = new Button();
            button2 = new Button();
            mesapanel = new Panel();
            panel2 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label15 = new Label();
            label12 = new Label();
            eliminarbtn = new Button();
            txtbuscador = new TextBox();
            panel3 = new Panel();
            guardarbtn = new Button();
            limpiarbtn = new Button();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            detalleorden = new DataGridView();
            mas = new Button();
            menos = new Button();
            agregar = new Button();
            cantidad = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            label8 = new Label();
            button5 = new Button();
            textBox2 = new TextBox();
            panel6 = new Panel();
            button6 = new Button();
            button7 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label7 = new Label();
            seleccionarmesapanel.SuspendLayout();
            mesapanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)detalleorden).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panelMesas
            // 
            panelMesas.AutoScroll = true;
            panelMesas.BackColor = Color.FromArgb(64, 64, 64);
            panelMesas.Location = new Point(3, 43);
            panelMesas.Name = "panelMesas";
            panelMesas.Size = new Size(646, 581);
            panelMesas.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(203, 4);
            label5.Name = "label5";
            label5.Size = new Size(253, 40);
            label5.TabIndex = 27;
            label5.Text = "Seleccionar mesa";
            // 
            // seleccionarmesapanel
            // 
            seleccionarmesapanel.Controls.Add(button1);
            seleccionarmesapanel.Controls.Add(panel5);
            seleccionarmesapanel.Controls.Add(button2);
            seleccionarmesapanel.Controls.Add(label5);
            seleccionarmesapanel.Location = new Point(6, 5);
            seleccionarmesapanel.Name = "seleccionarmesapanel";
            seleccionarmesapanel.Size = new Size(659, 800);
            seleccionarmesapanel.TabIndex = 28;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.angulo_izquierdo_blanco;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(9, 11);
            button1.Name = "button1";
            button1.Size = new Size(29, 27);
            button1.TabIndex = 96;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.cruz__1_;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(623, 11);
            button2.Name = "button2";
            button2.Size = new Size(29, 27);
            button2.TabIndex = 96;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // mesapanel
            // 
            mesapanel.Controls.Add(panelMesas);
            mesapanel.Controls.Add(panel2);
            mesapanel.Controls.Add(label12);
            mesapanel.Controls.Add(eliminarbtn);
            mesapanel.Controls.Add(txtbuscador);
            mesapanel.Location = new Point(671, 69);
            mesapanel.Name = "mesapanel";
            mesapanel.Size = new Size(652, 629);
            mesapanel.TabIndex = 101;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label15);
            panel2.Location = new Point(338, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 32);
            panel2.TabIndex = 100;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Cursor = Cursors.Hand;
            checkBox2.Font = new Font("Segoe UI", 12F);
            checkBox2.ForeColor = Color.White;
            checkBox2.Image = Properties.Resources.ocupado;
            checkBox2.ImageAlign = ContentAlignment.MiddleLeft;
            checkBox2.Location = new Point(35, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(107, 25);
            checkBox2.TabIndex = 66;
            checkBox2.Text = "    Ocupada";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Segoe UI", 12F);
            checkBox1.ForeColor = Color.White;
            checkBox1.Image = Properties.Resources.reservado;
            checkBox1.ImageAlign = ContentAlignment.MiddleLeft;
            checkBox1.Location = new Point(159, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(113, 25);
            checkBox1.TabIndex = 67;
            checkBox1.Text = "   Reservada";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.ForeColor = SystemColors.WindowFrame;
            label15.Image = Properties.Resources.filtroblanco;
            label15.Location = new Point(5, 6);
            label15.Name = "label15";
            label15.Size = new Size(18, 21);
            label15.TabIndex = 38;
            label15.Text = "  ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.Control;
            label12.Image = Properties.Resources.busqueda1;
            label12.Location = new Point(307, 11);
            label12.Name = "label12";
            label12.Size = new Size(18, 21);
            label12.TabIndex = 98;
            label12.Text = "  ";
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(617, 5);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(32, 32);
            eliminarbtn.TabIndex = 99;
            eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // txtbuscador
            // 
            txtbuscador.Font = new Font("Segoe UI", 14F);
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(3, 5);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.PlaceholderText = "Buscar Mesa";
            txtbuscador.Size = new Size(328, 32);
            txtbuscador.TabIndex = 97;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(guardarbtn);
            panel3.Controls.Add(limpiarbtn);
            panel3.Location = new Point(674, 702);
            panel3.Name = "panel3";
            panel3.Size = new Size(646, 102);
            panel3.TabIndex = 95;
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.next;
            guardarbtn.ImageAlign = ContentAlignment.MiddleRight;
            guardarbtn.Location = new Point(340, 25);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(181, 58);
            guardarbtn.TabIndex = 27;
            guardarbtn.Text = "Siguiente";
            guardarbtn.UseVisualStyleBackColor = true;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.back;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(125, 25);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(181, 58);
            limpiarbtn.TabIndex = 28;
            limpiarbtn.Text = "Atrás";
            limpiarbtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(agregar);
            panel1.Controls.Add(detalleorden);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(1326, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 629);
            panel1.TabIndex = 101;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(3, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(391, 429);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Image = Properties.Resources.busqueda1;
            label2.Location = new Point(589, 11);
            label2.Name = "label2";
            label2.Size = new Size(18, 21);
            label2.TabIndex = 98;
            label2.Text = "  ";
            // 
            // button3
            // 
            button3.Image = Properties.Resources.limpio;
            button3.Location = new Point(617, 5);
            button3.Name = "button3";
            button3.Size = new Size(32, 32);
            button3.TabIndex = 99;
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(3, 5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar Plato";
            textBox1.Size = new Size(608, 32);
            textBox1.TabIndex = 97;
            // 
            // detalleorden
            // 
            detalleorden.AllowUserToAddRows = false;
            detalleorden.AllowUserToDeleteRows = false;
            detalleorden.AllowUserToResizeRows = false;
            detalleorden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            detalleorden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detalleorden.Location = new Point(396, 70);
            detalleorden.MultiSelect = false;
            detalleorden.Name = "detalleorden";
            detalleorden.ReadOnly = true;
            detalleorden.RowHeadersVisible = false;
            detalleorden.RowHeadersWidth = 51;
            detalleorden.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            detalleorden.Size = new Size(253, 429);
            detalleorden.TabIndex = 100;
            // 
            // mas
            // 
            mas.Image = Properties.Resources.abajo;
            mas.Location = new Point(162, 39);
            mas.Name = "mas";
            mas.Size = new Size(135, 70);
            mas.TabIndex = 101;
            mas.UseVisualStyleBackColor = true;
            // 
            // menos
            // 
            menos.Image = Properties.Resources.arriba;
            menos.Location = new Point(298, 39);
            menos.Name = "menos";
            menos.Size = new Size(135, 70);
            menos.TabIndex = 101;
            menos.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            agregar.Image = Properties.Resources.anadir1;
            agregar.Location = new Point(479, 548);
            agregar.Name = "agregar";
            agregar.Size = new Size(135, 70);
            agregar.TabIndex = 101;
            agregar.UseVisualStyleBackColor = true;
            // 
            // cantidad
            // 
            cantidad.Font = new Font("Segoe UI", 34.5F);
            cantidad.Location = new Point(4, 40);
            cantidad.Name = "cantidad";
            cantidad.Size = new Size(152, 69);
            cantidad.TabIndex = 102;
            cantidad.Text = "1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(4, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 103;
            label1.Text = "Cantidad";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(cantidad);
            panel4.Controls.Add(menos);
            panel4.Controls.Add(mas);
            panel4.Location = new Point(3, 509);
            panel4.Name = "panel4";
            panel4.Size = new Size(439, 115);
            panel4.TabIndex = 104;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(158, 38);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 103;
            label3.Text = "Menú";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(480, 38);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 32);
            label4.TabIndex = 103;
            label4.Text = "Orden";
            // 
            // panel5
            // 
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(button5);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(flowLayoutPanel2);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(3, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(652, 730);
            panel5.TabIndex = 101;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(195, 37);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(204, 32);
            label6.TabIndex = 103;
            label6.Text = "Mesas Ocupadas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Image = Properties.Resources.busqueda1;
            label8.Location = new Point(589, 11);
            label8.Name = "label8";
            label8.Size = new Size(18, 21);
            label8.TabIndex = 98;
            label8.Text = "  ";
            // 
            // button5
            // 
            button5.Image = Properties.Resources.limpio;
            button5.Location = new Point(617, 5);
            button5.Name = "button5";
            button5.Size = new Size(32, 32);
            button5.TabIndex = 99;
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.ForeColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(3, 5);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Buscar Orden";
            textBox2.Size = new Size(608, 32);
            textBox2.TabIndex = 97;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gray;
            panel6.Controls.Add(button6);
            panel6.Controls.Add(button7);
            panel6.Location = new Point(498, 70);
            panel6.Name = "panel6";
            panel6.Size = new Size(151, 659);
            panel6.TabIndex = 104;
            // 
            // button6
            // 
            button6.Image = Properties.Resources.nuevo;
            button6.Location = new Point(8, 14);
            button6.Name = "button6";
            button6.Size = new Size(135, 70);
            button6.TabIndex = 101;
            button6.Text = "Nueva Orden";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Image = Properties.Resources.editar;
            button7.Location = new Point(8, 90);
            button7.Name = "button7";
            button7.Size = new Size(135, 70);
            button7.TabIndex = 101;
            button7.Text = "Editar";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel2.Location = new Point(3, 70);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(493, 659);
            flowLayoutPanel2.TabIndex = 26;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(519, 37);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(116, 32);
            label7.TabIndex = 103;
            label7.Text = "Acciones";
            // 
            // TabletSistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(670, 811);
            Controls.Add(seleccionarmesapanel);
            Controls.Add(panel1);
            Controls.Add(mesapanel);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TabletSistema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de tablet";
            Load += TabletSistema_Load;
            seleccionarmesapanel.ResumeLayout(false);
            seleccionarmesapanel.PerformLayout();
            mesapanel.ResumeLayout(false);
            mesapanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)detalleorden).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelMesas;
        private Label label5;
        private Panel seleccionarmesapanel;
        private Panel panel3;
        private Button guardarbtn;
        private Button limpiarbtn;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label label15;
        private Label label12;
        private Button eliminarbtn;
        private TextBox txtbuscador;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Panel mesapanel;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Button button3;
        private TextBox textBox1;
        private TextBox cantidad;
        private Button agregar;
        private Button menos;
        private Button mas;
        private DataGridView detalleorden;
        private Label label1;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private Panel panel5;
        private Label label6;
        private Label label8;
        private Button button5;
        private TextBox textBox2;
        private Panel panel6;
        private Button button6;
        private Button button7;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label7;
    }
}