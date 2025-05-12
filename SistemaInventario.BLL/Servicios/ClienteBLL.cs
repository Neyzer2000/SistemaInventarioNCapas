using System.Collections.Generic;
using SistemaInventario.EL;
using SistemaInventario.DAL.Repositorios;

namespace SistemaInventario.BLL.Servicios
{
    public class ClienteBLL
    {
        private ClienteDAL clienteDAL = new ClienteDAL();

        public List<Cliente> ObtenerTodos()
        {
            return clienteDAL.ObtenerTodos();
        }

        public void Insertar(Cliente cliente)
        {
            clienteDAL.Insertar(cliente);
        }

        public void Actualizar(Cliente cliente)
        {
            clienteDAL.Actualizar(cliente);
        }

        public void Eliminar(int idCliente)
        {
            clienteDAL.Eliminar(idCliente);
        }
    }
}
