using Licores.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

public class BodegaDbContext : DbContext
{
    public BodegaDbContext(DbContextOptions<BodegaDbContext> options)
        : base(options)
    {
    }

    public DbSet<ProductoModel> Productos { get; set; }
    //public DbSet<PedidoModel> Pedidos { get; set; }
    //public DbSet<UsuarioModel> Usuarios { get; set; }
    //public DbSet<ProveedorModel> Proveedores { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("InMemoryDatabaseName"); // Nombre de la base de datos en memoria
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Aquí puedes configurar relaciones y restricciones si es necesario.
        //// Por ejemplo, configurar la relación entre PedidoModel y ProveedorModel.
        //modelBuilder.Entity<PedidoModel>()
        //    .HasOne(p => p.Proveedor)
        //    .WithMany(proveedor => proveedor.Pedidos)
        //    .HasForeignKey(p => p.ProveedorId)
        //    .OnDelete(DeleteBehavior.Restrict); // Puedes configurar la acción de eliminación según tus necesidades.
    }
}
