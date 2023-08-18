using CRUD2_0;
using Dapper;
using DesafioCRUD.Model;
using System.Collections;
using System.Linq;

namespace DesafioCRUD.Repositories
{
    public class ConsultaporIdRepository
    {

        public Cliente BuscarPorId(int id_cliente)
        {
            using (var conexao = ConexaoBanco.ObterConexao())
            {
               string query = "SELECT c.id_Cliente, C.nome_Cliente AS 'Nome', c.sobrenome, c.idade, c.dataNascimento, c.numTelefone, c.Rua AS 'NomeRua', c.numero AS 'NumeroCasa', c.cep, c.Bairro, c.Cidade, c.UF ,g.nomeGenero AS 'Genero' FROM Cliente c INNER JOIN Genero g ON c.id_genero = g.id_genero WHERE id_cliente = @Id";

               var respota = conexao.QueryFirstOrDefault<Cliente>(query, new { Id = id_cliente });


                return respota;
            }
        }
    }
}
