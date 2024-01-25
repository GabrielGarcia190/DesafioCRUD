using DesafioCRUD.Controller;
using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace DesafioCRUD.View
{
    public partial class formListClientes : Form
    {
        public formListClientes()
        {
            InitializeComponent();
        }

        private void formListClientes_Load(object sender, EventArgs e)
        {
            var dados = new ListarClientesController().ListarClientes();

            dgvListClientes.DataSource = dados;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var cliente_selecionado = Int32.Parse(dgvListClientes.SelectedCells[0].Value.ToString());

            var formdadosClientes = new formDadosCliente(cliente_selecionado);

            formdadosClientes.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var filtroSelecionado = cbFiltro.SelectedIndex;
            var dadosBusca = txtDadosBusca.Text;

            switch (filtroSelecionado)
            {
                case 1:
                    {
                        var validarDados = new SomenteNumeros().TemSomenteNumeros(dadosBusca);

                        if (validarDados == false)
                        {
                            MessageBox.Show("Para pesquisar por idade preencha somente com números");
                            return;
                        }
                        var respotas = new ConsultarClienteController().ConsultarClientePorIdade(Int32.Parse(dadosBusca));
                        dgvListClientes.DataSource = respotas;
                        break;
                    }
                case 2:
                    {
                        var respotas = new ConsultarClienteController().ConsultarClientePorCidade(dadosBusca);
                        dgvListClientes.DataSource = respotas;

                        break;
                    }
                case 3:
                    {
                        var respotas = new ConsultarClienteController().ConsultarClientePorTelefone(dadosBusca);
                        dgvListClientes.DataSource = respotas;
                        break;
                    }
                case 4:
                    { 
                        var respotas = new ConsultarClienteController().ConsultarClientePorGenero(dadosBusca);
                        dgvListClientes.DataSource = respotas;
                        break;
                    }

                    
                default:
                    {
                        var respotas = new ConsultarClienteController().ConsultarClientePorNome(dadosBusca);

                        dgvListClientes.DataSource = respotas;
                        break;
                    }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var form = new formDadosCliente();
            form.ShowDialog();
        }
    }
}
