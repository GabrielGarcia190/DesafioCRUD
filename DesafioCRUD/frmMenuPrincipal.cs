using DesafioCRUD.App.Services;
using DesafioCRUD.Enums;
using DesafioCRUD.Ioc;
using Ninject;

namespace DesafioCRUD;

public partial class frmMenuPrincipal : Form
{

    public frmMenuPrincipal()
    {
        InitializeComponent();

        ConfigurarControle(ETipoPanel.Listar);
    }

    private void ConfigurarControle(ETipoPanel tipoPanel)
    {

        var controle = ControleFactory.ObterControle(tipoPanel);

        pnMenu.Controls.Clear();

        pnMenu.Controls.Add(controle);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        var servico = Config.Kernel.TryGet<ClienteAppService>();

        var teste = servico.ObterClientes();
    }
}