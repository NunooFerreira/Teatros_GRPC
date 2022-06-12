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
    public class ListarCompraBilheteService: ListarCompraBilhete.ListarCompraBilheteBase
    {
        private readonly ILogger<ListarCompraBilheteService> _logger;
        private readonly BaseTeatrosContext _context;

        public ListarCompraBilheteService(ILogger<ListarCompraBilheteService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }


        public override async Task GetCompraBilhete(ListarCompraBilheteVerModelo request,
            IServerStreamWriter<ListarCompraBilheteModelo> responseStream, ServerCallContext context)
        {
            var id = request.Idutilizador;
            List<ListarCompraBilheteModelo> listbilhete = new List<ListarCompraBilheteModelo>();
            var aux = new ListarCompraBilheteModelo();
            foreach (var i in _context.ComprarBilhetes)
            {
                if (i.IdUtilizador == id)
                {
                    foreach (var res in _context.Reservas)
                    {
                        if (i.IdReserva == res.IdReserva)
                        {
                            foreach (var reg in _context.RegistaEspetaculos)
                            {
                                if (reg.IdRegisto == res.IdRegisto)
                                {
                                    foreach (var teat in _context.Teatros)
                                    {
                                        if (reg.IdTeatro == teat.IdTeatro)
                                        {
                                            aux.Teatro = teat.NomeTeatro;
                                        }
                                    }

                                    foreach (var ses in _context.Sessaos)
                                    {
                                        if (reg.IdSessao == ses.IdSessao)
                                        {
                                            aux.Sessao = ses.NomeSessao;
                                        }
                                    }
                                    foreach (var espct in _context.Espetaculos)
                                    {
                                        if (reg.IdEspetaculo == espct.IdEspetaculo)
                                        {
                                            aux.Espect = espct.Nome;
                                            aux.Quantidade = res.Quantidade;
                                            aux.Datacompra = Convert.ToString(res.DataReserva);
                                            listbilhete.Add(aux);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            foreach (var custo in listbilhete)
            {
                await responseStream.WriteAsync(custo);
            }


        }
    }
}
