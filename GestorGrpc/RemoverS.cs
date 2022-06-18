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

namespace GestorGrpc
{
    public partial class RemoverS : Form
    {
        public RemoverS()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void RemoverS_Load(object sender, EventArgs e)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClientsess = new ListarSessao.ListarSessaoClient(channel);

            using (var call = listaClientsess.GetListarSessao(new ListarSessaoVerModelo()))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    var currentCustomer = call.ResponseStream.Current;
                    cmbremoverSessao.Items.Add(currentCustomer.NomeSessao);
                }
            }
        }
        private async void btnremover_Click(object sender, EventArgs e)
        {
            int b = cmbremoverSessao.SelectedIndex;
            string sess = cmbremoverSessao.Items[b].ToString();
            var input = new SessaoVerModeloUpdate { NomeSessao = sess };

            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var regClient = new AdicionarSessao.AdicionarSessaoClient(channel);

            //var clienteRequest = new SessaoLookupModelupdate(input);


            var reply = await regClient.UpdateSessaoAsync(input);
            MessageBox.Show(reply.Feedback, "Eliminar Sessão", MessageBoxButtons.OK);
        }

        private void cmbremoverSessao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
