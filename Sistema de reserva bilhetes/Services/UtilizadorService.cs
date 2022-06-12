using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes;
using Sistema_de_reserva_bilhetes.Models;

namespace Sistema_de_reserva_bilhetes.Services
{
    public class UtilizadorService: CriarUtilizador.CriarUtilizadorBase
    {
        private readonly ILogger<UtilizadorService> _logger;
        private readonly BaseTeatrosContext _context;

        public UtilizadorService(ILogger<UtilizadorService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }


        public override Task<UtilizadorModelo> GetUtilizadorInfo(UtilizadorVerModelo request, ServerCallContext context)
        {

            var uti = new Utilizador
            {
                Username = request.Username,
                Pass = request.Pass,
                Nome = request.Nome,
                Nif = request.Nif,
                Idade = request.Idade,
                Localidade = request.Localidade,
                Tipoutilizador = request.Tipoutilizador
            };
            _context.Add(uti);
            //_context.SaveChangesAsync();
            return Task.FromResult(new UtilizadorModelo
            {
                Feedback = "Utilizador Foi Registado!"
            });
        }

    }
}
