using System.Data.Entity;
using SistemaInventario.EL;

namespace SistemaInventario.DAL.Contexto
{
    public class InventarioDbContext : DbContext
    {
        // Constructor: indica el nombre de la cadena de conexión
        public InventarioDbContext() : base("name=MiConexion") { }

        // DbSets: representan las tablas
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
