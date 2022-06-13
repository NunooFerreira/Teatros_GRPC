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
    public partial class ListarEgestor : Form
    {
        public ListarEgestor()
        {
            InitializeComponent();
        }

        private void btncancelarE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
