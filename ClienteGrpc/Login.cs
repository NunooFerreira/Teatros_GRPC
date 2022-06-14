using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // ADicionar isto para base dados

namespace ClienteGrpc
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        // SqlConnection conn = new SqlConnection(@"Data Source=BOOSTED\SQLEXPRESS;Initial Catalog=TeatroGRPC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void btnentrar_Click(object sender, EventArgs e)
        {
            /*
            // Verificar o Login:

            String username, user_password;

            username = tbusername.Text;
            user_password = tbpassword.Text;

            try
            {
                String querry = "SELECT * FROM Login_new WHERE username = '" + tbusername.Text + "' AND password = '" + tbpassword.Text + "'";
                // SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                // sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = tbusername.Text;
                    user_password = tbpassword.Text;

                    // Pagina que abre asseguir a verificacao
                    InicioCliente inicioCliente = new InicioCliente();
                    inicioCliente.ShowDialog();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Email ou password incorretos","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbusername.Clear();
                    tbpassword.Clear();

                    // para voltar a focar no 
                    tbusername.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                // conn.clos();
            }


            */

            InicioCliente inicioCliente = new InicioCliente();
            inicioCliente.ShowDialog();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RegistarUtilizador registarUtilizador = new RegistarUtilizador();  
            registarUtilizador.ShowDialog();
        }
    }
}
