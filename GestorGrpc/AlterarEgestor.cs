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
    public partial class AlterarEgestor : Form
    {
        public AlterarEgestor()
        {
            InitializeComponent();
            CarregarInformacoes();
        }

        private async void CarregarInformacoes()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var listaespet = new ListarEspetaculo.ListarEspetaculoClient(channel);


            using (var call1 = listaespet.GetListarEspetaculo(new ListarEspetaculoVerModelo()))
            {
                while (await call1.ResponseStream.MoveNext())
                {
                    var currentCustomer = call1.ResponseStream.Current;
                    cmbespetaculo.Items.Add("*" + currentCustomer.Nome);

                }
            }

        }



    }
}
