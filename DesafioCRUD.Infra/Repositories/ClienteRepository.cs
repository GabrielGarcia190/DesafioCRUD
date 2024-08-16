using Dapper;
using DesafioCRUD.Domain.Entities;
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

        public IEnumerable<ClienteCadastroResult> ObterClientes()
        {
            using var conexao = new SqlConnection(_configuracoes.ConnectionString);

            return conexao.Query<ClienteCadastroResult>("SELECT CodigoCliente, NomeCliente, DataNascimento, Cidade, UF FROM Cliente WHERE Ativo = 1").ToList();
        }

        public void DeletarCliente(Guid codigoCliente)
        {
            using (var conexao = new SqlConnection(_configuracoes.ConnectionString))
            {
                var sql = "DELETE Cliente WHERE CodigoCliente = @CodigoCliente";
                conexao.Execute(sql, new { CodigoCliente = codigoCliente });
            };

        }

        public object ObterClientePorId(int idCliente)
        {
            throw new NotImplementedException();
        }

        public void CadastraCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void AtualizarCadastroCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
