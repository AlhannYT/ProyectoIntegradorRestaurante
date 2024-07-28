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
            estadochk = new CheckBox();
            passView = new CheckBox();
            label5 = new Label();
            guardarbtn = new Button();
            limpiarbtn = new Button();
            verificarbtn = new Button();
            txtestado_datos = new TextBox();
            txtnuevapass = new TextBox();
            confirmarpass = new Label();
            privilegiochk = new CheckBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(74, -2);
            label1.Name = "label1";
            label1.Size = new Size(260, 37);
            label1.TabIndex = 0;
            label1.Text = "Registro de Usuarios";
            label1.Click += label1_Click;
            // 
            // txtRegistroUsuario
            // 
            txtRegistroUsuario.Location = new Point(212, 219);
            txtRegistroUsuario.Name = "txtRegistroUsuario";
            txtRegistroUsuario.Size = new Size(119, 23);
            txtRegistroUsuario.TabIndex = 0;
            // 
            // txtRegistroPass
            // 
            txtRegistroPass.Enabled = false;
            txtRegistroPass.Location = new Point(212, 248);
            txtRegistroPass.Name = "txtRegistroPass";
            txtRegistroPass.Size = new Size(119, 23);
            txtRegistroPass.TabIndex = 1;
            txtRegistroPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(40, 222);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Ingresar Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(40, 251);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 2;
            label3.Text = "Ingresar Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(146, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(212, 153);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(60, 19);
            estadochk.TabIndex = 6;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // passView
            // 
            passView.Appearance = Appearance.Button;
            passView.Enabled = false;
            passView.Image = Properties.Resources.ojo;
            passView.Location = new Point(337, 248);
            passView.Name = "passView";
            passView.Size = new Size(27, 24);
            passView.TabIndex = 7;
            passView.UseVisualStyleBackColor = true;
            passView.CheckedChanged += passView_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(147, 153);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 2;
            label5.Text = "Estado: ";
            // 
            // guardarbtn
            // 
            guardarbtn.Location = new Point(83, 325);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(100, 35);
            guardarbtn.TabIndex = 8;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Location = new Point(231, 325);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(100, 35);
            limpiarbtn.TabIndex = 8;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // verificarbtn
            // 
            verificarbtn.Location = new Point(83, 325);
            verificarbtn.Name = "verificarbtn";
            verificarbtn.Size = new Size(100, 35);
            verificarbtn.TabIndex = 8;
            verificarbtn.Text = "Verificar";
            verificarbtn.UseVisualStyleBackColor = true;
            verificarbtn.Click += verificarbtn_Click;
            // 
            // txtestado_datos
            // 
            txtestado_datos.Enabled = false;
            txtestado_datos.Location = new Point(6, 7);
            txtestado_datos.Name = "txtestado_datos";
            txtestado_datos.Size = new Size(65, 23);
            txtestado_datos.TabIndex = 0;
            txtestado_datos.Text = "Creando";
            txtestado_datos.TextAlign = HorizontalAlignment.Center;
            // 
            // txtnuevapass
            // 
            txtnuevapass.Enabled = false;
            txtnuevapass.Location = new Point(212, 277);
            txtnuevapass.Name = "txtnuevapass";
            txtnuevapass.Size = new Size(119, 23);
            txtnuevapass.TabIndex = 1;
            txtnuevapass.UseSystemPasswordChar = true;
            txtnuevapass.Visible = false;
            // 
            // confirmarpass
            // 
            confirmarpass.AutoSize = true;
            confirmarpass.Font = new Font("Segoe UI", 11.25F);
            confirmarpass.ForeColor = SystemColors.Control;
            confirmarpass.Location = new Point(40, 280);
            confirmarpass.Name = "confirmarpass";
            confirmarpass.Size = new Size(153, 20);
            confirmarpass.TabIndex = 2;
            confirmarpass.Text = "Confirmar Contraseña";
            confirmarpass.Visible = false;
            // 
            // privilegiochk
            // 
            privilegiochk.AutoSize = true;
            privilegiochk.ForeColor = Color.Black;
            privilegiochk.Location = new Point(212, 178);
            privilegiochk.Name = "privilegiochk";
            privilegiochk.Size = new Size(66, 19);
            privilegiochk.TabIndex = 6;
            privilegiochk.Text = "Usuario";
            privilegiochk.UseVisualStyleBackColor = true;
            privilegiochk.CheckedChanged += privilegiochk_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(147, 178);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 9;
            label4.Text = "Privilegio:";
            // 
            // MantUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(406, 375);
            Controls.Add(label4);
            Controls.Add(limpiarbtn);
            Controls.Add(verificarbtn);
            Controls.Add(guardarbtn);
            Controls.Add(passView);
            Controls.Add(privilegiochk);
            Controls.Add(estadochk);
            Controls.Add(pictureBox1);
            Controls.Add(confirmarpass);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtnuevapass);
            Controls.Add(txtRegistroPass);
            Controls.Add(txtestado_datos);
            Controls.Add(txtRegistroUsuario);
            Controls.Add(label1);
            Name = "MantUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Usuarios";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private CheckBox estadochk;
        private CheckBox passView;
        private Label label5;
        private Button guardarbtn;
        private Button limpiarbtn;
        private Button verificarbtn;
        private TextBox txtestado_datos;
        private TextBox txtnuevapass;
        private Label confirmarpass;
        private CheckBox privilegiochk;
        private Label label4;
    }
}