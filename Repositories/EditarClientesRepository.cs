using CRUD2_0;
using Dapper;
using DesafioCRUD.Model;
using System;

namespace DesafioCRUD.Repositories
{
    public class EditarClientesRepository
    {
        public bool AtualizarCadastro(Cliente cliente)
        {
            try
            {
                using (var conexao = ConexaoBanco.ObterConexao())
                {
                    string query = "UPDATE Cliente SET nome_Cliente = @nome, sobrenome = @sobrenome, dataNascimento = @dataNascimento, numTelefone = @numTelefone, Rua = @nomeRua, numero = @NumeroCasa, cep = @cep, Bairro = @bairro, Cidade = @cidade, UF= @uf, id_genero= @genero WHERE id_Cliente = @Id_cliente";

                    conexao.Execute(query, new { cliente.Nome, cliente.Sobrenome, cliente.DataNascimento, cliente.NumTelefone, cliente.NomeRua, cliente.NumeroCasa, cliente.Cep, cliente.Bairro, cliente.Cidade, cliente.Uf, genero = 1, cliente.Id_cliente });
                    return true;
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Não foi possível buscar o cliente \n Erro: {error.Message} ");
            }


        }
    }
}
