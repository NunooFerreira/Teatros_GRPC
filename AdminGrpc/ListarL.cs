using Grpc.Core;
using Grpc.Net.Client;
using Sistema_de_reserva_bilhetes;
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
    public partial class ListarL : Form
    {
        public ListarL()
        {
            InitializeComponent();
            CarregarLogin();
        }

        private async Task CarregarLogin()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new ListarUtilizadores.ListarUtilizadoresClient(channel);

            using (var call = listaClient.GetListaUtilizadores(new ListarUtilizadoresVerModelo()))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    var currentCustomer = call.ResponseStream.Current;
                    lblogin.Items.Add("Nome: " + currentCustomer.Nome);
                    lblogin.Items.Add("Username: " + currentCustomer.Username);
                    lblogin.Items.Add("Idade: " + currentCustomer.Idade);
                    lblogin.Items.Add("Localidade: " + currentCustomer.Localidade);
                    lblogin.Items.Add("Nif: " + currentCustomer.Nif);
                    lblogin.Items.Add(" ");
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}