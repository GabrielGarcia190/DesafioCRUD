using DesafioCRUD.Model;
using DesafioCRUD.Repositories;
using System;
using System.Collections;

namespace DesafioCRUD.Controller
{
    public class ConsultaClienteController
    {
        public Cliente ConsultarCliente(int id_cliente)
        {
            var dados_cliente = new ConsultarClienteRepository().BuscarPorId(id_cliente);
            return dados_cliente;
        }



        public IEnumerable ConsultarClientePorNome(string nome)
        {
            var consultaCliente = new ConsultarClienteRepository().BuscarPorNome(nome);
            return consultaCliente;
        }
    }
}
