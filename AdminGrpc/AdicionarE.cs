using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGrpc
{
    public partial class AdicionarE : Form
    {
        public AdicionarE()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BaseTeatros;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void btnguardar_Click(object sender, EventArgs e)
        {
           


            SqlCommand sm = new SqlCommand("insert into dbo.espetaculo values('" + tbnomee.Text + "'," + tbprecoe.Text + ",'"+ dtpdatai.Value.ToShortDateString() + "','" + dtpdatef.Value.ToShortDateString() + "','" + rtbsinopsee.Text + "')", sc);

            sc.Open();

           sm.ExecuteNonQuery();

            sc.Close();

            MessageBox.Show("Espetaculo adicionado com sucesso!");

        }
    }
}
