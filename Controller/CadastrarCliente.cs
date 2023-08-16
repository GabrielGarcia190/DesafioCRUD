using CRUD2_0;
using Dapper;
using DesafioCRUD.Model;
using System;

namespace DesafioCRUD.Controller
{
    public class CadastrarCliente
    {

        public bool Cadastrar(Cliente cliente) {

			try
			{
				using ( var conexao = ConexaoBanco.ObterConexao())
				{
					string query = "INSERT INTO Cliente (nome_Cliente, sobrenome, idade, dataNascimento, numTelefone, Rua, numero, cep, Bairro, Cidade, UF, id_genero) VALUES (@nome, @sobrenome, @idade, @DataNascimento, @numTelefone, @nomeRua, @NumeroCasa, @cep, @bairro, @cidade, @UF, @genero);";

					conexao.Execute(query, new Cliente(cliente.Nome, cliente.Sobrenome, cliente.Idade, cliente.DataNascimento, cliente.NumTelefone, cliente.NomeRua, cliente.NumeroCasa, cliente.Cep, cliente.Bairro, cliente.Cidade, cliente.Uf, "2"));
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
