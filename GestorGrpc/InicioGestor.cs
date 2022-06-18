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
            ListarTgestor listarTgestor = new ListarTgestor();
            listarTgestor.ShowDialog();


        }

        private void btnAdicionarS_Click(object sender, EventArgs e)
        {
            ListarSgestor listarSgestor = new ListarSgestor();
            listarSgestor.ShowDialog();
        }

        private void btnAdicionarE_Click(object sender, EventArgs e)
        {
            ListarEgestor listarEgestor = new ListarEgestor();
            listarEgestor.ShowDialog();
        }
    }
}
