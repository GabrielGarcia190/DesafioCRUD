using DesafioCRUD.Controller;
using DesafioCRUD.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
