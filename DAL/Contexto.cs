using System.Data.Entity;
using EL;

namespace DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("name=miConexion")
        {
        }

        public DbSet<Producto> Productos { get; set; }
    }
}
