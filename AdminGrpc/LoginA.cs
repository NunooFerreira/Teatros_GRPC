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
    public partial class LoginA : Form
    {
        public LoginA()
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
            //AddLoginModel reply = new AddLoginModel();

            var reply = await client.GetLoginAsync(input);
            if (reply.Sucesso == 0)
            {

                if (reply.UtilizadorTipo == 4)
                {
                    MessageBox.Show(reply.Feedback);
                    InicioAdmin wgest = new InicioAdmin();
                    wgest.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error esta conta não pertence a um Admin");
                }

            }
            else
            {

                MessageBox.Show("Mensagem Não Concluida");

            }


        }

    
    }
}
