﻿using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes;
using Sistema_de_reserva_bilhetes.Models;
using System.Linq;

namespace Sistema_de_reserva_bilhetes.Services
{
    public class AdicionarEspetaculoService : AdicionarEspetaculo.AdicionarEspetaculoBase
    {
        private readonly ILogger<AdicionarEspetaculoService> _logger;
        private readonly BaseTeatrosContext _context;

        public AdicionarEspetaculoService(ILogger<AdicionarEspetaculoService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }

        public override async Task<EspetaculoModelo> GetNovoEspetaculo(EspetaculoVerModelo request, ServerCallContext context)
        {
            var sess = new Espetaculo
            {
                Nome = request.Nome,
                Sinopse = request.Sinopse,
                DataInicio = Convert.ToDateTime(request.DataInicio),
                DataFim = Convert.ToDateTime(request.DataFim),
                Preco = request.Dinheiro
            };
            _context.Add(sess);
            await _context.SaveChangesAsync();
            return await Task.FromResult(new EspetaculoModelo
            {
                Feedback = "Espetaculo adicionado com Sucesso!"
            });
        }

        public override Task<EspetaculoModeloPesquisa> PesquisaEspetaculo(EspetaculoVerModeloPesquisa request, ServerCallContext context)
        {
            var sess = new EspetaculoModeloPesquisa();
            var uti = new Espetaculo();
            foreach (var i in _context.Espetaculos)
            {
                if (i.Nome == request.Nome)
                {
                    sess.Nome = i.Nome;
                    sess.DataInicio = Convert.ToString(i.DataInicio);
                    sess.DataFim = Convert.ToString(i.DataFim);
                    sess.Dinheiro = i.Preco;
                    sess.Sinopse = i.Sinopse;

                    return Task.FromResult(sess);
                }
            }

            return Task.FromResult(new EspetaculoModeloPesquisa
            {
                Nome = "Não foi possivel remover a Sessão!"
            });
        }

        public override Task<GetEspetaculoResponse> GetEspetaculo(GetEspetaculoRequest request, ServerCallContext context)
        {
            var espetaculo = this._context.Espetaculos.FirstOrDefault(e => e.IdEspetaculo == request.Id);

            if (espetaculo is { })
            {
                return Task.FromResult(new GetEspetaculoResponse
                {
                    DataFim = Convert.ToString(espetaculo.DataFim),
                    DataInicio = Convert.ToString(espetaculo.DataInicio),
                    Dinheiro = espetaculo.Preco,
                    Sinopse = espetaculo.Sinopse,
                    Id = espetaculo.IdEspetaculo,
                    Nome = espetaculo.Nome
                });
            }

            return Task.FromResult<GetEspetaculoResponse>(null);
        }
    }
}