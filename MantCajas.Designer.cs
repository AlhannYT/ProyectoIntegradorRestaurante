namespace Proyecto_restaurante
{
    partial class MantCajas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantCajas));
            label5 = new Label();
            eliminarbtn = new Button();
            tabladatos = new DataGridView();
            txtbuscador = new TextBox();
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            button4 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            filtro = new CheckBox();
            label3 = new Label();
            Editar = new Button();
            agregar = new Button();
            tabPage2 = new TabPage();
            responsablepanel = new Panel();
            idconsultatxt = new TextBox();
            categoriaconsultatxt = new TextBox();
            button5 = new Button();
            label1 = new Label();
            categoriaconsulta = new DataGridView();
            idresponsabletxt = new TextBox();
            responsabletxt = new TextBox();
            buscarresponsable = new Button();
            panel3 = new Panel();
            guardatbtn = new Button();
            limpiarbtn = new Button();
            label8 = new Label();
            estadocajachk = new CheckBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            nombrecajatxt = new TextBox();
            numerocajatxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            responsablepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoriaconsulta).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(160, 12);
            label5.Name = "label5";
            label5.Size = new Size(215, 32);
            label5.TabIndex = 39;
            label5.Text = "Consulta de Cajas";
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(373, 71);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 29);
            eliminarbtn.TabIndex = 36;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(8, 106);
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.RowHeadersWidth = 51;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(395, 308);
            tabladatos.TabIndex = 34;
            tabladatos.CellClick += tabladatos_CellClick;
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(8, 71);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(309, 29);
            txtbuscador.TabIndex = 35;
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Ayuda";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.actualizar;
            button1.Location = new Point(12, 14);
            button1.Name = "button1";
            button1.Size = new Size(29, 29);
            button1.TabIndex = 55;
            button1.TabStop = false;
            toolTip1.SetToolTip(button1, "Regarcar Datos");
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.actualizar;
            button4.Location = new Point(8, 14);
            button4.Name = "button4";
            button4.Size = new Size(29, 29);
            button4.TabIndex = 56;
            button4.TabStop = false;
            toolTip1.SetToolTip(button4, "Regarcar Datos");
            button4.UseVisualStyleBackColor = true;
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
            tabControl1.Size = new Size(586, 458);
            tabControl1.TabIndex = 43;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.WindowFrame;
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(filtro);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(Editar);
            tabPage1.Controls.Add(agregar);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(eliminarbtn);
            tabPage1.Controls.Add(tabladatos);
            tabPage1.Controls.Add(txtbuscador);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(578, 424);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consulta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Image = Properties.Resources.busqueda;
            label2.Location = new Point(296, 75);
            label2.Name = "label2";
            label2.Size = new Size(18, 21);
            label2.TabIndex = 57;
            label2.Text = "  ";
            // 
            // filtro
            // 
            filtro.AutoSize = true;
            filtro.Checked = true;
            filtro.CheckState = CheckState.Checked;
            filtro.Cursor = Cursors.Hand;
            filtro.Font = new Font("Segoe UI", 13F);
            filtro.Image = Properties.Resources.sicheck;
            filtro.Location = new Point(329, 71);
            filtro.Name = "filtro";
            filtro.Size = new Size(41, 29);
            filtro.TabIndex = 58;
            filtro.Text = "  ";
            filtro.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(430, 69);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 51;
            label3.Text = "Acciones";
            // 
            // Editar
            // 
            Editar.Image = Properties.Resources.editar;
            Editar.Location = new Point(409, 183);
            Editar.Name = "Editar";
            Editar.Size = new Size(159, 72);
            Editar.TabIndex = 49;
            Editar.Text = "Editar";
            Editar.TextAlign = ContentAlignment.BottomCenter;
            Editar.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            agregar.Image = Properties.Resources.cajero;
            agregar.Location = new Point(409, 106);
            agregar.Name = "agregar";
            agregar.Size = new Size(159, 72);
            agregar.TabIndex = 50;
            agregar.Text = "Nuevo";
            agregar.TextAlign = ContentAlignment.BottomCenter;
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.WindowFrame;
            tabPage2.Controls.Add(responsablepanel);
            tabPage2.Controls.Add(idresponsabletxt);
            tabPage2.Controls.Add(responsabletxt);
            tabPage2.Controls.Add(buscarresponsable);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(estadocajachk);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(nombrecajatxt);
            tabPage2.Controls.Add(numerocajatxt);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(578, 424);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Creación";
            // 
            // responsablepanel
            // 
            responsablepanel.BackColor = Color.FromArgb(64, 64, 64);
            responsablepanel.Controls.Add(idconsultatxt);
            responsablepanel.Controls.Add(categoriaconsultatxt);
            responsablepanel.Controls.Add(button5);
            responsablepanel.Controls.Add(label1);
            responsablepanel.Controls.Add(categoriaconsulta);
            responsablepanel.Location = new Point(277, 126);
            responsablepanel.Name = "responsablepanel";
            responsablepanel.Size = new Size(217, 170);
            responsablepanel.TabIndex = 82;
            responsablepanel.Visible = false;
            // 
            // idconsultatxt
            // 
            idconsultatxt.Location = new Point(4, 28);
            idconsultatxt.Name = "idconsultatxt";
            idconsultatxt.Size = new Size(40, 29);
            idconsultatxt.TabIndex = 58;
            // 
            // categoriaconsultatxt
            // 
            categoriaconsultatxt.Location = new Point(49, 28);
            categoriaconsultatxt.Name = "categoriaconsultatxt";
            categoriaconsultatxt.Size = new Size(133, 29);
            categoriaconsultatxt.TabIndex = 58;
            // 
            // button5
            // 
            button5.ForeColor = Color.Black;
            button5.Image = Properties.Resources.angulo_hacia_arriba;
            button5.Location = new Point(185, 28);
            button5.Name = "button5";
            button5.Size = new Size(28, 29);
            button5.TabIndex = 60;
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 2);
            label1.Name = "label1";
            label1.Size = new Size(198, 21);
            label1.TabIndex = 50;
            label1.Text = "Seleccionar Responsable";
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
            categoriaconsulta.Size = new Size(208, 101);
            categoriaconsulta.TabIndex = 74;
            // 
            // idresponsabletxt
            // 
            idresponsabletxt.Location = new Point(279, 87);
            idresponsabletxt.Name = "idresponsabletxt";
            idresponsabletxt.Size = new Size(42, 29);
            idresponsabletxt.TabIndex = 78;
            // 
            // responsabletxt
            // 
            responsabletxt.Location = new Point(326, 87);
            responsabletxt.Name = "responsabletxt";
            responsabletxt.Size = new Size(133, 29);
            responsabletxt.TabIndex = 79;
            // 
            // buscarresponsable
            // 
            buscarresponsable.ForeColor = Color.Black;
            buscarresponsable.Image = Properties.Resources.busqueda;
            buscarresponsable.Location = new Point(462, 87);
            buscarresponsable.Name = "buscarresponsable";
            buscarresponsable.Size = new Size(28, 29);
            buscarresponsable.TabIndex = 80;
            buscarresponsable.UseVisualStyleBackColor = true;
            buscarresponsable.Click += buscarresponsable_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(guardatbtn);
            panel3.Controls.Add(limpiarbtn);
            panel3.Location = new Point(85, 335);
            panel3.Name = "panel3";
            panel3.Size = new Size(409, 74);
            panel3.TabIndex = 76;
            // 
            // guardatbtn
            // 
            guardatbtn.Image = Properties.Resources.disco;
            guardatbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardatbtn.Location = new Point(12, 8);
            guardatbtn.Name = "guardatbtn";
            guardatbtn.Size = new Size(181, 58);
            guardatbtn.TabIndex = 43;
            guardatbtn.Text = "Guardar";
            guardatbtn.UseVisualStyleBackColor = true;
            guardatbtn.Click += guardatbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(216, 8);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(181, 58);
            limpiarbtn.TabIndex = 44;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(184, 12);
            label8.Name = "label8";
            label8.Size = new Size(210, 32);
            label8.TabIndex = 53;
            label8.Text = "Registro de Cajas";
            // 
            // estadocajachk
            // 
            estadocajachk.AutoSize = true;
            estadocajachk.Checked = true;
            estadocajachk.CheckState = CheckState.Checked;
            estadocajachk.ForeColor = Color.Lime;
            estadocajachk.Location = new Point(171, 271);
            estadocajachk.Name = "estadocajachk";
            estadocajachk.Size = new Size(72, 25);
            estadocajachk.TabIndex = 45;
            estadocajachk.Text = "Activo";
            estadocajachk.UseVisualStyleBackColor = true;
            estadocajachk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(85, 166);
            label9.Name = "label9";
            label9.Size = new Size(133, 21);
            label9.TabIndex = 46;
            label9.Text = "Nombre de Caja";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(85, 273);
            label10.Name = "label10";
            label10.Size = new Size(65, 21);
            label10.TabIndex = 47;
            label10.Text = "Estado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(85, 59);
            label11.Name = "label11";
            label11.Size = new Size(91, 21);
            label11.TabIndex = 48;
            label11.Text = "N° De Caja";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(277, 59);
            label12.Name = "label12";
            label12.Size = new Size(106, 21);
            label12.TabIndex = 49;
            label12.Text = "Responsable";
            // 
            // nombrecajatxt
            // 
            nombrecajatxt.Location = new Point(85, 193);
            nombrecajatxt.Name = "nombrecajatxt";
            nombrecajatxt.Size = new Size(158, 29);
            nombrecajatxt.TabIndex = 51;
            nombrecajatxt.TextChanged += txtnombrecaja_TextChanged;
            // 
            // numerocajatxt
            // 
            numerocajatxt.Location = new Point(85, 87);
            numerocajatxt.Name = "numerocajatxt";
            numerocajatxt.Size = new Size(158, 29);
            numerocajatxt.TabIndex = 52;
            // 
            // MantCajas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(586, 458);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MantCajas";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Cajas";
            Load += MantCajas_Load;
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            responsablepanel.ResumeLayout(false);
            responsablepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoriaconsulta).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private Button eliminarbtn;
        private DataGridView tabladatos;
        private TextBox txtbuscador;
        private ToolTip toolTip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label8;
        public Button button1;
        private Button guardatbtn;
        private Button limpiarbtn;
        private CheckBox estadocajachk;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox nombrecajatxt;
        private TextBox numerocajatxt;
        private Label label3;
        private Button Editar;
        private Button agregar;
        public Button button4;
        private Panel panel3;
        private Label label2;
        private CheckBox filtro;
        private TextBox idresponsabletxt;
        private TextBox responsabletxt;
        private Button buscarresponsable;
        private Panel responsablepanel;
        private TextBox idconsultatxt;
        private TextBox categoriaconsultatxt;
        private Button button5;
        private Label label1;
        private DataGridView categoriaconsulta;
    }
}