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
    public partial class ListarE : Form
    {
        public ListarE()
        {
            InitializeComponent();
            CarregaListarEspetaculos();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            AdicionarE adicionarE = new AdicionarE();
            adicionarE.ShowDialog();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task CarregaListarEspetaculos()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new ListarEspetaculo.ListarEspetaculoClient(channel);

            using (var call = listaClient.GetListarEspetaculo(new ListarEspetaculoVerModelo()))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    var currentCustomer = call.ResponseStream.Current;
                    lblistare.Items.Add("Espetaculo: " + currentCustomer.Nome);
                    lblistare.Items.Add("Data Inicio: " + currentCustomer.DataInicio);
                    lblistare.Items.Add("Data Fim: " + currentCustomer.DataFim);
                    lblistare.Items.Add("Preço: " + currentCustomer.Money);
                    lblistare.Items.Add("-----------------------------------");
                }
            }
        }


        /*
            private async Task CarregaListaEspetaculos()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var listaClient = new ListarEspetaculo.ListarEspetaculoClient(channel);

            using (var call = listaClient.GetListarEspetaculo(new ListarEspetaculoVerModelo()))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    var currentCustomer = call.ResponseStream.Current;
                 //   lblistare.Items.Add("Espetaculo: " + currentCustomer.Nome);
                 //   lblistare.Items.Add("Data Inicio: " + currentCustomer.DataInicio);
                 //   lblistare.Items.Add("Data Fim: " + currentCustomer.DataFim);
                   // lblistare.Items.Add("Preço: " + currentCustomer.Money);
                  //  lblistare.Items.Add("Sinopse: " + currentCustomer.Sinopse);
                    lblistare.Items.Add("-----------------------------------");
                }
            }
        }
        */
    }
}
