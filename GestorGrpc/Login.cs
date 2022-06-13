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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Depois da verificacao do Login.
            this.Hide();

            InicioGestor inicioGestor = new InicioGestor(); 
            inicioGestor.Show();
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
