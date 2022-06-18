using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoCliente
{
    public partial class InicioCliente : Form
    {
        public InicioCliente()
        {
            InitializeComponent();
        }

        private void btnbilhetescomprados_Click(object sender, EventArgs e)
        {
            VerBilheteCliente verBilheteCliente = new VerBilheteCliente();
            verBilheteCliente.ShowDialog();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            PesquisarInfoCliente pesquisarInfoCliente = new PesquisarInfoCliente();
            pesquisarInfoCliente.ShowDialog();
        }

        private void btncomprarbilhetes_Click(object sender, EventArgs e)
        {
            ComprarBCliente comprarBCliente = new ComprarBCliente();
            comprarBCliente.ShowDialog();
        }

        private void btnadicionarfundos_Click(object sender, EventArgs e)
        {
            AdicionarFCliente adicionarFCliente = new AdicionarFCliente();
            adicionarFCliente.ShowDialog();
        }

        private void btnanularcompra_Click(object sender, EventArgs e)
        {
            AnularCCliente anularCCliente = new AnularCCliente();
            anularCCliente.ShowDialog();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginC loginC = new LoginC();
            loginC.ShowDialog();
        }
    }
}
