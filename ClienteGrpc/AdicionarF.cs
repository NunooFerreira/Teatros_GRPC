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
    public partial class AdicionarF : Form
    {
        public AdicionarF()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            try
            {
                

                float num1 = Convert.ToSingle(tbvalor.Text);
                labeltotal.Text = (num1).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter only numeric values");
            }
        }
    }
}
