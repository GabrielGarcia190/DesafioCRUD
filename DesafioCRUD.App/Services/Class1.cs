using DesafioCRUD.Domain.Repositories;

namespace DesafioCRUD.App.Services
{
    public class ClienteAppService
    {
        private readonly IClienteRepository _repository;

        public ClienteAppService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public object ObterClientes()
            => _repository.ConsultarCliente();
    }
}