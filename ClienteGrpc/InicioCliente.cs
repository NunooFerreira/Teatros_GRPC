using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteGrpc
{
    public partial class InicioCliente : Form
    {
        public InicioCliente()
        {
            InitializeComponent();
        }

        private void btnbilhetescomprados_Click(object sender, EventArgs e)
        {
            VerB verB = new VerB();
            verB.ShowDialog();
        }

        private void btnadicionarfundos_Click(object sender, EventArgs e)
        {
            AdicionarF adicionarF = new AdicionarF();
            adicionarF.ShowDialog();
        }

        private void btncomprarbilhetes_Click(object sender, EventArgs e)
        {
            ComprarB comprarB = new ComprarB();
            comprarB.ShowDialog();
        }

        private void btnanularcompra_Click(object sender, EventArgs e)
        {
            AnularC anularC = new AnularC();
            anularC.ShowDialog();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpesquisarteatros_Click(object sender, EventArgs e)
        {
            PesquisarT pesquisarT = new PesquisarT();
            pesquisarT.ShowDialog();
        }

        private void btnpesquisarsessoes_Click(object sender, EventArgs e)
        {
            PesquisarS pesquisarS = new PesquisarS();
            pesquisarS.ShowDialog();
        }

        private void btnpesquisarespetaculos_Click(object sender, EventArgs e)
        {
            PesquisarE pesquisarE = new PesquisarE();
            pesquisarE.ShowDialog();
        }
    }
}
