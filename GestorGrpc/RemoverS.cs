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
            CarregarTudo();
           
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void CarregarTudo()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var listaClientsess = new ListarSessao.ListarSessaoClient(channel);

            using (var call = listaClientsess.GetListarSessao(new ListarSessaoVerModelo()))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    var currentCustomer = call.ResponseStream.Current;
                    cmbremoversessao.Items.Add(currentCustomer.NomeSessao);
                }
            }
        }

        private async void btnremover_Click(object sender, EventArgs e)
        {
            int b = cmbremoversessao.SelectedIndex;
            var input = new SessaoVerModeloUpdate { NomeSessao = (cmbremoversessao.Items[b].ToString()) };

            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var regsessao = new AdicionarSessao.AdicionarSessaoClient(channel);

            var reply = await regsessao.UpdateSessaoAsync(input);
            MessageBox.Show(reply.Feedback, "Eliminar Sessão", MessageBoxButtons.OK);
            cmbremoversessao.SelectedIndex = -1;
            this.Close();
        }
    }
}
