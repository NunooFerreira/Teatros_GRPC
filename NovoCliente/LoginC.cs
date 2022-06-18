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
    public partial class LoginC : Form
    {
        public LoginC()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioCliente inicioCliente = new InicioCliente();
            inicioCliente.ShowDialog();
            
        }
    }
}
