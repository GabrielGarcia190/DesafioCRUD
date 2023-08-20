using DesafioCRUD.Controller;
using DesafioCRUD.DTO;
using DesafioCRUD.Model;
using DesafioCRUD.Repositories;
using System;
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
                var dados_cliente = new ConsultarClienteController().ConsultarCliente(id);

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
            var respota = ValidarCampos(cliente);

            if (respota.Sucesso == false)
            {
                MessageBox.Show(respota.MensagemErro.ToString());
                return;
            }

            if (!isEdit)
            {
                var sucesso = new CadastrarClienteControoller().CadastrarCliente(cliente);

                if (sucesso)
                {
                    MessageBox.Show("Cliente adicionado com Sucesso");
                    LimparCampos();
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
                    this.FindForm().Close();
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
                var respota = new ExcluirClienteRepository().ExcluirCliente(CodigoCliente);
                this.FindForm().Close();
            }
            else
            {
                LimparCampos();
            }
        }

        public Cliente ObterDados()
        {
            if (!isEdit)
            {
                return new Cliente(txtNomeCliente.Text, txtSobrenomeCliente.Text, dtpDateNasc.Value, txtTelefone.Text, txtNomeRua.Text, txtNumCasa.Text, mtbCEP.Text, txtBairro.Text, txtCidade.Text, cbUF.Text, cbGenero.SelectedIndex.ToString());
            }
            else
            {
                return new Cliente(CodigoCliente, txtNomeCliente.Text, txtSobrenomeCliente.Text, dtpDateNasc.Value, txtTelefone.Text, txtNomeRua.Text, txtNumCasa.Text, mtbCEP.Text, txtBairro.Text, txtCidade.Text, cbUF.Text, cbGenero.SelectedIndex.ToString());
            }
        }

        public void LimparCampos()
        {
            txtNomeCliente.Text = "";
            txtSobrenomeCliente.Text = "";
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

        public DadosRetornoDTO ValidarCampos(Cliente cliente)
        {
            if (String.IsNullOrEmpty(cliente.Nome)) return new DadosRetornoDTO { MensagemErro = "Preencha Corretamente o nome do Cliente", Sucesso = false };
            if (String.IsNullOrEmpty(cliente.Sobrenome)) return new DadosRetornoDTO { MensagemErro = "Preencha Corretamente o sobrenome do Cliente", Sucesso = false };
            if (cliente.NumTelefone.Length != 14) return new DadosRetornoDTO { MensagemErro = "Preencha Corretamente o número de telefone", Sucesso = false };
            if (cliente.DataNascimento.Date == DateTime.Now.Date) return new DadosRetornoDTO { MensagemErro = "Preencha Corretamente a data de nascimento", Sucesso = false };
            if (String.IsNullOrEmpty(cliente.NomeRua)) return new DadosRetornoDTO { MensagemErro = "Preencha Corretamente o nome da rua", Sucesso = false };
            if (cliente.Genero == "-1") return new DadosRetornoDTO { MensagemErro = "Preencha corrtamente o genêro", Sucesso = false };
            if (cliente.NumeroCasa.Length > 10) return new DadosRetornoDTO { MensagemErro = "Por favor preencha corretamente o número da casa", Sucesso = false };
            if (cliente.Cep.Length != 9) return new DadosRetornoDTO { MensagemErro = "O número da casa está muito extenso, por favor preencha corretamente", Sucesso = false };
            if (String.IsNullOrEmpty(txtBairro.Text)) return new DadosRetornoDTO { MensagemErro = "Preencha corretamente o bairro", Sucesso = false };
            if (String.IsNullOrEmpty(txtCidade.Text)) return new DadosRetornoDTO { MensagemErro = "Preencha Corretamento o nome da cidade", Sucesso = false };
            if (cbUF.Text.Length != 2) return new DadosRetornoDTO { MensagemErro = "Selecione corrtamente a UF", Sucesso = false };

            return new DadosRetornoDTO { Sucesso = true };
        }

        private void checkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            var resposta = MensagemConfirmação();

            if (resposta)
            {
                new DesativarClienteRepository().DesativarCliete(CodigoCliente);

                MessageBox.Show("Cliente Desativado Com Sucesso!");
                
                this.FindForm().Close();
            }

        }

        public static bool MensagemConfirmação()
        {
            DialogResult result = MessageBox.Show("Deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }
    }
}
