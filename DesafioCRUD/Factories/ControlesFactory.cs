using DesafioCRUD.Controles;
using DesafioCRUD.Enums;

namespace DesafioCRUD;
public static class ControleFactory
{
    public static ControleBase ObterControle(ETipoPanel tipoPanel)
    {
        switch (tipoPanel)
        {
            case ETipoPanel.Listar:

                return new ucListaClientes();

            case ETipoPanel.Adicionar:
                return new ucAdicionarCliente();

            default:
                return new ucListaClientes();
        }
    }
}
