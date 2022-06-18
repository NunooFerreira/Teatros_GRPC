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
    public partial class AdicionarRegistoEspetaculo : Form
    {
        public AdicionarRegistoEspetaculo()
        {
            InitializeComponent();
        }

        private void buttonConfimar_Click(object sender, EventArgs e)
        {
            if (this.espetaculosListBox.SelectedItem is null || this.teatrosListBox.SelectedItem is null || this.sessoesListBox.SelectedItem is null)
            {
                MessageBox.Show("Tem que selecionar um espetáculo, um teatro e uma sessão.");
                return;
            }

            ListBoxItem selectedEspetaculo = (ListBoxItem)this.espetaculosListBox.SelectedItem;
            ListBoxItem selectedTeatro = (ListBoxItem)this.teatrosListBox.SelectedItem;
            ListBoxItem selectedSessao = (ListBoxItem)this.sessoesListBox.SelectedItem;

            CreateRegistoEspetaculo(selectedSessao.Text, selectedEspetaculo.Text, selectedTeatro.Text);

            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void AdicionarRegistoEspetaculo_Load(object sender, EventArgs e)
        {
            var sessoes = await GetSessoesAsync();
            var espetaculos = await GetEspetaculosAsync();
            var teatros = await GetTeatrosAsync();

            foreach (var sessao in sessoes)
            {
                sessoesListBox.Items.Add(new ListBoxItem { Id = sessao.Id, Text = sessao.NomeSessao });
            }

            foreach (var espetaculo in espetaculos)
            {
                espetaculosListBox.Items.Add(new ListBoxItem { Id = espetaculo.Id, Text = espetaculo.Nome });
            }

            foreach (var teatro in teatros)
            {
                teatrosListBox.Items.Add(new ListBoxItem { Id = teatro.Id, Text = teatro.Nome });
            }
        }

        private async Task<IEnumerable<ListarSessaoModelo>> GetSessoesAsync()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new ListarSessao.ListarSessaoClient(channel);

            using (var call = listaClient.GetListarSessao(new ListarSessaoVerModelo()))
            {
                List<ListarSessaoModelo> result = new List<ListarSessaoModelo>();

                await foreach (var sessao in call.ResponseStream.ReadAllAsync())
                {
                    result.Add(sessao);
                }

                return result;
            }
        }

        private async Task<IEnumerable<ListarEspetaculoModelo>> GetEspetaculosAsync()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new ListarEspetaculo.ListarEspetaculoClient(channel);

            using (var call = listaClient.GetListarEspetaculo(new ListarEspetaculoVerModelo()))
            {
                List<ListarEspetaculoModelo> result = new List<ListarEspetaculoModelo>();

                await foreach (var espetaculo in call.ResponseStream.ReadAllAsync())
                {
                    result.Add(espetaculo);
                }

                return result;
            }
        }

        private async Task<IEnumerable<ListarTeatrosModelo>> GetTeatrosAsync()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new ListarTeatros.ListarTeatrosClient(channel);

            using (var call = listaClient.GetListaTeatros(new ListaTeatroVerModelo()))
            {
                List<ListarTeatrosModelo> result = new List<ListarTeatrosModelo>();

                await foreach (var teatro in call.ResponseStream.ReadAllAsync())
                {
                    result.Add(teatro);
                }

                return result;
            }
        }

        private void CreateRegistoEspetaculo(string sessaoNome, string espetaculoNome, string teatroNome)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new RegistarEspetaculo.RegistarEspetaculoClient(channel);

            listaClient.GetRegistarEspetaculo(new RegistarEspetaculoVerModelo { Espect = espetaculoNome, Sessao = sessaoNome, Teatro = teatroNome });
        }

        private class ListBoxItem
        {
            public int Id { get; set; }

            public string Text { get; set; }
        }
    }
}