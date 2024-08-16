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
                       decimal cep,
                       string cidade,
                       string estado,
                       string uf) 
            : base(rua, bairro, cep, cidade, estado, uf)
        {
            NomeCliente = nomeCliente;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            CodigoCliente = Guid.NewGuid();
        }

        public Guid CodigoCliente { get; private set; }
        public string NomeCliente { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public EGeneroCliente Sexo { get; private set; }
    }
}
