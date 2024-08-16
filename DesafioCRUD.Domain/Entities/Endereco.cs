namespace DesafioCRUD.Domain.Entities
{
    public class Endereco
    {
        public Endereco(string rua, string bairro, string numero, string cep, string cidade, string uf)
        {
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
        }

        public string Rua { get; private set; }
        public string Bairro { get; private set; }
        public string Numero { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Uf { get; private set; }
    }
}
