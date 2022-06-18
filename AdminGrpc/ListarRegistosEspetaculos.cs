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
    public partial class ListarRegistosEspetaculos : Form
    {
        public ListarRegistosEspetaculos()
        {
            InitializeComponent();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            AdicionarRegistoEspetaculo adicionarRegistoEspetaculo = new AdicionarRegistoEspetaculo();
            adicionarRegistoEspetaculo.ShowDialog();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task LoadRegistosEspetaculosAsync()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new RegistarEspetaculo.RegistarEspetaculoClient(channel);

            using (var call = listaClient.GetAllRegistoEspetaculo(new GetAllRegistoEspetaculoRequest()))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    var currentRegistoEspetaculo = call.ResponseStream.Current;
                    var sessao = GetSessao(currentRegistoEspetaculo.SessaoId);
                    var espetaculo = GetEspetaculo(currentRegistoEspetaculo.EspetaculoId);
                    var teatro = GetTeatro(currentRegistoEspetaculo.TeatroId);

                    registosEspetaculosListBox.Items.Add("Teatro: " + teatro.Nome);
                    registosEspetaculosListBox.Items.Add("Espetaculo: " + espetaculo.Nome);
                    registosEspetaculosListBox.Items.Add("Sessão: " + sessao.NomeSessao);
                    registosEspetaculosListBox.Items.Add("Data: " + sessao.Datasessao);
                    registosEspetaculosListBox.Items.Add("Hora Início: " + sessao.Horainicio);
                    registosEspetaculosListBox.Items.Add("Hora Fim: " + sessao.Horafim);
                    registosEspetaculosListBox.Items.Add("Preço: " + espetaculo.Dinheiro);
                    registosEspetaculosListBox.Items.Add("-----------------------------------");
                }
            }
        }

        private GetEspetaculoResponse GetEspetaculo(int id)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new AdicionarEspetaculo.AdicionarEspetaculoClient(channel);

            return listaClient.GetEspetaculo(new GetEspetaculoRequest { Id = id });
        }

        private ListarSessaoModelo GetSessao(int id)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new ListarSessao.ListarSessaoClient(channel);

            return listaClient.GetSessao(new GetSessaoRequest { Id = id });
        }

        private ListarTeatrosModelo GetTeatro(int id)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new ListarTeatros.ListarTeatrosClient(channel);

            return listaClient.GetTeatro(new GetTeatroRequest { Id = id });
        }

        private async void ListarRegistosEspetaculos_Load(object sender, EventArgs e)
        {
            await LoadRegistosEspetaculosAsync();
        }
    }
}