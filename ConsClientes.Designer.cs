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
            nombrelabel = new Label();
            direccionlabel = new Label();
            idenlabel = new Label();
            clienteimg = new PictureBox();
            button1 = new Button();
            filtro = new CheckBox();
            tabPage2 = new TabPage();
            tipodoccmbx = new ComboBox();
            label14 = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            label19 = new Label();
            textBox3 = new TextBox();
            numerotxt = new TextBox();
            label13 = new Label();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            dataGridView1 = new DataGridView();
            ingredientesconsulta = new DataGridView();
            button7 = new Button();
            button4 = new Button();
            button6 = new Button();
            button3 = new Button();
            nombredirecciontxt = new TextBox();
            nombrenumerotxt = new TextBox();
            panel3 = new Panel();
            guardarbtn = new Button();
            limpiarbtn = new Button();
            panel1 = new Panel();
            seleccionimagenbtn = new Button();
            imagencliente = new PictureBox();
            button2 = new Button();
            estadochk = new CheckBox();
            txtapellido = new TextBox();
            idclientetxt = new TextBox();
            identtxt = new TextBox();
            txtnombre = new TextBox();
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
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredientesconsulta).BeginInit();
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
            tabladatos.Size = new Size(543, 541);
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
            tabControl1.Size = new Size(734, 679);
            tabControl1.TabIndex = 49;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.WindowFrame;
            tabPage1.Controls.Add(nombrelabel);
            tabPage1.Controls.Add(direccionlabel);
            tabPage1.Controls.Add(idenlabel);
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
            tabPage1.Size = new Size(726, 645);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consulta";
            // 
            // nombrelabel
            // 
            nombrelabel.AutoSize = true;
            nombrelabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombrelabel.ForeColor = Color.White;
            nombrelabel.Location = new Point(558, 431);
            nombrelabel.Name = "nombrelabel";
            nombrelabel.Size = new Size(154, 21);
            nombrelabel.TabIndex = 50;
            nombrelabel.Text = "Nombre completo:";
            // 
            // direccionlabel
            // 
            direccionlabel.AutoSize = true;
            direccionlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            direccionlabel.ForeColor = Color.White;
            direccionlabel.Location = new Point(558, 564);
            direccionlabel.Name = "direccionlabel";
            direccionlabel.Size = new Size(155, 21);
            direccionlabel.TabIndex = 50;
            direccionlabel.Text = "Direccion principal";
            // 
            // idenlabel
            // 
            idenlabel.AutoSize = true;
            idenlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idenlabel.ForeColor = Color.White;
            idenlabel.Location = new Point(558, 496);
            idenlabel.Name = "idenlabel";
            idenlabel.Size = new Size(107, 21);
            idenlabel.TabIndex = 50;
            idenlabel.Text = "Cedula/RNC:";
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
            button1.Size = new Size(29, 29);
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
            tabPage2.Controls.Add(tipodoccmbx);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(estadochk);
            tabPage2.Controls.Add(txtapellido);
            tabPage2.Controls.Add(idclientetxt);
            tabPage2.Controls.Add(identtxt);
            tabPage2.Controls.Add(txtnombre);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label9);
            tabPage2.Font = new Font("Segoe UI", 12F);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(726, 645);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Creación";
            // 
            // tipodoccmbx
            // 
            tipodoccmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            tipodoccmbx.FormattingEnabled = true;
            tipodoccmbx.Items.AddRange(new object[] { "RNC", "Cedula" });
            tipodoccmbx.Location = new Point(11, 259);
            tipodoccmbx.Name = "tipodoccmbx";
            tipodoccmbx.Size = new Size(70, 29);
            tipodoccmbx.TabIndex = 100;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(11, 236);
            label14.Name = "label14";
            label14.Size = new Size(211, 21);
            label14.TabIndex = 99;
            label14.Text = "Documento de indentidad";
            // 
            // panel4
            // 
            panel4.Location = new Point(458, 365);
            panel4.Name = "panel4";
            panel4.Size = new Size(258, 26);
            panel4.TabIndex = 98;
            // 
            // panel2
            // 
            panel2.Location = new Point(214, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(129, 26);
            panel2.TabIndex = 97;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(numerotxt);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(checkBox2);
            panel5.Controls.Add(checkBox1);
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(ingredientesconsulta);
            panel5.Controls.Add(button7);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(button6);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(nombredirecciontxt);
            panel5.Controls.Add(nombrenumerotxt);
            panel5.Location = new Point(11, 365);
            panel5.Name = "panel5";
            panel5.Size = new Size(705, 206);
            panel5.TabIndex = 96;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label19.ForeColor = Color.White;
            label19.Image = Properties.Resources.ubicacion;
            label19.ImageAlign = ContentAlignment.MiddleRight;
            label19.Location = new Point(339, 5);
            label19.Name = "label19";
            label19.Size = new Size(103, 21);
            label19.TabIndex = 55;
            label19.Text = "Direccion     ";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(411, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 29);
            textBox3.TabIndex = 79;
            // 
            // numerotxt
            // 
            numerotxt.Enabled = false;
            numerotxt.Location = new Point(81, 36);
            numerotxt.Name = "numerotxt";
            numerotxt.Size = new Size(113, 29);
            numerotxt.TabIndex = 79;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Image = Properties.Resources.telefonoblanco;
            label13.ImageAlign = ContentAlignment.MiddleRight;
            label13.Location = new Point(9, 5);
            label13.Name = "label13";
            label13.Size = new Size(185, 21);
            label13.TabIndex = 55;
            label13.Text = "Numero de telefono     ";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(575, 38);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(89, 25);
            checkBox2.TabIndex = 90;
            checkBox2.Text = "Principal";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(201, 38);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 25);
            checkBox1.TabIndex = 90;
            checkBox1.Text = "Principal";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(339, 71);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(324, 129);
            dataGridView1.TabIndex = 74;
            // 
            // ingredientesconsulta
            // 
            ingredientesconsulta.AllowUserToAddRows = false;
            ingredientesconsulta.AllowUserToDeleteRows = false;
            ingredientesconsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ingredientesconsulta.Location = new Point(9, 69);
            ingredientesconsulta.MultiSelect = false;
            ingredientesconsulta.Name = "ingredientesconsulta";
            ingredientesconsulta.ReadOnly = true;
            ingredientesconsulta.RowHeadersWidth = 51;
            ingredientesconsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ingredientesconsulta.Size = new Size(281, 129);
            ingredientesconsulta.TabIndex = 74;
            // 
            // button7
            // 
            button7.BackColor = Color.Red;
            button7.Enabled = false;
            button7.Image = Properties.Resources.basurablanco;
            button7.Location = new Point(669, 171);
            button7.Name = "button7";
            button7.Size = new Size(28, 29);
            button7.TabIndex = 77;
            button7.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Image = Properties.Resources.angulo_hacia_abajo;
            button4.Location = new Point(669, 36);
            button4.Name = "button4";
            button4.Size = new Size(28, 29);
            button4.TabIndex = 77;
            button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Enabled = false;
            button6.Image = Properties.Resources.basurablanco;
            button6.Location = new Point(295, 169);
            button6.Name = "button6";
            button6.Size = new Size(28, 29);
            button6.TabIndex = 77;
            button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Image = Properties.Resources.angulo_hacia_abajo;
            button3.Location = new Point(295, 36);
            button3.Name = "button3";
            button3.Size = new Size(28, 29);
            button3.TabIndex = 77;
            button3.UseVisualStyleBackColor = true;
            // 
            // nombredirecciontxt
            // 
            nombredirecciontxt.Enabled = false;
            nombredirecciontxt.Location = new Point(339, 36);
            nombredirecciontxt.Name = "nombredirecciontxt";
            nombredirecciontxt.Size = new Size(66, 29);
            nombredirecciontxt.TabIndex = 79;
            // 
            // nombrenumerotxt
            // 
            nombrenumerotxt.Enabled = false;
            nombrenumerotxt.Location = new Point(9, 36);
            nombrenumerotxt.Name = "nombrenumerotxt";
            nombrenumerotxt.Size = new Size(66, 29);
            nombrenumerotxt.TabIndex = 79;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(guardarbtn);
            panel3.Controls.Add(limpiarbtn);
            panel3.Location = new Point(159, 568);
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
            panel1.Location = new Point(509, 68);
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
            estadochk.Location = new Point(596, 328);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(72, 25);
            estadochk.TabIndex = 25;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(11, 188);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(363, 29);
            txtapellido.TabIndex = 2;
            txtapellido.TextChanged += txtapellido_TextChanged;
            txtapellido.KeyPress += txtapellido_KeyPress;
            // 
            // idclientetxt
            // 
            idclientetxt.Enabled = false;
            idclientetxt.Location = new Point(43, 9);
            idclientetxt.Name = "idclientetxt";
            idclientetxt.Size = new Size(76, 29);
            idclientetxt.TabIndex = 12;
            idclientetxt.TextChanged += txtnombre_TextChanged;
            idclientetxt.KeyPress += txtnombre_KeyPress;
            // 
            // identtxt
            // 
            identtxt.Location = new Point(87, 259);
            identtxt.Name = "identtxt";
            identtxt.Size = new Size(132, 29);
            identtxt.TabIndex = 1;
            identtxt.TextChanged += txtcedula_TextChanged;
            identtxt.KeyPress += txtnombre_KeyPress;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(11, 117);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(363, 29);
            txtnombre.TabIndex = 1;
            txtnombre.TextChanged += txtnombre_TextChanged;
            txtnombre.KeyPress += txtnombre_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(11, 163);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 15;
            label6.Text = "Apellido(s)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(525, 330);
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
            label7.Location = new Point(219, 3);
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
            label12.Location = new Point(11, 13);
            label12.Name = "label12";
            label12.Size = new Size(27, 21);
            label12.TabIndex = 18;
            label12.Text = "ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(11, 90);
            label9.Name = "label9";
            label9.Size = new Size(92, 21);
            label9.TabIndex = 18;
            label9.Text = "Nombre(s)";
            // 
            // ConsClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(734, 679);
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
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredientesconsulta).EndInit();
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
        private TextBox txtapellido;
        private TextBox txtnombre;
        private Button limpiarbtn;
        private Button guardarbtn;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label9;
        private Button button1;
        private Button button2;
        private PictureBox imagencliente;
        private Panel panel1;
        private Button seleccionimagenbtn;
        private Panel panel3;
        private Label idenlabel;
        private PictureBox clienteimg;
        private TextBox idclientetxt;
        private Label label12;
        private CheckBox filtro;
        private Panel panel4;
        private Panel panel2;
        private Panel panel5;
        private Label label19;
        private TextBox textBox3;
        private TextBox numerotxt;
        private Label label13;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
        private DataGridView ingredientesconsulta;
        private Button button7;
        private Button button4;
        private Button button6;
        private Button button3;
        private TextBox nombredirecciontxt;
        private TextBox nombrenumerotxt;
        private Label nombrelabel;
        private Label direccionlabel;
        private ComboBox tipodoccmbx;
        private Label label14;
        private TextBox identtxt;
    }
}