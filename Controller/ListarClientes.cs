using CRUD2_0;
using Dapper;
using DesafioCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioCRUD.Controller
{
    public class ListarClientes
    {

        public IEnumerable<Cliente> Listar()
        {
            try
            {
                using (var conexao = ConexaoBanco.ObterConexao())
                {
                    string query = "\r\nSELECT C.*, g.nomeGenero AS 'Genero' FROM Cliente c INNER JOIN Genero g ON c.id_genero = g.id_genero WHERE nome_Cliente LIKE '%%'";
                    var respota = conexao.Query<Cliente>(query).ToList();


                    return respota;
                }


            }
            catch (Exception erro)
            {

                throw new Exception($"Ferrou  {erro.Message}");
            }
        }
    }
}
