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

       private readonly bool isEdit;
        public formDadosCliente(int id = 0)
        {
            InitializeComponent();

            if(id != 0)
            {
                lblTitulo.Text = "Editar Cadastro";
                checkAtivo.Enabled = true;
                checkAtivo.Visible = true;
                btnLimpar.Text = "DELETAR";
                isEdit = true;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            var cliente = new Cliente(txtNomeCliente.Text, txtSobrenomeCliente.Text, dtpDateNasc.Value, txtTelefone.Text, txtNomeRua.Text, txtNumCasa.Text, mtbCEP.Text, txtBairro.Text, txtCidade.Text, cbUF.Text, cbGenero.TabIndex.ToString());

            var sucesso = new CadastrarCliente().Cadastrar(cliente);

            if (sucesso)
            {
                MessageBox.Show("Dados Gravados com Sucesso");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            if (isEdit)
            {
                Console.WriteLine("Editando....");
            }
            else
            {
                txtNomeCliente.Text = "";
                txtSobrenomeCliente.Text = "";
                numIdade.Value = 0;
                dtpDateNasc.Text = "";
                txtTelefone.Text = "";
                txtNomeRua.Text = "";
                txtNumCasa.Text = "";
                mtbCEP.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                cbUF.SelectedIndex = -1;
                cbGenero.SelectedIndex = -1;
            }
        }
    }
}
