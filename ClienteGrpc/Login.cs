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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            InicioCliente inicioCliente = new InicioCliente();
            inicioCliente.ShowDialog();
        }
    }
}
