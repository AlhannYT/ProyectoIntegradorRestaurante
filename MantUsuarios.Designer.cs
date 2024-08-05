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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantUsuarios));
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
            checkBox1 = new CheckBox();
            toolTip1 = new ToolTip(components);
            label6 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            eliminarbtn = new Button();
            label7 = new Label();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            SuspendLayout();
            // 
            // txtRegistroUsuario
            // 
            txtRegistroUsuario.Location = new Point(212, 219);
            txtRegistroUsuario.Name = "txtRegistroUsuario";
            txtRegistroUsuario.Size = new Size(119, 23);
            txtRegistroUsuario.TabIndex = 0;
            txtRegistroUsuario.TextChanged += txtRegistroUsuario_TextChanged;
            txtRegistroUsuario.KeyPress += txtRegistroUsuario_KeyPress;
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
            pictureBox1.Location = new Point(139, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Enabled = false;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(205, 166);
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
            label5.Location = new Point(140, 167);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 2;
            label5.Text = "Estado: ";
            // 
            // guardarbtn
            // 
            guardarbtn.Location = new Point(42, 318);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(114, 44);
            guardarbtn.TabIndex = 8;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Location = new Point(217, 318);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(114, 44);
            limpiarbtn.TabIndex = 8;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // verificarbtn
            // 
            verificarbtn.Location = new Point(42, 318);
            verificarbtn.Name = "verificarbtn";
            verificarbtn.Size = new Size(114, 44);
            verificarbtn.TabIndex = 8;
            verificarbtn.Text = "Verificar";
            verificarbtn.UseVisualStyleBackColor = true;
            verificarbtn.Click += verificarbtn_Click;
            // 
            // txtestado_datos
            // 
            txtestado_datos.Enabled = false;
            txtestado_datos.Location = new Point(12, 68);
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
            privilegiochk.Enabled = false;
            privilegiochk.ForeColor = Color.Black;
            privilegiochk.Location = new Point(205, 191);
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
            label4.Location = new Point(140, 191);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 9;
            label4.Text = "Privilegio:";
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.Enabled = false;
            checkBox1.Image = Properties.Resources.cuadrado_norte;
            checkBox1.Location = new Point(370, 248);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(27, 24);
            checkBox1.TabIndex = 7;
            toolTip1.SetToolTip(checkBox1, "Este boton sirve para alternar entre\r\ndejar la misma contraseña o\r\ncolocar una nueva contraseña\r\n\r\n");
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Ayuda";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(453, 9);
            label6.Name = "label6";
            label6.Size = new Size(306, 40);
            label6.TabIndex = 32;
            label6.Text = "Consulta de Usuarios";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(406, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 382);
            panel2.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(414, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 10);
            panel1.TabIndex = 30;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.basura;
            eliminarbtn.Location = new Point(765, 72);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 24);
            eliminarbtn.TabIndex = 29;
            eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(422, 74);
            label7.Name = "label7";
            label7.Size = new Size(69, 17);
            label7.TabIndex = 26;
            label7.Text = "Buscador: ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(421, 118);
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(380, 247);
            tabladatos.TabIndex = 27;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(493, 73);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(266, 23);
            txtbuscador.TabIndex = 28;
            txtbuscador.Text = "(ID, Usuario)";
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(55, 9);
            label1.Name = "label1";
            label1.Size = new Size(300, 40);
            label1.TabIndex = 33;
            label1.Text = "Registro de Usuarios";
            // 
            // MantUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(806, 375);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(eliminarbtn);
            Controls.Add(label7);
            Controls.Add(tabladatos);
            Controls.Add(txtbuscador);
            Controls.Add(label4);
            Controls.Add(limpiarbtn);
            Controls.Add(verificarbtn);
            Controls.Add(guardarbtn);
            Controls.Add(checkBox1);
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
            Name = "MantUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Usuarios";
            Load += MantUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private CheckBox checkBox1;
        private ToolTip toolTip1;
        private Label label6;
        private Panel panel2;
        private Panel panel1;
        private Button eliminarbtn;
        private Label label7;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private Label label1;
    }
}