using CuentaCorriente.Entidades;
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

            repositorio.AgregarCliente(cliente);
            return "Cliente registrado";
        }

        public string RegistrarMovimiento(int cuentaId, decimal monto, TipoMovimiento tipo, string descripcion)
        {
            if (monto <= 0)
            {
                return "El monto debe ser un valor positivo.";
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
    }
}
