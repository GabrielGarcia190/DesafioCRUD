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

        public int Idade { get; set; }
        public string NomeRua { get; set; }
        public int Bairro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }


        public Cliente()
        {

        }

        public Cliente(string nome, string sobrenome, int idade, string nomeRua, int bairro, string numero, string cep)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            NomeRua = nomeRua;
            Bairro = bairro;
            Numero = numero;
            Cep = cep;
        }
    }


    

}
