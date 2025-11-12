using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaCorriente
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();
        public decimal Saldo { get; set; }
        public CuentaCorriente()
        {
            Movimientos = new List<Movimiento>();
        }
    }
}
