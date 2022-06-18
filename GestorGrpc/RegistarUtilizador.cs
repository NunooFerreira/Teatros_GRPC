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
    public partial class RegistarUtilizador : Form
    {
        public RegistarUtilizador()
        {
            InitializeComponent();
   
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            //Neste botão, apos a introdução dos dados do utilizador, é feita a comunicação com o Servidor
            // São enviados os dados pelo canal para serem gravadod na base de dados

            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var utiClient = new AdicionarUtilizador.AdicionarUtilizadorClient(channel);

            // vai ser atribuida as variaveis do proto os valores das textboxes preenchidas, guardadas numa variavel do tipo AddUtiLookupModel
            var clienteRequest = new UtilizadorVerModelo
            {
                Username = txbusername.Text,
                Pass = txbpassword.Text,
                Nome = txbnome.Text,
                Nif = txbnif.Text,
                Idade = Convert.ToInt32(txbidade.Text),
                Localidade = txblocalidade.Text,
                Tipoutilizador = 2

            };
            // É chamado o metodo do proto para comunicar com o servidor, enviar os dados e receber a resposta na variavel feedback
            var feedback = utiClient.GetUtilizadorInfo(clienteRequest);
            var message = MessageBox.Show(feedback.Feedback, "Adicionar Utilizador", MessageBoxButtons.OK);
            if (message == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
