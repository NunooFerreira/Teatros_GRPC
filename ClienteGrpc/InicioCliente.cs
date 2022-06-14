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
    }
}
