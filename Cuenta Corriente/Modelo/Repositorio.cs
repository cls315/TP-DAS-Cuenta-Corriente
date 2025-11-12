using CuentaCorriente.Entidades;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Entidades;

namespace CuentaCorriente.Persistencia
{
    public class Repositorio
    {
        private readonly CuentaCorrienteContext _context;

        public Repositorio()
        {
            _context = new CuentaCorrienteContext();
        }

        public IReadOnlyCollection<Movimiento> ListarMovimientos(int cuentaId)
        {
            return _context.Movimientos
                .Where(m => m.CuentaCorrienteId == cuentaId)
                .OrderByDescending(m => m.Fecha)
                .ToList().AsReadOnly();
        }

        public void AgregarMovimiento(Movimiento movimiento)
        {
            _context.Movimientos.Add(movimiento);
            _context.SaveChanges();
        }

        public IReadOnlyCollection<Cliente> ListarClientes()
        {
            return _context.Clientes.Include(c => c.CuentaCorrientes).ToList().AsReadOnly();
        }

        public void AgregarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public Cliente ObtenerClientePorId(int id)
        {
            return _context.Clientes.Find(id);
        }

        public void ModificarCliente(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        public void EliminarCliente(Cliente cliente)
        {
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }

        public void AgregarCuenta(CuentaCorriente cuenta)
        {
            _context.CuentasCorrientes.Add(cuenta);
            _context.SaveChanges();
        }

        public CuentaCorriente ObtenerCuentaPorId(int id)
        {
            return _context.CuentasCorrientes
                .Include(cc => cc.Movimientos)
                .FirstOrDefault(cc => cc.Id == id);
        }
    }
}
