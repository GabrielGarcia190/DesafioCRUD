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
					string query = "INSERT INTO cliente (nome, sobrenome, idade, nomeRua, bairro, numero, CEP, id_genero) VALUES ('João', 'Silva', 30, 'Rua das Flores', 'Centro', '123', '12345-678', 2);";

					conexao.Execute(query);
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
