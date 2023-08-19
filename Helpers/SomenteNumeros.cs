using DesafioCRUD.DTO;

namespace DesafioCRUD.Helpers
{
    public class SomenteNumeros
    {
        public bool TemSomenteNumeros(string dados)
        {
            foreach (char c in dados)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
