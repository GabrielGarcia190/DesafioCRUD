using CRUD2_0;
using Dapper;
using DesafioCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioCRUD.Repositories
{
    public class ListarClienteRepository
    {
        public IEnumerable<Cliente> ListarClientes()
        {
            try
            {
                using (var conexao = ConexaoBanco.ObterConexao())
                {
                    string query = "SELECT c.id_Cliente, C.nome_Cliente AS 'Nome',\r\n c.sobrenome, c.dataNascimento, c.numTelefone, c.Rua AS 'NomeRua', c.numero AS 'NumeroCasa', c.cep, c.Bairro, c.Cidade, c.UF ,g.nomeGenero AS 'Genero' FROM Cliente c INNER JOIN Genero g \r\nON c.id_genero = g.id_genero WHERE nome_Cliente LIKE '%%'";
                    return conexao.Query<Cliente>(query).ToList();
                }
            }
            catch (Exception erro)
            {
                throw new Exception($"Ferrou  {erro.Message}");
            }
        }
    }
}
