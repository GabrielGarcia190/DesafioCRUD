using CRUD2_0;
using Dapper;
using System;

namespace DesafioCRUD.Repositories
{
    public class ExcluirClienteRepository
    {
        public bool ExcluirCliente(string id_Cliente)
        {
            try
            {
                using (var conexao = ConexaoBanco.ObterConexao())
                {
                    string query = "DELETE cliente WHERE id_Cliente = @id_Cliente";

                    var respota = conexao.Execute(query, new { id_Cliente });
                }

                return true;
            }
            catch (Exception error)
            {
                throw new Exception($"Não foi possível remover o cliente \n Motivo: {error.Message}");
            }


        }
    }
}
