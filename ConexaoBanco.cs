using System.Data;
using System.Data.SqlClient;

namespace CRUD2_0
{
    public static class ConexaoBanco
    {

        private static IDbConnection _conexao;

        public static IDbConnection ObterConexao()
        {
            _conexao = new SqlConnection("Data Source=GARCIA-DELLG15\\SQLEXPRESS;Initial Catalog=DesafioCRUD;Integrated Security=True");

            return _conexao;
        }
    }
}
