using DesafioCRUD.Controller;
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
    }
}
