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
    public class ListarReservaService: ListarReserva.ListarReservaBase
    {

        private readonly ILogger<ListarReservaService> _logger;
        private readonly BaseTeatrosContext _context;

        public ListarReservaService(ILogger<ListarReservaService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }

        public override async Task GetListaReserva(ListarReservaVerModelo request,
           IServerStreamWriter<ListarReservaModelo> responseStream, ServerCallContext context)
        {
            var uti = new ListarReservaModelo();
            foreach (var utilizador in _context.Reservas)
            {
                foreach (var i in _context.RegistaEspetaculos)
                {
                    if (utilizador.IdRegisto == i.IdRegisto)
                    {
                        foreach (var c in _context.Teatros)
                        {
                            if (i.IdTeatro == c.IdTeatro)
                            {
                                uti.ResTeatro = c.NomeTeatro;
                            }
                        }
                        foreach (var c in _context.Espetaculos)
                        {
                            if (i.IdEspetaculo == c.IdEspetaculo)
                            {
                                uti.ResEspetaculo = c.Nome;
                            }
                        }
                        foreach (var c in _context.Sessaos)
                        {
                            if (i.IdSessao == c.IdSessao)
                            {
                                uti.ResSessao = c.NomeSessao;
                            }
                        }
                    }

                }
                uti.Quantidade = utilizador.Quantidade;
                uti.Data = utilizador.DataReserva.ToString();

                await Task.Delay(1000);
                await responseStream.WriteAsync(uti);

            }
        }
    }
}
