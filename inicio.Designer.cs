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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtusuario = new TextBox();
            txtpass = new TextBox();
            iniciobtn = new Button();
            panel1 = new Panel();
            passView = new CheckBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            iniciolabel = new Label();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(214, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(167, 230);
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
            label2.Location = new Point(167, 278);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(265, 231);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(115, 23);
            txtusuario.TabIndex = 0;
            txtusuario.TextChanged += txtusuario_TextChanged;
            txtusuario.KeyPress += txtusuario_KeyPress;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(265, 278);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(115, 23);
            txtpass.TabIndex = 1;
            txtpass.UseSystemPasswordChar = true;
            txtpass.KeyPress += txtpass_KeyPress;
            // 
            // iniciobtn
            // 
            iniciobtn.Location = new Point(214, 325);
            iniciobtn.Name = "iniciobtn";
            iniciobtn.Size = new Size(142, 29);
            iniciobtn.TabIndex = 3;
            iniciobtn.Text = "Iniciar Sesión";
            iniciobtn.UseVisualStyleBackColor = true;
            iniciobtn.Click += iniciobtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Location = new Point(99, 201);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 6);
            panel1.TabIndex = 4;
            // 
            // passView
            // 
            passView.Appearance = Appearance.Button;
            passView.Image = Properties.Resources.ojo;
            passView.Location = new Point(386, 278);
            passView.Name = "passView";
            passView.Size = new Size(27, 20);
            passView.TabIndex = 6;
            passView.UseVisualStyleBackColor = true;
            passView.CheckedChanged += passView_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.restaurantes_moda_barcelona_roka_6475ba03ee8bc;
            pictureBox2.Location = new Point(-15, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(601, 396);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.minimizar_ventana__1_;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(494, 3);
            button1.Name = "button1";
            button1.Size = new Size(29, 27);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // iniciolabel
            // 
            iniciolabel.AutoSize = true;
            iniciolabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iniciolabel.ForeColor = Color.White;
            iniciolabel.Location = new Point(223, 7);
            iniciolabel.Name = "iniciolabel";
            iniciolabel.Size = new Size(113, 20);
            iniciolabel.TabIndex = 8;
            iniciolabel.Text = "Inicio de Sesion";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.cruz__1_;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(528, 3);
            button2.Name = "button2";
            button2.Size = new Size(29, 27);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(564, 368);
            Controls.Add(pictureBox1);
            Controls.Add(iniciolabel);
            Controls.Add(passView);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(iniciobtn);
            Controls.Add(txtpass);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
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
        private CheckBox passView;
        private PictureBox pictureBox2;
        private Button button1;
        private Label iniciolabel;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}
