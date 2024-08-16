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
    }

    private void ConfigurarControle(ETipoPanel tipoPanel)
    {

        var controle = ControleFactory.ObterControle(tipoPanel);

        pnMenu.Controls.Clear();

        pnMenu.Controls.Add(controle);
    }

    private void btnAdicionar_Click(object sender, EventArgs e)
    {
        CustomizarBotaoSelecionado(btnAdicionar, btnListar);

        ConfigurarControle(ETipoPanel.Adicionar);
    }

    private void btnListar_Click(object sender, EventArgs e)
    {
        CustomizarBotaoSelecionado(btnListar, btnAdicionar);

        ConfigurarControle(ETipoPanel.Listar);
    }

    private void CustomizarBotaoSelecionado(Button botaoSelecionado, Button outroBotao)
    {
        botaoSelecionado.BackColor = Color.FromArgb(red: 39, green: 39, blue: 58);
        outroBotao.BackColor = Color.FromArgb(red: 51, green: 51, blue: 76);
    }
}