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
    public class AdicionarTeatroService: AdicionarTeatro.AdicionarTeatroBase
    {
        private readonly ILogger<AdicionarTeatroService> _logger;
        private readonly BaseTeatrosContext _context;


        public AdicionarTeatroService(ILogger<AdicionarTeatroService> logger, BaseTeatrosContext context)
        {
            _logger = logger;
            _context = context;
        }
        public AdicionarTeatroService(BaseTeatrosContext dbcontext)
        {
            //_logger = logger;
            _context = dbcontext;
        }

        public override Task<TeatroModelo> GetNewTeatro(TeatroVerModelo request, ServerCallContext context)
        {
            var teatro = new Teatro
            {
                NomeTeatro = request.Nome,
                MoradaTeatro = request.MoradaTeatro,
                Localizacao = request.LocalizacaoTeatro,
                Telemovel = request.Telemovel,
                Telefone = request.Telefone,
                Email = request.Email
            };
            _context.Add(teatro);
            _context.SaveChangesAsync();


            return Task.FromResult(new TeatroModelo
            {
                Feedback = "Teatro adicionado com Sucesso! " + request.Nome + " " + request.Email
            });
        }

        public override Task<TeatroModeloPesquisa> PesquisaTeatro(TeatroVerModeloPesquisa request, ServerCallContext context)
        {
            foreach (var i in _context.Teatros)
            {
                if (request.Nome == i.NomeTeatro)
                {
                    return Task.FromResult(new TeatroModeloPesquisa
                    {
                        Nome = i.NomeTeatro,
                        MoradaTeatro = i.MoradaTeatro,
                        LocalizacaoTeatro = i.Localizacao,
                        Telemovel = i.Telemovel,
                        Telefone = i.Telefone,
                        Email = i.Email
                    });
                }
            }
            return Task.FromResult(new TeatroModeloPesquisa
            {
                Nome = "Teatro não foi encontrado!"
            });
        }
    }
}
