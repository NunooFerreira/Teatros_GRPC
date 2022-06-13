using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_reserva_bilhetes;
using Grpc.Core;
using Grpc.Net.Client;





namespace AdminGrpc
{
    public partial class ListarT : Form
    {
        public ListarT()
        {
           InitializeComponent();
           ListarTeatros_Load();
        }
        
        private async void ListarTeatros_Load()
        {  // primeiro criamos a ligação, canal.
            var channel = GrpcChannel.ForAddress("https://localhost:5001");


            var listaClient = new ListarTeatros.ListarTeatrosClient(channel);

            var call = listaClient.GetListaTeatros(new ListaTeatroVerModelo());

            while (await call.ResponseStream.MoveNext())
            {
                var teatro = call.ResponseStream.Current;

                lbListarTeatros.Items.Add("Nome: " + teatro.Nome);
                lbListarTeatros.Items.Add("Morada: " + teatro.MoradaTeatro);
                lbListarTeatros.Items.Add("Localização: " + teatro.LocalizacaoTeatro);
                lbListarTeatros.Items.Add("---Contactos---");
                lbListarTeatros.Items.Add("Telemovel: " + teatro.Telemovel);
                lbListarTeatros.Items.Add("Telefone: " + teatro.Telefone);
                lbListarTeatros.Items.Add("Email: " + teatro.Email);
                lbListarTeatros.Items.Add(" ");
                lbListarTeatros.Items.Add(" ");

            }
        
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadicionarT_Click(object sender, EventArgs e)
        {
            AdicionarT adicionarT = new AdicionarT();
            adicionarT.ShowDialog();
        }
    }
}
