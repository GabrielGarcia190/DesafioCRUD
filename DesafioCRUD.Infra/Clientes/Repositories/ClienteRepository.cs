using Dapper;
using DesafioCRUD.Domain.Cliente.Repositories;
using System.Data.SqlClient;

namespace DesafioCRUD.Infra.Clientes.Repositories
{

    public class ClienteRepository : IClienteRepository
    {
        private readonly Configuracoes _configuracoes;

        public ClienteRepository(Configuracoes configuracoes)
        => _configuracoes = configuracoes;

        public object ConsultarCliente()
        {
            using var conexao = new SqlConnection(_configuracoes.ConnectionString);

            return conexao.Query<object>("SELECT * FROM Cliente");
        }
    }
}
