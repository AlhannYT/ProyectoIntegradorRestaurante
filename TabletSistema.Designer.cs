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
            panel2 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label15 = new Label();
            label12 = new Label();
            eliminarbtn = new Button();
            txtbuscador = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            guardarbtn = new Button();
            limpiarbtn = new Button();
            seleccionarmesapanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelMesas
            // 
            panelMesas.AutoScroll = true;
            panelMesas.BackColor = Color.FromArgb(64, 64, 64);
            panelMesas.Location = new Point(6, 109);
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
            seleccionarmesapanel.Controls.Add(panel2);
            seleccionarmesapanel.Controls.Add(label12);
            seleccionarmesapanel.Controls.Add(eliminarbtn);
            seleccionarmesapanel.Controls.Add(txtbuscador);
            seleccionarmesapanel.Controls.Add(panelMesas);
            seleccionarmesapanel.Controls.Add(button1);
            seleccionarmesapanel.Controls.Add(button2);
            seleccionarmesapanel.Controls.Add(panel3);
            seleccionarmesapanel.Controls.Add(label5);
            seleccionarmesapanel.Location = new Point(6, 5);
            seleccionarmesapanel.Name = "seleccionarmesapanel";
            seleccionarmesapanel.Size = new Size(659, 800);
            seleccionarmesapanel.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label15);
            panel2.Location = new Point(343, 71);
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
            label12.Location = new Point(313, 75);
            label12.Name = "label12";
            label12.Size = new Size(18, 21);
            label12.TabIndex = 98;
            label12.Text = "  ";
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(620, 71);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(32, 32);
            eliminarbtn.TabIndex = 99;
            eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // txtbuscador
            // 
            txtbuscador.Font = new Font("Segoe UI", 14F);
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(9, 71);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.PlaceholderText = "Buscar Mesa";
            txtbuscador.Size = new Size(328, 32);
            txtbuscador.TabIndex = 97;
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(guardarbtn);
            panel3.Controls.Add(limpiarbtn);
            panel3.Location = new Point(6, 687);
            panel3.Name = "panel3";
            panel3.Size = new Size(646, 109);
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
            // TabletSistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(670, 811);
            Controls.Add(seleccionarmesapanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TabletSistema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de tablet";
            Load += TabletSistema_Load;
            seleccionarmesapanel.ResumeLayout(false);
            seleccionarmesapanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
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
    }
}