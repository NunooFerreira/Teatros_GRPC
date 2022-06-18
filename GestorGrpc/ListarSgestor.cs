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
    public partial class ListarSgestor : Form
    {
        public ListarSgestor()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadicionarS_Click(object sender, EventArgs e)
        {
            AdicionarSgestor adicionarSgestor = new AdicionarSgestor();
            adicionarSgestor.ShowDialog();
        }
    }
}
