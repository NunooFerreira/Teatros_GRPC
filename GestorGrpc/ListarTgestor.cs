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
    public partial class ListarTgestor : Form
    {
        public ListarTgestor()
        {
            InitializeComponent();
            CarregaListaTeatros();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private async void CarregaListaTeatros()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new ListarTeatros.ListarTeatrosClient(channel);

            var call = listaClient.GetListaTeatros(new ListaTeatroVerModelo());

            while (await call.ResponseStream.MoveNext())
            {
                var teatro = call.ResponseStream.Current;

                lblistarT.Items.Add("Nome: " + teatro.Nome);
                lblistarT.Items.Add("Morada: " + teatro.MoradaTeatro);
                lblistarT.Items.Add("Localização: " + teatro.LocalizacaoTeatro);
                lblistarT.Items.Add("---Contactos---");
                lblistarT.Items.Add("Telemovel: " + teatro.Telemovel);
                lblistarT.Items.Add("Telefone: " + teatro.Telefone);
                lblistarT.Items.Add("Email: " + teatro.Email);
                lblistarT.Items.Add(" ");
                lblistarT.Items.Add(" ");

            }

        }
    }
}
