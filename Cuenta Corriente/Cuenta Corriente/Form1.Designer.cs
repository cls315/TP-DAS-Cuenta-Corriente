namespace Cuenta_Corriente
{
    partial class Form1
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
            txtNombreCliente = new TextBox();
            txtApellidoCliente = new TextBox();
            txtDNICliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            lblNombreCliente = new Label();
            lblApellidoCliente = new Label();
            lblDNICliente = new Label();
            lblTelefonoCLiente = new Label();
            btnAgregarCliente = new Button();
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(215, 68);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(100, 23);
            txtNombreCliente.TabIndex = 0;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(215, 119);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(100, 23);
            txtApellidoCliente.TabIndex = 1;
            // 
            // txtDNICliente
            // 
            txtDNICliente.Location = new Point(215, 167);
            txtDNICliente.Name = "txtDNICliente";
            txtDNICliente.Size = new Size(100, 23);
            txtDNICliente.TabIndex = 2;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(215, 216);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(100, 23);
            txtTelefonoCliente.TabIndex = 3;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(72, 71);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(93, 15);
            lblNombreCliente.TabIndex = 4;
            lblNombreCliente.Text = "Ingreso Nombre";
            // 
            // lblApellidoCliente
            // 
            lblApellidoCliente.AutoSize = true;
            lblApellidoCliente.Location = new Point(72, 122);
            lblApellidoCliente.Name = "lblApellidoCliente";
            lblApellidoCliente.Size = new Size(93, 15);
            lblApellidoCliente.TabIndex = 5;
            lblApellidoCliente.Text = "Ingreso Apellido";
            // 
            // lblDNICliente
            // 
            lblDNICliente.AutoSize = true;
            lblDNICliente.Location = new Point(96, 170);
            lblDNICliente.Name = "lblDNICliente";
            lblDNICliente.Size = new Size(69, 15);
            lblDNICliente.TabIndex = 6;
            lblDNICliente.Text = "Ingreso DNI";
            // 
            // lblTelefonoCLiente
            // 
            lblTelefonoCLiente.AutoSize = true;
            lblTelefonoCLiente.Location = new Point(71, 219);
            lblTelefonoCLiente.Name = "lblTelefonoCLiente";
            lblTelefonoCLiente.Size = new Size(94, 15);
            lblTelefonoCLiente.TabIndex = 7;
            lblTelefonoCLiente.Text = "Ingreso Telefono";
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(128, 278);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(121, 31);
            btnAgregarCliente.TabIndex = 8;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(363, 27);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(425, 378);
            dgvClientes.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvClientes);
            Controls.Add(btnAgregarCliente);
            Controls.Add(lblTelefonoCLiente);
            Controls.Add(lblDNICliente);
            Controls.Add(lblApellidoCliente);
            Controls.Add(lblNombreCliente);
            Controls.Add(txtTelefonoCliente);
            Controls.Add(txtDNICliente);
            Controls.Add(txtApellidoCliente);
            Controls.Add(txtNombreCliente);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreCliente;
        private TextBox txtApellidoCliente;
        private TextBox txtDNICliente;
        private TextBox txtTelefonoCliente;
        private Label lblNombreCliente;
        private Label lblApellidoCliente;
        private Label lblDNICliente;
        private Label lblTelefonoCLiente;
        private Button btnAgregarCliente;
        private DataGridView dgvClientes;
    }
}
