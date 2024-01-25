using DesafioCRUD.Model;
using DesafioCRUD.Repositories;

namespace DesafioCRUD.Controller
{
    public class EditarClienteController
    {
        public bool EditarCliente(Cliente cliente)
        {
            return new EditarClientesRepository().AtualizarCadastro(cliente);

        }

    }
}
