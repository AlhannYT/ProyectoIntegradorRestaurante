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
            txtnuevapass = new TextBox();
            confirmarpass = new Label();
            privilegiochk = new CheckBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            instrucciones = new Button();
            label6 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            eliminarbtn = new Button();
            label7 = new Label();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            label1 = new Label();
            panelconfirmacion = new Panel();
            panel3 = new Panel();
            confirmarpasspanel = new TextBox();
            adminlabel = new Label();
            label8 = new Label();
            cancelarbtn = new Button();
            eliminarusuariobtn = new Button();
            ConfirmPanelTransp = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            panelconfirmacion.SuspendLayout();
            ConfirmPanelTransp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtRegistroUsuario
            // 
            txtRegistroUsuario.Location = new Point(243, 293);
            txtRegistroUsuario.Margin = new Padding(3, 4, 3, 4);
            txtRegistroUsuario.Name = "txtRegistroUsuario";
            txtRegistroUsuario.Size = new Size(135, 27);
            txtRegistroUsuario.TabIndex = 0;
            txtRegistroUsuario.TextChanged += txtRegistroUsuario_TextChanged;
            txtRegistroUsuario.KeyPress += txtRegistroUsuario_KeyPress;
            // 
            // txtRegistroPass
            // 
            txtRegistroPass.Enabled = false;
            txtRegistroPass.Location = new Point(243, 332);
            txtRegistroPass.Margin = new Padding(3, 4, 3, 4);
            txtRegistroPass.Name = "txtRegistroPass";
            txtRegistroPass.Size = new Size(135, 27);
            txtRegistroPass.TabIndex = 1;
            txtRegistroPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(42, 296);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 2;
            label2.Text = "Ingresar Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(42, 335);
            label3.Name = "label3";
            label3.Size = new Size(182, 25);
            label3.TabIndex = 2;
            label3.Text = "Ingresar Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(146, 68);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.Enabled = false;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(221, 221);
            estadochk.Margin = new Padding(3, 4, 3, 4);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(73, 24);
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
            passView.Location = new Point(386, 332);
            passView.Margin = new Padding(3, 4, 3, 4);
            passView.Name = "passView";
            passView.Size = new Size(31, 30);
            passView.TabIndex = 7;
            toolTip1.SetToolTip(passView, "Mostrar Contraseña");
            passView.UseVisualStyleBackColor = true;
            passView.CheckedChanged += passView_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(143, 223);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 2;
            label5.Text = "Estado: ";
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.basura;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(44, 424);
            guardarbtn.Margin = new Padding(3, 4, 3, 4);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(130, 59);
            guardarbtn.TabIndex = 8;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(248, 424);
            limpiarbtn.Margin = new Padding(3, 4, 3, 4);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(130, 59);
            limpiarbtn.TabIndex = 8;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // verificarbtn
            // 
            verificarbtn.Image = Properties.Resources.disco;
            verificarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            verificarbtn.Location = new Point(43, 424);
            verificarbtn.Margin = new Padding(3, 4, 3, 4);
            verificarbtn.Name = "verificarbtn";
            verificarbtn.Size = new Size(130, 59);
            verificarbtn.TabIndex = 8;
            verificarbtn.Text = "Verificar";
            verificarbtn.UseVisualStyleBackColor = true;
            verificarbtn.Click += verificarbtn_Click;
            // 
            // txtnuevapass
            // 
            txtnuevapass.Enabled = false;
            txtnuevapass.Location = new Point(243, 370);
            txtnuevapass.Margin = new Padding(3, 4, 3, 4);
            txtnuevapass.Name = "txtnuevapass";
            txtnuevapass.Size = new Size(135, 27);
            txtnuevapass.TabIndex = 1;
            txtnuevapass.UseSystemPasswordChar = true;
            txtnuevapass.Visible = false;
            // 
            // confirmarpass
            // 
            confirmarpass.AutoSize = true;
            confirmarpass.Font = new Font("Segoe UI", 11.25F);
            confirmarpass.ForeColor = SystemColors.Control;
            confirmarpass.Location = new Point(42, 373);
            confirmarpass.Name = "confirmarpass";
            confirmarpass.Size = new Size(198, 25);
            confirmarpass.TabIndex = 2;
            confirmarpass.Text = "Confirmar Contraseña";
            confirmarpass.Visible = false;
            // 
            // privilegiochk
            // 
            privilegiochk.AutoSize = true;
            privilegiochk.Enabled = false;
            privilegiochk.ForeColor = Color.Black;
            privilegiochk.Location = new Point(221, 255);
            privilegiochk.Margin = new Padding(3, 4, 3, 4);
            privilegiochk.Name = "privilegiochk";
            privilegiochk.Size = new Size(81, 24);
            privilegiochk.TabIndex = 6;
            privilegiochk.Text = "Usuario";
            privilegiochk.UseVisualStyleBackColor = true;
            privilegiochk.CheckedChanged += privilegiochk_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(143, 255);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 9;
            label4.Text = "Privilegio:";
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.Enabled = false;
            checkBox1.Image = Properties.Resources.cuadrado_norte;
            checkBox1.Location = new Point(424, 332);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(31, 30);
            checkBox1.TabIndex = 7;
            toolTip1.SetToolTip(checkBox1, "Este boton sirve para alternar entre\r\ndejar la misma contraseña o\r\ncolocar una nueva contraseña\r\n\r\n");
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Ayuda";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Image = Properties.Resources.basura;
            button1.Location = new Point(386, 292);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(31, 30);
            button1.TabIndex = 35;
            toolTip1.SetToolTip(button1, "¡Este boton elimina por\r\ncompleto al usuario que\r\nhaya sido seleccionado!");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // instrucciones
            // 
            instrucciones.BackColor = Color.White;
            instrucciones.Image = Properties.Resources.interrogatorio;
            instrucciones.Location = new Point(1014, 12);
            instrucciones.Margin = new Padding(3, 4, 3, 4);
            instrucciones.Name = "instrucciones";
            instrucciones.Size = new Size(27, 28);
            instrucciones.TabIndex = 37;
            toolTip1.SetToolTip(instrucciones, "Instrucciones");
            instrucciones.UseVisualStyleBackColor = false;
            instrucciones.Click += instrucciones_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(518, 12);
            label6.Name = "label6";
            label6.Size = new Size(386, 50);
            label6.TabIndex = 32;
            label6.Text = "Consulta de Usuarios";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(464, -1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 529);
            panel2.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(473, 136);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 13);
            panel1.TabIndex = 30;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(1010, 96);
            eliminarbtn.Margin = new Padding(3, 4, 3, 4);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(31, 31);
            eliminarbtn.TabIndex = 29;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(482, 99);
            label7.Name = "label7";
            label7.Size = new Size(89, 23);
            label7.TabIndex = 26;
            label7.Text = "Buscador: ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(481, 157);
            tabladatos.Margin = new Padding(3, 4, 3, 4);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.RowHeadersWidth = 51;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(559, 325);
            tabladatos.TabIndex = 27;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(576, 97);
            txtbuscador.Margin = new Padding(3, 4, 3, 4);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(428, 27);
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
            label1.Location = new Point(37, 10);
            label1.Name = "label1";
            label1.Size = new Size(380, 50);
            label1.TabIndex = 33;
            label1.Text = "Registro de Usuarios";
            // 
            // panelconfirmacion
            // 
            panelconfirmacion.BackColor = Color.FromArgb(192, 0, 0);
            panelconfirmacion.Controls.Add(panel3);
            panelconfirmacion.Controls.Add(confirmarpasspanel);
            panelconfirmacion.Controls.Add(adminlabel);
            panelconfirmacion.Controls.Add(label8);
            panelconfirmacion.Controls.Add(cancelarbtn);
            panelconfirmacion.Controls.Add(eliminarusuariobtn);
            panelconfirmacion.Location = new Point(537, 484);
            panelconfirmacion.Margin = new Padding(3, 4, 3, 4);
            panelconfirmacion.Name = "panelconfirmacion";
            panelconfirmacion.Size = new Size(287, 273);
            panelconfirmacion.TabIndex = 34;
            panelconfirmacion.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(15, 81);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(256, 8);
            panel3.TabIndex = 3;
            // 
            // confirmarpasspanel
            // 
            confirmarpasspanel.Location = new Point(13, 153);
            confirmarpasspanel.Margin = new Padding(3, 4, 3, 4);
            confirmarpasspanel.Name = "confirmarpasspanel";
            confirmarpasspanel.Size = new Size(263, 27);
            confirmarpasspanel.TabIndex = 2;
            confirmarpasspanel.UseSystemPasswordChar = true;
            // 
            // adminlabel
            // 
            adminlabel.AutoSize = true;
            adminlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            adminlabel.ForeColor = SystemColors.Control;
            adminlabel.Location = new Point(13, 107);
            adminlabel.Name = "adminlabel";
            adminlabel.Size = new Size(160, 28);
            adminlabel.TabIndex = 1;
            adminlabel.Text = "Administrador: ";
            adminlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(13, 4);
            label8.Name = "label8";
            label8.Size = new Size(264, 69);
            label8.TabIndex = 1;
            label8.Text = "Coloque su contraseña para eliminar a este usuario";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancelarbtn
            // 
            cancelarbtn.Image = Properties.Resources.salida;
            cancelarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            cancelarbtn.Location = new Point(157, 197);
            cancelarbtn.Margin = new Padding(3, 4, 3, 4);
            cancelarbtn.Name = "cancelarbtn";
            cancelarbtn.Size = new Size(120, 59);
            cancelarbtn.TabIndex = 0;
            cancelarbtn.Text = "     Cancelar";
            cancelarbtn.UseVisualStyleBackColor = true;
            cancelarbtn.Click += cancelarbtn_Click;
            // 
            // eliminarusuariobtn
            // 
            eliminarusuariobtn.Image = Properties.Resources.basura;
            eliminarusuariobtn.ImageAlign = ContentAlignment.MiddleLeft;
            eliminarusuariobtn.Location = new Point(13, 197);
            eliminarusuariobtn.Margin = new Padding(3, 4, 3, 4);
            eliminarusuariobtn.Name = "eliminarusuariobtn";
            eliminarusuariobtn.Size = new Size(120, 59);
            eliminarusuariobtn.TabIndex = 0;
            eliminarusuariobtn.Text = "      Eliminar";
            eliminarusuariobtn.UseVisualStyleBackColor = true;
            eliminarusuariobtn.Click += eliminarusuariobtn_Click;
            // 
            // ConfirmPanelTransp
            // 
            ConfirmPanelTransp.BackColor = Color.Silver;
            ConfirmPanelTransp.Controls.Add(pictureBox3);
            ConfirmPanelTransp.Controls.Add(pictureBox2);
            ConfirmPanelTransp.Location = new Point(873, 484);
            ConfirmPanelTransp.Margin = new Padding(3, 4, 3, 4);
            ConfirmPanelTransp.Name = "ConfirmPanelTransp";
            ConfirmPanelTransp.Size = new Size(1001, 495);
            ConfirmPanelTransp.TabIndex = 36;
            ConfirmPanelTransp.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.alerta;
            pictureBox3.Location = new Point(685, 125);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(314, 275);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.alerta;
            pictureBox2.Location = new Point(3, 125);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(314, 275);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // MantUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1051, 497);
            Controls.Add(instrucciones);
            Controls.Add(panelconfirmacion);
            Controls.Add(ConfirmPanelTransp);
            Controls.Add(button1);
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
            Controls.Add(txtRegistroUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MantUsuarios";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Mantenimiento de Usuarios || Creando...";
            Load += MantUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            panelconfirmacion.ResumeLayout(false);
            panelconfirmacion.PerformLayout();
            ConfirmPanelTransp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label label8;
        private Button eliminarusuariobtn;
        private TextBox confirmarpasspanel;
        private Button cancelarbtn;
        private Panel panel3;
        private Button button1;
        public Label adminlabel;
        public Panel panelconfirmacion;
        private Panel ConfirmPanelTransp;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button instrucciones;
    }
}