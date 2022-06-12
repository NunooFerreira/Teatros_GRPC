using Grpc.Core;
using Grpc.Net.Client;
using GrpcServer.Protos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace adminSorteio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btGetBets_ClickAsync(object sender, EventArgs e)
        {
            lbUserKey.Items.Clear();


            var clientRequested = new GrpcServer.Protos.Status { Status_ = true };

            // criar uma stream para receber varias keys
            var streamingUserKeysBet = Program.clientUtilizador.GetUserKeyBets(clientRequested);

            string newItem = null;

            // ciclo que vai receber a stream de keys
            try
            {
                await foreach (var userKey in streamingUserKeysBet.ResponseStream.ReadAllAsync())
                {
                    // vai adicionando as keys que recebe na list box
                    newItem = userKey.Email + "     " + userKey.KeyString;
                    
                    lbUserKey.Items.Add(newItem);

                    newItem = String.Empty;
                }
            }
            catch (RpcException ex) when (ex.StatusCode == StatusCode.Cancelled)
            {
                Console.WriteLine("Stream cancelled.");
            }
        }

        private void btArchive_Click(object sender, EventArgs e)
        {

            var clientRequested = new GrpcServer.Protos.Status { Status_ = true };

            // criar uma stream para receber varias keys
            var status = Program.clientUtilizador.ArchiveAllActiveBets(clientRequested);


            if (status.Status_ == true)
            {
                string message = "Keys archived with success";
                string caption = "Success";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                lbUserKey.Items.Clear();

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);

            }
            else
            {
                string message = "Erros archiving the keys";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);

            }

        }
    }
}
