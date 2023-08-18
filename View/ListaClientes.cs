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
            var formdadosClientes = new formDadosCliente(4);

            formdadosClientes.ShowDialog();
        }
    }
}
