using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCRUD.Model
{
    public class Cliente
    {
        public int Id_cliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public decimal Idade { get; set; }
        public string DataNascimento { get; set; }

        public string NumTelefone { get; set; }
        public string NomeRua { get; set; }
        public string NumeroCasa { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Genero { get; set; }


       

        public Cliente()
        {

        }
        public Cliente(string nome, string sobrenome, decimal idade, string dataNasc, string numTelefone, string nomeRua, string numeroCasa, string cep, string bairro, string cidade, string uf, string genero)
        {

            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
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
    }




}
