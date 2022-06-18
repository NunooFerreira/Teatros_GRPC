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
    public partial class AdicionarFCliente : Form
    {
        public AdicionarFCliente()
        {
            InitializeComponent();
            CarregarSaldo();

        }

        private async Task CarregarSaldo()
        {
            lbcreditos.Text = Convert.ToString(0);
        }

        private async void btnadicionar_Click(object sender, EventArgs e)
        {

            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var fundosClient = new AdicionarFundos.AdicionarFundosClient(channel);

            var clienteRequest = new FundosVerModelo
            {
                // está por defeito pois tem que ser adicionada uma variavel global para armazenar o ID.
                Idutil = Convert.ToInt32(1006),
                Fundo = Convert.ToInt32(tbvalor.Text)

            };
            lbcreditos.Text = Convert.ToString(Convert.ToInt32(lbcreditos.Text) + Convert.ToInt32(tbvalor.Text));
            var feedback = await fundosClient.GetAdicionarFundosAsync(clienteRequest);
            var message = MessageBox.Show(feedback.Feedback, "Adicionar Crédito", MessageBoxButtons.OK);
            if (message == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
