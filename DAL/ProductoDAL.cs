using System.Collections.Generic;
using System.Linq;

public class ProductoDAL
{
    private MiDbContext _context = new MiDbContext();

    public void Insertar(Producto producto)
    {
        _context.Productos.Add(producto);
        _context.SaveChanges();
    }

    public List<Producto> ObtenerTodos()
    {
        return _context.Productos.ToList();
    }

    public void Actualizar(Producto producto)
    {
        _context.Entry(producto).State = System.Data.Entity.EntityState.Modified;
        _context.SaveChanges();
    }

    public void Eliminar(int id)
    {
        var producto = _context.Productos.Find(id);
        if (producto != null)
        {
            _context.Productos.Remove(producto);
            _context.SaveChanges();
        }
    }
}
