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
    public partial class AdicionarAlterarS : Form
    {
        public AdicionarAlterarS()
        {
            InitializeComponent();
        }

        private async void btnguardar_Click(object sender, EventArgs e)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var sessaoClient = new AdicionarSessao.AdicionarSessaoClient(channel);

            var clienteRequest = new SessaoVerModelo
            {
                NomeSessao = tbnome.Text,
                HoraInicio = tbhorai.Text,
                HoraFim = tbhoraf.Text,
                DataSessao = dtpsessao.Value.ToShortDateString(),
                LugarTotal = Convert.ToInt32(tblugart.Text),
                LugarDisponivel = Convert.ToInt32(tblugard.Text)
            };

            var feedback = await sessaoClient.GetNovaSessaoAsync(clienteRequest);
            var message = MessageBox.Show(feedback.Feedback, "Adicionar Sessão", MessageBoxButtons.OK);
            if (message == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
