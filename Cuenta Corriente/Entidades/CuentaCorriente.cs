using System.Collections.Generic;

namespace Entidades
{
    public class CuentaCorriente
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();
        public decimal Saldo { get; set; }
    }
}
