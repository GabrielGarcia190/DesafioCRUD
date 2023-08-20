using CRUD2_0;
using Dapper;
using DesafioCRUD.Model;
using System;

namespace DesafioCRUD.Repositories
{
    public class CadastrarClienteRepository
    {
        public bool CadastrarCliente(Cliente cliente)
        {
            try
            {
                using (var conexao = ConexaoBanco.ObterConexao())
                {
                    string query = "INSERT INTO Cliente (nome_Cliente, sobrenome, dataNascimento, numTelefone, Rua, numero, cep, Bairro, Cidade, UF, id_genero) VALUES (@nome, @sobrenome, @DataNascimento, @numTelefone, @nomeRua, @NumeroCasa, @cep, @bairro, @cidade, @UF, @genero);";
                    conexao.Execute(query, new Cliente(cliente.Nome, cliente.Sobrenome, cliente.DataNascimento, cliente.NumTelefone, cliente.NomeRua, cliente.NumeroCasa, cliente.Cep, cliente.Bairro, cliente.Cidade, cliente.Uf, "2"));
                    return true;
                }
            }
            catch (Exception error)
            {

                throw new Exception($"Não foi possível cadatrar o cliente \n Erro: {error.Message} ");
            }
        }
    }
}
