namespace Proyecto_restaurante
{
    partial class inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtusuario = new TextBox();
            txtpass = new TextBox();
            iniciobtn = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(70, 178);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(70, 225);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(168, 180);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(115, 23);
            txtusuario.TabIndex = 0;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(168, 227);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(115, 23);
            txtpass.TabIndex = 1;
            txtpass.UseSystemPasswordChar = true;
            // 
            // iniciobtn
            // 
            iniciobtn.Location = new Point(117, 277);
            iniciobtn.Name = "iniciobtn";
            iniciobtn.Size = new Size(119, 26);
            iniciobtn.TabIndex = 3;
            iniciobtn.Text = "Iniciar Sesión";
            iniciobtn.UseVisualStyleBackColor = true;
            iniciobtn.Click += iniciobtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Location = new Point(70, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 5);
            panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(5, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(344, 334);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(iniciobtn);
            Controls.Add(txtpass);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio De Sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtusuario;
        private TextBox txtpass;
        private Button iniciobtn;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}
