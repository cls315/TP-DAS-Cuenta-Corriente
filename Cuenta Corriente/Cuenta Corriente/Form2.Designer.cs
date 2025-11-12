namespace Cuenta_Corriente
{
    partial class Form2
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
            cmbClientes = new ComboBox();
            button1 = new Button();
            cmbCuentas = new ComboBox();
            txtMontoMov = new TextBox();
            txtDescMov = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(352, 115);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(147, 23);
            cmbClientes.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(352, 169);
            button1.Name = "button1";
            button1.Size = new Size(109, 32);
            button1.TabIndex = 1;
            button1.Text = "Crear Cuenta";
            button1.UseVisualStyleBackColor = true;
            // 
            // cmbCuentas
            // 
            cmbCuentas.FormattingEnabled = true;
            cmbCuentas.Location = new Point(362, 224);
            cmbCuentas.Name = "cmbCuentas";
            cmbCuentas.Size = new Size(121, 23);
            cmbCuentas.TabIndex = 2;
            // 
            // txtMontoMov
            // 
            txtMontoMov.Location = new Point(113, 92);
            txtMontoMov.Name = "txtMontoMov";
            txtMontoMov.Size = new Size(100, 23);
            txtMontoMov.TabIndex = 3;
            // 
            // txtDescMov
            // 
            txtDescMov.Location = new Point(100, 163);
            txtDescMov.Name = "txtDescMov";
            txtDescMov.Size = new Size(100, 23);
            txtDescMov.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(557, 139);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtDescMov);
            Controls.Add(txtMontoMov);
            Controls.Add(cmbCuentas);
            Controls.Add(button1);
            Controls.Add(cmbClientes);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbClientes;
        private Button button1;
        private ComboBox cmbCuentas;
        private TextBox txtMontoMov;
        private TextBox txtDescMov;
        private Label label1;
    }
}