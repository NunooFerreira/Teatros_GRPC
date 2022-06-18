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
    public class ListarEspetaculoService : ListarEspetaculo.ListarEspetaculoBase
    {
        private readonly ILogger<ListarEspetaculoService> _logger;
        private readonly BaseTeatrosContext _context;

        public ListarEspetaculoService(ILogger<ListarEspetaculoService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }

        public override async Task GetListarEspetaculo(ListarEspetaculoVerModelo request,
           IServerStreamWriter<ListarEspetaculoModelo> responseStream, ServerCallContext context)
        {
            var espetaculo = new ListarEspetaculoModelo();
            foreach (var i in _context.Espetaculos)
            {
                espetaculo.Nome = i.Nome;
                espetaculo.DataInicio = Convert.ToString(i.DataInicio);
                espetaculo.DataFim = Convert.ToString(i.DataFim);
                espetaculo.Money = Convert.ToDouble(i.Preco);
                espetaculo.Sinopse = i.Sinopse;
                espetaculo.Id = i.IdEspetaculo;

                await Task.Delay(10);
                await responseStream.WriteAsync(espetaculo);
            }
        }
    }
}