namespace Proyecto_restaurante
{
    partial class ConsClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsClientes));
            txtbuscador = new TextBox();
            tabladatos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            eliminarbtn = new Button();
            label3 = new Label();
            Editar = new Button();
            agregar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label11 = new Label();
            clienteimg = new PictureBox();
            button1 = new Button();
            filtro = new CheckBox();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            guardarbtn = new Button();
            limpiarbtn = new Button();
            panel1 = new Panel();
            seleccionimagenbtn = new Button();
            imagencliente = new PictureBox();
            button2 = new Button();
            estadochk = new CheckBox();
            txtnumero = new TextBox();
            txtcedula = new TextBox();
            txtdireccion = new TextBox();
            txtapellido = new TextBox();
            idclientetxt = new TextBox();
            txtnombre = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            label12 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clienteimg).BeginInit();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagencliente).BeginInit();
            SuspendLayout();
            // 
            // txtbuscador
            // 
            txtbuscador.Font = new Font("Segoe UI", 12F);
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(10, 63);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(452, 29);
            txtbuscador.TabIndex = 1;
            txtbuscador.Text = "(ID, Nombre, Apellido)";
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.AllowUserToDeleteRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(10, 98);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(543, 348);
            tabladatos.TabIndex = 1;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(216, 3);
            label1.Name = "label1";
            label1.Size = new Size(295, 40);
            label1.TabIndex = 3;
            label1.Text = "Consulta de Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Image = Properties.Resources.busqueda;
            label2.Location = new Point(439, 67);
            label2.Name = "label2";
            label2.Size = new Size(18, 21);
            label2.TabIndex = 0;
            label2.Text = "  ";
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(522, 63);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(31, 29);
            eliminarbtn.TabIndex = 2;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(581, 56);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 48;
            label3.Text = "Acciones";
            // 
            // Editar
            // 
            Editar.Image = Properties.Resources.editarcliente1;
            Editar.Location = new Point(558, 175);
            Editar.Name = "Editar";
            Editar.Size = new Size(159, 72);
            Editar.TabIndex = 46;
            Editar.Text = "Editar";
            Editar.TextAlign = ContentAlignment.BottomCenter;
            Editar.UseVisualStyleBackColor = true;
            Editar.Click += Editar_Click;
            // 
            // agregar
            // 
            agregar.Image = Properties.Resources.cliente1;
            agregar.Location = new Point(558, 98);
            agregar.Name = "agregar";
            agregar.Size = new Size(159, 72);
            agregar.TabIndex = 47;
            agregar.Text = "Nuevo";
            agregar.TextAlign = ContentAlignment.BottomCenter;
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(734, 485);
            tabControl1.TabIndex = 49;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.WindowFrame;
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(clienteimg);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtbuscador);
            tabPage1.Controls.Add(Editar);
            tabPage1.Controls.Add(tabladatos);
            tabPage1.Controls.Add(agregar);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(eliminarbtn);
            tabPage1.Controls.Add(filtro);
            tabPage1.Font = new Font("Segoe UI", 12F);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(726, 451);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consulta";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(558, 418);
            label11.Name = "label11";
            label11.Size = new Size(67, 21);
            label11.TabIndex = 50;
            label11.Text = "Cedula:";
            // 
            // clienteimg
            // 
            clienteimg.ErrorImage = Properties.Resources.perfilcliente;
            clienteimg.Image = Properties.Resources.perfilcliente;
            clienteimg.InitialImage = Properties.Resources.perfilcliente;
            clienteimg.Location = new Point(559, 252);
            clienteimg.Name = "clienteimg";
            clienteimg.Size = new Size(158, 158);
            clienteimg.SizeMode = PictureBoxSizeMode.StretchImage;
            clienteimg.TabIndex = 49;
            clienteimg.TabStop = false;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.actualizar;
            button1.Location = new Point(10, 12);
            button1.Name = "button1";
            button1.Size = new Size(31, 29);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // filtro
            // 
            filtro.AutoSize = true;
            filtro.Checked = true;
            filtro.CheckState = CheckState.Checked;
            filtro.Cursor = Cursors.Hand;
            filtro.Font = new Font("Segoe UI", 13F);
            filtro.Image = Properties.Resources.sicheck;
            filtro.Location = new Point(476, 64);
            filtro.Name = "filtro";
            filtro.Size = new Size(41, 29);
            filtro.TabIndex = 51;
            filtro.Text = "  ";
            filtro.UseVisualStyleBackColor = true;
            filtro.CheckedChanged += filtro_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.WindowFrame;
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(estadochk);
            tabPage2.Controls.Add(txtnumero);
            tabPage2.Controls.Add(txtcedula);
            tabPage2.Controls.Add(txtdireccion);
            tabPage2.Controls.Add(txtapellido);
            tabPage2.Controls.Add(idclientetxt);
            tabPage2.Controls.Add(txtnombre);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label9);
            tabPage2.Font = new Font("Segoe UI", 12F);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(726, 451);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Creacion";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(guardarbtn);
            panel3.Controls.Add(limpiarbtn);
            panel3.Location = new Point(159, 365);
            panel3.Name = "panel3";
            panel3.Size = new Size(409, 74);
            panel3.TabIndex = 75;
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.guardar;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(12, 8);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(181, 58);
            guardarbtn.TabIndex = 20;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.nuevo;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(216, 8);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(181, 58);
            limpiarbtn.TabIndex = 19;
            limpiarbtn.Text = "Nuevo";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(seleccionimagenbtn);
            panel1.Controls.Add(imagencliente);
            panel1.Location = new Point(509, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 255);
            panel1.TabIndex = 28;
            // 
            // seleccionimagenbtn
            // 
            seleccionimagenbtn.BackColor = Color.Lime;
            seleccionimagenbtn.ForeColor = Color.Black;
            seleccionimagenbtn.Image = Properties.Resources.subir1;
            seleccionimagenbtn.Location = new Point(9, 191);
            seleccionimagenbtn.Name = "seleccionimagenbtn";
            seleccionimagenbtn.Size = new Size(181, 58);
            seleccionimagenbtn.TabIndex = 0;
            seleccionimagenbtn.Text = "Buscar Imagen";
            seleccionimagenbtn.TextAlign = ContentAlignment.BottomCenter;
            seleccionimagenbtn.UseVisualStyleBackColor = false;
            seleccionimagenbtn.Click += seleccionimagenbtn_Click;
            // 
            // imagencliente
            // 
            imagencliente.ErrorImage = Properties.Resources.perfilcliente;
            imagencliente.Image = Properties.Resources.perfilcliente;
            imagencliente.InitialImage = Properties.Resources.perfilcliente;
            imagencliente.Location = new Point(9, 6);
            imagencliente.Name = "imagencliente";
            imagencliente.Size = new Size(181, 181);
            imagencliente.SizeMode = PictureBoxSizeMode.StretchImage;
            imagencliente.TabIndex = 27;
            imagencliente.TabStop = false;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.atrás;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(611, 9);
            button2.Name = "button2";
            button2.Size = new Size(97, 29);
            button2.TabIndex = 26;
            button2.Text = " Volver";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(106, 303);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(72, 25);
            estadochk.TabIndex = 25;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(243, 187);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(172, 29);
            txtnumero.TabIndex = 4;
            txtnumero.TextChanged += txtnumero_TextChanged;
            txtnumero.KeyPress += txtnumero_KeyPress;
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(35, 187);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(172, 29);
            txtcedula.TabIndex = 3;
            txtcedula.TextChanged += txtcedula_TextChanged;
            txtcedula.KeyPress += txtcedula_KeyPress;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(35, 257);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(380, 29);
            txtdireccion.TabIndex = 5;
            txtdireccion.TextChanged += txtdireccion_TextChanged;
            txtdireccion.KeyPress += txtdireccion_KeyPress;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(243, 117);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(172, 29);
            txtapellido.TabIndex = 2;
            txtapellido.TextChanged += txtapellido_TextChanged;
            txtapellido.KeyPress += txtapellido_KeyPress;
            // 
            // idclientetxt
            // 
            idclientetxt.Enabled = false;
            idclientetxt.Location = new Point(67, 9);
            idclientetxt.Name = "idclientetxt";
            idclientetxt.Size = new Size(76, 29);
            idclientetxt.TabIndex = 12;
            idclientetxt.TextChanged += txtnombre_TextChanged;
            idclientetxt.KeyPress += txtnombre_KeyPress;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(35, 117);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(172, 29);
            txtnombre.TabIndex = 1;
            txtnombre.TextChanged += txtnombre_TextChanged;
            txtnombre.KeyPress += txtnombre_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(35, 160);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 13;
            label4.Text = "Cedula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(243, 160);
            label5.Name = "label5";
            label5.Size = new Size(165, 21);
            label5.TabIndex = 14;
            label5.Text = "Número de telefono";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(35, 230);
            label10.Name = "label10";
            label10.Size = new Size(83, 21);
            label10.TabIndex = 15;
            label10.Text = "Direccion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(243, 90);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 15;
            label6.Text = "Apellido";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(35, 305);
            label8.Name = "label8";
            label8.Size = new Size(65, 21);
            label8.TabIndex = 16;
            label8.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(216, 3);
            label7.Name = "label7";
            label7.Size = new Size(289, 40);
            label7.TabIndex = 17;
            label7.Text = "Registro de Clientes";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(35, 13);
            label12.Name = "label12";
            label12.Size = new Size(29, 21);
            label12.TabIndex = 18;
            label12.Text = "N°";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(35, 90);
            label9.Name = "label9";
            label9.Size = new Size(73, 21);
            label9.TabIndex = 18;
            label9.Text = "Nombre";
            // 
            // ConsClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(734, 485);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsClientes";
            StartPosition = FormStartPosition.Manual;
            Text = "Clientes";
            Load += ConsultaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clienteimg).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagencliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtbuscador;
        private DataGridView tabladatos;
        private Label label1;
        private Label label2;
        private Button eliminarbtn;
        private Label label3;
        private Button Editar;
        private Button agregar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private CheckBox estadochk;
        private TextBox txtnumero;
        private TextBox txtcedula;
        private TextBox txtapellido;
        private TextBox txtnombre;
        private Button limpiarbtn;
        private Button guardarbtn;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label9;
        private Button button1;
        private Button button2;
        private PictureBox imagencliente;
        private Panel panel1;
        private TextBox txtdireccion;
        private Label label10;
        private Button seleccionimagenbtn;
        private Panel panel3;
        private Label label11;
        private PictureBox clienteimg;
        private TextBox idclientetxt;
        private Label label12;
        private CheckBox filtro;
    }
}