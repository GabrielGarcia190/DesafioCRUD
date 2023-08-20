using DesafioCRUD.Helpers;
using DesafioCRUD.Model;
using DesafioCRUD.Repositories;
using System.Collections;

namespace DesafioCRUD.Controller
{
    public class ConsultarClienteController
    {
        public Cliente ConsultarCliente(int id_cliente)
        {
            return new ConsultarClienteRepository().BuscarPorId(id_cliente);
        }
        public IEnumerable ConsultarClientePorNome(string nome)
        {
            return new ConsultarClienteRepository().BuscarPorNome(nome);
        }
        public IEnumerable ConsultarClientePorIdade(int idade)
        {
            var datanascimento = new CalculaDataNascimento().CalcularDataNascimentoMinima(idade);

            return new ConsultarClienteRepository().BuscarPorDataNascimento(datanascimento);
        }
        public IEnumerable ConsultarClientePorTelefone(string numTelefone)
        {
            return new ConsultarClienteRepository().BuscarPorTelefone(numTelefone);
        }
        public IEnumerable ConsultarClientePorCidade(string cidade)
        {
            return new ConsultarClienteRepository().BuscarPorCidade(cidade);
        }
        public IEnumerable ConsultarClientePorGenero(string genero)
        {
            return new ConsultarClienteRepository().BuscarPorGenero(genero);
        }
    }
}
