using DesafioCRUD.App.Services;
using DesafioCRUD.Ioc;
using Ninject;

namespace DesafioCRUD;

public partial class frmMenuPrincipal : Form
{
    public frmMenuPrincipal()
    {
        InitializeComponent();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        var servico = Config.Kernel.TryGet<ClienteAppService>();

        var teste = servico.ObterClientes();
    }
}