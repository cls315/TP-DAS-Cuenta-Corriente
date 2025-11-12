using Microsoft.EntityFrameworkCore;
using Entidades;

namespace CuentaCorriente.Persistencia
{
    public class CuentaCorrienteContext : DbContext
    {
        public CuentaCorrienteContext() { }

        public CuentaCorrienteContext(DbContextOptions<CuentaCorrienteContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaCorriente> CuentasCorrientes { get; set; }
        public DbSet<Movimiento> Movimientos { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=CuentaCorriente;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.CuentaCorrientes)
                .WithOne(cc => cc.Cliente)
                .HasForeignKey(cc => cc.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CuentaCorriente>()
                .HasMany(cc => cc.Movimientos)
                .WithOne(m => m.CuentaCorriente)
                .HasForeignKey(m => m.CuentaCorrienteId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Cliente>()
                .HasIndex(c => c.DNI)
                .IsUnique()
                .HasDatabaseName("IX_Cliente_DNI");
        }
    }
}
