using DesafioCRUD.Model;
using DesafioCRUD.Repositories;
using System.Collections.Generic;

namespace DesafioCRUD.Controller
{
    public class ListarClientesController
    {
        public IEnumerable<Cliente> ListarClientes()
        {
            return new ListarClienteRepository().ListarClientes(); 
        }
    }
}
