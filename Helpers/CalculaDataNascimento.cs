using System;

namespace DesafioCRUD.Helpers
{
    public class CalculaDataNascimento
    {
        public static DateTime CalcularDataNascimentoMinima(int idadeMinima)
        {
            //DateTime dataAtual = DateTime.Today;
            DateTime dataAtual = new DateTime (2023, 08, 17);
            DateTime dataNascimentoMinima = dataAtual.AddYears(-idadeMinima);

            return dataNascimentoMinima;
        }
    }
}
