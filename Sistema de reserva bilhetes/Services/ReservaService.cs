using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes;
using Sistema_de_reserva_bilhetes.Models;

namespace Sistema_de_reserva_bilhetes.Services
{
    public class ReservaService: AdicionarReserva.AdicionarReservaBase
    {
        private readonly ILogger<ReservaService> _logger;
        private readonly BaseTeatrosContext _context;

        public ReservaService(ILogger<ReservaService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }

        public override Task<ReservaModelo> GetNovaReserva(ReservaVerModelo request, ServerCallContext context)
        {
            var teatro = new Teatro();
            int codigoteatro = 0;

            var espetaculo = new Espetaculo();
            int cod_espetaculo = 0;

            var sessao = new Sessao();
            var cod_sessao = 0;

            foreach (var i in _context.Teatros)
            {
                if (i.NomeTeatro == request.Teatro)
                {
                    codigoteatro = i.IdTeatro;
                }
            }

            foreach (var i in _context.Espetaculos)
            {
                if (i.Nome == request.Espetaculo)
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
            int cod_registo = 0;
            // Obter o id do Registo da tabela registo
            foreach (var reg in _context.RegistaEspetaculos)
            {
                if ((reg.IdSessao == cod_sessao) && (reg.IdTeatro == codigoteatro) && (reg.IdEspetaculo == cod_espetaculo))
                {
                    cod_registo = reg.IdRegisto;
                }
            }
            DateTime time = request.DataReserva.ToDateTime();
            var reserv = new Reserva
            {
                DataReserva = time,
                IdRegisto = cod_registo,
                Quantidade = request.Quantidade
            };
            _context.Add(reserv);
            
            return Task.FromResult(new ReservaModelo
            {
                Feedback = "Reserva Registada"
            });
        }
    }
}
