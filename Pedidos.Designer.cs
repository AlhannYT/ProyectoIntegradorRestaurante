namespace Proyecto_restaurante
{
    partial class Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel8 = new Panel();
            panel10 = new Panel();
            labelsalamesa = new Label();
            label5 = new Label();
            labelmesa = new Label();
            label4 = new Label();
            asignarmesabtn = new Button();
            panel9 = new Panel();
            label6 = new Label();
            labelsubtotal = new Label();
            labeltotal = new Label();
            labelcantidadarticulos = new Label();
            label7 = new Label();
            label3 = new Label();
            imagenproducto = new PictureBox();
            panel2 = new Panel();
            tabladatosconsultaprod = new DataGridView();
            panel3 = new Panel();
            bajarproductobtn = new Button();
            buscarproductobtn = new Button();
            numCantidad = new NumericUpDown();
            txtnombreproducto = new TextBox();
            txtiva = new TextBox();
            txtprecioproducto = new TextBox();
            txtcodigoproducto = new TextBox();
            panel4 = new Panel();
            labelcaja = new Label();
            fechapedido = new DateTimePicker();
            limpiarbtn = new Button();
            label11 = new Label();
            guardarpedidobtn = new Button();
            panel1 = new Panel();
            txtnumero_cliente = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label20 = new Label();
            label1 = new Label();
            buscarclientebtn = new Button();
            txtidpedido = new TextBox();
            txtnombrecompleto = new TextBox();
            tabPage2 = new TabPage();
            label13 = new Label();
            label12 = new Label();
            todoschk = new CheckBox();
            canceladochk = new CheckBox();
            pendientechk = new CheckBox();
            facturadochk = new CheckBox();
            txtbusquedafactura = new TextBox();
            label10 = new Label();
            panel7 = new Panel();
            label8 = new Label();
            label9 = new Label();
            fecini = new DateTimePicker();
            fecfin = new DateTimePicker();
            editar = new Button();
            cancelarpedido = new Button();
            imprimirbtn = new Button();
            facturarbtn = new Button();
            panel5 = new Panel();
            tabladatospedidos = new DataGridView();
            panelmesas = new Panel();
            label15 = new Label();
            txtmesabusqueda = new TextBox();
            button7 = new Button();
            label14 = new Label();
            tablaseleccionmesas = new DataGridView();
            panelclientes = new Panel();
            label18 = new Label();
            txtclientebusqueda = new TextBox();
            button5 = new Button();
            label19 = new Label();
            tablaclientes = new DataGridView();
            tablapanelproducto = new DataGridView();
            label17 = new Label();
            button4 = new Button();
            txtproductobusqueda = new TextBox();
            label16 = new Label();
            panelproducto = new Panel();
            toolTip1 = new ToolTip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenproducto).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabladatosconsultaprod).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabladatospedidos).BeginInit();
            panelmesas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaseleccionmesas).BeginInit();
            panelclientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaclientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablapanelproducto).BeginInit();
            panelproducto.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(817, 492);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(87, 128, 87);
            tabPage1.Controls.Add(panel8);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(809, 458);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Realizar Pedido";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Gray;
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(imagenproducto);
            panel8.Location = new Point(466, 201);
            panel8.Name = "panel8";
            panel8.Size = new Size(334, 249);
            panel8.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.WindowFrame;
            panel10.Controls.Add(labelsalamesa);
            panel10.Controls.Add(label5);
            panel10.Controls.Add(labelmesa);
            panel10.Controls.Add(label4);
            panel10.Controls.Add(asignarmesabtn);
            panel10.Location = new Point(166, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(163, 140);
            panel10.TabIndex = 2;
            // 
            // labelsalamesa
            // 
            labelsalamesa.AutoSize = true;
            labelsalamesa.Font = new Font("Segoe UI", 9.75F);
            labelsalamesa.ForeColor = SystemColors.Control;
            labelsalamesa.Location = new Point(46, 117);
            labelsalamesa.Name = "labelsalamesa";
            labelsalamesa.Size = new Size(0, 17);
            labelsalamesa.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(3, 115);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 3;
            label5.Text = "Sala: ";
            // 
            // labelmesa
            // 
            labelmesa.AutoSize = true;
            labelmesa.Font = new Font("Segoe UI", 9.75F);
            labelmesa.ForeColor = SystemColors.Control;
            labelmesa.Location = new Point(60, 93);
            labelmesa.Name = "labelmesa";
            labelmesa.Size = new Size(0, 17);
            labelmesa.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(3, 90);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Mesa:";
            // 
            // asignarmesabtn
            // 
            asignarmesabtn.Enabled = false;
            asignarmesabtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            asignarmesabtn.Image = Properties.Resources.mesa_redonda;
            asignarmesabtn.Location = new Point(3, 2);
            asignarmesabtn.Name = "asignarmesabtn";
            asignarmesabtn.Size = new Size(157, 81);
            asignarmesabtn.TabIndex = 0;
            asignarmesabtn.Text = "Asignar Mesa";
            asignarmesabtn.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(asignarmesabtn, "Click derecho para\r\nregistrar una nueva\r\nmesa\r\n");
            asignarmesabtn.UseVisualStyleBackColor = true;
            asignarmesabtn.Click += asignarmesabtn_Click;
            asignarmesabtn.MouseDown += asignarmesabtn_MouseDown;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.WindowFrame;
            panel9.Controls.Add(label6);
            panel9.Controls.Add(labelsubtotal);
            panel9.Controls.Add(labeltotal);
            panel9.Controls.Add(labelcantidadarticulos);
            panel9.Controls.Add(label7);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(3, 149);
            panel9.Name = "panel9";
            panel9.Size = new Size(328, 97);
            panel9.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(3, 2);
            label6.Name = "label6";
            label6.Size = new Size(269, 32);
            label6.TabIndex = 3;
            label6.Text = "Cantidad de Articulos:";
            // 
            // labelsubtotal
            // 
            labelsubtotal.AutoSize = true;
            labelsubtotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelsubtotal.ForeColor = SystemColors.Control;
            labelsubtotal.Location = new Point(126, 32);
            labelsubtotal.Name = "labelsubtotal";
            labelsubtotal.Size = new Size(27, 32);
            labelsubtotal.TabIndex = 3;
            labelsubtotal.Text = "0";
            // 
            // labeltotal
            // 
            labeltotal.AutoSize = true;
            labeltotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltotal.ForeColor = SystemColors.Control;
            labeltotal.Location = new Point(82, 64);
            labeltotal.Name = "labeltotal";
            labeltotal.Size = new Size(27, 32);
            labeltotal.TabIndex = 3;
            labeltotal.Text = "0";
            // 
            // labelcantidadarticulos
            // 
            labelcantidadarticulos.AutoSize = true;
            labelcantidadarticulos.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcantidadarticulos.ForeColor = SystemColors.Control;
            labelcantidadarticulos.Location = new Point(273, 2);
            labelcantidadarticulos.Name = "labelcantidadarticulos";
            labelcantidadarticulos.Size = new Size(27, 32);
            labelcantidadarticulos.TabIndex = 3;
            labelcantidadarticulos.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(4, 64);
            label7.Name = "label7";
            label7.Size = new Size(77, 32);
            label7.TabIndex = 3;
            label7.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(4, 32);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 3;
            label3.Text = "Subtotal:";
            // 
            // imagenproducto
            // 
            imagenproducto.Image = Properties.Resources.paisaje;
            imagenproducto.Location = new Point(3, 3);
            imagenproducto.Name = "imagenproducto";
            imagenproducto.Size = new Size(158, 140);
            imagenproducto.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenproducto.TabIndex = 0;
            imagenproducto.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(tabladatosconsultaprod);
            panel2.Location = new Point(6, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 249);
            panel2.TabIndex = 1;
            // 
            // tabladatosconsultaprod
            // 
            tabladatosconsultaprod.AllowUserToAddRows = false;
            tabladatosconsultaprod.AllowUserToDeleteRows = false;
            tabladatosconsultaprod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatosconsultaprod.Location = new Point(3, 3);
            tabladatosconsultaprod.MultiSelect = false;
            tabladatosconsultaprod.Name = "tabladatosconsultaprod";
            tabladatosconsultaprod.ReadOnly = true;
            tabladatosconsultaprod.RowHeadersWidth = 51;
            tabladatosconsultaprod.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatosconsultaprod.Size = new Size(452, 243);
            tabladatosconsultaprod.TabIndex = 5;
            tabladatosconsultaprod.CellClick += tabladatosconsultaprod_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(bajarproductobtn);
            panel3.Controls.Add(buscarproductobtn);
            panel3.Controls.Add(numCantidad);
            panel3.Controls.Add(txtnombreproducto);
            panel3.Controls.Add(txtiva);
            panel3.Controls.Add(txtprecioproducto);
            panel3.Controls.Add(txtcodigoproducto);
            panel3.Location = new Point(6, 145);
            panel3.Name = "panel3";
            panel3.Size = new Size(793, 50);
            panel3.TabIndex = 0;
            // 
            // bajarproductobtn
            // 
            bajarproductobtn.Enabled = false;
            bajarproductobtn.Image = Properties.Resources.angulo_hacia_abajo;
            bajarproductobtn.Location = new Point(753, 11);
            bajarproductobtn.Name = "bajarproductobtn";
            bajarproductobtn.Size = new Size(34, 29);
            bajarproductobtn.TabIndex = 2;
            bajarproductobtn.UseVisualStyleBackColor = true;
            bajarproductobtn.Click += bajarproductobtn_Click;
            // 
            // buscarproductobtn
            // 
            buscarproductobtn.Enabled = false;
            buscarproductobtn.Image = Properties.Resources.carrito_de_compras;
            buscarproductobtn.Location = new Point(6, 11);
            buscarproductobtn.Name = "buscarproductobtn";
            buscarproductobtn.Size = new Size(34, 29);
            buscarproductobtn.TabIndex = 2;
            toolTip1.SetToolTip(buscarproductobtn, "Click derecho para\r\nregistrar un nuevo\r\nproducto\r\n");
            buscarproductobtn.UseVisualStyleBackColor = true;
            buscarproductobtn.Click += buscarproductobtn_Click;
            buscarproductobtn.MouseDown += buscarproductobtn_MouseDown;
            // 
            // numCantidad
            // 
            numCantidad.Enabled = false;
            numCantidad.Location = new Point(639, 11);
            numCantidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(108, 29);
            numCantidad.TabIndex = 1;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtnombreproducto
            // 
            txtnombreproducto.Enabled = false;
            txtnombreproducto.Location = new Point(156, 11);
            txtnombreproducto.Name = "txtnombreproducto";
            txtnombreproducto.PlaceholderText = "Nombre";
            txtnombreproducto.Size = new Size(285, 29);
            txtnombreproducto.TabIndex = 0;
            // 
            // txtiva
            // 
            txtiva.Enabled = false;
            txtiva.Location = new Point(582, 11);
            txtiva.Name = "txtiva";
            txtiva.PlaceholderText = "ITBIS";
            txtiva.Size = new Size(51, 29);
            txtiva.TabIndex = 0;
            // 
            // txtprecioproducto
            // 
            txtprecioproducto.Enabled = false;
            txtprecioproducto.Location = new Point(447, 11);
            txtprecioproducto.Name = "txtprecioproducto";
            txtprecioproducto.PlaceholderText = "Precio";
            txtprecioproducto.Size = new Size(129, 29);
            txtprecioproducto.TabIndex = 0;
            // 
            // txtcodigoproducto
            // 
            txtcodigoproducto.Enabled = false;
            txtcodigoproducto.Location = new Point(46, 11);
            txtcodigoproducto.Name = "txtcodigoproducto";
            txtcodigoproducto.PlaceholderText = "Codigo";
            txtcodigoproducto.Size = new Size(104, 29);
            txtcodigoproducto.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.WindowFrame;
            panel4.Controls.Add(labelcaja);
            panel4.Controls.Add(fechapedido);
            panel4.Controls.Add(limpiarbtn);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(guardarpedidobtn);
            panel4.Location = new Point(518, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(281, 133);
            panel4.TabIndex = 0;
            // 
            // labelcaja
            // 
            labelcaja.AutoSize = true;
            labelcaja.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcaja.ForeColor = SystemColors.Control;
            labelcaja.Location = new Point(3, 5);
            labelcaja.Name = "labelcaja";
            labelcaja.Size = new Size(51, 21);
            labelcaja.TabIndex = 5;
            labelcaja.Text = "Caja: ";
            // 
            // fechapedido
            // 
            fechapedido.Enabled = false;
            fechapedido.Format = DateTimePickerFormat.Short;
            fechapedido.Location = new Point(140, 28);
            fechapedido.Name = "fechapedido";
            fechapedido.Size = new Size(128, 29);
            fechapedido.TabIndex = 4;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            limpiarbtn.Image = Properties.Resources.nuevo;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(140, 70);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(128, 52);
            limpiarbtn.TabIndex = 0;
            limpiarbtn.Text = "Nuevo";
            limpiarbtn.TextAlign = ContentAlignment.MiddleRight;
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(3, 32);
            label11.Name = "label11";
            label11.Size = new Size(126, 20);
            label11.TabIndex = 3;
            label11.Text = "Fecha de pedido:";
            // 
            // guardarpedidobtn
            // 
            guardarpedidobtn.BackColor = Color.FromArgb(128, 255, 128);
            guardarpedidobtn.Enabled = false;
            guardarpedidobtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guardarpedidobtn.Image = Properties.Resources.guardar;
            guardarpedidobtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarpedidobtn.Location = new Point(4, 70);
            guardarpedidobtn.Name = "guardarpedidobtn";
            guardarpedidobtn.Size = new Size(128, 52);
            guardarpedidobtn.TabIndex = 0;
            guardarpedidobtn.Text = "Guardar Pedido";
            guardarpedidobtn.TextAlign = ContentAlignment.MiddleRight;
            guardarpedidobtn.UseVisualStyleBackColor = false;
            guardarpedidobtn.Click += guardarpedidobtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(txtnumero_cliente);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buscarclientebtn);
            panel1.Controls.Add(txtidpedido);
            panel1.Controls.Add(txtnombrecompleto);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 133);
            panel1.TabIndex = 0;
            // 
            // txtnumero_cliente
            // 
            txtnumero_cliente.Location = new Point(327, 98);
            txtnumero_cliente.Name = "txtnumero_cliente";
            txtnumero_cliente.PlaceholderText = "Numero de telefono";
            txtnumero_cliente.Size = new Size(147, 29);
            txtnumero_cliente.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = Properties.Resources.telefono;
            pictureBox1.Location = new Point(295, 98);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(304, 3);
            label2.Name = "label2";
            label2.Size = new Size(190, 32);
            label2.TabIndex = 3;
            label2.Text = "Realizar Pedido";
            label2.Click += label2_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.Control;
            label20.Location = new Point(6, 9);
            label20.Name = "label20";
            label20.Size = new Size(29, 21);
            label20.TabIndex = 3;
            label20.Text = "N°";
            label20.Click += label20_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 3;
            label1.Text = "Datos cliente";
            // 
            // buscarclientebtn
            // 
            buscarclientebtn.Image = Properties.Resources.buscar;
            buscarclientebtn.Location = new Point(4, 98);
            buscarclientebtn.Name = "buscarclientebtn";
            buscarclientebtn.RightToLeft = RightToLeft.No;
            buscarclientebtn.Size = new Size(34, 29);
            buscarclientebtn.TabIndex = 2;
            toolTip1.SetToolTip(buscarclientebtn, "Click derecho para\r\nregistrar un nuevo\r\ncliente");
            buscarclientebtn.UseVisualStyleBackColor = true;
            buscarclientebtn.Click += buscarclientebtn_Click;
            // 
            // txtidpedido
            // 
            txtidpedido.Enabled = false;
            txtidpedido.Location = new Point(39, 5);
            txtidpedido.Name = "txtidpedido";
            txtidpedido.Size = new Size(87, 29);
            txtidpedido.TabIndex = 0;
            txtidpedido.TextChanged += txtidpedido_TextChanged;
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Location = new Point(41, 98);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.PlaceholderText = "Nombre del cliente";
            txtnombrecompleto.Size = new Size(241, 29);
            txtnombrecompleto.TabIndex = 0;
            txtnombrecompleto.TextChanged += txtnombrecompleto_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(85, 151, 100);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(todoschk);
            tabPage2.Controls.Add(canceladochk);
            tabPage2.Controls.Add(pendientechk);
            tabPage2.Controls.Add(facturadochk);
            tabPage2.Controls.Add(txtbusquedafactura);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(panel7);
            tabPage2.Controls.Add(panel5);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(809, 458);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pendientes De factura";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.ForeColor = SystemColors.Control;
            label13.Image = Properties.Resources.busqueda;
            label13.Location = new Point(314, 145);
            label13.Name = "label13";
            label13.Size = new Size(18, 21);
            label13.TabIndex = 7;
            label13.Text = "  ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.Control;
            label12.Image = Properties.Resources.filtrar;
            label12.Location = new Point(393, 145);
            label12.Name = "label12";
            label12.Size = new Size(18, 21);
            label12.TabIndex = 7;
            label12.Text = "  ";
            // 
            // todoschk
            // 
            todoschk.AutoSize = true;
            todoschk.Location = new Point(730, 143);
            todoschk.Name = "todoschk";
            todoschk.Size = new Size(69, 25);
            todoschk.TabIndex = 6;
            todoschk.Text = "Todos";
            todoschk.UseVisualStyleBackColor = true;
            todoschk.CheckedChanged += todoschk_CheckedChanged;
            // 
            // canceladochk
            // 
            canceladochk.AutoSize = true;
            canceladochk.Location = new Point(624, 143);
            canceladochk.Name = "canceladochk";
            canceladochk.Size = new Size(101, 25);
            canceladochk.TabIndex = 6;
            canceladochk.Text = "Cancelado";
            canceladochk.UseVisualStyleBackColor = true;
            canceladochk.CheckedChanged += canceladochk_CheckedChanged;
            // 
            // pendientechk
            // 
            pendientechk.AutoSize = true;
            pendientechk.Checked = true;
            pendientechk.CheckState = CheckState.Checked;
            pendientechk.Location = new Point(522, 143);
            pendientechk.Name = "pendientechk";
            pendientechk.Size = new Size(97, 25);
            pendientechk.TabIndex = 6;
            pendientechk.Text = "Pendiente";
            pendientechk.UseVisualStyleBackColor = true;
            pendientechk.CheckedChanged += pendientechk_CheckedChanged;
            // 
            // facturadochk
            // 
            facturadochk.AutoSize = true;
            facturadochk.Location = new Point(419, 143);
            facturadochk.Name = "facturadochk";
            facturadochk.Size = new Size(97, 25);
            facturadochk.TabIndex = 6;
            facturadochk.Text = "Facturado";
            facturadochk.UseVisualStyleBackColor = true;
            facturadochk.CheckedChanged += facturadochk_CheckedChanged;
            // 
            // txtbusquedafactura
            // 
            txtbusquedafactura.ForeColor = Color.Gray;
            txtbusquedafactura.Location = new Point(9, 141);
            txtbusquedafactura.Name = "txtbusquedafactura";
            txtbusquedafactura.Size = new Size(330, 29);
            txtbusquedafactura.TabIndex = 5;
            txtbusquedafactura.Text = "(ID Pedido, Cliente, Mesa, Total)";
            txtbusquedafactura.TextChanged += txtbusquedafactura_TextChanged;
            txtbusquedafactura.Enter += txtbusquedafactura_Enter;
            txtbusquedafactura.Leave += txtbusquedafactura_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(285, 10);
            label10.Name = "label10";
            label10.Size = new Size(241, 32);
            label10.TabIndex = 4;
            label10.Text = "Area de Facturacion";
            label10.Click += label10_Click;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.WindowFrame;
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(fecini);
            panel7.Controls.Add(fecfin);
            panel7.Controls.Add(editar);
            panel7.Controls.Add(cancelarpedido);
            panel7.Controls.Add(imprimirbtn);
            panel7.Controls.Add(facturarbtn);
            panel7.Location = new Point(9, 53);
            panel7.Name = "panel7";
            panel7.Size = new Size(795, 74);
            panel7.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(6, 9);
            label8.Name = "label8";
            label8.Size = new Size(101, 21);
            label8.TabIndex = 9;
            label8.Text = "Fecha inicio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(142, 9);
            label9.Name = "label9";
            label9.Size = new Size(79, 21);
            label9.TabIndex = 10;
            label9.Text = "Fecha fin";
            // 
            // fecini
            // 
            fecini.Enabled = false;
            fecini.Format = DateTimePickerFormat.Short;
            fecini.Location = new Point(6, 33);
            fecini.Name = "fecini";
            fecini.Size = new Size(123, 29);
            fecini.TabIndex = 7;
            // 
            // fecfin
            // 
            fecfin.Enabled = false;
            fecfin.Format = DateTimePickerFormat.Short;
            fecfin.Location = new Point(142, 33);
            fecfin.Name = "fecfin";
            fecfin.Size = new Size(123, 29);
            fecfin.TabIndex = 8;
            // 
            // editar
            // 
            editar.BackColor = Color.FromArgb(255, 192, 128);
            editar.Image = Properties.Resources.editar;
            editar.ImageAlign = ContentAlignment.MiddleLeft;
            editar.Location = new Point(440, 9);
            editar.Name = "editar";
            editar.Size = new Size(114, 56);
            editar.TabIndex = 1;
            editar.Text = "Editar";
            editar.TextAlign = ContentAlignment.MiddleRight;
            editar.UseVisualStyleBackColor = false;
            // 
            // cancelarpedido
            // 
            cancelarpedido.BackColor = Color.FromArgb(255, 128, 128);
            cancelarpedido.Image = Properties.Resources.cancelardoc;
            cancelarpedido.ImageAlign = ContentAlignment.MiddleLeft;
            cancelarpedido.Location = new Point(678, 9);
            cancelarpedido.Name = "cancelarpedido";
            cancelarpedido.Size = new Size(114, 56);
            cancelarpedido.TabIndex = 0;
            cancelarpedido.Text = "Cancelar";
            cancelarpedido.TextAlign = ContentAlignment.MiddleRight;
            cancelarpedido.UseVisualStyleBackColor = false;
            cancelarpedido.Click += cancelarpedido_Click;
            // 
            // imprimirbtn
            // 
            imprimirbtn.BackColor = Color.FromArgb(192, 255, 255);
            imprimirbtn.Image = Properties.Resources.imprimir;
            imprimirbtn.ImageAlign = ContentAlignment.MiddleLeft;
            imprimirbtn.Location = new Point(559, 9);
            imprimirbtn.Name = "imprimirbtn";
            imprimirbtn.Size = new Size(114, 56);
            imprimirbtn.TabIndex = 0;
            imprimirbtn.Text = "Imprimir";
            imprimirbtn.TextAlign = ContentAlignment.MiddleRight;
            imprimirbtn.UseVisualStyleBackColor = false;
            imprimirbtn.Click += imprimirbtn_Click;
            // 
            // facturarbtn
            // 
            facturarbtn.BackColor = Color.FromArgb(128, 255, 128);
            facturarbtn.Image = Properties.Resources.facturar;
            facturarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            facturarbtn.Location = new Point(321, 9);
            facturarbtn.Name = "facturarbtn";
            facturarbtn.Size = new Size(114, 56);
            facturarbtn.TabIndex = 0;
            facturarbtn.Text = "Facturar";
            facturarbtn.TextAlign = ContentAlignment.MiddleRight;
            facturarbtn.UseVisualStyleBackColor = false;
            facturarbtn.Click += facturarbtn_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SeaGreen;
            panel5.Controls.Add(tabladatospedidos);
            panel5.Location = new Point(6, 176);
            panel5.Name = "panel5";
            panel5.Size = new Size(795, 274);
            panel5.TabIndex = 0;
            // 
            // tabladatospedidos
            // 
            tabladatospedidos.AllowUserToAddRows = false;
            tabladatospedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatospedidos.Location = new Point(3, 5);
            tabladatospedidos.MultiSelect = false;
            tabladatospedidos.Name = "tabladatospedidos";
            tabladatospedidos.ReadOnly = true;
            tabladatospedidos.RowHeadersWidth = 51;
            tabladatospedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatospedidos.Size = new Size(789, 264);
            tabladatospedidos.TabIndex = 5;
            tabladatospedidos.CellClick += tabladatospedidos_CellClick;
            // 
            // panelmesas
            // 
            panelmesas.BackColor = Color.FromArgb(64, 64, 64);
            panelmesas.Controls.Add(label15);
            panelmesas.Controls.Add(txtmesabusqueda);
            panelmesas.Controls.Add(button7);
            panelmesas.Controls.Add(label14);
            panelmesas.Controls.Add(tablaseleccionmesas);
            panelmesas.Location = new Point(820, 32);
            panelmesas.Name = "panelmesas";
            panelmesas.Size = new Size(804, 459);
            panelmesas.TabIndex = 1;
            panelmesas.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(6, 81);
            label15.Name = "label15";
            label15.Size = new Size(59, 15);
            label15.TabIndex = 9;
            label15.Text = "Busqueda";
            // 
            // txtmesabusqueda
            // 
            txtmesabusqueda.Location = new Point(71, 78);
            txtmesabusqueda.Name = "txtmesabusqueda";
            txtmesabusqueda.Size = new Size(714, 23);
            txtmesabusqueda.TabIndex = 8;
            txtmesabusqueda.TextChanged += txtmesabusqueda_TextChanged;
            // 
            // button7
            // 
            button7.Location = new Point(674, 10);
            button7.Name = "button7";
            button7.Size = new Size(111, 45);
            button7.TabIndex = 7;
            button7.Text = "Salir";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(277, 10);
            label14.Name = "label14";
            label14.Size = new Size(233, 32);
            label14.TabIndex = 3;
            label14.Text = "Seleccion de mesas";
            // 
            // tablaseleccionmesas
            // 
            tablaseleccionmesas.AllowUserToAddRows = false;
            tablaseleccionmesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaseleccionmesas.Location = new Point(3, 113);
            tablaseleccionmesas.MultiSelect = false;
            tablaseleccionmesas.Name = "tablaseleccionmesas";
            tablaseleccionmesas.ReadOnly = true;
            tablaseleccionmesas.RowHeadersWidth = 51;
            tablaseleccionmesas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaseleccionmesas.Size = new Size(784, 340);
            tablaseleccionmesas.TabIndex = 6;
            tablaseleccionmesas.CellContentClick += tablaseleccionmesas_CellContentClick;
            tablaseleccionmesas.CellDoubleClick += tablaseleccionmesas_CellDoubleClick;
            // 
            // panelclientes
            // 
            panelclientes.BackColor = Color.FromArgb(64, 64, 64);
            panelclientes.Controls.Add(label18);
            panelclientes.Controls.Add(txtclientebusqueda);
            panelclientes.Controls.Add(button5);
            panelclientes.Controls.Add(label19);
            panelclientes.Controls.Add(tablaclientes);
            panelclientes.Location = new Point(813, 532);
            panelclientes.Name = "panelclientes";
            panelclientes.Size = new Size(804, 459);
            panelclientes.TabIndex = 1;
            panelclientes.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(6, 81);
            label18.Name = "label18";
            label18.Size = new Size(59, 15);
            label18.TabIndex = 9;
            label18.Text = "Busqueda";
            // 
            // txtclientebusqueda
            // 
            txtclientebusqueda.Location = new Point(71, 78);
            txtclientebusqueda.Name = "txtclientebusqueda";
            txtclientebusqueda.Size = new Size(716, 23);
            txtclientebusqueda.TabIndex = 8;
            txtclientebusqueda.TextChanged += txtclientebusqueda_TextChanged;
            // 
            // button5
            // 
            button5.Location = new Point(676, 12);
            button5.Name = "button5";
            button5.Size = new Size(111, 45);
            button5.TabIndex = 7;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.Control;
            label19.Location = new Point(277, 13);
            label19.Name = "label19";
            label19.Size = new Size(250, 32);
            label19.TabIndex = 3;
            label19.Text = "Seleccion de clientes";
            // 
            // tablaclientes
            // 
            tablaclientes.AllowUserToAddRows = false;
            tablaclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaclientes.Location = new Point(3, 113);
            tablaclientes.MultiSelect = false;
            tablaclientes.Name = "tablaclientes";
            tablaclientes.ReadOnly = true;
            tablaclientes.RowHeadersWidth = 51;
            tablaclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaclientes.Size = new Size(784, 340);
            tablaclientes.TabIndex = 6;
            tablaclientes.CellDoubleClick += tablaclientes_CellDoubleClick;
            // 
            // tablapanelproducto
            // 
            tablapanelproducto.AllowUserToAddRows = false;
            tablapanelproducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablapanelproducto.Location = new Point(3, 113);
            tablapanelproducto.MultiSelect = false;
            tablapanelproducto.Name = "tablapanelproducto";
            tablapanelproducto.ReadOnly = true;
            tablapanelproducto.RowHeadersWidth = 51;
            tablapanelproducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablapanelproducto.Size = new Size(784, 340);
            tablapanelproducto.TabIndex = 6;
            tablapanelproducto.CellDoubleClick += tablapanelproducto_CellDoubleClick;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.Control;
            label17.Location = new Point(279, 14);
            label17.Name = "label17";
            label17.Size = new Size(269, 32);
            label17.TabIndex = 3;
            label17.Text = "Seleccion de producto";
            // 
            // button4
            // 
            button4.Location = new Point(676, 14);
            button4.Name = "button4";
            button4.Size = new Size(111, 45);
            button4.TabIndex = 7;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtproductobusqueda
            // 
            txtproductobusqueda.Location = new Point(71, 78);
            txtproductobusqueda.Name = "txtproductobusqueda";
            txtproductobusqueda.Size = new Size(716, 23);
            txtproductobusqueda.TabIndex = 8;
            txtproductobusqueda.TextChanged += txtproductobusqueda_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.Control;
            label16.Location = new Point(6, 81);
            label16.Name = "label16";
            label16.Size = new Size(59, 15);
            label16.TabIndex = 9;
            label16.Text = "Busqueda";
            // 
            // panelproducto
            // 
            panelproducto.BackColor = Color.FromArgb(64, 64, 64);
            panelproducto.Controls.Add(label16);
            panelproducto.Controls.Add(txtproductobusqueda);
            panelproducto.Controls.Add(button4);
            panelproducto.Controls.Add(label17);
            panelproducto.Controls.Add(tablapanelproducto);
            panelproducto.Location = new Point(3, 499);
            panelproducto.Name = "panelproducto";
            panelproducto.Size = new Size(804, 459);
            panelproducto.TabIndex = 1;
            panelproducto.Visible = false;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Ayuda";
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(817, 492);
            Controls.Add(panelclientes);
            Controls.Add(panelproducto);
            Controls.Add(panelmesas);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Pedidos";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Pedidos";
            Load += Pedidos_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenproducto).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabladatosconsultaprod).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabladatospedidos).EndInit();
            panelmesas.ResumeLayout(false);
            panelmesas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaseleccionmesas).EndInit();
            panelclientes.ResumeLayout(false);
            panelclientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaclientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablapanelproducto).EndInit();
            panelproducto.ResumeLayout(false);
            panelproducto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel7;
        private Panel panel5;
        private Button guardarpedidobtn;
        private Button limpiarbtn;
        private Panel panel8;
        private PictureBox imagenproducto;
        private TextBox txtnombrecompleto;
        private Panel panel9;
        private TextBox txtnombreproducto;
        private TextBox txtcodigoproducto;
        private NumericUpDown numCantidad;
        private Button buscarproductobtn;
        private Label label1;
        private Button buscarclientebtn;
        private Label label3;
        private TextBox txtprecioproducto;
        private Label label2;
        private Panel panel10;
        private Label label5;
        private Label label4;
        private Button asignarmesabtn;
        private Label label6;
        private Label label7;
        private TextBox txtnumero_cliente;
        private Button cancelarpedido;
        private Button imprimirbtn;
        private Button facturarbtn;
        private Label label10;
        private DateTimePicker fechapedido;
        private Label label11;
        private TextBox txtbusquedafactura;
        private Label label12;
        private CheckBox pendientechk;
        private CheckBox facturadochk;
        private Label label13;
        private DataGridView tabladatosconsultaprod;
        private DataGridView tabladatospedidos;
        private CheckBox canceladochk;
        private Panel panelmesas;
        private Label label14;
        private DataGridView tablaseleccionmesas;
        private Label label15;
        private TextBox txtmesabusqueda;
        private Panel panelclientes;
        private Label label18;
        private TextBox txtclientebusqueda;
        private Label label19;
        private DataGridView tablaclientes;
        private Button bajarproductobtn;
        private Button button5;
        private DataGridView tablapanelproducto;
        private Label label17;
        private Button button4;
        private TextBox txtproductobusqueda;
        private Label label16;
        private Panel panelproducto;
        private Button button7;
        private Label labelmesa;
        private Label labelsalamesa;
        private Label labelcantidadarticulos;
        private Label labelsubtotal;
        private Label labeltotal;
        private Label label20;
        private TextBox txtidpedido;
        private TextBox txtiva;
        private CheckBox todoschk;
        private Label labelcaja;
        private ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button editar;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
        private DateTimePicker fecini;
        private DateTimePicker fecfin;
    }
}