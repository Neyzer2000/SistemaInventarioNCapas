using DAL;
using System.Collections.Generic;

public class ProductoBLL
{
    private ProductoDAL dal = new ProductoDAL();

    public void Insertar(Producto producto)
    {
        // Validaciones si necesitas
        dal.Insertar(producto);
    }

    public List<Producto> ObtenerTodos()
    {
        return dal.ObtenerTodos();
    }

    public void Actualizar(Producto producto)
    {
        dal.Actualizar(producto);
    }

    public void Eliminar(int id)
    {
        dal.Eliminar(id);
    }
}
