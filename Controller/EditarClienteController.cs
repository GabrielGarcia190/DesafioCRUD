using DesafioCRUD.Model;
using DesafioCRUD.Repositories;

namespace DesafioCRUD.Controller
{
    public class EditarClienteController
    {
        public bool EditarCliente(Cliente cliente)
        {

            var sucesso = new EditarClientesRepository().AtualizarCadastro(cliente);


            if (sucesso)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
