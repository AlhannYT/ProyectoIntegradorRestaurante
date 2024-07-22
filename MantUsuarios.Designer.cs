namespace Proyecto_restaurante
{
    partial class MantUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantUsuarios));
            label1 = new Label();
            txtRegistroUsuario = new TextBox();
            txtRegistroPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 1);
            label1.Name = "label1";
            label1.Size = new Size(313, 45);
            label1.TabIndex = 0;
            label1.Text = "Registro de Usuarios";
            label1.Click += label1_Click;
            // 
            // txtRegistroUsuario
            // 
            txtRegistroUsuario.Location = new Point(174, 225);
            txtRegistroUsuario.Name = "txtRegistroUsuario";
            txtRegistroUsuario.Size = new Size(100, 23);
            txtRegistroUsuario.TabIndex = 0;
            // 
            // txtRegistroPass
            // 
            txtRegistroPass.Location = new Point(174, 267);
            txtRegistroPass.Name = "txtRegistroPass";
            txtRegistroPass.Size = new Size(100, 23);
            txtRegistroPass.TabIndex = 1;
            txtRegistroPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(46, 228);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingresar Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(46, 270);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 2;
            label3.Text = "Ingresar Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(117, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.ForeColor = SystemColors.ControlLightLight;
            checkBox1.Location = new Point(140, 186);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Estado";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Window;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(280, 267);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // MantUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(334, 378);
            Controls.Add(pictureBox2);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRegistroPass);
            Controls.Add(txtRegistroUsuario);
            Controls.Add(label1);
            Name = "MantUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Usuarios";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRegistroUsuario;
        private TextBox txtRegistroPass;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private PictureBox pictureBox2;
    }
}