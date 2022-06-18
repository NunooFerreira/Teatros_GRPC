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
    public partial class SessoesDisponiveis : Form
    {
        public SessoesDisponiveis()
        {
            InitializeComponent();
        }

        private async void SessoesDisponiveis_Load(object sender, EventArgs e)
        {
            var registosEspetaculos = await GetRegistosEspetaculosAsync();

            BindingSource source = new BindingSource();
            foreach (var registoEspetaculo in registosEspetaculos)
            {
                var sessao = GetSessao(registoEspetaculo.SessaoId);
                var espetaculo = GetEspetaculo(registoEspetaculo.EspetaculoId);
                var teatro = GetTeatro(registoEspetaculo.TeatroId);
                source.Add(new RegistoEspetaculoViewModel
                {
                    Id = registoEspetaculo.Id,
                    NomeSessao = sessao.NomeSessao,
                    NomeEspetaculo = espetaculo.Nome,
                    NomeTeatro = teatro.Nome,
                    DataHora = $"{sessao.Datasessao} {sessao.Horainicio} <-> {sessao.Horafim}"
                });
            }

            sessoesDataGridView.AutoResizeColumns();
            sessoesDataGridView.DataSource = source;
            sessoesDataGridView.CellContentClick += SessoesDataGridView_CellContentClick;

            //var currentCustomer = call.ResponseStream.Current;
            //listSessoes.Items.Add("Nome: " + currentCustomer.NomeSessao);
            //listSessoes.Items.Add("Data da Sessão: " + currentCustomer.Datasessao);
            //listSessoes.Items.Add("Hora Inicio: " + currentCustomer.Horainicio);
            //listSessoes.Items.Add("Hora Fim: " + currentCustomer.Horafim);
            //listSessoes.Items.Add("Lugares Totais: " + currentCustomer.LugaresTotais);
            //listSessoes.Items.Add("Lugares Restantes: " + currentCustomer.LugaresDisponiveis);
            //listSessoes.Items.Add("---------------------------------------------- ");
        }

        private void SessoesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                return;
            }

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                var registoEspetaculo = (RegistoEspetaculoViewModel)grid.Rows[e.RowIndex].DataBoundItem;
                ComprarBCliente comprarBCliente = new ComprarBCliente(registoEspetaculo.Id);
                comprarBCliente.ShowDialog();
                this.Close();
            }
        }

        private async Task<IEnumerable<RegistoEspetaculo>> GetRegistosEspetaculosAsync()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new RegistarEspetaculo.RegistarEspetaculoClient(channel);

            using (var call = listaClient.GetAllRegistoEspetaculo(new GetAllRegistoEspetaculoRequest()))
            {
                List<RegistoEspetaculo> result = new List<RegistoEspetaculo>();

                await foreach (var registoEspetaculo in call.ResponseStream.ReadAllAsync())
                {
                    result.Add(registoEspetaculo);
                }

                return result;
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

        private class RegistoEspetaculoViewModel
        {
            public int Id { get; set; }
            public string NomeEspetaculo { get; set; }
            public string NomeSessao { get; set; }
            public string NomeTeatro { get; set; }
            public string DataHora { get; set; }
        }
    }
}