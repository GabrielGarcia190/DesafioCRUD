using DesafioCRUD.Domain.Enums;

namespace DesafioCRUD.Domain.Filters
{
    public class ClienteCadastroFilter
    {
        public ClienteCadastroFilter(ETipoFiltro tipo, string? textBuscar)
        {
            Tipo = tipo;
            TextBuscar = textBuscar;
        }

        public ETipoFiltro Tipo { get; private set; }
        public string? TextBuscar { get; private set; }
    }
}
