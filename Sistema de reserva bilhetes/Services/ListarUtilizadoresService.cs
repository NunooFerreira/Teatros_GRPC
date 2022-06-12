using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes;
using Sistema_de_reserva_bilhetes.Models;
using System.Collections.Generic;
using System.Linq;


namespace Sistema_de_reserva_bilhetes.Services
{
    public class ListarUtilizadoresService: ListarUtilizadores.ListarUtilizadoresBase
    {
        private readonly ILogger<ListarUtilizadoresService> _logger;
        private readonly BaseTeatrosContext _context;

        public ListarUtilizadoresService(ILogger<ListarUtilizadoresService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }

        public override async Task GetListaUtilizadores(ListarUtilizadoresVerModelo request,
           IServerStreamWriter<ListarUtilizadoresModelo> responseStream, ServerCallContext context)
        {
            var uti = new ListarUtilizadoresModelo();
            foreach (var utilizador in _context.Utilizadors)
            {
                uti.Username = utilizador.Username;
                uti.Nome = utilizador.Nome;
                uti.Nif = utilizador.Nif;
                uti.Idade = utilizador.Idade;
                uti.Localidade = utilizador.Localidade;
                if (utilizador.Tipoutilizador == 1)
                {
                    uti.TipoUti = "Administrador";
                }
                if (utilizador.Tipoutilizador == 2)
                {
                    uti.TipoUti = "Gestor";
                }
                if (utilizador.Tipoutilizador == 3)
                {
                    uti.TipoUti = "Cliente";
                }
                // Aplicamos um atraso de 1 segundo a cada registo
                await Task.Delay(1000);
                await responseStream.WriteAsync(uti);

            }
        }
    }
}
