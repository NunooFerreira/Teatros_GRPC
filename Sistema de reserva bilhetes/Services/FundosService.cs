using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes;
using Sistema_de_reserva_bilhetes.Models;

namespace Sistema_de_reserva_bilhetes.Services
{
    public class FundosService: AdicionarFundos.AdicionarFundosBase
    {
        private readonly ILogger<FundosService> _logger;
        private readonly BaseTeatrosContext _context;

        public FundosService(ILogger<FundosService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }


        public override Task<FundosModelo> GetAdicionarFundos(FundosVerModelo request, ServerCallContext context)
        {
            var id = request.Idutil;
            var fundo = request.Fundo;
            foreach (var uti in _context.Utilizadors)
            {
                if (uti.IdUtilizador == id)
                {
                    uti.Username = uti.Username;
                    uti.Pass = uti.Pass;
                    uti.Nome = uti.Nome;
                    uti.Nif = uti.Nif;
                    uti.Idade = uti.Idade;
                    uti.Localidade = uti.Localidade;
                    uti.Tipoutilizador = uti.Tipoutilizador;
                    uti.Saldo = uti.Saldo + fundo;
                    _context.Update(uti);
                    _context.SaveChangesAsync();
                }
            }

            return Task.FromResult(new FundosModelo
            {
                Feedback = "Fundos adicionados!"
            });

        }
    }
}
