using System;
using System.Linq;
using System.Windows.Forms;
using CuentaCorriente.Negocio;
using Entidades;

namespace CuentaCorriente.App
{     
        public partial class Form1 : Form
        {
            private readonly CuentaCorrienteManager _manager = CuentaCorrienteManager.Instancia;

            public Form1()
            {
                InitializeComponent();
                CargarClientes();
            }
            private void CargarClientes()
            {
                var clientes = _manager.ListarClientes().ToList();
                dgvClientes.DataSource = clientes;

                cmbClientes.DataSource = clientes;
                cmbClientes.DisplayMember = "NombreCompleto"; 
                cmbClientes.ValueMember = "Id";
            }

            private void btnGuardarCliente_Click(object sender, EventArgs e)
            {
                var nuevoCliente = new Cliente
                {
                    Nombre = txtNombreCliente.Text.Trim(),
                    Apellido = txtApellidoCliente.Text.Trim(),
                    DNI = txtDNICliente.Text.Trim(),
                    Telefono = txtTelefonoCliente.Text.Trim()
                };

                try
                {
                    string resultado = _manager.AgregarCliente(nuevoCliente);
                    MessageBox.Show(resultado);

                    CargarClientes(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar cliente: " + ex.Message);
                }
            }

            private void btnCrearCuenta_Click(object sender, EventArgs e)
            {
                if (cmbClientes.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un cliente para crear la cuenta.");
                    return;
                }

                int clienteId = (int)cmbClientes.SelectedValue;

                try
                {
                    string resultado = _manager.CrearCuentaCorriente(clienteId);
                    MessageBox.Show(resultado);

                    CargarCuentas(clienteId); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear la cuenta: " + ex.Message);
                }
            }

            private void CargarCuentas(int clienteId)
            {
                var cuentas = _manager.ListarCuentasPorClienteId(clienteId).ToList();

                cmbCuentas.DataSource = cuentas;
                cmbCuentas.DisplayMember = "Id"; 
                cmbCuentas.ValueMember = "Id";
            }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedValue is int clienteId)
            {
                CargarCuentas(clienteId);
                dgvMovimientos.DataSource = null;
                lblSaldoActual.Text = "Saldo Actual: -";
            }
        }

        private void cmbCuentas_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cmbCuentas.SelectedValue is int cuentaId)
                {
                    MostrarEstadoDeCuenta(cuentaId);
                }
            }

            private void btnRegistrarMov_Click(object sender, EventArgs e)
            {
                if (cmbCuentas.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar una cuenta.");
                    return;
                }

                int cuentaId = (int)cmbCuentas.SelectedValue;

                if (!decimal.TryParse(txtMontoMov.Text, out decimal monto))
                {
                    MessageBox.Show("Ingrese un monto válido.");
                    return;
                }

                TipoMovimiento tipo;
                if (rbCredito.Checked)
                {
                    tipo = TipoMovimiento.Credito;
                }
                else if (rbDebito.Checked)
                {
                    tipo = TipoMovimiento.Debito;
                }
                else
                {
                    MessageBox.Show("Seleccione Débito o Crédito.");
                    return;
                }

                try
                {
                    string resultado = _manager.RegistrarMovimiento(
                        cuentaId,
                        monto,
                        tipo,
                        txtDescMov.Text
                    );

                    MessageBox.Show(resultado);

                    MostrarEstadoDeCuenta(cuentaId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar movimiento: " + ex.Message);
                }
            }

            private void MostrarEstadoDeCuenta(int cuentaId)
            {
                var historial = _manager.ObtenerHistorial(cuentaId);
                dgvMovimientos.DataSource = historial.ToList();

                decimal saldo = _manager.CalcularSaldo(cuentaId);
                lblSaldoActual.Text = $"Saldo Actual: {saldo.ToString("C")}";

                if (saldo > 0)
                    lblSaldoActual.ForeColor = Color.Green;
                else if (saldo < 0)
                    lblSaldoActual.ForeColor = Color.Red;
                else
                    lblSaldoActual.ForeColor = Color.Black;
            }
        }
    }
}
    

