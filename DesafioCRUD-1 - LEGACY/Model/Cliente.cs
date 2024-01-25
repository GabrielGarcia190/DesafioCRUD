using System;

namespace DesafioCRUD.Model
{
    public class Cliente
    {
        public string Id_cliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NumTelefone { get; set; }
        public string NomeRua { get; set; }
        public string NumeroCasa { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Genero { get; set; }
        public int Idade
        {
            get
            {
                var dataAtual = DateTime.Now;
                int idade = dataAtual.Year - DataNascimento.Year;

                if (dataAtual.Month < DataNascimento.Month || (dataAtual.Month == DataNascimento.Month && dataAtual.Day < DataNascimento.Day))
                {
                    idade--;
                }
                return idade;
            }
            set { }
        }

        public Cliente() { }
        public Cliente(string nome, string sobrenome, DateTime dataNasc, string numTelefone, string nomeRua, string numeroCasa, string cep, string bairro, string cidade, string uf, string genero)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNasc;
            NumTelefone = numTelefone;
            NomeRua = nomeRua;
            NumeroCasa = numeroCasa;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Genero = genero;
        }

        public Cliente(string id, string nome, string sobrenome, DateTime dataNascimento, string numTelefone, string nomeRua, string numeroCasa, string cep, string bairro, string cidade, string uf, string genero)
        {
            Id_cliente = id;
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            NumTelefone = numTelefone;
            NomeRua = nomeRua;
            NumeroCasa = numeroCasa;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Genero = genero;
        }
    }




}
