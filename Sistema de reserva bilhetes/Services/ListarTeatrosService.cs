using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes;
using Sistema_de_reserva_bilhetes.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sistema_de_reserva_bilhetes.Services
{
    public class ListarTeatrosService : ListarTeatros.ListarTeatrosBase
    {
        private readonly ILogger<ListarTeatrosService> _logger;
        private readonly BaseTeatrosContext _context;

        public ListarTeatrosService(ILogger<ListarTeatrosService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }

        public override async Task<ListarTeatrosModelo> PesquisaListaTeatros(PesquisaListaTeatrosVerModelo request, ServerCallContext context)
        {
            bool flag = true;
            string nome = Convert.ToString(request.Teatro);
            ListarTeatrosModelo teatro = new ListarTeatrosModelo();
            foreach (var i in _context.Teatros)
            {
                if (nome == i.NomeTeatro)
                {
                    teatro.Nome = i.NomeTeatro;
                    teatro.MoradaTeatro = i.MoradaTeatro;
                    teatro.LocalizacaoTeatro = i.Localizacao;
                    teatro.Telefone = i.Telefone;
                    teatro.Telemovel = i.Telemovel;
                    teatro.Email = i.Email;
                    flag = false;
                }
            }

            if (flag == false)
            {
                return await Task.FromResult(teatro);
            }
            else
            {
                teatro.Nome = "Não Encontrado";
                return await Task.FromResult(teatro);
            }
        }

        public override async Task GetListaTeatros(ListaTeatroVerModelo request,
           IServerStreamWriter<ListarTeatrosModelo> responseStream, ServerCallContext context)
        {
            List<ListarTeatrosModelo> teatro = new List<ListarTeatrosModelo>();

            foreach (var _teatro in _context.Teatros)
            {
                teatro.Add(new ListarTeatrosModelo
                {
                    Email = _teatro.Email,
                    LocalizacaoTeatro = _teatro.Localizacao,
                    Nome = _teatro.NomeTeatro,
                    Telemovel = _teatro.Telemovel,
                    Telefone = _teatro.Telefone,
                    MoradaTeatro = _teatro.MoradaTeatro
                });
            }

            foreach (var xpto in teatro)
            {
                await responseStream.WriteAsync(xpto);
            }
        }

        public override Task<ListarTeatrosModelo> GetTeatro(GetTeatroRequest request, ServerCallContext context)
        {
            var teatro = this._context.Teatros.FirstOrDefault(t => t.IdTeatro == request.Id);

            if (teatro is { })
            {
                return Task.FromResult(new ListarTeatrosModelo
                {
                    Email = teatro.Email,
                    Id = teatro.IdTeatro,
                    LocalizacaoTeatro = teatro.Localizacao,
                    MoradaTeatro = teatro.MoradaTeatro,
                    Nome = teatro.NomeTeatro,
                    Telefone = teatro.Telefone,
                    Telemovel = teatro.Telemovel
                });
            }

            return Task.FromResult<ListarTeatrosModelo>(null);
        }
    }
}