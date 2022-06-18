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
    public partial class RemoverTeatro : Form
    {
        public RemoverTeatro()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
