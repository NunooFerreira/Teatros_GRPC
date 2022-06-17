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
using Grpc.Net.Client;
using Sistema_de_reserva_bilhetes;

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

        private async void btnadicionar_Click(object sender, EventArgs e)
        {
            
        }
        void Clear()
        {
            txbnome.Text = txbidade.Text = txbusername.Text = txbpassword.Text = txbnif.Text = txblocalidade.Text = "";

        }
            
    }
}
