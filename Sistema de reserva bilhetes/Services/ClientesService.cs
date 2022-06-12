using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_de_reserva_bilhetes;
using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes.Models;


namespace Sistema_de_reserva_bilhetes.Services
{
    public class ClientesService: Clientes.ClientesBase
    {

        private readonly ILogger<ClientesService> _logger;
        public ClientesService(ILogger<ClientesService> logger)
        {
            _logger = logger;
        }

        public override Task<ClientesModelo> GetClienteInfo(ClienteVerModelo request, ServerCallContext context)
        {
            ClientesModelo output = new ClientesModelo();
            if (request.UserId == 1)
            {
                output.Firstname = "Jaime";
                output.LastName = "Smit";
            }
            else if (request.UserId == 1)
            {
                output.Firstname = "Jane ";
                output.LastName = "Doe";
            }
            else
            {
                output.Firstname = "Greg";
                output.LastName = "Tomas";
            }

            return Task.FromResult(output);
        }




        public override async Task GetNovosClientes(ClientesRequest request,
            IServerStreamWriter<ClientesModelo> responseStream, ServerCallContext context)
        {
            List<ClientesModelo> customers = new List<ClientesModelo>
    {
        new ClientesModelo
        {
            Firstname = "Tim",
            LastName ="Corey",
            Email = "aaaa@aaaa.com",
            Age = 41,
            IsAlive = true
        },
    };

            foreach (var cust in customers)
            {
                await Task.Delay(1000);
                await responseStream.WriteAsync(cust);
            }


        }
    }
}
