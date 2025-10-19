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
            txtbuscador = new TextBox();
            tabladatos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            eliminarbtn = new Button();
            label3 = new Label();
            Editar = new Button();
            agregar = new Button();
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
            tabladatos.Location = new Point(12, 106);
            tabladatos.Name = "tabladatos";
            tabladatos.ReadOnly = true;
            tabladatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabladatos.Size = new Size(543, 332);
            tabladatos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(216, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 40);
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
            eliminarbtn.Image = Properties.Resources.limpio;
            eliminarbtn.Location = new Point(526, 76);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(29, 24);
            eliminarbtn.TabIndex = 2;
            eliminarbtn.UseVisualStyleBackColor = true;
            eliminarbtn.Click += eliminarbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(583, 69);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 48;
            label3.Text = "Acciones";
            // 
            // Editar
            // 
            Editar.Image = Properties.Resources.editarcliente1;
            Editar.Location = new Point(560, 184);
            Editar.Name = "Editar";
            Editar.Size = new Size(159, 72);
            Editar.TabIndex = 46;
            Editar.Text = "Editar";
            Editar.TextAlign = ContentAlignment.BottomCenter;
            Editar.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            agregar.Image = Properties.Resources.cliente1;
            agregar.Location = new Point(560, 106);
            agregar.Name = "agregar";
            agregar.Size = new Size(159, 72);
            agregar.TabIndex = 47;
            agregar.Text = "Nuevo";
            agregar.TextAlign = ContentAlignment.BottomCenter;
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // ConsClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(727, 450);
            Controls.Add(label3);
            Controls.Add(Editar);
            Controls.Add(agregar);
            Controls.Add(eliminarbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tabladatos);
            Controls.Add(txtbuscador);
            Name = "ConsClientes";
            StartPosition = FormStartPosition.Manual;
            Text = "ConsultaClientes";
            Load += ConsultaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)tabladatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}