using DesafioCRUD.Controller;
using DesafioCRUD.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioCRUD.View
{
    public partial class formDadosCliente : Form
    {
        public formDadosCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            var cliente = new Cliente();



            var sucesso = new CadastrarCliente().Cadastrar(cliente);

            if (sucesso)
            {
                MessageBox.Show("Dados Gravados com Sucesso");
            }
        }
    }
}
