using DesafioCRUD.App.Services;
using DesafioCRUD.Domain.Entities;
using DesafioCRUD.Domain.Enums;
using DesafioCRUD.Domain.Helpers;
using DesafioCRUD.Ioc;
using Ninject;

namespace DesafioCRUD.Controles
{
    public partial class ucAdicionarCliente : ControleBase
    {
        public ucAdicionarCliente()
        {
            InitializeComponent();
        }

        private void ucAdicionarCliente_Load(object sender, EventArgs e)
        {
            PreencherComboBoxHelper.PreencherComboComEnum<EGeneroCliente>(cbGenero);
            PreencherComboBoxHelper.PreencherComboComEnum<EEstadoCivil>(cbEstadoCivil);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var cliente = ObterCliente();

            if (cliente is null) return;

            var servico = Config.Kernel.TryGet<ClienteAppService>();

            var result = servico.CadastrarCliente(cliente);

            MessageBox.Show(result.Mensagem, "Aviso", MessageBoxButtons.OK);

            if (result.Sucesso)
                LimparCampos();
        }

        private Cliente? ObterCliente()
        {
            var nomeCliente = txtNome.Text.Trim();
            DateTime dataNascimento = dtpDataNascimento.Value;
            var telefone = txtTelefone.Text.Trim();
            EGeneroCliente genero = (EGeneroCliente)cbGenero.SelectedIndex + 1;
            EEstadoCivil estadoCivil = (EEstadoCivil)cbEstadoCivil.SelectedIndex + 1;
            var rua = txtNomeRua.Text.Trim();
            var bairro = txtBairro.Text.Trim();
            var numero = txtNumero.Text.Trim();
            var cep = txtCEP.Text.Trim();
            var cidade = txtCidade.Text.Trim();
            var uf = txtUf.Text.Trim();

            var camposObrigatorios = new List<string> { nomeCliente, telefone, rua, bairro, numero, cep, cidade, uf };

            if (camposObrigatorios.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Preencha todos os campos corretamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return new Cliente(nomeCliente,
                               dataNascimento,
                               genero,
                               rua,
                               bairro,
                               numero,
                               cep,
                               cidade,
                               uf,
                               estadoCivil,
                               telefone);
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            dtpDataNascimento.Value = DateTime.Today;
            txtTelefone.Text = string.Empty;
            cbGenero.SelectedIndex = -1;
            cbEstadoCivil.SelectedIndex = -1;
            txtNomeRua.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUf.Text = string.Empty;
        }


        private void btnRemover_Click(object sender, EventArgs e)
            => LimparCampos();

    }
}
