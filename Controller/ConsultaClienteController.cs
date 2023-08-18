using DesafioCRUD.Model;
using DesafioCRUD.Repositories;

namespace DesafioCRUD.Controller
{
    public class ConsultaClienteController
    {
        public Cliente ConsultarCliente(int id_cliente)
        {
            var dados_cliente = new ConsultaporIdRepository().BuscarPorId(id_cliente);

            return dados_cliente;
;        }
    }
}
