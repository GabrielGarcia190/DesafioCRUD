using DesafioCRUD.Controller;
using DesafioCRUD.Enum;
using DesafioCRUD.Model;
using DesafioCRUD.Repositories;
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
        private readonly string CodigoCliente;
        public formDadosCliente(int id = 0)
        {
            InitializeComponent();



            if (id != 0)
            {
                lblTitulo.Text = "Editar Cadastro";
                checkAtivo.Enabled = true;
                checkAtivo.Visible = true;
                btnLimpar.Text = "DELETAR";
                isEdit = true;
                var dados_cliente = new ConsultaClienteController().ConsultarCliente(id);

                txtNomeCliente.Text = dados_cliente.Nome;
                txtSobrenomeCliente.Text = dados_cliente.Sobrenome;
                txtTelefone.Text = dados_cliente.NumTelefone;
                cbGenero.Text = dados_cliente.Genero;
                txtBairro.Text = dados_cliente.Bairro;
                txtNomeRua.Text = dados_cliente.NomeRua;
                mtbCEP.Text = dados_cliente.Cep;
                txtNumCasa.Text = dados_cliente.NumeroCasa;
                cbUF.Text = dados_cliente.Uf;
                txtCidade.Text = dados_cliente.Cidade;

                CodigoCliente = id.ToString();

                Console.WriteLine(dados_cliente.Genero);

            }

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            var cliente = ObterDados();


            Console.WriteLine(cliente.Nome);

            if (!isEdit)
            {

                var sucesso = new CadastrarCliente().Cadastrar(cliente);

                if (sucesso)
                {
                    MessageBox.Show("Cliente adicionado com Sucesso");
                    return;
                }

                return;

            }
            else
            {
                var sucesso = new EditarClienteController().EditarCliente(cliente);

                if (sucesso)
                {
                    MessageBox.Show("Dados Editados com Sucesso");
                }
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
                var respostar = new ExcluirClienteRepository().ExcluirCliente(CodigoCliente);
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

        public Cliente ObterDados()
        {
            if (!isEdit)
            {
                var cliente = new Cliente(txtNomeCliente.Text, txtSobrenomeCliente.Text, dtpDateNasc.Value, txtTelefone.Text, txtNomeRua.Text, txtNumCasa.Text, mtbCEP.Text, txtBairro.Text, txtCidade.Text, cbUF.Text, cbGenero.SelectedIndex.ToString());
                return cliente;
            }
            else
            {
                var cliente = new Cliente(CodigoCliente, txtNomeCliente.Text, txtSobrenomeCliente.Text, dtpDateNasc.Value, txtTelefone.Text, txtNomeRua.Text, txtNumCasa.Text, mtbCEP.Text, txtBairro.Text, txtCidade.Text, cbUF.Text, cbGenero.SelectedIndex.ToString());
                return cliente;

            }


        }
    }
}
