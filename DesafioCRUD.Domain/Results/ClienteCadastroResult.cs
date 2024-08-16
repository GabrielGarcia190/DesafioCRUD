using DesafioCRUD.Domain.Enums;

namespace DesafioCRUD.Domain.Results
{
    public class ClienteCadastroResult
    {
        public string? IdCliente { get; set; }
        public string? NomeCliente { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade
        {
            get => DataNascimento.Year - DateTime.Today.Year;
        }

        public EGeneroCliente Sexo { get; private set; }
    }
}
