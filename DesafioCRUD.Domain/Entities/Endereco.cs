namespace DesafioCRUD.Domain.Entities
{
    public abstract class Endereco
    {
        protected Endereco(string rua, string bairro, decimal cep, string cidade, string estado, string uf)
        {
            Rua = rua;
            Bairro = bairro;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;
            UF = uf;
        }

        protected string Rua { get; set; }
        public string Bairro { get; set; }
        public decimal CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string UF { get; set; }
    }
}
