using Microsoft.EntityFrameworkCore;
using Cuenta_Corriente.Modelo;
using Entidades;

namespace Cuenta_Corriente
{
    public partial class CuentaCorrienteContext : DbContext
    {
        public CuentaCorrienteContext()
        {
        }

        public CuentaCorrienteContext(DbContextOptions<CuentaCorrienteContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaCorriente> CuentasCorrientes { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.CuentaCorrientes)
                .WithOne(cc => cc.Cliente)
                .HasForeignKey(cc => cc.ClienteId);

            modelBuilder.Entity<CuentaCorriente>()
                .HasMany(cc => cc.Movimientos)
                .WithOne(m => m.CuentaCorriente)
                .HasForeignKey(m => m.CuentaCorrienteId);

            modelBuilder.Entity<Cliente>()
                .HasIndex(c => c.DNI)
                .IsUnique();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
