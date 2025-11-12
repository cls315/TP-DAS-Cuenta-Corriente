using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public ICollection<CuentaCorriente> CuentaCorrientes { get; set; } = new List<CuentaCorriente>();

        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
}
