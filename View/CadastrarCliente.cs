﻿using DesafioCRUD.Controller;
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


            //var genero = 

            var cliente = new Cliente(txtNomeCliente.Text, txtSobrenomeCliente.Text, numIdade.Value, dtpDateNasc.Text, txtTelefone.Text, txtNomeRua.Text, txtNumCasa.Text, mtbCEP.Text, txtBairo.Text, txtCidade.Text, cbUF.Text, cbGenero.TabIndex.ToString());




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

       
    }
}