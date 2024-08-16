using DesafioCRUD.Domain.Enums;

namespace DesafioCRUD.Domain.Results
{
    public class ClienteCadastroResult
    {
        public Guid? CodigoCliente { get; set; }
        public string? NomeCliente { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade
        {
            get => DateTime.Today.Year - DataNascimento.Year;
        }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
    }
}
