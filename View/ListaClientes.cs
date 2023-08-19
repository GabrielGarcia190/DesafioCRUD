using DesafioCRUD.Controller;
using System;
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
            var dados = new ListarClientes().Listar();

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


            var respotas = new ConsultaClienteController().ConsultarClientePorNome(dadosBusca);

            dgvListClientes.DataSource = respotas;

            Console.WriteLine(filtroSelecionado);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
    }
}
