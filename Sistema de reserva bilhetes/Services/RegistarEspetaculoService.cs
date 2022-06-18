using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes;
using Sistema_de_reserva_bilhetes.Models;
using System.Linq;

namespace Sistema_de_reserva_bilhetes.Services
{
    public class RegistarEspetaculoService : RegistarEspetaculo.RegistarEspetaculoBase
    {
        private readonly ILogger<RegistarEspetaculoService> _logger;
        private readonly BaseTeatrosContext _context;

        public RegistarEspetaculoService(ILogger<RegistarEspetaculoService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }

        public override async Task<RegistarEspetaculoModelo> GetRegistarEspetaculo(RegistarEspetaculoVerModelo request, ServerCallContext context)
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
            await _context.SaveChangesAsync();

            return new RegistarEspetaculoModelo
            {
                Feedback = "Sucesso Registo do Utilizador!"
            };
        }

        public override async Task GetAllRegistoEspetaculo(GetAllRegistoEspetaculoRequest request, IServerStreamWriter<RegistoEspetaculo> responseStream, ServerCallContext context)
        {
            var results = this._context.RegistaEspetaculos.AsQueryable()
                .Select(re => new RegistoEspetaculo
                {
                    EspetaculoId = re.IdEspetaculo,
                    Id = re.IdRegisto,
                    SessaoId = re.IdSessao,
                    TeatroId = re.IdTeatro
                }).ToList();

            foreach (var registoEspetaculo in results)
            {
                await responseStream.WriteAsync(registoEspetaculo);
            }
        }

        public override Task<RegistoEspetaculo> GetRegistoEspetaculo(GetRegistoEspetaculoRequest request, ServerCallContext context)
        {
            var registoEspetaculo = this._context.RegistaEspetaculos.FirstOrDefault(re => re.IdRegisto == request.Id);

            return Task.FromResult(new RegistoEspetaculo
            {
                EspetaculoId = registoEspetaculo.IdEspetaculo,
                Id = registoEspetaculo.IdRegisto,
                SessaoId = registoEspetaculo.IdSessao,
                TeatroId = registoEspetaculo.IdTeatro
            });
        }
    }
}