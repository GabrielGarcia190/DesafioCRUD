using DesafioCRUD.Domain.Entities;
using DesafioCRUD.Domain.Filters;
using DesafioCRUD.Domain.Results;

namespace DesafioCRUD.Domain.Repositories
{
    public interface IClienteRepository
    {
        IEnumerable<ClienteCadastroResult> ObterClientes();
        List<ClienteCadastroResult> ObterClientesFitlrados(ClienteCadastroFilter filtro);
        ClienteCompletoResult? ObterClientePorId(Guid CodigoCliente);
        void DeletarCliente(Guid codigoCliente);
        void CadastraCliente(Cliente cliente);
        void AtualizarCadastroCliente(Cliente cliente);
    }
}
