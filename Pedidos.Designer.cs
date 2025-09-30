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
            label2 = new Label();
            label9 = new Label();
            label8 = new Label();
            label20 = new Label();
            label1 = new Label();
            buscarclientebtn = new Button();
            txtidpedido = new TextBox();
            txtnumero_cliente = new TextBox();
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
            cancelarpedido = new Button();
            imprimirbtn = new Button();
            facturarbtn = new Button();
            panel6 = new Panel();
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
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(5, 4);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(907, 653);
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
            tabPage1.Location = new Point(4, 37);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(899, 612);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Realizar Pedido";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Gray;
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(imagenproducto);
            panel8.Location = new Point(509, 268);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(382, 332);
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
            panel10.Location = new Point(190, 4);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(186, 187);
            panel10.TabIndex = 2;
            // 
            // labelsalamesa
            // 
            labelsalamesa.AutoSize = true;
            labelsalamesa.Font = new Font("Segoe UI", 9.75F);
            labelsalamesa.ForeColor = SystemColors.Control;
            labelsalamesa.Location = new Point(53, 156);
            labelsalamesa.Name = "labelsalamesa";
            labelsalamesa.Size = new Size(0, 23);
            labelsalamesa.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(3, 153);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 3;
            label5.Text = "Sala: ";
            // 
            // labelmesa
            // 
            labelmesa.AutoSize = true;
            labelmesa.Font = new Font("Segoe UI", 9.75F);
            labelmesa.ForeColor = SystemColors.Control;
            labelmesa.Location = new Point(69, 124);
            labelmesa.Name = "labelmesa";
            labelmesa.Size = new Size(0, 23);
            labelmesa.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(3, 120);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 3;
            label4.Text = "Mesa:";
            // 
            // asignarmesabtn
            // 
            asignarmesabtn.Enabled = false;
            asignarmesabtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            asignarmesabtn.Image = Properties.Resources.mesa_redonda;
            asignarmesabtn.Location = new Point(3, 3);
            asignarmesabtn.Margin = new Padding(3, 4, 3, 4);
            asignarmesabtn.Name = "asignarmesabtn";
            asignarmesabtn.Size = new Size(179, 108);
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
            panel9.Location = new Point(3, 199);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(375, 129);
            panel9.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(5, 0);
            label6.Name = "label6";
            label6.Size = new Size(332, 41);
            label6.TabIndex = 3;
            label6.Text = "Cantidad de Articulos:";
            // 
            // labelsubtotal
            // 
            labelsubtotal.AutoSize = true;
            labelsubtotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelsubtotal.ForeColor = SystemColors.Control;
            labelsubtotal.Location = new Point(137, 43);
            labelsubtotal.Name = "labelsubtotal";
            labelsubtotal.Size = new Size(34, 41);
            labelsubtotal.TabIndex = 3;
            labelsubtotal.Text = "0";
            // 
            // labeltotal
            // 
            labeltotal.AutoSize = true;
            labeltotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltotal.ForeColor = SystemColors.Control;
            labeltotal.Location = new Point(89, 85);
            labeltotal.Name = "labeltotal";
            labeltotal.Size = new Size(34, 41);
            labeltotal.TabIndex = 3;
            labeltotal.Text = "0";
            // 
            // labelcantidadarticulos
            // 
            labelcantidadarticulos.AutoSize = true;
            labelcantidadarticulos.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcantidadarticulos.ForeColor = SystemColors.Control;
            labelcantidadarticulos.Location = new Point(305, 0);
            labelcantidadarticulos.Name = "labelcantidadarticulos";
            labelcantidadarticulos.Size = new Size(34, 41);
            labelcantidadarticulos.TabIndex = 3;
            labelcantidadarticulos.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(6, 85);
            label7.Name = "label7";
            label7.Size = new Size(96, 41);
            label7.TabIndex = 3;
            label7.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(6, 43);
            label3.Name = "label3";
            label3.Size = new Size(147, 41);
            label3.TabIndex = 3;
            label3.Text = "Subtotal:";
            // 
            // imagenproducto
            // 
            imagenproducto.Image = Properties.Resources.paisaje;
            imagenproducto.Location = new Point(3, 4);
            imagenproducto.Margin = new Padding(3, 4, 3, 4);
            imagenproducto.Name = "imagenproducto";
            imagenproducto.Size = new Size(181, 187);
            imagenproducto.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenproducto.TabIndex = 0;
            imagenproducto.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(tabladatosconsultaprod);
            panel2.Location = new Point(7, 268);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(495, 332);
            panel2.TabIndex = 1;
            // 
            // tabladatosconsultaprod
            // 
            tabladatosconsultaprod.AllowUserToAddRows = false;
            tabladatosconsultaprod.AllowUserToDeleteRows = false;
            tabladatosconsultaprod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatosconsultaprod.Location = new Point(3, 4);
            tabladatosconsultaprod.Margin = new Padding(3, 4, 3, 4);
            tabladatosconsultaprod.MultiSelect = false;
            tabladatosconsultaprod.Name = "tabladatosconsultaprod";
            tabladatosconsultaprod.ReadOnly = true;
            tabladatosconsultaprod.RowHeadersWidth = 51;
            tabladatosconsultaprod.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatosconsultaprod.Size = new Size(488, 324);
            tabladatosconsultaprod.TabIndex = 5;
            tabladatosconsultaprod.CellClick += tabladatosconsultaprod_CellClick;
            tabladatosconsultaprod.CellContentClick += tabladatosconsultaprod_CellContentClick;
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
            panel3.Location = new Point(7, 193);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(885, 67);
            panel3.TabIndex = 0;
            // 
            // bajarproductobtn
            // 
            bajarproductobtn.Enabled = false;
            bajarproductobtn.Image = Properties.Resources.angulo_hacia_abajo;
            bajarproductobtn.Location = new Point(845, 16);
            bajarproductobtn.Margin = new Padding(3, 4, 3, 4);
            bajarproductobtn.Name = "bajarproductobtn";
            bajarproductobtn.Size = new Size(32, 39);
            bajarproductobtn.TabIndex = 2;
            bajarproductobtn.UseVisualStyleBackColor = true;
            bajarproductobtn.Click += bajarproductobtn_Click;
            // 
            // buscarproductobtn
            // 
            buscarproductobtn.Enabled = false;
            buscarproductobtn.Image = Properties.Resources.carrito_de_compras;
            buscarproductobtn.Location = new Point(5, 15);
            buscarproductobtn.Margin = new Padding(3, 4, 3, 4);
            buscarproductobtn.Name = "buscarproductobtn";
            buscarproductobtn.Size = new Size(39, 39);
            buscarproductobtn.TabIndex = 2;
            toolTip1.SetToolTip(buscarproductobtn, "Click derecho para\r\nregistrar un nuevo\r\nproducto\r\n");
            buscarproductobtn.UseVisualStyleBackColor = true;
            buscarproductobtn.Click += buscarproductobtn_Click;
            buscarproductobtn.MouseDown += buscarproductobtn_MouseDown;
            // 
            // numCantidad
            // 
            numCantidad.Enabled = false;
            numCantidad.Location = new Point(714, 16);
            numCantidad.Margin = new Padding(3, 4, 3, 4);
            numCantidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(123, 34);
            numCantidad.TabIndex = 1;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtnombreproducto
            // 
            txtnombreproducto.Enabled = false;
            txtnombreproducto.Location = new Point(175, 16);
            txtnombreproducto.Margin = new Padding(3, 4, 3, 4);
            txtnombreproducto.Name = "txtnombreproducto";
            txtnombreproducto.Size = new Size(316, 34);
            txtnombreproducto.TabIndex = 0;
            // 
            // txtiva
            // 
            txtiva.Enabled = false;
            txtiva.Location = new Point(649, 16);
            txtiva.Margin = new Padding(3, 4, 3, 4);
            txtiva.Name = "txtiva";
            txtiva.Size = new Size(58, 34);
            txtiva.TabIndex = 0;
            // 
            // txtprecioproducto
            // 
            txtprecioproducto.Enabled = false;
            txtprecioproducto.Location = new Point(498, 16);
            txtprecioproducto.Margin = new Padding(3, 4, 3, 4);
            txtprecioproducto.Name = "txtprecioproducto";
            txtprecioproducto.Size = new Size(147, 34);
            txtprecioproducto.TabIndex = 0;
            // 
            // txtcodigoproducto
            // 
            txtcodigoproducto.Enabled = false;
            txtcodigoproducto.Location = new Point(49, 16);
            txtcodigoproducto.Margin = new Padding(3, 4, 3, 4);
            txtcodigoproducto.Name = "txtcodigoproducto";
            txtcodigoproducto.Size = new Size(118, 34);
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
            panel4.Location = new Point(592, 8);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(302, 177);
            panel4.TabIndex = 0;
            // 
            // labelcaja
            // 
            labelcaja.AutoSize = true;
            labelcaja.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcaja.ForeColor = SystemColors.Control;
            labelcaja.Location = new Point(6, 7);
            labelcaja.Name = "labelcaja";
            labelcaja.Size = new Size(63, 28);
            labelcaja.TabIndex = 5;
            labelcaja.Text = "Caja: ";
            // 
            // fechapedido
            // 
            fechapedido.Enabled = false;
            fechapedido.Format = DateTimePickerFormat.Short;
            fechapedido.Location = new Point(154, 133);
            fechapedido.Margin = new Padding(3, 4, 3, 4);
            fechapedido.Name = "fechapedido";
            fechapedido.Size = new Size(140, 34);
            fechapedido.TabIndex = 4;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            limpiarbtn.Location = new Point(160, 49);
            limpiarbtn.Margin = new Padding(3, 4, 3, 4);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(137, 69);
            limpiarbtn.TabIndex = 0;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(3, 143);
            label11.Name = "label11";
            label11.Size = new Size(162, 25);
            label11.TabIndex = 3;
            label11.Text = "Fecha de pedido:";
            // 
            // guardarpedidobtn
            // 
            guardarpedidobtn.Enabled = false;
            guardarpedidobtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guardarpedidobtn.Location = new Point(6, 49);
            guardarpedidobtn.Margin = new Padding(3, 4, 3, 4);
            guardarpedidobtn.Name = "guardarpedidobtn";
            guardarpedidobtn.Size = new Size(137, 69);
            guardarpedidobtn.TabIndex = 0;
            guardarpedidobtn.Text = "Guardar Pedido";
            guardarpedidobtn.UseVisualStyleBackColor = true;
            guardarpedidobtn.Click += guardarpedidobtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buscarclientebtn);
            panel1.Controls.Add(txtidpedido);
            panel1.Controls.Add(txtnumero_cliente);
            panel1.Controls.Add(txtnombrecompleto);
            panel1.Location = new Point(7, 8);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 177);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(331, 4);
            label2.Name = "label2";
            label2.Size = new Size(235, 41);
            label2.TabIndex = 3;
            label2.Text = "Realizar Pedido";
            label2.Click += label2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(331, 99);
            label9.Name = "label9";
            label9.Size = new Size(189, 28);
            label9.TabIndex = 3;
            label9.Text = "Numero de telefono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(49, 99);
            label8.Name = "label8";
            label8.Size = new Size(177, 28);
            label8.TabIndex = 3;
            label8.Text = "Nombre Completo";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.Control;
            label20.Location = new Point(3, 11);
            label20.Name = "label20";
            label20.Size = new Size(189, 28);
            label20.TabIndex = 3;
            label20.Text = "Numero de pedido";
            label20.Click += label20_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 67);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 3;
            label1.Text = "Datos cliente";
            // 
            // buscarclientebtn
            // 
            buscarclientebtn.Image = Properties.Resources.busqueda;
            buscarclientebtn.Location = new Point(5, 131);
            buscarclientebtn.Margin = new Padding(3, 4, 3, 4);
            buscarclientebtn.Name = "buscarclientebtn";
            buscarclientebtn.Size = new Size(38, 34);
            buscarclientebtn.TabIndex = 2;
            toolTip1.SetToolTip(buscarclientebtn, "Click derecho para\r\nregistrar un nuevo\r\ncliente");
            buscarclientebtn.UseVisualStyleBackColor = true;
            buscarclientebtn.Click += buscarclientebtn_Click;
            buscarclientebtn.MouseDown += buscarclientebtn_MouseDown;
            // 
            // txtidpedido
            // 
            txtidpedido.Enabled = false;
            txtidpedido.Location = new Point(198, 11);
            txtidpedido.Margin = new Padding(3, 4, 3, 4);
            txtidpedido.Name = "txtidpedido";
            txtidpedido.Size = new Size(99, 34);
            txtidpedido.TabIndex = 0;
            txtidpedido.TextChanged += txtidpedido_TextChanged;
            // 
            // txtnumero_cliente
            // 
            txtnumero_cliente.Location = new Point(331, 131);
            txtnumero_cliente.Margin = new Padding(3, 4, 3, 4);
            txtnumero_cliente.Name = "txtnumero_cliente";
            txtnumero_cliente.Size = new Size(171, 34);
            txtnumero_cliente.TabIndex = 0;
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Location = new Point(49, 131);
            txtnombrecompleto.Margin = new Padding(3, 4, 3, 4);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new Size(275, 34);
            txtnombrecompleto.TabIndex = 0;
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
            tabPage2.Controls.Add(panel6);
            tabPage2.Controls.Add(panel5);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(899, 612);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pendientes De factura";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(6, 159);
            label13.Name = "label13";
            label13.Size = new Size(97, 28);
            label13.TabIndex = 7;
            label13.Text = "Busqueda";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(394, 159);
            label12.Name = "label12";
            label12.Size = new Size(62, 28);
            label12.TabIndex = 7;
            label12.Text = "Filtro:";
            // 
            // todoschk
            // 
            todoschk.AutoSize = true;
            todoschk.Location = new Point(813, 157);
            todoschk.Margin = new Padding(3, 4, 3, 4);
            todoschk.Name = "todoschk";
            todoschk.Size = new Size(86, 32);
            todoschk.TabIndex = 6;
            todoschk.Text = "Todos";
            todoschk.UseVisualStyleBackColor = true;
            todoschk.CheckedChanged += todoschk_CheckedChanged;
            // 
            // canceladochk
            // 
            canceladochk.AutoSize = true;
            canceladochk.Location = new Point(691, 157);
            canceladochk.Margin = new Padding(3, 4, 3, 4);
            canceladochk.Name = "canceladochk";
            canceladochk.Size = new Size(125, 32);
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
            pendientechk.Location = new Point(575, 157);
            pendientechk.Margin = new Padding(3, 4, 3, 4);
            pendientechk.Name = "pendientechk";
            pendientechk.Size = new Size(120, 32);
            pendientechk.TabIndex = 6;
            pendientechk.Text = "Pendiente";
            pendientechk.UseVisualStyleBackColor = true;
            pendientechk.CheckedChanged += pendientechk_CheckedChanged;
            // 
            // facturadochk
            // 
            facturadochk.AutoSize = true;
            facturadochk.Location = new Point(457, 157);
            facturadochk.Margin = new Padding(3, 4, 3, 4);
            facturadochk.Name = "facturadochk";
            facturadochk.Size = new Size(121, 32);
            facturadochk.TabIndex = 6;
            facturadochk.Text = "Facturado";
            facturadochk.UseVisualStyleBackColor = true;
            facturadochk.CheckedChanged += facturadochk_CheckedChanged;
            // 
            // txtbusquedafactura
            // 
            txtbusquedafactura.ForeColor = Color.Gray;
            txtbusquedafactura.Location = new Point(103, 155);
            txtbusquedafactura.Margin = new Padding(3, 4, 3, 4);
            txtbusquedafactura.Name = "txtbusquedafactura";
            txtbusquedafactura.Size = new Size(284, 34);
            txtbusquedafactura.TabIndex = 5;
            txtbusquedafactura.Text = "(ID, ID Pedido, Cliente, Mesa, Total)";
            txtbusquedafactura.TextChanged += txtbusquedafactura_TextChanged;
            txtbusquedafactura.Enter += txtbusquedafactura_Enter;
            txtbusquedafactura.Leave += txtbusquedafactura_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(291, 0);
            label10.Name = "label10";
            label10.Size = new Size(296, 41);
            label10.TabIndex = 4;
            label10.Text = "Area de Facturacion";
            label10.Click += label10_Click;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.WindowFrame;
            panel7.Controls.Add(cancelarpedido);
            panel7.Controls.Add(imprimirbtn);
            panel7.Controls.Add(facturarbtn);
            panel7.Location = new Point(475, 47);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(416, 99);
            panel7.TabIndex = 0;
            // 
            // cancelarpedido
            // 
            cancelarpedido.Location = new Point(281, 12);
            cancelarpedido.Margin = new Padding(3, 4, 3, 4);
            cancelarpedido.Name = "cancelarpedido";
            cancelarpedido.Size = new Size(130, 75);
            cancelarpedido.TabIndex = 0;
            cancelarpedido.Text = "Cancelar";
            cancelarpedido.UseVisualStyleBackColor = true;
            cancelarpedido.Click += cancelarpedido_Click;
            // 
            // imprimirbtn
            // 
            imprimirbtn.Location = new Point(143, 12);
            imprimirbtn.Margin = new Padding(3, 4, 3, 4);
            imprimirbtn.Name = "imprimirbtn";
            imprimirbtn.Size = new Size(130, 75);
            imprimirbtn.TabIndex = 0;
            imprimirbtn.Text = "Imprimir";
            imprimirbtn.UseVisualStyleBackColor = true;
            imprimirbtn.Click += imprimirbtn_Click;
            // 
            // facturarbtn
            // 
            facturarbtn.Location = new Point(5, 12);
            facturarbtn.Margin = new Padding(3, 4, 3, 4);
            facturarbtn.Name = "facturarbtn";
            facturarbtn.Size = new Size(130, 75);
            facturarbtn.TabIndex = 0;
            facturarbtn.Text = "Facturar";
            facturarbtn.UseVisualStyleBackColor = true;
            facturarbtn.Click += facturarbtn_Click;
            // 
            // panel6
            // 
            panel6.Location = new Point(7, 47);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(462, 99);
            panel6.TabIndex = 0;
            panel6.Paint += panel6_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(tabladatospedidos);
            panel5.Location = new Point(7, 201);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(885, 399);
            panel5.TabIndex = 0;
            // 
            // tabladatospedidos
            // 
            tabladatospedidos.AllowUserToAddRows = false;
            tabladatospedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatospedidos.Location = new Point(3, 9);
            tabladatospedidos.Margin = new Padding(3, 4, 3, 4);
            tabladatospedidos.MultiSelect = false;
            tabladatospedidos.Name = "tabladatospedidos";
            tabladatospedidos.ReadOnly = true;
            tabladatospedidos.RowHeadersWidth = 51;
            tabladatospedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatospedidos.Size = new Size(878, 385);
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
            panelmesas.Location = new Point(919, 44);
            panelmesas.Margin = new Padding(3, 4, 3, 4);
            panelmesas.Name = "panelmesas";
            panelmesas.Size = new Size(911, 657);
            panelmesas.TabIndex = 1;
            panelmesas.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(7, 108);
            label15.Name = "label15";
            label15.Size = new Size(74, 20);
            label15.TabIndex = 9;
            label15.Text = "Busqueda";
            // 
            // txtmesabusqueda
            // 
            txtmesabusqueda.Location = new Point(81, 104);
            txtmesabusqueda.Margin = new Padding(3, 4, 3, 4);
            txtmesabusqueda.Name = "txtmesabusqueda";
            txtmesabusqueda.Size = new Size(815, 27);
            txtmesabusqueda.TabIndex = 8;
            txtmesabusqueda.TextChanged += txtmesabusqueda_TextChanged;
            // 
            // button7
            // 
            button7.Location = new Point(770, 13);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(127, 60);
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
            label14.Location = new Point(317, 13);
            label14.Name = "label14";
            label14.Size = new Size(285, 41);
            label14.TabIndex = 3;
            label14.Text = "Seleccion de mesas";
            // 
            // tablaseleccionmesas
            // 
            tablaseleccionmesas.AllowUserToAddRows = false;
            tablaseleccionmesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaseleccionmesas.Location = new Point(3, 151);
            tablaseleccionmesas.Margin = new Padding(3, 4, 3, 4);
            tablaseleccionmesas.MultiSelect = false;
            tablaseleccionmesas.Name = "tablaseleccionmesas";
            tablaseleccionmesas.ReadOnly = true;
            tablaseleccionmesas.RowHeadersWidth = 51;
            tablaseleccionmesas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaseleccionmesas.Size = new Size(896, 453);
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
            panelclientes.Location = new Point(919, 709);
            panelclientes.Margin = new Padding(3, 4, 3, 4);
            panelclientes.Name = "panelclientes";
            panelclientes.Size = new Size(911, 657);
            panelclientes.TabIndex = 1;
            panelclientes.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(7, 108);
            label18.Name = "label18";
            label18.Size = new Size(74, 20);
            label18.TabIndex = 9;
            label18.Text = "Busqueda";
            // 
            // txtclientebusqueda
            // 
            txtclientebusqueda.Location = new Point(81, 104);
            txtclientebusqueda.Margin = new Padding(3, 4, 3, 4);
            txtclientebusqueda.Name = "txtclientebusqueda";
            txtclientebusqueda.Size = new Size(818, 27);
            txtclientebusqueda.TabIndex = 8;
            txtclientebusqueda.TextChanged += txtclientebusqueda_TextChanged;
            // 
            // button5
            // 
            button5.Location = new Point(773, 16);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(127, 60);
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
            label19.Location = new Point(317, 17);
            label19.Name = "label19";
            label19.Size = new Size(307, 41);
            label19.TabIndex = 3;
            label19.Text = "Seleccion de clientes";
            // 
            // tablaclientes
            // 
            tablaclientes.AllowUserToAddRows = false;
            tablaclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaclientes.Location = new Point(3, 151);
            tablaclientes.Margin = new Padding(3, 4, 3, 4);
            tablaclientes.MultiSelect = false;
            tablaclientes.Name = "tablaclientes";
            tablaclientes.ReadOnly = true;
            tablaclientes.RowHeadersWidth = 51;
            tablaclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaclientes.Size = new Size(896, 453);
            tablaclientes.TabIndex = 6;
            tablaclientes.CellDoubleClick += tablaclientes_CellDoubleClick;
            // 
            // tablapanelproducto
            // 
            tablapanelproducto.AllowUserToAddRows = false;
            tablapanelproducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablapanelproducto.Location = new Point(3, 151);
            tablapanelproducto.Margin = new Padding(3, 4, 3, 4);
            tablapanelproducto.MultiSelect = false;
            tablapanelproducto.Name = "tablapanelproducto";
            tablapanelproducto.ReadOnly = true;
            tablapanelproducto.RowHeadersWidth = 51;
            tablapanelproducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablapanelproducto.Size = new Size(896, 453);
            tablapanelproducto.TabIndex = 6;
            tablapanelproducto.CellDoubleClick += tablapanelproducto_CellDoubleClick;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.Control;
            label17.Location = new Point(319, 19);
            label17.Name = "label17";
            label17.Size = new Size(330, 41);
            label17.TabIndex = 3;
            label17.Text = "Seleccion de producto";
            // 
            // button4
            // 
            button4.Location = new Point(773, 19);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(127, 60);
            button4.TabIndex = 7;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtproductobusqueda
            // 
            txtproductobusqueda.Location = new Point(81, 104);
            txtproductobusqueda.Margin = new Padding(3, 4, 3, 4);
            txtproductobusqueda.Name = "txtproductobusqueda";
            txtproductobusqueda.Size = new Size(818, 27);
            txtproductobusqueda.TabIndex = 8;
            txtproductobusqueda.TextChanged += txtproductobusqueda_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.Control;
            label16.Location = new Point(7, 108);
            label16.Name = "label16";
            label16.Size = new Size(74, 20);
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
            panelproducto.Location = new Point(3, 665);
            panelproducto.Margin = new Padding(3, 4, 3, 4);
            panelproducto.Name = "panelproducto";
            panelproducto.Size = new Size(909, 657);
            panelproducto.TabIndex = 1;
            panelproducto.Visible = false;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Ayuda";
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(917, 661);
            Controls.Add(panelclientes);
            Controls.Add(panelproducto);
            Controls.Add(panelmesas);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Pedidos";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel7.ResumeLayout(false);
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
        private Panel panel6;
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
        private Label label9;
        private Label label8;
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
    }
}