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

namespace NovoCliente
{
    public partial class VerBilheteCliente : Form
    {
        public VerBilheteCliente()
        {
            InitializeComponent();
            VerBilhetes();
        }

        private async void VerBilhetes()
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
                    lbBilhete.Items.Add("Teatro: " + currentCustomer.Teatro);
                    lbBilhete.Items.Add("Data Inicio: " + currentCustomer.Sessao);
                    lbBilhete.Items.Add("Data Fim: " + currentCustomer.Espect);
                    lbBilhete.Items.Add("Preço: " + currentCustomer.Datacompra);
                    lbBilhete.Items.Add("Sinopse: " + currentCustomer.Quantidade);
                    lbBilhete.Items.Add(" ");
                }
            
            }
        }

    }
}
