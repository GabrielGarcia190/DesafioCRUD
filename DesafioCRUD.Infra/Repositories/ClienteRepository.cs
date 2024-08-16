using Dapper;
using DesafioCRUD.Domain.Repositories;
using DesafioCRUD.Domain.Results;
using System.Data.SqlClient;

namespace DesafioCRUD.Infra.Repositories
{

    public class ClienteRepository : IClienteRepository
    {
        private readonly Configuracoes _configuracoes;

        public ClienteRepository(Configuracoes configuracoes)
        => _configuracoes = configuracoes;

        public object ConsultarCliente()
        {
            using var conexao = new SqlConnection(_configuracoes.ConnectionString);

            return conexao.Query<ClienteCadastroResult>("SELECT * FROM Cliente");
        }
    }
}
