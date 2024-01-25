using DesafioCRUD.Model;
using DesafioCRUD.Repositories;

namespace DesafioCRUD.Controller
{
    public class CadastrarClienteControoller
    {
        public bool CadastrarCliente(Cliente cliente)
        {
            var respota = new CadastrarClienteRepository().CadastrarCliente(cliente);

            return respota;

        }
    }
}
