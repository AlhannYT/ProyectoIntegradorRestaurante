namespace Proyecto_restaurante
{
    partial class ConsProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsProductos));
            label11 = new Label();
            eliminarbtn = new Button();
            label12 = new Label();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            agregar = new Button();
            Editar = new Button();
            panel1 = new Panel();
            label2 = new Label();
            imagenproducto = new PictureBox();
            label1 = new Label();
            recargarbtn = new Button();
            tabControl1 = new TabControl();
            consulta = new TabPage();
            filtroingredientes = new CheckBox();
            filtroplatos = new CheckBox();
            filtrotodos = new CheckBox();
            filtro = new CheckBox();
            label15 = new Label();
            creacion = new TabPage();
            panel6 = new Panel();
            panel3 = new Panel();
            idregproducto = new TextBox();
            label18 = new Label();
            idcategoriatxt = new TextBox();
            imagenpanel = new Panel();
            imagenprod = new PictureBox();
            seleccionimagenbtn = new Button();
            panel4 = new Panel();
            guardarbtn = new Button();
            limpiarbtn = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label13 = new Label();
            txtprecio_compra = new TextBox();
            categoriatxt = new TextBox();
            txtnombre_prod = new TextBox();
            txtcodigo_barras = new TextBox();
            txtprecio_venta = new TextBox();
            label16 = new Label();
            label21 = new Label();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label17 = new Label();
            label10 = new Label();
            label14 = new Label();
            estadochk = new CheckBox();
            codigobarrarandombtn = new Button();
            buscarcateg = new Button();
            panel5 = new Panel();
            label19 = new Label();
            textBox1 = new TextBox();
            numCantidad = new NumericUpDown();
            label6 = new Label();
            txtnombre = new TextBox();
            recetaingredientes = new DataGridView();
            buscarprodbtn = new Button();
            ingredientesconsulta = new DataGridView();
            button3 = new Button();
            textBox2 = new TextBox();
            txtcodigo = new TextBox();
            agregarbtn = new Button();
            unidadmedida = new ComboBox();
            ITBIS = new ComboBox();
            categoriapanel = new Panel();
            idconsultatxt = new TextBox();
            categoriaconsultatxt = new TextBox();
            button4 = new Button();
            label9 = new Label();
            categoriaconsulta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenproducto).BeginInit();
            tabControl1.SuspendLayout();
            consulta.SuspendLayout();
            creacion.SuspendLayout();
            imagenpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenprod).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recetaingredientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredientesconsulta).BeginInit();
            categoriapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoriaconsulta).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(283, 8);
            label11.Name = "label11";
            label11.Size = new Size(273, 32);
            label11.TabIndex = 42;
            label11.Text = "Consulta de Productos";
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(635, 55);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 29);
            eliminarbtn.TabIndex = 41;
            eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.Control;
            label12.Image = Properties.Resources.busqueda1;
            label12.Location = new Point(352, 59);
            label12.Name = "label12";
            label12.Size = new Size(18, 21);
            label12.TabIndex = 38;
            label12.Text = "  ";
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.AllowUserToDeleteRows = false;
            tabladatos.Anchor = AnchorStyles.None;
            tabladatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabladatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(8, 92);
            tabladatos.MultiSelect = false;
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.RowHeadersWidth = 51;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(656, 558);
            tabladatos.TabIndex = 39;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(8, 55);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(366, 29);
            txtbuscador.TabIndex = 1;
            // 
            // agregar
            // 
            agregar.Image = Properties.Resources.producto;
            agregar.Location = new Point(672, 92);
            agregar.Name = "agregar";
            agregar.Size = new Size(159, 72);
            agregar.TabIndex = 43;
            agregar.Text = "Nuevo";
            agregar.TextAlign = ContentAlignment.BottomCenter;
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // Editar
            // 
            Editar.Image = Properties.Resources.editar;
            Editar.Location = new Point(672, 170);
            Editar.Name = "Editar";
            Editar.Size = new Size(159, 72);
            Editar.TabIndex = 43;
            Editar.Text = "Editar";
            Editar.TextAlign = ContentAlignment.BottomCenter;
            Editar.UseVisualStyleBackColor = true;
            Editar.Click += Editar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(imagenproducto);
            panel1.Location = new Point(667, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 404);
            panel1.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(7, 4);
            label2.Name = "label2";
            label2.Size = new Size(155, 64);
            label2.TabIndex = 46;
            label2.Text = "Informacion\r\n    General";
            // 
            // imagenproducto
            // 
            imagenproducto.ErrorImage = Properties.Resources.paisaje;
            imagenproducto.Image = Properties.Resources.paisaje;
            imagenproducto.InitialImage = Properties.Resources.paisaje;
            imagenproducto.Location = new Point(5, 71);
            imagenproducto.Name = "imagenproducto";
            imagenproducto.Size = new Size(159, 159);
            imagenproducto.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenproducto.TabIndex = 0;
            imagenproducto.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(693, 50);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 45;
            label1.Text = "Acciones";
            // 
            // recargarbtn
            // 
            recargarbtn.Image = Properties.Resources.actualizar;
            recargarbtn.Location = new Point(8, 10);
            recargarbtn.Name = "recargarbtn";
            recargarbtn.Size = new Size(29, 29);
            recargarbtn.TabIndex = 46;
            recargarbtn.TabStop = false;
            recargarbtn.UseVisualStyleBackColor = true;
            recargarbtn.Click += recargarbtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(consulta);
            tabControl1.Controls.Add(creacion);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(847, 690);
            tabControl1.TabIndex = 47;
            // 
            // consulta
            // 
            consulta.BackColor = SystemColors.WindowFrame;
            consulta.Controls.Add(filtroingredientes);
            consulta.Controls.Add(filtroplatos);
            consulta.Controls.Add(filtrotodos);
            consulta.Controls.Add(filtro);
            consulta.Controls.Add(label15);
            consulta.Controls.Add(label12);
            consulta.Controls.Add(recargarbtn);
            consulta.Controls.Add(panel1);
            consulta.Controls.Add(Editar);
            consulta.Controls.Add(label1);
            consulta.Controls.Add(agregar);
            consulta.Controls.Add(tabladatos);
            consulta.Controls.Add(eliminarbtn);
            consulta.Controls.Add(label11);
            consulta.Controls.Add(txtbuscador);
            consulta.Location = new Point(4, 30);
            consulta.Name = "consulta";
            consulta.Padding = new Padding(3);
            consulta.Size = new Size(839, 656);
            consulta.TabIndex = 0;
            consulta.Text = "Consulta";
            // 
            // filtroingredientes
            // 
            filtroingredientes.AutoSize = true;
            filtroingredientes.Cursor = Cursors.Hand;
            filtroingredientes.Font = new Font("Segoe UI", 13F);
            filtroingredientes.Image = Properties.Resources.saleroblanco;
            filtroingredientes.Location = new Point(525, 55);
            filtroingredientes.Name = "filtroingredientes";
            filtroingredientes.Size = new Size(41, 29);
            filtroingredientes.TabIndex = 0;
            filtroingredientes.Text = "  ";
            filtroingredientes.UseVisualStyleBackColor = true;
            // 
            // filtroplatos
            // 
            filtroplatos.AutoSize = true;
            filtroplatos.Cursor = Cursors.Hand;
            filtroplatos.Font = new Font("Segoe UI", 13F);
            filtroplatos.Image = Properties.Resources.cuchilloblanco;
            filtroplatos.Location = new Point(470, 55);
            filtroplatos.Name = "filtroplatos";
            filtroplatos.Size = new Size(41, 29);
            filtroplatos.TabIndex = 0;
            filtroplatos.Text = "  ";
            filtroplatos.UseVisualStyleBackColor = true;
            // 
            // filtrotodos
            // 
            filtrotodos.AutoSize = true;
            filtrotodos.Checked = true;
            filtrotodos.CheckState = CheckState.Checked;
            filtrotodos.Cursor = Cursors.Hand;
            filtrotodos.Font = new Font("Segoe UI", 13F);
            filtrotodos.Image = Properties.Resources.mundoblanco;
            filtrotodos.Location = new Point(415, 55);
            filtrotodos.Name = "filtrotodos";
            filtrotodos.Size = new Size(41, 29);
            filtrotodos.TabIndex = 0;
            filtrotodos.Text = "  ";
            filtrotodos.UseVisualStyleBackColor = true;
            // 
            // filtro
            // 
            filtro.AutoSize = true;
            filtro.Checked = true;
            filtro.CheckState = CheckState.Checked;
            filtro.Cursor = Cursors.Hand;
            filtro.Font = new Font("Segoe UI", 13F);
            filtro.Image = Properties.Resources.sicheck;
            filtro.Location = new Point(580, 55);
            filtro.Name = "filtro";
            filtro.Size = new Size(41, 29);
            filtro.TabIndex = 0;
            filtro.Text = "  ";
            filtro.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.ForeColor = SystemColors.WindowFrame;
            label15.Image = Properties.Resources.filtroblanco;
            label15.Location = new Point(388, 59);
            label15.Name = "label15";
            label15.Size = new Size(18, 21);
            label15.TabIndex = 38;
            label15.Text = "  ";
            // 
            // creacion
            // 
            creacion.BackColor = SystemColors.WindowFrame;
            creacion.Controls.Add(panel6);
            creacion.Controls.Add(panel3);
            creacion.Controls.Add(panel5);
            creacion.Controls.Add(categoriapanel);
            creacion.Controls.Add(idregproducto);
            creacion.Controls.Add(label18);
            creacion.Controls.Add(idcategoriatxt);
            creacion.Controls.Add(imagenpanel);
            creacion.Controls.Add(panel4);
            creacion.Controls.Add(button1);
            creacion.Controls.Add(comboBox1);
            creacion.Controls.Add(label13);
            creacion.Controls.Add(txtprecio_compra);
            creacion.Controls.Add(categoriatxt);
            creacion.Controls.Add(txtnombre_prod);
            creacion.Controls.Add(txtcodigo_barras);
            creacion.Controls.Add(txtprecio_venta);
            creacion.Controls.Add(label16);
            creacion.Controls.Add(label21);
            creacion.Controls.Add(label8);
            creacion.Controls.Add(label4);
            creacion.Controls.Add(label7);
            creacion.Controls.Add(label5);
            creacion.Controls.Add(label3);
            creacion.Controls.Add(label17);
            creacion.Controls.Add(label10);
            creacion.Controls.Add(label14);
            creacion.Controls.Add(estadochk);
            creacion.Controls.Add(codigobarrarandombtn);
            creacion.Controls.Add(buscarcateg);
            creacion.Controls.Add(unidadmedida);
            creacion.Controls.Add(ITBIS);
            creacion.Location = new Point(4, 30);
            creacion.Name = "creacion";
            creacion.Padding = new Padding(3);
            creacion.Size = new Size(839, 656);
            creacion.TabIndex = 1;
            creacion.Text = "Creación";
            // 
            // panel6
            // 
            panel6.Location = new Point(455, 372);
            panel6.Name = "panel6";
            panel6.Size = new Size(386, 34);
            panel6.TabIndex = 85;
            // 
            // panel3
            // 
            panel3.Location = new Point(155, 374);
            panel3.Name = "panel3";
            panel3.Size = new Size(194, 34);
            panel3.TabIndex = 85;
            // 
            // idregproducto
            // 
            idregproducto.Enabled = false;
            idregproducto.Location = new Point(773, 10);
            idregproducto.Name = "idregproducto";
            idregproducto.Size = new Size(56, 29);
            idregproducto.TabIndex = 84;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label18.ForeColor = Color.White;
            label18.Location = new Point(740, 14);
            label18.Name = "label18";
            label18.Size = new Size(27, 21);
            label18.TabIndex = 83;
            label18.Text = "ID";
            // 
            // idcategoriatxt
            // 
            idcategoriatxt.Location = new Point(234, 142);
            idcategoriatxt.Name = "idcategoriatxt";
            idcategoriatxt.Size = new Size(45, 29);
            idcategoriatxt.TabIndex = 58;
            idcategoriatxt.TextChanged += txtnombre_prod_TextChanged;
            // 
            // imagenpanel
            // 
            imagenpanel.BackColor = Color.Gray;
            imagenpanel.Controls.Add(imagenprod);
            imagenpanel.Controls.Add(seleccionimagenbtn);
            imagenpanel.Location = new Point(545, 65);
            imagenpanel.Name = "imagenpanel";
            imagenpanel.Size = new Size(199, 265);
            imagenpanel.TabIndex = 72;
            // 
            // imagenprod
            // 
            imagenprod.ErrorImage = Properties.Resources.paisaje;
            imagenprod.Image = Properties.Resources.paisaje;
            imagenprod.InitialImage = Properties.Resources.paisaje;
            imagenprod.Location = new Point(9, 9);
            imagenprod.Name = "imagenprod";
            imagenprod.Size = new Size(181, 181);
            imagenprod.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenprod.TabIndex = 13;
            imagenprod.TabStop = false;
            // 
            // seleccionimagenbtn
            // 
            seleccionimagenbtn.BackColor = Color.Lime;
            seleccionimagenbtn.Enabled = false;
            seleccionimagenbtn.ForeColor = Color.Black;
            seleccionimagenbtn.Image = Properties.Resources.subir1;
            seleccionimagenbtn.Location = new Point(9, 198);
            seleccionimagenbtn.Name = "seleccionimagenbtn";
            seleccionimagenbtn.Size = new Size(181, 60);
            seleccionimagenbtn.TabIndex = 12;
            seleccionimagenbtn.Text = "Buscar Imagen";
            seleccionimagenbtn.TextAlign = ContentAlignment.BottomCenter;
            seleccionimagenbtn.UseVisualStyleBackColor = false;
            seleccionimagenbtn.Click += seleccionimagenbtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(guardarbtn);
            panel4.Controls.Add(limpiarbtn);
            panel4.Location = new Point(206, 580);
            panel4.Name = "panel4";
            panel4.Size = new Size(426, 74);
            panel4.TabIndex = 71;
            // 
            // guardarbtn
            // 
            guardarbtn.ForeColor = Color.Black;
            guardarbtn.Image = Properties.Resources.disco;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(12, 8);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(181, 58);
            guardarbtn.TabIndex = 13;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.ForeColor = Color.Black;
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(233, 8);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(181, 58);
            limpiarbtn.TabIndex = 14;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.actualizar;
            button1.Location = new Point(8, 10);
            button1.Name = "button1";
            button1.Size = new Size(29, 29);
            button1.TabIndex = 70;
            button1.TabStop = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 29);
            comboBox1.TabIndex = 64;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(283, 8);
            label13.Name = "label13";
            label13.Size = new Size(268, 32);
            label13.TabIndex = 68;
            label13.Text = "Registro de Productos";
            // 
            // txtprecio_compra
            // 
            txtprecio_compra.Location = new Point(16, 272);
            txtprecio_compra.Name = "txtprecio_compra";
            txtprecio_compra.Size = new Size(163, 29);
            txtprecio_compra.TabIndex = 61;
            // 
            // categoriatxt
            // 
            categoriatxt.Location = new Point(281, 142);
            categoriatxt.Name = "categoriatxt";
            categoriatxt.Size = new Size(117, 29);
            categoriatxt.TabIndex = 58;
            categoriatxt.TextChanged += txtnombre_prod_TextChanged;
            // 
            // txtnombre_prod
            // 
            txtnombre_prod.Location = new Point(16, 207);
            txtnombre_prod.Name = "txtnombre_prod";
            txtnombre_prod.Size = new Size(163, 29);
            txtnombre_prod.TabIndex = 58;
            txtnombre_prod.TextChanged += txtnombre_prod_TextChanged;
            // 
            // txtcodigo_barras
            // 
            txtcodigo_barras.Location = new Point(16, 142);
            txtcodigo_barras.Name = "txtcodigo_barras";
            txtcodigo_barras.Size = new Size(163, 29);
            txtcodigo_barras.TabIndex = 65;
            // 
            // txtprecio_venta
            // 
            txtprecio_venta.Location = new Point(16, 337);
            txtprecio_venta.Name = "txtprecio_venta";
            txtprecio_venta.Size = new Size(163, 29);
            txtprecio_venta.TabIndex = 62;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(16, 53);
            label16.Name = "label16";
            label16.Size = new Size(141, 21);
            label16.TabIndex = 55;
            label16.Text = "Tipo de producto";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label21.ForeColor = Color.White;
            label21.Location = new Point(234, 183);
            label21.Name = "label21";
            label21.Size = new Size(151, 21);
            label21.TabIndex = 55;
            label21.Text = "Unidad de medida";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(234, 53);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 55;
            label8.Text = "ITBIS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 245);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 54;
            label4.Text = "Precio de Compra:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 117);
            label7.Name = "label7";
            label7.Size = new Size(143, 21);
            label7.TabIndex = 53;
            label7.Text = "Codigo de Barras:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 309);
            label5.Name = "label5";
            label5.Size = new Size(133, 21);
            label5.TabIndex = 52;
            label5.Text = "Precio de Venta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 181);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 51;
            label3.Text = "Nombre:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label17.ForeColor = Color.White;
            label17.Location = new Point(310, 79);
            label17.Name = "label17";
            label17.Size = new Size(28, 25);
            label17.TabIndex = 50;
            label17.Text = "%";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(234, 112);
            label10.Name = "label10";
            label10.Size = new Size(88, 21);
            label10.TabIndex = 50;
            label10.Text = "Categoria:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(571, 338);
            label14.Name = "label14";
            label14.Size = new Size(65, 21);
            label14.TabIndex = 49;
            label14.Text = "Estado:";
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(647, 336);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(72, 25);
            estadochk.TabIndex = 46;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            // 
            // codigobarrarandombtn
            // 
            codigobarrarandombtn.ForeColor = Color.Black;
            codigobarrarandombtn.Image = Properties.Resources.barajar;
            codigobarrarandombtn.Location = new Point(182, 142);
            codigobarrarandombtn.Name = "codigobarrarandombtn";
            codigobarrarandombtn.Size = new Size(28, 29);
            codigobarrarandombtn.TabIndex = 66;
            codigobarrarandombtn.UseVisualStyleBackColor = true;
            codigobarrarandombtn.Click += codigobarrarandombtn_Click;
            // 
            // buscarcateg
            // 
            buscarcateg.ForeColor = Color.Black;
            buscarcateg.Image = Properties.Resources.busqueda;
            buscarcateg.Location = new Point(401, 142);
            buscarcateg.Name = "buscarcateg";
            buscarcateg.Size = new Size(28, 29);
            buscarcateg.TabIndex = 60;
            buscarcateg.UseVisualStyleBackColor = true;
            buscarcateg.Click += buscarcateg_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(numCantidad);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtnombre);
            panel5.Controls.Add(recetaingredientes);
            panel5.Controls.Add(buscarprodbtn);
            panel5.Controls.Add(ingredientesconsulta);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(txtcodigo);
            panel5.Controls.Add(agregarbtn);
            panel5.Location = new Point(3, 380);
            panel5.Name = "panel5";
            panel5.Size = new Size(834, 206);
            panel5.TabIndex = 82;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label19.ForeColor = Color.White;
            label19.Image = Properties.Resources.recetablanco;
            label19.ImageAlign = ContentAlignment.MiddleRight;
            label19.Location = new Point(348, 5);
            label19.Name = "label19";
            label19.Size = new Size(98, 21);
            label19.TabIndex = 55;
            label19.Text = "2. Receta     ";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(39, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 29);
            textBox1.TabIndex = 79;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(685, 37);
            numCantidad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(108, 29);
            numCantidad.TabIndex = 80;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Image = Properties.Resources.saleroblanco;
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(5, 5);
            label6.Name = "label6";
            label6.Size = new Size(147, 21);
            label6.TabIndex = 55;
            label6.Text = "1. Ingredientes      ";
            // 
            // txtnombre
            // 
            txtnombre.Enabled = false;
            txtnombre.Location = new Point(438, 37);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(154, 29);
            txtnombre.TabIndex = 75;
            // 
            // recetaingredientes
            // 
            recetaingredientes.AllowUserToAddRows = false;
            recetaingredientes.AllowUserToDeleteRows = false;
            recetaingredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recetaingredientes.Location = new Point(351, 69);
            recetaingredientes.MultiSelect = false;
            recetaingredientes.Name = "recetaingredientes";
            recetaingredientes.ReadOnly = true;
            recetaingredientes.RowHeadersWidth = 51;
            recetaingredientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            recetaingredientes.Size = new Size(477, 129);
            recetaingredientes.TabIndex = 74;
            // 
            // buscarprodbtn
            // 
            buscarprodbtn.Image = Properties.Resources.busqueda1;
            buscarprodbtn.Location = new Point(5, 37);
            buscarprodbtn.Name = "buscarprodbtn";
            buscarprodbtn.Size = new Size(28, 29);
            buscarprodbtn.TabIndex = 76;
            buscarprodbtn.UseVisualStyleBackColor = true;
            // 
            // ingredientesconsulta
            // 
            ingredientesconsulta.AllowUserToAddRows = false;
            ingredientesconsulta.AllowUserToDeleteRows = false;
            ingredientesconsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ingredientesconsulta.Location = new Point(5, 69);
            ingredientesconsulta.MultiSelect = false;
            ingredientesconsulta.Name = "ingredientesconsulta";
            ingredientesconsulta.ReadOnly = true;
            ingredientesconsulta.RowHeadersWidth = 51;
            ingredientesconsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ingredientesconsulta.Size = new Size(338, 129);
            ingredientesconsulta.TabIndex = 74;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Image = Properties.Resources.angulo_hacia_derecha;
            button3.Location = new Point(315, 37);
            button3.Name = "button3";
            button3.Size = new Size(28, 29);
            button3.TabIndex = 77;
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(598, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(81, 29);
            textBox2.TabIndex = 79;
            // 
            // txtcodigo
            // 
            txtcodigo.Enabled = false;
            txtcodigo.Location = new Point(351, 37);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(81, 29);
            txtcodigo.TabIndex = 79;
            // 
            // agregarbtn
            // 
            agregarbtn.Enabled = false;
            agregarbtn.Image = Properties.Resources.angulo_hacia_abajo;
            agregarbtn.Location = new Point(799, 37);
            agregarbtn.Name = "agregarbtn";
            agregarbtn.Size = new Size(28, 29);
            agregarbtn.TabIndex = 77;
            agregarbtn.UseVisualStyleBackColor = true;
            // 
            // unidadmedida
            // 
            unidadmedida.DropDownStyle = ComboBoxStyle.DropDownList;
            unidadmedida.FormattingEnabled = true;
            unidadmedida.Location = new Point(234, 207);
            unidadmedida.Name = "unidadmedida";
            unidadmedida.Size = new Size(163, 29);
            unidadmedida.TabIndex = 64;
            // 
            // ITBIS
            // 
            ITBIS.DropDownStyle = ComboBoxStyle.DropDownList;
            ITBIS.FormattingEnabled = true;
            ITBIS.Items.AddRange(new object[] { "18", "16" });
            ITBIS.Location = new Point(234, 77);
            ITBIS.Name = "ITBIS";
            ITBIS.Size = new Size(70, 29);
            ITBIS.TabIndex = 64;
            // 
            // categoriapanel
            // 
            categoriapanel.BackColor = Color.FromArgb(64, 64, 64);
            categoriapanel.Controls.Add(idconsultatxt);
            categoriapanel.Controls.Add(categoriaconsultatxt);
            categoriapanel.Controls.Add(button4);
            categoriapanel.Controls.Add(label9);
            categoriapanel.Controls.Add(categoriaconsulta);
            categoriapanel.Location = new Point(227, 245);
            categoriapanel.Name = "categoriapanel";
            categoriapanel.Size = new Size(204, 170);
            categoriapanel.TabIndex = 81;
            categoriapanel.Visible = false;
            categoriapanel.Leave += categoriapanel_Leave;
            // 
            // idconsultatxt
            // 
            idconsultatxt.Location = new Point(4, 28);
            idconsultatxt.Name = "idconsultatxt";
            idconsultatxt.Size = new Size(31, 29);
            idconsultatxt.TabIndex = 58;
            idconsultatxt.TextChanged += txtnombre_prod_TextChanged;
            // 
            // categoriaconsultatxt
            // 
            categoriaconsultatxt.Location = new Point(37, 28);
            categoriaconsultatxt.Name = "categoriaconsultatxt";
            categoriaconsultatxt.Size = new Size(131, 29);
            categoriaconsultatxt.TabIndex = 58;
            categoriaconsultatxt.TextChanged += txtnombre_prod_TextChanged;
            // 
            // button4
            // 
            button4.ForeColor = Color.Black;
            button4.Image = Properties.Resources.angulo_hacia_arriba;
            button4.Location = new Point(171, 28);
            button4.Name = "button4";
            button4.Size = new Size(28, 29);
            button4.TabIndex = 60;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(5, 2);
            label9.Name = "label9";
            label9.Size = new Size(174, 21);
            label9.TabIndex = 50;
            label9.Text = "Seleccionar categoria";
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
            categoriaconsulta.Size = new Size(195, 101);
            categoriaconsulta.TabIndex = 74;
            // 
            // ConsProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(847, 690);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsProductos";
            StartPosition = FormStartPosition.Manual;
            Text = "Productos";
            Load += ConsProductos_Load;
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenproducto).EndInit();
            tabControl1.ResumeLayout(false);
            consulta.ResumeLayout(false);
            consulta.PerformLayout();
            creacion.ResumeLayout(false);
            creacion.PerformLayout();
            imagenpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagenprod).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)recetaingredientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredientesconsulta).EndInit();
            categoriapanel.ResumeLayout(false);
            categoriapanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoriaconsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label11;
        private Button eliminarbtn;
        private Label label12;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private Button agregar;
        private Button Editar;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox imagenproducto;
        public Button recargarbtn;
        private TabControl tabControl1;
        private TabPage consulta;
        private TabPage creacion;
        private Panel imagenpanel;
        private Button seleccionimagenbtn;
        private Panel panel4;
        private Button guardarbtn;
        private Button limpiarbtn;
        public Button button1;
        private ComboBox ITBIS;
        private Label label13;
        private TextBox txtprecio_compra;
        private TextBox txtnombre_prod;
        private TextBox txtcodigo_barras;
        private TextBox txtprecio_venta;
        private Label label8;
        private Label label4;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label10;
        private Label label14;
        private CheckBox estadochk;
        private Button codigobarrarandombtn;
        private Button buscarcateg;
        private PictureBox imagenprod;
        private DataGridView recetaingredientes;
        private ComboBox comboBox1;
        private Label label6;
        private Label label16;
        private NumericUpDown numCantidad;
        private TextBox txtnombre;
        private Button buscarprodbtn;
        private Button agregarbtn;
        private TextBox textBox1;
        private TextBox txtcodigo;
        private DataGridView ingredientesconsulta;
        private Button button3;
        private Panel categoriapanel;
        private TextBox categoriaconsultatxt;
        private TextBox categoriatxt;
        private Panel panel5;
        private Button button4;
        private Label label9;
        private DataGridView categoriaconsulta;
        private CheckBox filtroingredientes;
        private CheckBox filtroplatos;
        private CheckBox filtrotodos;
        private CheckBox filtro;
        private Label label15;
        private TextBox idcategoriatxt;
        private TextBox idconsultatxt;
        private Label label17;
        private TextBox idregproducto;
        private Label label18;
        private Panel panel3;
        private Panel panel6;
        private Label label19;
        private Label label21;
        private TextBox textBox2;
        private ComboBox unidadmedida;
    }
}