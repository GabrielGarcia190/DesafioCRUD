using DesafioCRUD.Domain.Enums;

namespace DesafioCRUD.Domain.Results
{
    public class ClienteCompletoResult
    {
        public string? NomeCliente { get; set; }

        public DateTime DataNascimento { get; set; }
        public EGeneroCliente Genero { get; set; }
        public string? Rua { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? CEP { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
        public bool Ativo { get; set; }
        public string? Telefone { get; set; }
        public EEstadoCivil EstadoCivil { get; set; }
        public int Idade => DateTime.Now.Year - DataNascimento.Year;
    }
}