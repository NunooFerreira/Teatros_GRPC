using Grpc.Core;
using Grpc.Net.Client;
using Sistema_de_reserva_bilhetes;
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
    public partial class AdicionarT : Form
    {
        public AdicionarT()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BaseTeatros;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
          
                SqlCommand sm = new SqlCommand("insert into dbo.teatro values('" + tbnome.Text + "','" + tbmorada.Text + "','" + tblocal.Text + "'," + tbtelemovel.Text + "," + tbtelefone.Text + ",'" + tbemail.Text + "')", sc);

                sc.Open();

                sm.ExecuteNonQuery();

                sc.Close();

                MessageBox.Show("Teatro Adicionado com sucesso");

                ListarT listar = new ListarT();
                listar.ShowDialog();
                this.Close();
            



        }
    }
}
