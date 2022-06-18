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
    public partial class ComprarBCliente : Form
    {
        private readonly int idRegistoEspetaculo;

        public ComprarBCliente(int idRegistoEspetaculo)
        {
            InitializeComponent();
            this.idRegistoEspetaculo = idRegistoEspetaculo;
        }

        private void ComprarBCliente_Load(object sender, EventArgs e)
        {
            var registoEspetaculo = GetRegistoEspetaculo(this.idRegistoEspetaculo);
            var sessao = GetSessao(registoEspetaculo.SessaoId);
            var espetaculo = GetEspetaculo(registoEspetaculo.EspetaculoId);
            var teatro = GetTeatro(registoEspetaculo.TeatroId);

            BindingSource bindingSource = new BindingSource();
            bindingSource.Add(new KeyValuePair<string, string>("Teatro", teatro.Nome));
            bindingSource.Add(new KeyValuePair<string, string>("Espetáculo", espetaculo.Nome));
            bindingSource.Add(new KeyValuePair<string, string>("Sessão", sessao.NomeSessao));
            bindingSource.Add(new KeyValuePair<string, string>("Data/Hora", $"{sessao.Datasessao} {sessao.Horainicio} <-> {sessao.Horafim}"));
            bindingSource.Add(new KeyValuePair<string, string>("Preço", espetaculo.Dinheiro.ToString()));

            sessaoDataGridView.DataSource = bindingSource;
        }

        private RegistoEspetaculo GetRegistoEspetaculo(int id)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new RegistarEspetaculo.RegistarEspetaculoClient(channel);

            return listaClient.GetRegistoEspetaculo(new GetRegistoEspetaculoRequest { Id = id });
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

        private void buttonConfimar_Click(object sender, EventArgs e)
        {
            var registoEspetaculo = GetRegistoEspetaculo(this.idRegistoEspetaculo);
            var sessao = GetSessao(registoEspetaculo.SessaoId);
            var espetaculo = GetEspetaculo(registoEspetaculo.EspetaculoId);
            var teatro = GetTeatro(registoEspetaculo.TeatroId);

            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new AdicionarReserva.AdicionarReservaClient(channel);

            listaClient.GetNovaReserva(new ReservaVerModelo
            {
                DataReserva = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.Parse(sessao.Datasessao).ToUniversalTime()),
                Espetaculo = espetaculo.Nome,
                Quantidade = 1,
                Sessao = sessao.NomeSessao,
                Teatro = teatro.Nome
            });

            MessageBox.Show("Reserva efetuada.");

            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}