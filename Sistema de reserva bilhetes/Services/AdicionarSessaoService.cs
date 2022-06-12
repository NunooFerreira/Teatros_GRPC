using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes;
using Sistema_de_reserva_bilhetes.Models;

namespace Sistema_de_reserva_bilhetes.Services
{
    public class AdicionarSessaoService: AdicionarSessao.AdicionarSessaoBase
    {
        
        private readonly ILogger<AdicionarSessaoService> _logger;
        private readonly BaseTeatrosContext _context;

        public AdicionarSessaoService(ILogger<AdicionarSessaoService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }

        public override Task<SessaoModelo> GetNovaSessao(SessaoVerModelo request, ServerCallContext context)
        {


       

            var sess = new Sessao
            {
                DataSessao = Convert.ToDateTime(request.DataSessao),
                NomeSessao = request.NomeSessao,
                HoraInicio = request.HoraInicio,
                HoraFim = request.HoraFim,
                LugarTotais = request.LugarTotal,
                LugaresDisponiveis = request.LugarDisponivel

            };
            _context.Add(sess);
            _context.SaveChangesAsync();
            return Task.FromResult(new SessaoModelo
            {
                Feedback = "Teatro adicionado com Sucesso!"
            });



        }


        public override Task<SessaoModeloUpdate> UpdateSessao(SessaoVerModeloUpdate request, ServerCallContext context)
        {

            // vai percorrer a tabela sessão e encontrar a sessão com o mesmo nome
            var uti = new Sessao();
            foreach (var i in _context.Sessaos)
            {
                if (i.NomeSessao == request.NomeSessao)
                {
                    _context.Update(i);
                    _context.SaveChangesAsync();
                    return Task.FromResult(new SessaoModeloUpdate
                    {
                        Feedback = "Sessão Removida com Sucesso!"
                    });

                }

            }

            return Task.FromResult(new SessaoModeloUpdate
            {
                Feedback = "Não foi possivel remover a Sessão!"
            });
        }



        public override Task<SessaoModeloPesquisa> PesquisaSessao(SessaoVerModeloPesquisa request, ServerCallContext context)
        {

            // vai percorrer a tabela sessão e encontrar a sessão com o mesmo nome
            var sessao = new SessaoModeloPesquisa();
            var uti = new Sessao();
            foreach (var i in _context.Sessaos)
            {
                    if (i.NomeSessao == request.NomeSessao)
                    {
                        sessao.NomeSessao = i.NomeSessao;
                        sessao.DataSessao = Convert.ToString(i.DataSessao);
                        sessao.HoraFim = i.HoraInicio;
                        sessao.HoraFim = i.HoraFim;
                        sessao.LugarDisponivel = i.LugaresDisponiveis;
                        sessao.LugarTotal = i.LugarTotais;


                        return Task.FromResult(sessao);

                    }
                

            }

            return Task.FromResult(new SessaoModeloPesquisa
            {
                NomeSessao = "Sessão Não encontrada!"
            });
        }
    }
}
