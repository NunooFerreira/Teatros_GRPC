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
    public class ListarEspetaculoService: ListarEspetaculo.ListarEspetaculoBase
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
            var teatro = new ListarEspetaculoModelo();
            foreach (var i in _context.Espetaculos)
            {
                teatro.Nome = i.Nome;
                teatro.DataInicio = Convert.ToString(i.DataInicio);
                teatro.DataFim = Convert.ToString(i.DataFim);
                teatro.Money = Convert.ToDouble(i.Preco);
                teatro.Sinopse = i.Sinopse;

                await Task.Delay(10);
                await responseStream.WriteAsync(teatro);


            }
        }
    }
}
