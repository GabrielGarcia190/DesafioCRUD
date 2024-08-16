using DesafioCRUD.Domain.Enums;

namespace DesafioCRUD.Domain.Entities
{
    public class Cliente : Endereco
    {
        public Cliente(string nomeCliente,
                       DateTime dataNascimento,
                       EGeneroCliente sexo,
                       string rua,
                       string bairro,
                       string numero,
                       string cep,
                       string cidade,
                       string uf,
                       EEstadoCivil estadoCivil,
                       string telefone)
            : base(rua, bairro, numero, cep, cidade, uf)
        {
            NomeCliente = nomeCliente;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            CodigoCliente = Guid.NewGuid();
            IdEstadoCivil = estadoCivil;
            Telefone = telefone;
        }

        public Guid CodigoCliente { get; private set; }
        public string NomeCliente { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public EGeneroCliente Sexo { get; private set; }
        public EEstadoCivil IdEstadoCivil { get; private set; }
        public string Telefone { get; private set; }
    }
}
