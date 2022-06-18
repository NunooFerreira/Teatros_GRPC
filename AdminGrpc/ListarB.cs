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
    public partial class ListarB : Form
    {
        public ListarB()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void VerBilheteLoad(object sender, EventArgs e)
        {

            // primeiro criamos a ligação, canal.
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            // para a combobox do Espetaculo
            var listaClient = new ListarCompraBilhete.ListarCompraBilheteClient(channel);

            using (var call = listaClient.GetCompraBilhete(new ListarCompraBilheteVerModelo()))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    var currentCustomer = call.ResponseStream.Current;
                    lbbilhetes.Items.Add("Teatro: " + currentCustomer.Teatro);
                    lbbilhetes.Items.Add("Data Inicio: " + currentCustomer.Sessao);
                    lbbilhetes.Items.Add("Data Fim: " + currentCustomer.Espect);
                    lbbilhetes.Items.Add("Preço: " + currentCustomer.Datacompra);
                    lbbilhetes.Items.Add("Sinopse: " + currentCustomer.Quantidade);
                    lbbilhetes.Items.Add(" ");


                }
            }
        }
    }
}
