using CRUD2_0;
using Dapper;
using DesafioCRUD.DTO;
using System;

namespace DesafioCRUD.Repositories
{
    public class DesativarClienteRepository
    {
        public DadosRetornoDTO DesativarCliete(string id_cliente)
        {

            try
            {
                using (var conexao = ConexaoBanco.ObterConexao())
                {
                    string query = "UPDATE Cliente SET Ativo = 0 WHERE id_cliente = @Id";

                    conexao.Execute(query, new { Id = id_cliente });
                }

                return new DadosRetornoDTO { MensagemErro = "", Sucesso = true };
            }
            catch (Exception error)
            {

                throw new Exception($"Não foi possível desativar o cliente: {error.Message}");
            }

        }
    }
}
