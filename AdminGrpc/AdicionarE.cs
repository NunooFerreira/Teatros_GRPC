using Grpc.Net.Client;
using Sistema_de_reserva_bilhetes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGrpc
{
    public partial class AdicionarE : Form
    {
        public AdicionarE()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void btnguardar_Click(object sender, EventArgs e)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var espetaculoClient = new AdicionarEspetaculo.AdicionarEspetaculoClient(channel);

            var clienteRequest = new EspetaculoVerModelo
            {
                Nome = tbnomee.Text,
                Sinopse = rtbsinopsee.Text,
                DataInicio = dtpdatai.Value.ToShortDateString(),
                DataFim = dtpdatef.Value.ToShortDateString(),
                Dinheiro = Convert.ToInt32(tbprecoe.Text),
            };

            var feedback = await espetaculoClient.GetNovoEspetaculoAsync(clienteRequest);
            var message = MessageBox.Show(feedback.Feedback, "Adicionar Sessão", MessageBoxButtons.OK);
            if (message == DialogResult.OK)
            {
                this.Close();
            }




        }
    }
}
