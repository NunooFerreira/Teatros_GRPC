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
    public partial class ListarS : Form
    {
        public ListarS()
        {
            InitializeComponent();
            CarregaListarSessao();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            AdicionarS adicionarS = new AdicionarS();
            adicionarS.ShowDialog();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task CarregaListarSessao()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClient = new ListarSessao.ListarSessaoClient(channel);

            using (var call = listaClient.GetListarSessao(new ListarSessaoVerModelo()))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    var currentCustomer = call.ResponseStream.Current;
                    lbSessoes.Items.Add("Nome: " + currentCustomer.NomeSessao);
                    lbSessoes.Items.Add("Data da Sessão: " + currentCustomer.Datasessao);
                    lbSessoes.Items.Add("Hora Inicio: " + currentCustomer.Horainicio);
                    lbSessoes.Items.Add("Hora Fim: " + currentCustomer.Horafim);
                    lbSessoes.Items.Add("Lugares Totais: " + currentCustomer.LugaresTotais);
                    lbSessoes.Items.Add("Lugares Restantes: " + currentCustomer.LugaresDisponiveis);
                    lbSessoes.Items.Add("---------------------------------------------- ");
                }
            }
        }
    }
}