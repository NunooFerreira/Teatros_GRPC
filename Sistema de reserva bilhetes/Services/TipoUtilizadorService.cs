using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes;
using Sistema_de_reserva_bilhetes.Models;

namespace Sistema_de_reserva_bilhetes.Services
{
    public class TipoUtilizadorService: TipoUtilizador.TipoUtilizadorBase
    {
        private readonly ILogger<TipoUtilizadorService> _logger;
        private readonly BaseTeatrosContext _context;
        public TipoUtilizadorService(ILogger<TipoUtilizadorService> logger, BaseTeatrosContext context)
        {
            _logger = logger;
            _context = context;

        }


        public override Task<TipoModelo> GetTipoInformacao(TipoVerModelo request, ServerCallContext context)
        {
        
            return Task.FromResult(new TipoModelo
            {
                Confirma = "Registo Adicionado Com Sucesso!"
            });

        }

    }
}
