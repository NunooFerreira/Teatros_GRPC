using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGrpc
{
    public partial class InicioAdmin : Form
    {
        public InicioAdmin()
        {
            InitializeComponent();
        }

        private void Btnlistarteatros_Click(object sender, EventArgs e)
        {
            ListarT listarTeatros = new ListarT();

            listarTeatros.ShowDialog();
        }

        private void btnlistarsessao_Click(object sender, EventArgs e)
        {
            ListarS listarS = new ListarS();
            listarS.ShowDialog();
        }
    }
}
