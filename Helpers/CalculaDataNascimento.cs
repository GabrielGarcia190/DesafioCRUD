using System;

namespace DesafioCRUD.Helpers
{
    public class CalculaDataNascimento
    {
        public  DateTime CalcularDataNascimentoMinima(int idadeMinima)
        {
            DateTime dataAtual = DateTime.Today;
            DateTime dataNascimentoMinima = dataAtual.AddYears(-idadeMinima);

            return dataNascimentoMinima;
        }
    }
}
