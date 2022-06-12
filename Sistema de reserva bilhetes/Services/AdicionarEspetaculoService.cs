
using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes;
using Sistema_de_reserva_bilhetes.Models;


namespace Sistema_de_reserva_bilhetes.Services
{
    public class AdicionarEspetaculoService: AdicionarEspetaculo.AdicionarEspetaculoBase
    {
        private readonly ILogger<AdicionarEspetaculoService> _logger;
        private readonly BaseTeatrosContext _context;

        public AdicionarEspetaculoService(ILogger<AdicionarEspetaculoService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }

        public override Task<EspetaculoModelo> GetNovoEspetaculo(EspetaculoVerModelo request, ServerCallContext context)
        {


            //DateTime timeinicio = request.DataInicio.ToDateTime();
            //DateTime timefim = request.DataFim.ToDateTime();
            var sess = new Espetaculo
            {
                Nome = request.Nome,
                Sinopse = request.Sinopse,
                DataInicio = Convert.ToDateTime(request.DataInicio),
                DataFim = Convert.ToDateTime(request.DataFim),
                Preco = request.Dinheiro

            };
            _context.Add(sess);
            _context.SaveChangesAsync();
            return Task.FromResult(new EspetaculoModelo
            {
                Feedback = "Teatro adicionado com Sucesso!"
            });
        }

        public override Task<EspetaculoModeloPesquisa> PesquisaEspetaculo(EspetaculoVerModeloPesquisa request, ServerCallContext context)
        {

            // vai percorrer a tabela sessão e encontrar a sessão com o mesmo nome
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
    }
}
