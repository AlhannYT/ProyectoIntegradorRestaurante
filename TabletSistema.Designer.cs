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
            panel3 = new Panel();
            guardarbtn = new Button();
            limpiarbtn = new Button();
            seleccionarmesapanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelMesas
            // 
            panelMesas.AutoScroll = true;
            panelMesas.BackColor = Color.FromArgb(64, 64, 64);
            panelMesas.Location = new Point(6, 54);
            panelMesas.Name = "panelMesas";
            panelMesas.Size = new Size(646, 636);
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
            seleccionarmesapanel.ResumeLayout(false);
            seleccionarmesapanel.PerformLayout();
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
    }
}