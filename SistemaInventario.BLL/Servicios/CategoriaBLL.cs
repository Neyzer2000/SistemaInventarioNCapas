using System.Collections.Generic;
using SistemaInventario.EL;
using SistemaInventario.DAL.Repositorios;

namespace SistemaInventario.BLL.Servicios
{
    public class CategoriaBLL
    {
        private CategoriaDAL categoriaDAL = new CategoriaDAL();

        public List<Categoria> ObtenerTodos()
        {
            return categoriaDAL.ObtenerTodos();
        }

        public void Insertar(Categoria categoria)
        {
            categoriaDAL.Insertar(categoria);
        }

        public void Actualizar(Categoria categoria)
        {
            categoriaDAL.Actualizar(categoria);
        }

        public void Eliminar(int idCategoria)
        {
            categoriaDAL.Eliminar(idCategoria);
        }
    }
}
