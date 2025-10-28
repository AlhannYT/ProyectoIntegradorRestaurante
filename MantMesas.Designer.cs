namespace Proyecto_restaurante
{
    partial class MantMesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantMesas));
            toolTip1 = new ToolTip(components);
            recargarbtn = new Button();
            button1 = new Button();
            label5 = new Label();
            eliminarbtn = new Button();
            txtbuscador = new TextBox();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            label14 = new Label();
            filtro = new CheckBox();
            label4 = new Label();
            Editar = new Button();
            agregar = new Button();
            panelMesas = new FlowLayoutPanel();
            tabPage4 = new TabPage();
            idclientetxt = new TextBox();
            label13 = new Label();
            idcategoriatxt = new TextBox();
            categoriatxt = new TextBox();
            buscarpuesto = new Button();
            categoriapanel = new Panel();
            idconsultatxt = new TextBox();
            categoriaconsultatxt = new TextBox();
            button5 = new Button();
            label8 = new Label();
            categoriaconsulta = new DataGridView();
            panel3 = new Panel();
            guardarbtn = new Button();
            limpiarbtn = new Button();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            label10 = new Label();
            txtnombreMesa = new TextBox();
            label3 = new Label();
            txtNumAsientos = new TextBox();
            button2 = new Button();
            tabPage1 = new TabPage();
            selecmetodo = new Button();
            metfiltrochk = new CheckBox();
            metbuscar = new TextBox();
            label15 = new Label();
            tabladatos = new DataGridView();
            panel1 = new Panel();
            button3 = new Button();
            button4 = new Button();
            estadochk = new CheckBox();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtnombresala = new TextBox();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            categoriapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoriaconsulta).BeginInit();
            panel3.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Ayuda";
            // 
            // recargarbtn
            // 
            recargarbtn.Image = Properties.Resources.actualizar;
            recargarbtn.Location = new Point(10, 14);
            recargarbtn.Name = "recargarbtn";
            recargarbtn.Size = new Size(29, 29);
            recargarbtn.TabIndex = 51;
            recargarbtn.TabStop = false;
            toolTip1.SetToolTip(recargarbtn, "Recargar Datos");
            recargarbtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.actualizar;
            button1.Location = new Point(10, 14);
            button1.Name = "button1";
            button1.Size = new Size(29, 29);
            button1.TabIndex = 64;
            button1.TabStop = false;
            toolTip1.SetToolTip(button1, "Recargar Datos");
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(216, 8);
            label5.Name = "label5";
            label5.Size = new Size(273, 40);
            label5.TabIndex = 24;
            label5.Text = "Consulta de Mesas";
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(504, 88);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 29);
            eliminarbtn.TabIndex = 22;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(10, 88);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(439, 29);
            txtbuscador.TabIndex = 21;
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Font = new Font("Segoe UI", 12F);
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(713, 467);
            tabControl2.TabIndex = 27;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.WindowFrame;
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(filtro);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(Editar);
            tabPage3.Controls.Add(agregar);
            tabPage3.Controls.Add(panelMesas);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(eliminarbtn);
            tabPage3.Controls.Add(txtbuscador);
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(705, 433);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Consulta";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.ForeColor = SystemColors.Control;
            label14.Image = Properties.Resources.busqueda;
            label14.Location = new Point(426, 92);
            label14.Name = "label14";
            label14.Size = new Size(18, 21);
            label14.TabIndex = 66;
            label14.Text = "  ";
            // 
            // filtro
            // 
            filtro.AutoSize = true;
            filtro.Checked = true;
            filtro.CheckState = CheckState.Checked;
            filtro.Cursor = Cursors.Hand;
            filtro.Font = new Font("Segoe UI", 13F);
            filtro.Image = Properties.Resources.sicheck;
            filtro.Location = new Point(459, 88);
            filtro.Name = "filtro";
            filtro.Size = new Size(41, 29);
            filtro.TabIndex = 65;
            filtro.Text = "  ";
            filtro.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(562, 86);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 63;
            label4.Text = "Acciones";
            // 
            // Editar
            // 
            Editar.Image = Properties.Resources.editar;
            Editar.Location = new Point(539, 201);
            Editar.Name = "Editar";
            Editar.Size = new Size(159, 72);
            Editar.TabIndex = 61;
            Editar.Text = "Editar";
            Editar.TextAlign = ContentAlignment.BottomCenter;
            Editar.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            agregar.Image = Properties.Resources.mesa2;
            agregar.Location = new Point(539, 123);
            agregar.Name = "agregar";
            agregar.Size = new Size(159, 72);
            agregar.TabIndex = 62;
            agregar.Text = "Nuevo";
            agregar.TextAlign = ContentAlignment.BottomCenter;
            agregar.UseVisualStyleBackColor = true;
            // 
            // panelMesas
            // 
            panelMesas.AutoScroll = true;
            panelMesas.BackColor = Color.FromArgb(64, 64, 64);
            panelMesas.Location = new Point(10, 123);
            panelMesas.Name = "panelMesas";
            panelMesas.Size = new Size(523, 302);
            panelMesas.TabIndex = 25;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.WindowFrame;
            tabPage4.Controls.Add(idclientetxt);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(idcategoriatxt);
            tabPage4.Controls.Add(categoriatxt);
            tabPage4.Controls.Add(buscarpuesto);
            tabPage4.Controls.Add(categoriapanel);
            tabPage4.Controls.Add(panel3);
            tabPage4.Controls.Add(checkBox2);
            tabPage4.Controls.Add(checkBox1);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(txtnombreMesa);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(txtNumAsientos);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(recargarbtn);
            tabPage4.Location = new Point(4, 30);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(705, 433);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Creación";
            // 
            // idclientetxt
            // 
            idclientetxt.Enabled = false;
            idclientetxt.Location = new Point(621, 14);
            idclientetxt.Name = "idclientetxt";
            idclientetxt.Size = new Size(76, 29);
            idclientetxt.TabIndex = 105;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(585, 18);
            label13.Name = "label13";
            label13.Size = new Size(27, 21);
            label13.TabIndex = 106;
            label13.Text = "ID";
            // 
            // idcategoriatxt
            // 
            idcategoriatxt.Location = new Point(356, 152);
            idcategoriatxt.Name = "idcategoriatxt";
            idcategoriatxt.Size = new Size(48, 29);
            idcategoriatxt.TabIndex = 102;
            // 
            // categoriatxt
            // 
            categoriatxt.Location = new Point(406, 152);
            categoriatxt.Name = "categoriatxt";
            categoriatxt.Size = new Size(117, 29);
            categoriatxt.TabIndex = 103;
            // 
            // buscarpuesto
            // 
            buscarpuesto.ForeColor = Color.Black;
            buscarpuesto.Image = Properties.Resources.busqueda;
            buscarpuesto.Location = new Point(526, 152);
            buscarpuesto.Name = "buscarpuesto";
            buscarpuesto.Size = new Size(28, 29);
            buscarpuesto.TabIndex = 104;
            buscarpuesto.UseVisualStyleBackColor = true;
            // 
            // categoriapanel
            // 
            categoriapanel.BackColor = Color.FromArgb(64, 64, 64);
            categoriapanel.Controls.Add(idconsultatxt);
            categoriapanel.Controls.Add(categoriaconsultatxt);
            categoriapanel.Controls.Add(button5);
            categoriapanel.Controls.Add(label8);
            categoriapanel.Controls.Add(categoriaconsulta);
            categoriapanel.Location = new Point(355, 186);
            categoriapanel.Name = "categoriapanel";
            categoriapanel.Size = new Size(204, 147);
            categoriapanel.TabIndex = 101;
            categoriapanel.Visible = false;
            // 
            // idconsultatxt
            // 
            idconsultatxt.Location = new Point(4, 28);
            idconsultatxt.Name = "idconsultatxt";
            idconsultatxt.Size = new Size(42, 29);
            idconsultatxt.TabIndex = 58;
            // 
            // categoriaconsultatxt
            // 
            categoriaconsultatxt.Location = new Point(51, 28);
            categoriaconsultatxt.Name = "categoriaconsultatxt";
            categoriaconsultatxt.Size = new Size(118, 29);
            categoriaconsultatxt.TabIndex = 58;
            // 
            // button5
            // 
            button5.ForeColor = Color.Black;
            button5.Image = Properties.Resources.angulo_hacia_arriba;
            button5.Location = new Point(171, 28);
            button5.Name = "button5";
            button5.Size = new Size(28, 29);
            button5.TabIndex = 60;
            button5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(4, 2);
            label8.Name = "label8";
            label8.Size = new Size(132, 21);
            label8.TabIndex = 50;
            label8.Text = "Seleccionar sala";
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
            categoriaconsulta.Size = new Size(195, 78);
            categoriaconsulta.TabIndex = 74;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(guardarbtn);
            panel3.Controls.Add(limpiarbtn);
            panel3.Location = new Point(148, 344);
            panel3.Name = "panel3";
            panel3.Size = new Size(409, 74);
            panel3.TabIndex = 94;
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.guardar;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(11, 8);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(181, 58);
            guardarbtn.TabIndex = 27;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.nuevodoc;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(217, 8);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(181, 58);
            limpiarbtn.TabIndex = 28;
            limpiarbtn.Text = "Nuevo";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox2.ForeColor = Color.Lime;
            checkBox2.Location = new Point(216, 83);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(78, 25);
            checkBox2.TabIndex = 54;
            checkBox2.Text = "Activo";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox1.ForeColor = Color.Lime;
            checkBox1.Location = new Point(440, 83);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(43, 25);
            checkBox1.TabIndex = 54;
            checkBox1.Text = "Si";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(356, 127);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 40;
            label1.Text = "Sala";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(148, 85);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 39;
            label6.Text = "Estado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(358, 85);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 39;
            label7.Text = "Ocupada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(148, 127);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 35;
            label2.Text = "Nombre Mesa";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(219, 8);
            label10.Name = "label10";
            label10.Size = new Size(267, 40);
            label10.TabIndex = 31;
            label10.Text = "Registro de Mesas";
            // 
            // txtnombreMesa
            // 
            txtnombreMesa.Location = new Point(148, 152);
            txtnombreMesa.Name = "txtnombreMesa";
            txtnombreMesa.Size = new Size(163, 29);
            txtnombreMesa.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(148, 200);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 33;
            label3.Text = "Capacidad";
            // 
            // txtNumAsientos
            // 
            txtNumAsientos.Location = new Point(148, 224);
            txtNumAsientos.Name = "txtNumAsientos";
            txtNumAsientos.Size = new Size(163, 29);
            txtNumAsientos.TabIndex = 43;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.mas;
            button2.Location = new Point(556, 152);
            button2.Name = "button2";
            button2.Size = new Size(29, 29);
            button2.TabIndex = 50;
            button2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.WindowFrame;
            tabPage1.Controls.Add(selecmetodo);
            tabPage1.Controls.Add(metfiltrochk);
            tabPage1.Controls.Add(metbuscar);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(tabladatos);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(estadochk);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(txtnombresala);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(705, 433);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Salas";
            // 
            // selecmetodo
            // 
            selecmetodo.Image = Properties.Resources.seleccion;
            selecmetodo.ImageAlign = ContentAlignment.MiddleLeft;
            selecmetodo.Location = new Point(277, 278);
            selecmetodo.Name = "selecmetodo";
            selecmetodo.Size = new Size(138, 26);
            selecmetodo.TabIndex = 98;
            selecmetodo.Text = "Seleccionar";
            selecmetodo.UseVisualStyleBackColor = true;
            // 
            // metfiltrochk
            // 
            metfiltrochk.AutoSize = true;
            metfiltrochk.Checked = true;
            metfiltrochk.CheckState = CheckState.Checked;
            metfiltrochk.Font = new Font("Segoe UI", 15F);
            metfiltrochk.Image = Properties.Resources.sicheck;
            metfiltrochk.Location = new Point(277, 375);
            metfiltrochk.Name = "metfiltrochk";
            metfiltrochk.Size = new Size(61, 32);
            metfiltrochk.TabIndex = 100;
            metfiltrochk.Text = "      ";
            metfiltrochk.UseVisualStyleBackColor = true;
            // 
            // metbuscar
            // 
            metbuscar.Location = new Point(277, 346);
            metbuscar.Name = "metbuscar";
            metbuscar.Size = new Size(138, 29);
            metbuscar.TabIndex = 99;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label15.Image = Properties.Resources.filtrar;
            label15.ImageAlign = ContentAlignment.MiddleRight;
            label15.Location = new Point(277, 314);
            label15.Name = "label15";
            label15.Size = new Size(77, 21);
            label15.TabIndex = 97;
            label15.Text = "Filtros     ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(8, 278);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.RowHeadersWidth = 51;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(263, 140);
            tabladatos.TabIndex = 96;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(148, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 74);
            panel1.TabIndex = 95;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.guardar;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(11, 8);
            button3.Name = "button3";
            button3.Size = new Size(181, 58);
            button3.TabIndex = 27;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.nuevodoc;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(217, 8);
            button4.Name = "button4";
            button4.Size = new Size(181, 58);
            button4.TabIndex = 28;
            button4.Text = "Nuevo";
            button4.UseVisualStyleBackColor = true;
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(304, 139);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(78, 25);
            estadochk.TabIndex = 35;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(227, 140);
            label9.Name = "label9";
            label9.Size = new Size(65, 21);
            label9.TabIndex = 31;
            label9.Text = "Estado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(227, 8);
            label11.Name = "label11";
            label11.Size = new Size(250, 40);
            label11.TabIndex = 32;
            label11.Text = "Registro de Salas";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(227, 69);
            label12.Name = "label12";
            label12.Size = new Size(109, 21);
            label12.TabIndex = 33;
            label12.Text = "Nombre Sala";
            // 
            // txtnombresala
            // 
            txtnombresala.Location = new Point(229, 95);
            txtnombresala.Name = "txtnombresala";
            txtnombresala.Size = new Size(248, 29);
            txtnombresala.TabIndex = 30;
            // 
            // MantMesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(713, 467);
            Controls.Add(tabControl2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MantMesas";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Mesas";
            Load += MantMesas_Load;
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            categoriapanel.ResumeLayout(false);
            categoriapanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoriaconsulta).EndInit();
            panel3.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        private Label label5;
        private Button eliminarbtn;
        private TextBox txtbuscador;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private CheckBox checkBox1;
        private Button guardarbtn;
        private Button limpiarbtn;
        private Label label1;
        private Label label7;
        private Label label2;
        private Label label10;
        private TextBox txtnombreMesa;
        private Label label3;
        private TextBox txtNumAsientos;
        public Button recargarbtn;
        private TabPage tabPage1;
        private FlowLayoutPanel panelMesas;
        public Button button1;
        private Label label4;
        private Button Editar;
        private Button agregar;
        private CheckBox checkBox2;
        private Label label6;
        private Panel panel3;
        private Panel categoriapanel;
        private TextBox idconsultatxt;
        private TextBox categoriaconsultatxt;
        private Button button5;
        private Label label8;
        private DataGridView categoriaconsulta;
        private Button button2;
        private TextBox idcategoriatxt;
        private TextBox categoriatxt;
        private Button buscarpuesto;
        private CheckBox estadochk;
        private Label label9;
        private Label label11;
        private Label label12;
        private TextBox txtnombresala;
        private Panel panel1;
        private Button button3;
        private Button button4;
        private TextBox idclientetxt;
        private Label label13;
        private CheckBox filtro;
        private Label label14;
        private DataGridView tabladatos;
        private Button selecmetodo;
        private CheckBox metfiltrochk;
        private TextBox metbuscar;
        private Label label15;
    }
}