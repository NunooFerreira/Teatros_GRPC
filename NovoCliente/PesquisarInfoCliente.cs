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
    public partial class PesquisarInfoCliente : Form
    {
        public PesquisarInfoCliente()
        {
            InitializeComponent();
            CarregarInformacoes();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void CarregarInformacoes()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new ListarTeatros.ListarTeatrosClient(channel);
            var listaespet = new ListarEspetaculo.ListarEspetaculoClient(channel);
            var listasessao = new ListarSessao.ListarSessaoClient(channel);

            var call = listaClient.GetListaTeatros(new ListaTeatroVerModelo());


            while (await call.ResponseStream.MoveNext())
            {
                var teatro = call.ResponseStream.Current;

                cbteatros.Items.Add("* " + teatro.Nome);
            }

            using (var call1 = listaespet.GetListarEspetaculo(new ListarEspetaculoVerModelo()))
            {
                while (await call1.ResponseStream.MoveNext())
                {
                    var currentCustomer = call1.ResponseStream.Current;
                    cbespetaculos.Items.Add("*" + currentCustomer.Nome);

                }
            }

            using (var call2 = listasessao.GetListarSessao(new ListarSessaoVerModelo()))
            {
                while (await call2.ResponseStream.MoveNext())
                {
                    var currentCustomer = call2.ResponseStream.Current;
                    cbsessao.Items.Add("Nome: " + currentCustomer.NomeSessao);
                }
            }

        }

        private async void btnefetuapesquisa_Click(object sender, EventArgs e)
        {

            /*
            if (String.IsNullOrEmpty(tbpesquisat.Text) != true)
            {

                var input = new TeatroVerModeloPesquisa { Nome = tbpesquisat.Text };
                var channel = GrpcChannel.ForAddress("https://localhost:5001");
                var client = new AdicionarTeatro.AdicionarTeatroClient(channel);

                var reply = await client.PesquisaTeatroAsync(input);
                lbpesquisas.Items.Add(reply);

            }
            if (String.IsNullOrEmpty(tbpesquisas.Text) != true)
            {

                var input = new SessaoVerModeloPesquisa { NomeSessao = tbpesquisas.Text };
                var channel = GrpcChannel.ForAddress("https://localhost:5001");
                var client = new AdicionarSessao.AdicionarSessaoClient(channel);

                var reply = await client.PesquisaSessaoAsync(input);
                lbpesquisas.Items.Add(reply);

            }
            if (String.IsNullOrEmpty(tbpesquisae.Text) != true)
            {

                var input = new EspetaculoVerModeloPesquisa { Nome = tbpesquisae.Text };
                var channel = GrpcChannel.ForAddress("https://localhost:5001");
                var client = new AdicionarEspetaculo.AdicionarEspetaculoClient(channel);

                var reply = await client.PesquisaEspetaculoAsync(input);
                lbpesquisas.Items.Add(reply);

            }*/
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            cbteatros.SelectedIndex = -1;

        }
    }
}
