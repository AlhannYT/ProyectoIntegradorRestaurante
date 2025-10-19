namespace Proyecto_restaurante
{
    partial class MantClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantClientes));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            guardarbtn = new Button();
            limpiarbtn = new Button();
            label5 = new Label();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtcedula = new TextBox();
            txtnumero = new TextBox();
            pictureBox1 = new PictureBox();
            estadochk = new CheckBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(38, 199);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(38, 246);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 0;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(38, 340);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 0;
            label3.Text = "Numero de telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(38, 293);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 0;
            label4.Text = "Cedula";
            // 
            // guardarbtn
            // 
            guardarbtn.Image = Properties.Resources.disco;
            guardarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            guardarbtn.Location = new Point(90, 394);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(108, 42);
            guardarbtn.TabIndex = 1;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = true;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // limpiarbtn
            // 
            limpiarbtn.Image = Properties.Resources.limpio;
            limpiarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            limpiarbtn.Location = new Point(234, 394);
            limpiarbtn.Name = "limpiarbtn";
            limpiarbtn.Size = new Size(108, 42);
            limpiarbtn.TabIndex = 1;
            limpiarbtn.Text = "Limpiar";
            limpiarbtn.UseVisualStyleBackColor = true;
            limpiarbtn.Click += limpiarbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(64, 0);
            label5.Name = "label5";
            label5.Size = new Size(252, 37);
            label5.TabIndex = 0;
            label5.Text = "Registro de Clientes";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(216, 197);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(172, 23);
            txtnombre.TabIndex = 0;
            txtnombre.TextChanged += txtnombre_TextChanged;
            txtnombre.KeyPress += txtnombre_KeyPress;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(216, 244);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(172, 23);
            txtapellido.TabIndex = 2;
            txtapellido.TextChanged += txtapellido_TextChanged;
            txtapellido.KeyPress += txtapellido_KeyPress;
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(216, 292);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(172, 23);
            txtcedula.TabIndex = 2;
            txtcedula.TextChanged += txtcedula_TextChanged;
            txtcedula.KeyPress += txtcedula_KeyPress;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(216, 339);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(172, 23);
            txtnumero.TabIndex = 2;
            txtnumero.TextChanged += txtnumero_TextChanged;
            txtnumero.KeyPress += txtnumero_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(129, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // estadochk
            // 
            estadochk.AutoSize = true;
            estadochk.Checked = true;
            estadochk.CheckState = CheckState.Checked;
            estadochk.ForeColor = Color.Lime;
            estadochk.Location = new Point(216, 163);
            estadochk.Name = "estadochk";
            estadochk.Size = new Size(60, 19);
            estadochk.TabIndex = 11;
            estadochk.Text = "Activo";
            estadochk.UseVisualStyleBackColor = true;
            estadochk.CheckedChanged += estadochk_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(151, 159);
            label8.Name = "label8";
            label8.Size = new Size(59, 21);
            label8.TabIndex = 0;
            label8.Text = "Estado:";
            // 
            // MantClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(445, 455);
            Controls.Add(estadochk);
            Controls.Add(pictureBox1);
            Controls.Add(txtnumero);
            Controls.Add(txtcedula);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(limpiarbtn);
            Controls.Add(guardarbtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MantClientes";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Registro de Clientes";
            Load += MantClientes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button guardarbtn;
        private Button limpiarbtn;
        private Label label5;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtcedula;
        private TextBox txtnumero;
        private PictureBox pictureBox1;
        private CheckBox estadochk;
        private Label label8;
    }
}