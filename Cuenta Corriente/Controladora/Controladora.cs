using CuentaCorriente.Persistencia;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CuentaCorriente.Negocio
{
    public class CuentaCorrienteManager
    {
        private Repositorio repositorio = new Repositorio();
        private static CuentaCorrienteManager instancia;
        public static CuentaCorrienteManager Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return instancia = new CuentaCorrienteManager();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Cliente> ListarClientes()
        {
            return repositorio.ListarClientes();
        }

        public string AgregarCliente(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.DNI))
            {
                return "Nombre y DNI son campos obligatorios.";
            }

            var existentes = ListarClientes();
            if (existentes.Any(c => c.DNI == cliente.DNI))
            {
                return "Ya existe un cliente con ese DNI";
            }

            repositorio.AgregarCliente(cliente);
            return "Cliente registrado";
        }

        public string ModificarCliente(Cliente cliente)
        {
            if (cliente == null) return "Cliente invalido.";
            repositorio.ModificarCliente(cliente);
            return "Cliente modificado";
        }

        public string EliminarCliente(int clienteId)
        {
            var c = repositorio.ObtenerClientePorId(clienteId);
            if (c == null) return "Cliente no encontrado";
            repositorio.EliminarCliente(c);
            return "Cliente eliminado";
        }

        public string CrearCuentaCorriente(int clienteId)
        {
            var cliente = repositorio.ObtenerClientePorId(clienteId);
            if (cliente == null) return "Cliente no encontrado";

            var cuenta = new CuentaCorriente
            {
                ClienteId = clienteId
            };

            repositorio.AgregarCuenta(cuenta);
            return $"Cuenta corriente creada para {cliente.NombreCompleto} (Id: {cuenta.Id})";
        }

        public IReadOnlyCollection<CuentaCorriente> ListarCuentasPorClienteId(int clienteId)
        {
            return repositorio.ListarCuentasPorClienteId(clienteId);
        }

        public IReadOnlyCollection<CuentaCorriente> ListarTodasLasCuentas()
        {
            return repositorio.ListarTodasLasCuentas();
        }

        public string RegistrarMovimiento(int cuentaId, decimal monto, TipoMovimiento tipo, string descripcion)
        {
            if (monto <= 0)
            {
                return "El monto debe ser un valor positivo.";
            }

            var cuenta = repositorio.ObtenerCuentaPorId(cuentaId);
            if (cuenta == null)
            {
                return "Cuenta no encontrada.";
            }

            var movimiento = new Movimiento
            {
                CuentaCorrienteId = cuentaId,
                Monto = monto,
                Tipo = tipo,
                Descripcion = descripcion,
                Fecha = DateTime.Now
            };

            repositorio.AgregarMovimiento(movimiento);
            return $"Movimiento de {tipo.ToString()} registrado";
        }
        public decimal CalcularSaldo(int cuentaId)
        {
            var movimientos = repositorio.ListarMovimientos(cuentaId);

            decimal totalCreditos = movimientos.Where(m => m.Tipo == TipoMovimiento.Credito).Sum(m => m.Monto);
            decimal totalDebitos = movimientos.Where(m => m.Tipo == TipoMovimiento.Debito).Sum(m => m.Monto);

            return totalCreditos - totalDebitos;
        }

        public IReadOnlyCollection<Movimiento> ObtenerHistorial(int cuentaId)
        {
            return repositorio.ListarMovimientos(cuentaId);
        }

        public (decimal totalDebitos,decimal totalCreditos, decimal saldo) ResumenCuenta(int cuentaId)
        {
            var movimientos = repositorio.ListarMovimientos(cuentaId);
            decimal totalCreditos = movimientos.Where(m => m.Tipo == TipoMovimiento.Credito).Sum(m => m.Monto);
            decimal totalDebitos = movimientos.Where(m => m.Tipo == TipoMovimiento.Debito).Sum(m => m.Monto);
            decimal saldo = totalCreditos - totalDebitos;
            return (totalDebitos, totalCreditos, saldo);
        }
    }
}
