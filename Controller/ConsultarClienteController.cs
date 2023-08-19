using DesafioCRUD.Helpers;
using DesafioCRUD.Model;
using DesafioCRUD.Repositories;
using System;
using System.Collections;

namespace DesafioCRUD.Controller
{
    public class ConsultarClienteController
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

        public IEnumerable ConsultarClientePorIdade(int idade)
        {
            var datanascimento = new CalculaDataNascimento().CalcularDataNascimentoMinima(idade);

            var consultarCliente = new ConsultarClienteRepository().BuscarPorDataNascimento(datanascimento);
            return consultarCliente;
        }
        public IEnumerable ConsultarClientePorTelefone(string numTelefone)
        {
            var consultarCliente = new ConsultarClienteRepository().BuscarPorTelefone(numTelefone);
            return consultarCliente;
        }
        public IEnumerable ConsultarClientePorCidade(string cidade)
        {
            var consultarCliente = new ConsultarClienteRepository().BuscarPorCidade(cidade);
            return consultarCliente;
        }

        public IEnumerable ConsultarClientePorGenero(string genero)
        {
            var consultarCliente = new ConsultarClienteRepository().BuscarPorGenero(genero);
            return consultarCliente;
        }
    }
}
