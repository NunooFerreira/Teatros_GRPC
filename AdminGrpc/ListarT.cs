using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_reserva_bilhetes;
using Grpc.Core;
using Grpc.Net.Client;





namespace AdminGrpc
{
    public partial class ListarT : Form
    {
        public ListarT()
        {
           InitializeComponent();
           ListarTeatros_Load();
        }
        
        private async void ListarTeatros_Load()
        {  // primeiro criamos a ligação, canal.
            var channel = GrpcChannel.ForAddress("https://localhost:5001");


           var listaClient = new ListarTeatros.ListarTeatrosClient(channel);




            //using (var call = listaClient.GetNewListarTeatro(new ListarTeatroLookup()))
            //{
            //    while (await call.ResponseStream.MoveNext())
            //    {
            //        var currentCustomer = call.ResponseStream.Current;
            //        listBox1.Items.Add("Nome: " + currentCustomer.Nome);
            //        listBox1.Items.Add("Morada: " + currentCustomer.MoradaTeatro);
            //        listBox1.Items.Add("Localização: " + currentCustomer.LocalizacaoTeatro);
            //        listBox1.Items.Add("Telemovel: " + currentCustomer.Telemovel);
            //        listBox1.Items.Add("Telefone: " + currentCustomer.Telefone);
            //        listBox1.Items.Add("Email: " + currentCustomer.Email);
            //        listBox1.Items.Add(" ");

            //        //ListView listv1 = new ListView();
            //        //listv1.Items.Clear();
            //        //var item0 = new ListViewItem();
            //        //item0.Text = Convert.ToString(currentCustomer.Nome);
            //        //item0.SubItems.Add(Convert.ToString(currentCustomer.MoradaTeatro));
            //        //item0.SubItems.Add(Convert.ToString(currentCustomer.LocalizacaoTeatro));
            //        //item0.SubItems.Add(Convert.ToString(currentCustomer.Telemovel));
            //        //item0.SubItems.Add(Convert.ToString(currentCustomer.Telefone));
            //        //item0.SubItems.Add(Convert.ToString(currentCustomer.Email));
            //        //MessageBox.Show(currentCustomer.Nome);
            //    }
            //}
            var call = listaClient.GetListaTeatros(new ListaTeatroVerModelo());

            while (await call.ResponseStream.MoveNext())
            {
                var teatro = call.ResponseStream.Current;

                lbListarTeatros.Items.Add("Nome: " + teatro.Nome);
                lbListarTeatros.Items.Add("Morada: " + teatro.MoradaTeatro);
                lbListarTeatros.Items.Add("Localização: " + teatro.LocalizacaoTeatro);
                lbListarTeatros.Items.Add("Telemovel: " + teatro.Telemovel);
                lbListarTeatros.Items.Add("Telefone: " + teatro.Telefone);
                lbListarTeatros.Items.Add("Email: " + teatro.Email);
                lbListarTeatros.Items.Add(" ");
            }
        
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadicionarT_Click(object sender, EventArgs e)
        {
            AdicionarT adicionarT = new AdicionarT();
            adicionarT.ShowDialog();
        }
    }
}
