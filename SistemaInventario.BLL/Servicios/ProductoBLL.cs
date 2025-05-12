using System.Collections.Generic;
using SistemaInventario.EL;
using SistemaInventario.DAL.Repositorios;

namespace SistemaInventario.BLL.Servicios
{
    public class ProductoBLL
    {
        private ProductoDAL productoDAL = new ProductoDAL();

        public List<Producto> ObtenerTodos()
        {
            return productoDAL.ObtenerTodos();
        }

        public void Insertar(Producto producto)
        {
            productoDAL.Insertar(producto);
        }

        public void Actualizar(Producto producto)
        {
            productoDAL.Actualizar(producto);
        }

        public void Eliminar(int idProducto)
        {
            productoDAL.Eliminar(idProducto);
        }
    }
}
