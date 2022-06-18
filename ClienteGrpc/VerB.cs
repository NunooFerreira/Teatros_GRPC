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

namespace ClienteGrpc
{
    public partial class VerB : Form
    {
        public VerB()
        {
            InitializeComponent();
        }

        private async void ListarBilheteLoad(object sender, EventArgs e)
        {

            // primeiro criamos a ligação, canal.
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            // para a combobox do Espetaculo
           /* var listabilhete = new ListarCompraBilhete

            using (var call = listabilhete.GetCompraBilhete(new ListarCompraBilheteVerModelo()))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    var currentCustomer = call.ResponseStream.Current;
                    listBox1.Items.Add("Teatro: " + currentCustomer.Teatro);
                    listBox1.Items.Add("Data Inicio: " + currentCustomer.Sessao);
                    listBox1.Items.Add("Data Fim: " + currentCustomer.Espect);
                    listBox1.Items.Add("Preço: " + currentCustomer.Datacompra);
                    listBox1.Items.Add("Sinopse: " + currentCustomer.Quantidade);
                    listBox1.Items.Add(" ");


                }
            }*/

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
