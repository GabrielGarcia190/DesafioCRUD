using Dapper;
using DesafioCRUD.Domain.Entities;
using DesafioCRUD.Domain.Enums;
using DesafioCRUD.Domain.Filters;
using DesafioCRUD.Domain.Repositories;
using DesafioCRUD.Domain.Results;
using System.Data.SqlClient;
using System.Text;

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

        public ClienteCompletoResult? ObterClientePorId(Guid codigoCLiente)
        {
            var sql = new StringBuilder("SELECT c.*, g.Id AS Genero, ec.Id AS EstadoCivil FROM Cliente c INNER JOIN Genero g ON c.sexo = g.id INNER JOIN EstadoCivil ec ON ec.Id = c.Id_EstadoCivil");
            var parametros = new DynamicParameters();

            sql.Append(" WHERE Ativo = @Ativo");
            parametros.Add("Ativo", false);

            sql.Append(" AND CodigoCliente = @CodigoCliente");
            parametros.Add("CodigoCliente", codigoCLiente);

            using var conexao = new SqlConnection(_configuracoes.ConnectionString);

            return conexao.QueryFirstOrDefault<ClienteCompletoResult>(sql.ToString(), parametros);
        }

        public void CadastraCliente(Cliente cliente)
        {
            using (var conexao = new SqlConnection(_configuracoes.ConnectionString))
            {
                var sql = "INSERT INTO Cliente(CodigoCliente, NomeCliente, Telefone, DataNascimento, Sexo, Rua, Bairro, Cep, Cidade, Uf, id_EstadoCivil)VALUES(@CodigoCliente, @NomeCliente, @Telefone, @DataNascimento, @Sexo, @Rua, @Bairro, @Cep, @Cidade, @Uf, @IdEstadoCivil)";
                conexao.Execute(sql, cliente);
            }
        }

        public void AtualizarCadastroCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public List<ClienteCadastroResult> ObterClientesFitlrados(ClienteCadastroFilter filtro)
        {
            var sql = new StringBuilder("SELECT CodigoCliente, NomeCliente, DataNascimento, Cidade, UF FROM Cliente WHERE Ativo = 1");
            var parametros = new DynamicParameters();

            if (filtro.Tipo == ETipoFiltro.NOME)
            {
                sql.Append(" AND NomeCliente LIKE @Nome");
                parametros.Add("Nome", $"%{filtro.TextBuscar}%");
            }

            if (filtro.Tipo == ETipoFiltro.CIDADE)
            {
                sql.Append(" AND Cidade LIKE @Cidade");
                parametros.Add("Cidade", $"%{filtro.TextBuscar}%");
            }

            if (filtro.Tipo == ETipoFiltro.IDADE)
            {
                sql.Append(" AND DATEDIFF(YEAR, DataNascimento, GETDATE()) = @Idade");
                parametros.Add("Idade", filtro.TextBuscar);
            }

            using var conexao = new SqlConnection(_configuracoes.ConnectionString);

            return conexao.Query<ClienteCadastroResult>(sql.ToString(), parametros).ToList();
        }
    }
}
