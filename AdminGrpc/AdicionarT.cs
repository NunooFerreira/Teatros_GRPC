using Grpc.Core;
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
    public partial class AdicionarT : Form
    {
        public AdicionarT()
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
            var client = new AdicionarTeatro.AdicionarTeatroClient(channel);
            var input = new TeatroVerModelo
            {
                Nome = tbnome.Text,
                MoradaTeatro = tbmorada.Text,
                LocalizacaoTeatro = tblocal.Text,
                Telemovel = tbtelemovel.Text,
                Telefone =  tbtelefone.Text,
                Email = tbemail.Text
            };
            var reply = await client.GetNewTeatroAsync(input);
            var rep = MessageBox.Show(reply.Feedback, "Adicionar Teatro", MessageBoxButtons.OK);

            if (rep == DialogResult.OK)
            {
                this.Close();
            }


        }
    }
}
