using DesafioCRUD.Domain.Repositories;
using DesafioCRUD.Domain.Results;
using System.ComponentModel;

namespace DesafioCRUD.App.Services
{
    public class ClienteAppService
    {
        private readonly IClienteRepository _repository;

        public ClienteAppService(IClienteRepository repository)
            => _repository = repository;

        public BindingList<ClienteCadastroResult> ObterClientes()
            => new BindingList<ClienteCadastroResult>(_repository.ObterClientes().ToList());

        public ResultadoOperacao EliminarCliente(Guid codigoCliente)
        {
            try
            {
                _repository.DeletarCliente(codigoCliente);

                return new ResultadoOperacao(mensagem: "Cliente deletado com sucesso.", sucesso: true);
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao(mensagem: ex.Message, sucesso: false);
            }
        }
    }
}