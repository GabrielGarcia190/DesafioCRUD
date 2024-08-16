using DesafioCRUD.App.Services;
using DesafioCRUD.Domain.Results;
using DesafioCRUD.Ioc;
using Ninject;
using System.ComponentModel;

namespace DesafioCRUD.Controles
{
    public partial class ucListaClientes : ControleBase
    {
        private ClienteAppService _servico = Config.Kernel.TryGet<ClienteAppService>();
        private BindingList<ClienteCadastroResult>? _clientes;

        public ucListaClientes()
            => InitializeComponent();

        private void ucListaClientes_Load(object sender, EventArgs e)
        {
            _clientes = _servico.ObterClientes();
            gvClientes.DataSource = _clientes;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (gvClientes.SelectedRows.Count <= 0)
            {
                MessageBox.Show("É necessário selecionar um cliente para apaga-lo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var confirmacao = MessageBox.Show($"Deseja realmente deletar este cadastro?{Environment.NewLine}{Environment.NewLine}Está operação não pode ser revertida.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                var linhaSelecionada = gvClientes.SelectedRows[0];
                var codigoCliente = (Guid)linhaSelecionada.Cells[0].Value;

                var result = _servico.EliminarCliente(codigoCliente);

                if (result.Sucesso)
                {
                    var clienteExcluido = _clientes?.FirstOrDefault(x => x.CodigoCliente == codigoCliente);

                    if (clienteExcluido != null)
                        _clientes?.Remove(clienteExcluido);
                }

                MessageBox.Show(result.Mensagem, "Aviso", MessageBoxButtons.OK);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var clientesAtualizados = _servico.ObterClientes();
            _clientes?.Clear();

            foreach (var cliente in clientesAtualizados)
                _clientes?.Add(cliente);

        }
    }
}
