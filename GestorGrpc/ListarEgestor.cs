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

namespace GestorGrpc
{
    public partial class ListarEgestor : Form
    {
        public ListarEgestor()
        {
            InitializeComponent();
            CarregaListarEspetaculos();
        }

        private void btncancelarE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadicionarE_Click(object sender, EventArgs e)
        {
            AdicionarEgestor adicionarEgestor = new AdicionarEgestor();
            adicionarEgestor.ShowDialog();
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
                    lblistarE.Items.Add("Espetaculo: " + currentCustomer.Nome);
                    lblistarE.Items.Add("Preço: " + currentCustomer.Sinopse);
                    lblistarE.Items.Add("Data Inicio: " + currentCustomer.DataInicio);
                    lblistarE.Items.Add("Data Fim: " + currentCustomer.DataFim);
                    lblistarE.Items.Add("Preço: " + currentCustomer.Money);
                    lblistarE.Items.Add("-----------------------------------");
                }
            }
        }
    }
}
