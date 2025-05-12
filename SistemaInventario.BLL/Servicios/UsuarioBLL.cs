using System.Collections.Generic;
using SistemaInventario.EL;
using SistemaInventario.DAL.Repositorios;

namespace SistemaInventario.BLL.Servicios
{
    public class UsuarioBLL
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();

        public List<Usuario> ObtenerTodos()
        {
            return usuarioDAL.ObtenerTodos();
        }

        public void Insertar(Usuario usuario)
        {
            usuarioDAL.Insertar(usuario);
        }

        public void Actualizar(Usuario usuario)
        {
            usuarioDAL.Actualizar(usuario);
        }

        public void Eliminar(int idUsuario)
        {
            usuarioDAL.Eliminar(idUsuario);
        }
    }
}
