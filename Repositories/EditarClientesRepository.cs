using CRUD2_0;
using Dapper;
using DesafioCRUD.Model;
using System;

namespace DesafioCRUD.Repositories
{
    public class EditarClientesRepository
    {

        public string Cadstrar(Cliente cliente)
        {
            try
            {
                using (var conexao = ConexaoBanco.ObterConexao())
                {
                    string query = "UPDATE Cliente SET nome_Cliente = @nomeCliente, sobrenome = @sobrenome, dataNascimento = @dataNascimento, numTelefone = @numTelefone, Rua = @nomeRua, numero = @NumeroCasa, cep = @cep, Bairro = @bairro, Cidade = @cidade, UF= @uf, id_genero= @id_genero WHERE id_Cliente = @Id";

                    conexao.Execute(query, new Cliente(cliente.Nome, cliente.Sobrenome, cliente.Idade, cliente.DataNascimento, cliente.NumTelefone, cliente.NomeRua, cliente.NumeroCasa, cliente.Cep, cliente.Bairro, cliente.Cidade, cliente.Uf, "2"));
                    return "sucesso";
                }
            }
            catch (Exception error)
            {

                throw new Exception($"Não foi possível buscar o cliente \n Erro: {error.Message} ");
            }


        }
    }
}
