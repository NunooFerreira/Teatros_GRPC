using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClienteGrpc
{
    public partial class RegistarUtilizador : Form
    { 
       // fazer a striong para ligar a base dados
       // string connectionString = @"Data Source = (local)\sql....;";

        public RegistarUtilizador()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            /*
            if(txbusername.Text == "" || txbpassword.Text == "")
            {
                MessageBox.Show("Por favor preencha os campos necessarios!");
            }

          using(SqlConnection sqlCon = new SqlConnection(connectionStraing))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("UserAdd",sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddwithValue("@Nome", txbnome.Text.Trim());
                sqlCmd.Parameters.AddwithValue("@Idade", txbidade.Text.Trim());
                sqlCmd.Parameters.AddwithValue("@Username", txbusername.Text.Trim());
                sqlCmd.Parameters.AddwithValue("@Password", txbpassword.Text.Trim());
                sqlCmd.Parameters.AddwithValue("@Nif", txbnif.Text.Trim());
                sqlCmd.Parameters.AddwithValue("@Localidade", txblocalidade.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Registo feito com sucesso!");

                Clear();
            }
            */
        }
        void Clear()
        {
            txbnome.Text = txbidade.Text = txbusername.Text = txbpassword.Text = txbnif.Text = txblocalidade.Text = "";

        }
            
    }
}
