using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sistema_de_reserva_bilhetes;
using Grpc.Net.Client;

namespace GestorGrpc
{
    public partial class LoginG : Form
    {
        public LoginG()
        {
            InitializeComponent();
        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            ModeloLogin input = new ModeloLogin();
            input.User = tbusername.Text;
            input.Password = tbpassword.Text;


            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new CriarLogin.CriarLoginClient(channel);


            var reply = await client.GetLoginAsync(input);
            if (reply.Sucesso == 0)
            {
                

                if (reply.UtilizadorTipo == 2)
                {
                    MessageBox.Show(reply.Feedback);
                    InicioGestor wgest = new InicioGestor();
                    wgest.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error esta conta não pertence a um Gestor");
                }

            }
            else
            {

                MessageBox.Show("Mensagem Não Concluida");

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            RegistarUtilizador registarUtilizador = new RegistarUtilizador();
            registarUtilizador.ShowDialog();
        }
    }
}
