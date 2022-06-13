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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnentrar_Click(object sender, EventArgs e)
        {

            // Depois da verificacao do Login.
            this.Hide();

            InicioAdmin inicioAdmin = new InicioAdmin();
            inicioAdmin.ShowDialog();

            

        }

    
    }
}
