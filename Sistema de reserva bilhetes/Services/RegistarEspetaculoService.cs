using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes;
using Sistema_de_reserva_bilhetes.Models;

namespace Sistema_de_reserva_bilhetes.Services
{
    public class RegistarEspetaculoService: RegistarEspetaculo.RegistarEspetaculoBase
    {
        private readonly ILogger<RegistarEspetaculoService> _logger;
        private readonly BaseTeatrosContext _context;

        public RegistarEspetaculoService(ILogger<RegistarEspetaculoService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }

        public override Task<RegistarEspetaculoModelo> GetRegistarEspetaculo(RegistarEspetaculoVerModelo request, ServerCallContext context)
        {
         
            var teatro = new Teatro();
            int codigoteatro = 0;

            var espetaculo = new Espetaculo();
            int cod_espetaculo = 0;

            var sessao = new Sessao();
            var cod_sessao = 0;


            // Percorre a tabela TipoUtilizador e encontrar uma correspondencia entre opção selecionada e as existentes, 
            // e obtem o ID dessa descrição para inserir na tabela utilizador
            foreach (var i in _context.Teatros)
            {
                if (i.NomeTeatro == request.Teatro)
                {
                    codigoteatro = i.IdTeatro;
                }
            }

            foreach (var i in _context.Espetaculos)
            {
                if (i.Nome == request.Espect)
                {
                    cod_espetaculo = i.IdEspetaculo;
                }
            }

            foreach (var i in _context.Sessaos)
            {
                if (i.NomeSessao == request.Sessao)
                {
                    cod_sessao = i.IdSessao;
                }
            }


            var reg = new RegistaEspetaculo
            {
                IdSessao = cod_sessao,
                IdTeatro = codigoteatro,
                IdEspetaculo = cod_espetaculo,

            };
            _context.Add(reg);

            return Task.FromResult(new RegistarEspetaculoModelo
            {
                Feedback = "Sucesso Registo do Utilizador!"
            });
        }
    }
}
