namespace Proyecto_restaurante
{
    partial class inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtusuario = new TextBox();
            txtpass = new TextBox();
            iniciobtn = new Button();
            panel1 = new Panel();
            passView = new CheckBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            iniciolabel = new Label();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            sqlbtn = new Button();
            toolTip1 = new ToolTip(components);
            conexionpanel = new Panel();
            button6 = new Button();
            button3 = new Button();
            defectochk = new CheckBox();
            contservidortxt = new TextBox();
            usuarioservidortxt = new TextBox();
            servidortxt = new TextBox();
            salirsqlbtn = new Button();
            guardarbtn = new Button();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            txtsql = new DataGridView();
            conexiones = new Panel();
            borrarconex = new Button();
            button5 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            conexionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtsql).BeginInit();
            conexiones.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(167, 230);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(167, 278);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(265, 231);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(115, 23);
            txtusuario.TabIndex = 0;
            txtusuario.TextChanged += txtusuario_TextChanged;
            txtusuario.KeyPress += txtusuario_KeyPress;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(265, 278);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(115, 23);
            txtpass.TabIndex = 1;
            txtpass.UseSystemPasswordChar = true;
            txtpass.KeyPress += txtpass_KeyPress;
            // 
            // iniciobtn
            // 
            iniciobtn.Location = new Point(211, 325);
            iniciobtn.Name = "iniciobtn";
            iniciobtn.Size = new Size(142, 29);
            iniciobtn.TabIndex = 3;
            iniciobtn.Text = "Iniciar Sesión";
            iniciobtn.UseVisualStyleBackColor = true;
            iniciobtn.Click += iniciobtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Location = new Point(99, 201);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 6);
            panel1.TabIndex = 4;
            // 
            // passView
            // 
            passView.Appearance = Appearance.Button;
            passView.Image = Properties.Resources.ojo;
            passView.Location = new Point(386, 279);
            passView.Name = "passView";
            passView.Size = new Size(27, 22);
            passView.TabIndex = 6;
            passView.UseVisualStyleBackColor = true;
            passView.CheckedChanged += passView_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.restaurantes_moda_barcelona_roka_6475ba03ee8bc;
            pictureBox2.Location = new Point(-15, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(601, 396);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.minimizar_ventana__1_;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(494, 3);
            button1.Name = "button1";
            button1.Size = new Size(29, 27);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // iniciolabel
            // 
            iniciolabel.AutoSize = true;
            iniciolabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iniciolabel.ForeColor = Color.White;
            iniciolabel.Location = new Point(226, 7);
            iniciolabel.Name = "iniciolabel";
            iniciolabel.Size = new Size(113, 20);
            iniciolabel.TabIndex = 8;
            iniciolabel.Text = "Inicio de Sesion";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.cruz__1_;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(528, 3);
            button2.Name = "button2";
            button2.Size = new Size(29, 27);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // sqlbtn
            // 
            sqlbtn.Image = Properties.Resources.sql;
            sqlbtn.Location = new Point(9, 44);
            sqlbtn.Name = "sqlbtn";
            sqlbtn.Size = new Size(36, 36);
            sqlbtn.TabIndex = 9;
            toolTip1.SetToolTip(sqlbtn, "Conexion SQL");
            sqlbtn.UseVisualStyleBackColor = true;
            sqlbtn.Click += sqlbtn_Click;
            // 
            // conexionpanel
            // 
            conexionpanel.BackColor = Color.Gray;
            conexionpanel.Controls.Add(button6);
            conexionpanel.Controls.Add(button3);
            conexionpanel.Controls.Add(defectochk);
            conexionpanel.Controls.Add(contservidortxt);
            conexionpanel.Controls.Add(usuarioservidortxt);
            conexionpanel.Controls.Add(servidortxt);
            conexionpanel.Controls.Add(salirsqlbtn);
            conexionpanel.Controls.Add(guardarbtn);
            conexionpanel.Controls.Add(label5);
            conexionpanel.Controls.Add(label4);
            conexionpanel.Controls.Add(label6);
            conexionpanel.Controls.Add(label3);
            conexionpanel.Location = new Point(605, 45);
            conexionpanel.Name = "conexionpanel";
            conexionpanel.Size = new Size(564, 368);
            conexionpanel.TabIndex = 10;
            conexionpanel.Visible = false;
            // 
            // button6
            // 
            button6.Image = Properties.Resources.limpio;
            button6.Location = new Point(484, 91);
            button6.Name = "button6";
            button6.Size = new Size(31, 25);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.busqueda;
            button3.Location = new Point(17, 13);
            button3.Name = "button3";
            button3.Size = new Size(32, 32);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // defectochk
            // 
            defectochk.AutoSize = true;
            defectochk.CheckAlign = ContentAlignment.MiddleRight;
            defectochk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            defectochk.ForeColor = Color.White;
            defectochk.Location = new Point(204, 234);
            defectochk.Name = "defectochk";
            defectochk.Size = new Size(194, 25);
            defectochk.TabIndex = 3;
            defectochk.Text = "Conexion por defecto";
            defectochk.UseVisualStyleBackColor = true;
            // 
            // contservidortxt
            // 
            contservidortxt.Location = new Point(165, 200);
            contservidortxt.Name = "contservidortxt";
            contservidortxt.Size = new Size(315, 23);
            contservidortxt.TabIndex = 2;
            contservidortxt.UseSystemPasswordChar = true;
            // 
            // usuarioservidortxt
            // 
            usuarioservidortxt.Location = new Point(165, 146);
            usuarioservidortxt.Name = "usuarioservidortxt";
            usuarioservidortxt.Size = new Size(315, 23);
            usuarioservidortxt.TabIndex = 2;
            // 
            // servidortxt
            // 
            servidortxt.Location = new Point(165, 92);
            servidortxt.Name = "servidortxt";
            servidortxt.Size = new Size(315, 23);
            servidortxt.TabIndex = 2;
            // 
            // salirsqlbtn
            // 
            salirsqlbtn.Image = Properties.Resources.salida;
            salirsqlbtn.ImageAlign = ContentAlignment.MiddleLeft;
            salirsqlbtn.Location = new Point(320, 276);
            salirsqlbtn.Name = "salirsqlbtn";
            salirsqlbtn.Size = new Size(104, 48);
            salirsqlbtn.TabIndex = 1;
            salirsqlbtn.Text = "Salir";
            salirsqlbtn.TextAlign = ContentAlignment.MiddleRight;
            salirsqlbtn.UseVisualStyleBackColor = true;
            salirsqlbtn.Click += salirsqlbtn_Click;
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.disco;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(150, 276);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(104, 48);
            guardarbtn.TabIndex = 1;
            guardarbtn.Text = "Guardar";
            guardarbtn.TextAlign = ContentAlignment.MiddleRight;
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(61, 200);
            label5.Name = "label5";
            label5.Size = new Size(96, 21);
            label5.TabIndex = 0;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(61, 145);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 0;
            label4.Text = "Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(172, 27);
            label6.Name = "label6";
            label6.Size = new Size(221, 32);
            label6.TabIndex = 0;
            label6.Text = "Conexion con SQL\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(61, 90);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 0;
            label3.Text = "Servidor";
            // 
            // txtsql
            // 
            txtsql.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            txtsql.Location = new Point(9, 9);
            txtsql.MultiSelect = false;
            txtsql.Name = "txtsql";
            txtsql.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtsql.Size = new Size(482, 243);
            txtsql.TabIndex = 11;
            txtsql.CellDoubleClick += txtsql_CellDoubleClick;
            // 
            // conexiones
            // 
            conexiones.Controls.Add(borrarconex);
            conexiones.Controls.Add(txtsql);
            conexiones.Controls.Add(button5);
            conexiones.Controls.Add(button4);
            conexiones.Location = new Point(605, 416);
            conexiones.Name = "conexiones";
            conexiones.Size = new Size(564, 368);
            conexiones.TabIndex = 12;
            conexiones.Visible = false;
            // 
            // borrarconex
            // 
            borrarconex.Image = Properties.Resources.basura;
            borrarconex.Location = new Point(497, 9);
            borrarconex.Name = "borrarconex";
            borrarconex.Size = new Size(52, 41);
            borrarconex.TabIndex = 12;
            borrarconex.UseVisualStyleBackColor = true;
            borrarconex.Click += borrarconex_Click;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.cancelar1;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(320, 269);
            button5.Name = "button5";
            button5.Size = new Size(104, 48);
            button5.TabIndex = 1;
            button5.Text = "Cancelar";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.check;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(150, 269);
            button4.Name = "button4";
            button4.Size = new Size(104, 48);
            button4.TabIndex = 1;
            button4.Text = "Seleccionar";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(564, 368);
            Controls.Add(conexiones);
            Controls.Add(conexionpanel);
            Controls.Add(sqlbtn);
            Controls.Add(pictureBox1);
            Controls.Add(iniciolabel);
            Controls.Add(passView);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(iniciobtn);
            Controls.Add(txtpass);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio De Sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            conexionpanel.ResumeLayout(false);
            conexionpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtsql).EndInit();
            conexiones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtusuario;
        private TextBox txtpass;
        private Button iniciobtn;
        private Panel panel1;
        private CheckBox passView;
        private PictureBox pictureBox2;
        private Button button1;
        private Label iniciolabel;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Button sqlbtn;
        private ToolTip toolTip1;
        private Panel conexionpanel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button salirsqlbtn;
        private Button guardarbtn;
        private TextBox contservidortxt;
        private TextBox usuarioservidortxt;
        private TextBox servidortxt;
        private Label label6;
        private CheckBox defectochk;
        private Button button3;
        private DataGridView txtsql;
        private Panel conexiones;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button borrarconex;
    }
}
