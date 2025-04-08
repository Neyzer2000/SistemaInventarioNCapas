using System.Runtime.Remoting.Contexts;
using DAL;
using EL;

namespace BLL
{
    public class ProductoBLL
    {
        public void Insertar(Producto producto)
        {
            using (var db = new Contexto())
            {
                db.Productos.Add(producto);
                db.SaveChanges();
            }
        }
    }
}
