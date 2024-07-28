namespace Proyecto_restaurante
{
    partial class ConsultaClientes
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
            txtbuscador = new TextBox();
            tabladatos = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            eliminarbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)tabladatos).BeginInit();
            SuspendLayout();
            // 
            // txtbuscador
            // 
            txtbuscador.ForeColor = SystemColors.ScrollBar;
            txtbuscador.Location = new Point(87, 76);
            txtbuscador.Name = "txtbuscador";
            txtbuscador.Size = new Size(433, 23);
            txtbuscador.TabIndex = 1;
            txtbuscador.Text = "(ID, Nombre, Apellido)";
            txtbuscador.TextChanged += txtbuscador_TextChanged;
            txtbuscador.Enter += txtbuscador_Enter;
            txtbuscador.Leave += txtbuscador_Leave;
            // 
            // tabladatos
            // 
            tabladatos.AllowUserToAddRows = false;
            tabladatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladatos.Location = new Point(12, 131);
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(543, 307);
            tabladatos.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(12, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 10);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(145, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 40);
            label1.TabIndex = 3;
            label1.Text = "Consulta de Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 0;
            label2.Text = "Buscador: ";
            // 
            // eliminarbtn
            // 
            eliminarbtn.Image = Properties.Resources.basura;
            eliminarbtn.Location = new Point(526, 76);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 24);
            eliminarbtn.TabIndex = 2;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // ConsultaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(565, 450);
            Controls.Add(eliminarbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(tabladatos);
            Controls.Add(txtbuscador);
            Name = "ConsultaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaClientes";
            Load += ConsultaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbuscador;
        private DataGridView tabladatos;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button eliminarbtn;
    }
}