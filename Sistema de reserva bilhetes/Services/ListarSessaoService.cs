using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes;
using Sistema_de_reserva_bilhetes.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_reserva_bilhetes.Services
{
    public class ListarSessaoService : ListarSessao.ListarSessaoBase
    {
        private readonly ILogger<ListarSessaoService> _logger;
        private readonly BaseTeatrosContext _context;

        public ListarSessaoService(ILogger<ListarSessaoService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }

        public override async Task<ListarSessaoModelo> PesquisaListaSessao(PesquisaListaSessaoVerModelo request, ServerCallContext context)
        {
            bool flag = true;
            string nome = Convert.ToString(request.Sessao);
            ListarSessaoModelo teat = new ListarSessaoModelo();
            foreach (var i in _context.Sessaos)
            {
                if (nome == i.NomeSessao)
                {
                    teat.NomeSessao = i.NomeSessao;
                    teat.Datasessao = Convert.ToString(i.DataSessao);
                    teat.Horainicio = i.HoraInicio;
                    teat.Horafim = i.HoraFim;
                    teat.LugaresTotais = i.LugarTotais;
                    teat.LugaresDisponiveis = i.LugaresDisponiveis;
                    flag = false;
                }
            }

            if (flag == false)
            {
                return await Task.FromResult(teat);
            }
            else
            {
                teat.NomeSessao = "Nenhuma encontrada";
                return await Task.FromResult(teat);
            }
        }

        public override async Task GetListarSessao(ListarSessaoVerModelo request,
           IServerStreamWriter<ListarSessaoModelo> responseStream, ServerCallContext context)
        {
            foreach (var i in _context.Sessaos)
            {
                var teat = new ListarSessaoModelo();
                teat.Id = i.IdSessao;
                teat.NomeSessao = i.NomeSessao;
                teat.Datasessao = Convert.ToString(i.DataSessao);
                teat.Horainicio = i.HoraInicio;
                teat.Horafim = i.HoraFim;
                teat.LugaresTotais = i.LugarTotais;
                teat.LugaresDisponiveis = i.LugaresDisponiveis;

                await responseStream.WriteAsync(teat);
            }
        }

        public override async Task<ListarSessaoModelo> GetSessao(GetSessaoRequest request, ServerCallContext context)
        {
            var sessao = await this._context.Sessaos.FirstOrDefaultAsync(s => s.IdSessao == request.Id);

            return new ListarSessaoModelo
            {
                Datasessao = Convert.ToString(sessao.DataSessao),
                Horafim = sessao.HoraFim,
                LugaresTotais = sessao.LugarTotais,
                Horainicio = sessao.HoraInicio,
                Id = sessao.IdSessao,
                LugaresDisponiveis = sessao.LugaresDisponiveis,
                NomeSessao = sessao.NomeSessao
            };
        }
    }
}