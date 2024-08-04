namespace Proyecto_restaurante
{
    partial class MantCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantCategoria));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtcategoria = new TextBox();
            guardarbtn = new Button();
            limpiarbtn = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(28, 202);
            label1.Name = "label1";
            label1.Size = new Size(160, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre de Categoria";
            // 
            // txtcategoria
            // 
            txtcategoria.Location = new Point(226, 202);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.Size = new Size(160, 23);
            txtcategoria.TabIndex = 2;
            txtcategoria.TextChanged += txtcategoria_TextChanged;
            // 
            // guardarbtn
            // 
            guardarbtn.Location = new Point(28, 249);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(123, 49);
            guardarbtn.TabIndex = 3;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Location = new Point(263, 249);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(123, 49);
            limpiarbtn.TabIndex = 3;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(92, 7);
            label2.Name = "label2";
            label2.Size = new Size(243, 32);
            label2.TabIndex = 1;
            label2.Text = "Registro de Categoria";
            // 
            // MantCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(418, 319);
            Controls.Add(limpiarbtn);
            Controls.Add(guardarbtn);
            Controls.Add(txtcategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "MantCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantCategoria";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtcategoria;
        private Button guardarbtn;
        private Button limpiarbtn;
        private Label label2;
    }
}