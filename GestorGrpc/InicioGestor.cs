using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorGrpc
{
    public partial class InicioGestor : Form
    {
        public InicioGestor()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginG loginG = new LoginG();
            loginG.ShowDialog();
        }

        private void btnAdicionarT_Click(object sender, EventArgs e)
        {
           AdicionarTgestor adicionarTgestor = new AdicionarTgestor();
           adicionarTgestor.ShowDialog();

        }

        private void btnAdicionarS_Click(object sender, EventArgs e)
        {
            AdicionarS adicionarS = new AdicionarS();
            adicionarS.ShowDialog();
        }


        private void btnalterarteatro_Click(object sender, EventArgs e)
        {
            AlterarTgestor alterarTgestor = new AlterarTgestor();
            alterarTgestor.ShowDialog();
        }

        private void btnremoversessao_Click(object sender, EventArgs e)
        {
            RemoverS removerS = new RemoverS();
            removerS.ShowDialog();
        }

        private void btnalterarsessao_Click(object sender, EventArgs e)
        {
            AlterarSgestor alterarSgestor = new AlterarSgestor();
            alterarSgestor.ShowDialog();
        }

        private void btnassociarsessao_Click(object sender, EventArgs e)
        {
            AssociarSessao associarSessao = new AssociarSessao();
            associarSessao.ShowDialog();
        }
    }
}
