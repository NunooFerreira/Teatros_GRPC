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
    public partial class AlterarTgestor : Form
    {
        public AlterarTgestor()
        {
            InitializeComponent();
            CarregarInformacoes();
        }

        private async void CarregarInformacoes()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new ListarTeatros.ListarTeatrosClient(channel);
            

            var call = listaClient.GetListaTeatros(new ListaTeatroVerModelo());


            while (await call.ResponseStream.MoveNext())
            {
                var teatro = call.ResponseStream.Current;

                cmbteatro.Items.Add(teatro.Nome);
            }

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {

        }
    }
}
