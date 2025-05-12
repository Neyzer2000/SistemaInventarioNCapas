using System.Data.Entity;

public class MiDbContext : DbContext
{
    public DbSet<Producto> Productos { get; set; }

    public MiDbContext() : base("miConexion")
    {
    }
}
