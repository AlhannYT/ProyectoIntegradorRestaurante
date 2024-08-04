namespace Proyecto_restaurante
{
    partial class MantMedidas
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
            guardarbtn = new Button();
            limpiarbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            txtabreviatura = new TextBox();
            txtmedida = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            verificarbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guardarbtn
            // 
            guardarbtn.Enabled = false;
            guardarbtn.Location = new Point(30, 366);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(121, 53);
            guardarbtn.TabIndex = 0;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Visible = false;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Location = new Point(213, 366);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(121, 53);
            limpiarbtn.TabIndex = 0;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(30, 256);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Abreviatura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(30, 309);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Medida";
            // 
            // txtabreviatura
            // 
            txtabreviatura.Location = new Point(167, 253);
            txtabreviatura.Name = "txtabreviatura";
            txtabreviatura.Size = new Size(167, 23);
            txtabreviatura.TabIndex = 2;
            txtabreviatura.TextChanged += txtabreviatura_TextChanged;
            txtabreviatura.KeyPress += txtabreviatura_KeyPress;
            // 
            // txtmedida
            // 
            txtmedida.Enabled = false;
            txtmedida.Location = new Point(167, 306);
            txtmedida.Name = "txtmedida";
            txtmedida.Size = new Size(167, 23);
            txtmedida.TabIndex = 2;
            txtmedida.TextChanged += txtmedida_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cinta_metrica;
            pictureBox1.Location = new Point(108, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(45, 9);
            label3.Name = "label3";
            label3.Size = new Size(298, 40);
            label3.TabIndex = 1;
            label3.Text = "Registro de Medidas";
            // 
            // verificarbtn
            // 
            verificarbtn.Location = new Point(30, 366);
            verificarbtn.Name = "verificarbtn";
            verificarbtn.Size = new Size(121, 53);
            verificarbtn.TabIndex = 0;
            verificarbtn.Text = "Verificar";
            verificarbtn.UseVisualStyleBackColor = true;
            verificarbtn.Click += verificarbtn_Click;
            // 
            // MantMedidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(370, 450);
            Controls.Add(verificarbtn);
            Controls.Add(pictureBox1);
            Controls.Add(txtmedida);
            Controls.Add(txtabreviatura);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(limpiarbtn);
            Controls.Add(guardarbtn);
            Name = "MantMedidas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantMedidas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guardarbtn;
        private Button limpiarbtn;
        private Label label1;
        private Label label2;
        private TextBox txtabreviatura;
        private TextBox txtmedida;
        private PictureBox pictureBox1;
        private Label label3;
        private Button verificarbtn;
    }
}