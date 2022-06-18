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
    public partial class LoginC : Form
    {
        public LoginC()
        {
            InitializeComponent();
        }

        private async void btnentrar_Click(object sender, EventArgs e)
        {
            ModeloLogin input = new ModeloLogin();
            input.User = tbusername.Text;
            input.Password = tbpassword.Text;


            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new CriarLogin.CriarLoginClient(channel);


            var reply = await client.GetLoginAsync(input);
            if (reply.Sucesso == 0)
            {


                if (reply.UtilizadorTipo == 3)
                {
                    MessageBox.Show(reply.Feedback);
                    InicioCliente wgest = new InicioCliente();
                    this.Hide();
                    wgest.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Erro esta conta não pertence a um Cliente");
                }

            }
            else
            {

                MessageBox.Show("Mensagem Não Concluida");

            }

        }

        private void lcriarconta_Click(object sender, EventArgs e)
        {
            RegistarUtilizadorC registarUtilizadorC = new RegistarUtilizadorC();
            registarUtilizadorC.ShowDialog();
        }
    }
}
