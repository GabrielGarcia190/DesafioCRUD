using DesafioCRUD.Domain.Entities;
using DesafioCRUD.Domain.Results;

namespace DesafioCRUD.Domain.Repositories
{
    public interface IClienteRepository
    {
        IEnumerable<ClienteCadastroResult> ObterClientes();
        object ObterClientePorId(int idCliente);
        void DeletarCliente(Guid codigoCliente);
        void CadastraCliente(Cliente cliente);
        void AtualizarCadastroCliente(Cliente cliente);
    }
}
    