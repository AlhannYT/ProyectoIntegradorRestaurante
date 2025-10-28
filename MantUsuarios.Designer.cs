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
            estadochk = new CheckBox();
            passView = new CheckBox();
            label5 = new Label();
            guardarbtn = new Button();
            limpiarbtn = new Button();
            txtconfirmarpass = new TextBox();
            confirmarpass = new Label();
            privilegiochk = new CheckBox();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            instrucciones = new Button();
            label6 = new Label();
            eliminarbtn = new Button();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label11 = new Label();
            clienteimg = new PictureBox();
            label7 = new Label();
            Editar = new Button();
            agregar = new Button();
            filtro = new CheckBox();
            button1 = new Button();
            tabPage2 = new TabPage();
            idclientetxt = new TextBox();
            label12 = new Label();
            idcategoriatxt = new TextBox();
            categoriatxt = new TextBox();
            label10 = new Label();
            buscarpuesto = new Button();
            empleadopanel = new Panel();
            idconsultatxt = new TextBox();
            categoriaconsultatxt = new TextBox();
            button5 = new Button();
            label9 = new Label();
            categoriaconsulta = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clienteimg).BeginInit();
            tabPage2.SuspendLayout();
            empleadopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoriaconsulta).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtRegistroUsuario
            // 
            txtRegistroUsuario.Location = new Point(84, 179);
            txtRegistroUsuario.Margin = new Padding(4);
            txtRegistroUsuario.Name = "txtRegistroUsuario";
            txtRegistroUsuario.Size = new Size(189, 29);
            txtRegistroUsuario.TabIndex = 0;
            txtRegistroUsuario.TextChanged += txtRegistroUsuario_TextChanged;
            txtRegistroUsuario.KeyPress += txtRegistroUsuario_KeyPress;
            // 
            // txtRegistroPass
            // 
            txtRegistroPass.Enabled = false;
            txtRegistroPass.Location = new Point(84, 257);
            txtRegistroPass.Margin = new Padding(4);
            txtRegistroPass.Name = "txtRegistroPass";
            txtRegistroPass.Size = new Size(189, 29);
            txtRegistroPass.TabIndex = 1;
            txtRegistroPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(84, 152);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 2;
            label2.Text = "Ingresar Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(84, 230);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 21);
            label3.TabIndex = 2;
            label3.Text = "Ingresar Contraseña";
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.Enabled = false;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(183, 375);
            estadochk.Margin = new Padding(4);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(72, 25);
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
            passView.Location = new Point(276, 257);
            passView.Margin = new Padding(4);
            passView.Name = "passView";
            passView.Size = new Size(29, 29);
            passView.TabIndex = 7;
            toolTip1.SetToolTip(passView, "Mostrar Contraseña");
            passView.UseVisualStyleBackColor = true;
            passView.CheckedChanged += passView_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(84, 377);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 2;
            label5.Text = "Estado: ";
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.guardar;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(12, 8);
            guardarbtn.Margin = new Padding(4);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(181, 58);
            guardarbtn.TabIndex = 8;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.nuevodoc;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(215, 8);
            limpiarbtn.Margin = new Padding(4);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(181, 58);
            limpiarbtn.TabIndex = 8;
            limpiarbtn.Text = "Nuevo";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // txtconfirmarpass
            // 
            txtconfirmarpass.Enabled = false;
            txtconfirmarpass.Location = new Point(84, 338);
            txtconfirmarpass.Margin = new Padding(4);
            txtconfirmarpass.Name = "txtconfirmarpass";
            txtconfirmarpass.Size = new Size(189, 29);
            txtconfirmarpass.TabIndex = 1;
            txtconfirmarpass.UseSystemPasswordChar = true;
            txtconfirmarpass.Visible = false;
            // 
            // confirmarpass
            // 
            confirmarpass.AutoSize = true;
            confirmarpass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            confirmarpass.ForeColor = SystemColors.Control;
            confirmarpass.Location = new Point(84, 305);
            confirmarpass.Margin = new Padding(4, 0, 4, 0);
            confirmarpass.Name = "confirmarpass";
            confirmarpass.Size = new Size(177, 21);
            confirmarpass.TabIndex = 2;
            confirmarpass.Text = "Confirmar Contraseña";
            confirmarpass.Visible = false;
            // 
            // privilegiochk
            // 
            privilegiochk.AutoSize = true;
            privilegiochk.Enabled = false;
            privilegiochk.ForeColor = Color.Black;
            privilegiochk.Location = new Point(183, 412);
            privilegiochk.Margin = new Padding(4);
            privilegiochk.Name = "privilegiochk";
            privilegiochk.Size = new Size(83, 25);
            privilegiochk.TabIndex = 6;
            privilegiochk.Text = "Usuario";
            privilegiochk.UseVisualStyleBackColor = true;
            privilegiochk.CheckedChanged += privilegiochk_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(84, 412);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 9;
            label4.Text = "Privilegio:";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Ayuda";
            // 
            // instrucciones
            // 
            instrucciones.BackColor = Color.White;
            instrucciones.Image = Properties.Resources.interrogatorio;
            instrucciones.Location = new Point(609, 50);
            instrucciones.Margin = new Padding(4);
            instrucciones.Name = "instrucciones";
            instrucciones.Size = new Size(31, 29);
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
            label6.Location = new Point(125, 13);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(306, 40);
            label6.TabIndex = 32;
            label6.Text = "Consulta de Usuarios";
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(373, 78);
            eliminarbtn.Margin = new Padding(4);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(35, 32);
            eliminarbtn.TabIndex = 29;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(11, 119);
            tabladatos.Margin = new Padding(4);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.RowHeadersWidth = 51;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(397, 413);
            tabladatos.TabIndex = 27;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(10, 80);
            txtbuscador.Margin = new Padding(4);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(308, 29);
            txtbuscador.TabIndex = 28;
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(141, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 40);
            label1.TabIndex = 33;
            label1.Text = "Registro de Usuarios";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(590, 575);
            tabControl1.TabIndex = 38;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.WindowFrame;
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(clienteimg);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(Editar);
            tabPage1.Controls.Add(agregar);
            tabPage1.Controls.Add(filtro);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(instrucciones);
            tabPage1.Controls.Add(txtbuscador);
            tabPage1.Controls.Add(tabladatos);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(eliminarbtn);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(582, 541);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consulta";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.Control;
            label11.Image = Properties.Resources.busqueda1;
            label11.Location = new Point(297, 84);
            label11.Name = "label11";
            label11.Size = new Size(18, 21);
            label11.TabIndex = 69;
            label11.Text = "  ";
            // 
            // clienteimg
            // 
            clienteimg.ErrorImage = Properties.Resources.perfilcliente;
            clienteimg.Image = Properties.Resources.perfilcliente;
            clienteimg.InitialImage = Properties.Resources.perfilcliente;
            clienteimg.Location = new Point(416, 275);
            clienteimg.Name = "clienteimg";
            clienteimg.Size = new Size(158, 158);
            clienteimg.SizeMode = PictureBoxSizeMode.StretchImage;
            clienteimg.TabIndex = 67;
            clienteimg.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(438, 78);
            label7.Name = "label7";
            label7.Size = new Size(116, 32);
            label7.TabIndex = 66;
            label7.Text = "Acciones";
            // 
            // Editar
            // 
            Editar.Image = Properties.Resources.editarcliente1;
            Editar.Location = new Point(415, 196);
            Editar.Name = "Editar";
            Editar.Size = new Size(159, 72);
            Editar.TabIndex = 64;
            Editar.Text = "Editar";
            Editar.TextAlign = ContentAlignment.BottomCenter;
            Editar.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            agregar.Image = Properties.Resources.cliente1;
            agregar.Location = new Point(415, 119);
            agregar.Name = "agregar";
            agregar.Size = new Size(159, 72);
            agregar.TabIndex = 65;
            agregar.Text = "Nuevo";
            agregar.TextAlign = ContentAlignment.BottomCenter;
            agregar.UseVisualStyleBackColor = true;
            // 
            // filtro
            // 
            filtro.AutoSize = true;
            filtro.Checked = true;
            filtro.CheckState = CheckState.Checked;
            filtro.Cursor = Cursors.Hand;
            filtro.Font = new Font("Segoe UI", 13F);
            filtro.Image = Properties.Resources.sicheck;
            filtro.Location = new Point(325, 80);
            filtro.Name = "filtro";
            filtro.Size = new Size(41, 29);
            filtro.TabIndex = 68;
            filtro.Text = "  ";
            filtro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.actualizar;
            button1.Location = new Point(11, 17);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(35, 32);
            button1.TabIndex = 29;
            button1.UseVisualStyleBackColor = true;
            button1.Click += eliminarbtn_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.WindowFrame;
            tabPage2.Controls.Add(idclientetxt);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(idcategoriatxt);
            tabPage2.Controls.Add(categoriatxt);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(buscarpuesto);
            tabPage2.Controls.Add(empleadopanel);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtRegistroUsuario);
            tabPage2.Controls.Add(txtRegistroPass);
            tabPage2.Controls.Add(txtconfirmarpass);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(confirmarpass);
            tabPage2.Controls.Add(estadochk);
            tabPage2.Controls.Add(privilegiochk);
            tabPage2.Controls.Add(passView);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(582, 541);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Creación";
            // 
            // idclientetxt
            // 
            idclientetxt.Enabled = false;
            idclientetxt.Location = new Point(43, 16);
            idclientetxt.Name = "idclientetxt";
            idclientetxt.Size = new Size(64, 29);
            idclientetxt.TabIndex = 106;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(7, 20);
            label12.Name = "label12";
            label12.Size = new Size(27, 21);
            label12.TabIndex = 107;
            label12.Text = "ID";
            // 
            // idcategoriatxt
            // 
            idcategoriatxt.Location = new Point(84, 106);
            idcategoriatxt.Name = "idcategoriatxt";
            idcategoriatxt.Size = new Size(46, 29);
            idcategoriatxt.TabIndex = 102;
            // 
            // categoriatxt
            // 
            categoriatxt.Location = new Point(133, 106);
            categoriatxt.Name = "categoriatxt";
            categoriatxt.Size = new Size(140, 29);
            categoriatxt.TabIndex = 103;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(84, 82);
            label10.Name = "label10";
            label10.Size = new Size(87, 21);
            label10.TabIndex = 101;
            label10.Text = "Empleado";
            // 
            // buscarpuesto
            // 
            buscarpuesto.ForeColor = Color.Black;
            buscarpuesto.Image = Properties.Resources.busqueda;
            buscarpuesto.Location = new Point(276, 106);
            buscarpuesto.Name = "buscarpuesto";
            buscarpuesto.Size = new Size(29, 29);
            buscarpuesto.TabIndex = 104;
            buscarpuesto.UseVisualStyleBackColor = true;
            // 
            // empleadopanel
            // 
            empleadopanel.BackColor = Color.FromArgb(64, 64, 64);
            empleadopanel.Controls.Add(idconsultatxt);
            empleadopanel.Controls.Add(categoriaconsultatxt);
            empleadopanel.Controls.Add(button5);
            empleadopanel.Controls.Add(label9);
            empleadopanel.Controls.Add(categoriaconsulta);
            empleadopanel.Location = new Point(310, 106);
            empleadopanel.Name = "empleadopanel";
            empleadopanel.Size = new Size(256, 147);
            empleadopanel.TabIndex = 105;
            empleadopanel.Visible = false;
            // 
            // idconsultatxt
            // 
            idconsultatxt.Location = new Point(4, 28);
            idconsultatxt.Name = "idconsultatxt";
            idconsultatxt.Size = new Size(31, 29);
            idconsultatxt.TabIndex = 58;
            // 
            // categoriaconsultatxt
            // 
            categoriaconsultatxt.Location = new Point(37, 28);
            categoriaconsultatxt.Name = "categoriaconsultatxt";
            categoriaconsultatxt.Size = new Size(179, 29);
            categoriaconsultatxt.TabIndex = 58;
            // 
            // button5
            // 
            button5.ForeColor = Color.Black;
            button5.Image = Properties.Resources.angulo_hacia_arriba;
            button5.Location = new Point(220, 28);
            button5.Name = "button5";
            button5.Size = new Size(29, 29);
            button5.TabIndex = 60;
            button5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(5, 2);
            label9.Name = "label9";
            label9.Size = new Size(179, 21);
            label9.TabIndex = 50;
            label9.Text = "Seleccionar empleado";
            // 
            // categoriaconsulta
            // 
            categoriaconsulta.AllowUserToAddRows = false;
            categoriaconsulta.AllowUserToDeleteRows = false;
            categoriaconsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoriaconsulta.Location = new Point(4, 63);
            categoriaconsulta.MultiSelect = false;
            categoriaconsulta.Name = "categoriaconsulta";
            categoriaconsulta.ReadOnly = true;
            categoriaconsulta.RowHeadersWidth = 51;
            categoriaconsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categoriaconsulta.Size = new Size(245, 78);
            categoriaconsulta.TabIndex = 74;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(guardarbtn);
            panel1.Controls.Add(limpiarbtn);
            panel1.Location = new Point(87, 458);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 74);
            panel1.TabIndex = 76;
            // 
            // MantUsuarios
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(590, 575);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MantUsuarios";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Usuarios";
            Load += MantUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clienteimg).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            empleadopanel.ResumeLayout(false);
            empleadopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoriaconsulta).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtRegistroUsuario;
        private TextBox txtRegistroPass;
        private Label label2;
        private Label label3;
        private CheckBox estadochk;
        private CheckBox passView;
        private Label label5;
        private Button guardarbtn;
        private Button limpiarbtn;
        private TextBox txtconfirmarpass;
        private Label confirmarpass;
        private CheckBox privilegiochk;
        private Label label4;
        private ToolTip toolTip1;
        private Label label6;
        private Button eliminarbtn;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private Label label1;
        private Button instrucciones;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private TextBox idcategoriatxt;
        private TextBox categoriatxt;
        private Label label10;
        private Button buscarpuesto;
        private Panel empleadopanel;
        private TextBox idconsultatxt;
        private TextBox categoriaconsultatxt;
        private Button button5;
        private Label label9;
        private DataGridView categoriaconsulta;
        private TextBox idclientetxt;
        private Label label12;
        private PictureBox clienteimg;
        private Label label7;
        private Button Editar;
        private Button agregar;
        private CheckBox filtro;
        private Label label11;
        private Button button1;
    }
}