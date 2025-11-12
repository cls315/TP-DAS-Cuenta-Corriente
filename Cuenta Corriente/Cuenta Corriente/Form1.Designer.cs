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
            cmbClientes = new ComboBox();
            cmbCuentas = new ComboBox();
            btnCrearCuenta = new Button();
            btnRegistrarMov = new Button();
            txtMontoMov = new TextBox();
            txtDescMov = new TextBox();
            rbDebito = new RadioButton();
            rbCredito = new RadioButton();
            lblSeleccionCliente = new Label();
            lblSeleccionCuenta = new Label();
            lblMontoMovimiento = new Label();
            lblDescuentoMovimiento = new Label();
            lblTipoMovimiento = new Label();
            lblSaldoActual = new Label();
            dgvMovimientos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(171, 68);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(100, 23);
            txtNombreCliente.TabIndex = 0;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(171, 119);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(100, 23);
            txtApellidoCliente.TabIndex = 1;
            // 
            // txtDNICliente
            // 
            txtDNICliente.Location = new Point(171, 167);
            txtDNICliente.Name = "txtDNICliente";
            txtDNICliente.Size = new Size(100, 23);
            txtDNICliente.TabIndex = 2;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(171, 216);
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
            dgvClientes.Location = new Point(287, 12);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(209, 378);
            dgvClientes.TabIndex = 9;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(596, 61);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(121, 23);
            cmbClientes.TabIndex = 10;
            // 
            // cmbCuentas
            // 
            cmbCuentas.FormattingEnabled = true;
            cmbCuentas.Location = new Point(596, 125);
            cmbCuentas.Name = "cmbCuentas";
            cmbCuentas.Size = new Size(121, 23);
            cmbCuentas.TabIndex = 11;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Location = new Point(609, 164);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(99, 31);
            btnCrearCuenta.TabIndex = 12;
            btnCrearCuenta.Text = "Crear Cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarMov
            // 
            btnRegistrarMov.Location = new Point(812, 231);
            btnRegistrarMov.Name = "btnRegistrarMov";
            btnRegistrarMov.Size = new Size(133, 28);
            btnRegistrarMov.TabIndex = 13;
            btnRegistrarMov.Text = "Registrar Movimiento";
            btnRegistrarMov.UseVisualStyleBackColor = true;
            // 
            // txtMontoMov
            // 
            txtMontoMov.Location = new Point(836, 57);
            txtMontoMov.Name = "txtMontoMov";
            txtMontoMov.Size = new Size(100, 23);
            txtMontoMov.TabIndex = 14;
            // 
            // txtDescMov
            // 
            txtDescMov.Location = new Point(836, 122);
            txtDescMov.Name = "txtDescMov";
            txtDescMov.Size = new Size(100, 23);
            txtDescMov.TabIndex = 15;
            // 
            // rbDebito
            // 
            rbDebito.AutoSize = true;
            rbDebito.Location = new Point(812, 194);
            rbDebito.Name = "rbDebito";
            rbDebito.Size = new Size(60, 19);
            rbDebito.TabIndex = 16;
            rbDebito.TabStop = true;
            rbDebito.Text = "Debito";
            rbDebito.UseVisualStyleBackColor = true;
            // 
            // rbCredito
            // 
            rbCredito.AutoSize = true;
            rbCredito.Location = new Point(902, 194);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(64, 19);
            rbCredito.TabIndex = 17;
            rbCredito.TabStop = true;
            rbCredito.Text = "Credito";
            rbCredito.UseVisualStyleBackColor = true;
            // 
            // lblSeleccionCliente
            // 
            lblSeleccionCliente.AutoSize = true;
            lblSeleccionCliente.Location = new Point(530, 39);
            lblSeleccionCliente.Name = "lblSeleccionCliente";
            lblSeleccionCliente.Size = new Size(245, 15);
            lblSeleccionCliente.TabIndex = 18;
            lblSeleccionCliente.Text = "Seleccion de Cliente para Asociar una Cuenta";
            // 
            // lblSeleccionCuenta
            // 
            lblSeleccionCuenta.AutoSize = true;
            lblSeleccionCuenta.Location = new Point(530, 95);
            lblSeleccionCuenta.Name = "lblSeleccionCuenta";
            lblSeleccionCuenta.Size = new Size(262, 15);
            lblSeleccionCuenta.TabIndex = 19;
            lblSeleccionCuenta.Text = "Seleccion de Cuenta para Registrar Movimientos";
            // 
            // lblMontoMovimiento
            // 
            lblMontoMovimiento.AutoSize = true;
            lblMontoMovimiento.Location = new Point(825, 39);
            lblMontoMovimiento.Name = "lblMontoMovimiento";
            lblMontoMovimiento.Size = new Size(111, 15);
            lblMontoMovimiento.TabIndex = 20;
            lblMontoMovimiento.Text = "Monto Movimiento";
            // 
            // lblDescuentoMovimiento
            // 
            lblDescuentoMovimiento.AutoSize = true;
            lblDescuentoMovimiento.Location = new Point(822, 95);
            lblDescuentoMovimiento.Name = "lblDescuentoMovimiento";
            lblDescuentoMovimiento.Size = new Size(131, 15);
            lblDescuentoMovimiento.TabIndex = 21;
            lblDescuentoMovimiento.Text = "Descuento Movimiento";
            // 
            // lblTipoMovimiento
            // 
            lblTipoMovimiento.AutoSize = true;
            lblTipoMovimiento.Location = new Point(825, 164);
            lblTipoMovimiento.Name = "lblTipoMovimiento";
            lblTipoMovimiento.Size = new Size(114, 15);
            lblTipoMovimiento.TabIndex = 22;
            lblTipoMovimiento.Text = "Tipo de Movimiento";
            // 
            // lblSaldoActual
            // 
            lblSaldoActual.AutoSize = true;
            lblSaldoActual.Font = new Font("Segoe UI", 13F);
            lblSaldoActual.Location = new Point(588, 365);
            lblSaldoActual.Name = "lblSaldoActual";
            lblSaldoActual.Size = new Size(120, 25);
            lblSaldoActual.TabIndex = 23;
            lblSaldoActual.Text = "Saldo Actual: ";
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Location = new Point(986, 12);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.Size = new Size(240, 378);
            dgvMovimientos.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 462);
            Controls.Add(dgvMovimientos);
            Controls.Add(lblSaldoActual);
            Controls.Add(lblTipoMovimiento);
            Controls.Add(lblDescuentoMovimiento);
            Controls.Add(lblMontoMovimiento);
            Controls.Add(lblSeleccionCuenta);
            Controls.Add(lblSeleccionCliente);
            Controls.Add(rbCredito);
            Controls.Add(rbDebito);
            Controls.Add(txtDescMov);
            Controls.Add(txtMontoMov);
            Controls.Add(btnRegistrarMov);
            Controls.Add(btnCrearCuenta);
            Controls.Add(cmbCuentas);
            Controls.Add(cmbClientes);
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
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
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
        private ComboBox cmbClientes;
        private ComboBox cmbCuentas;
        private Button btnCrearCuenta;
        private Button btnRegistrarMov;
        private TextBox txtMontoMov;
        private TextBox txtDescMov;
        private RadioButton rbDebito;
        private RadioButton rbCredito;
        private Label lblSeleccionCliente;
        private Label lblSeleccionCuenta;
        private Label lblMontoMovimiento;
        private Label lblDescuentoMovimiento;
        private Label lblTipoMovimiento;
        private Label lblSaldoActual;
        private DataGridView dgvMovimientos;
    }
}
