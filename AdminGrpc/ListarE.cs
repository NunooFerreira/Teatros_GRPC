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
    public partial class ListarE : Form
    {
        public ListarE()
        {
            InitializeComponent();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            AdicionarE adicionarE = new AdicionarE();
            adicionarE.ShowDialog();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
