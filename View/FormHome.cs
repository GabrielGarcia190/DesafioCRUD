using DesafioCRUD.View;
using System;
using System.Windows.Forms;

namespace DesafioCRUD
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var formDados = new formDadosCliente();

            formDados.ShowDialog();

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            var formList = new formListClientes();

            formList.ShowDialog();
        }
    }
}
