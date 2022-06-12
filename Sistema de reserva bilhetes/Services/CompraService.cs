using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes;
using Sistema_de_reserva_bilhetes.Models;

namespace Sistema_de_reserva_bilhetes.Services
{
    public class CompraService: Compra.CompraBase
    {
        private readonly ILogger<CompraService> _logger;
        private readonly BaseTeatrosContext _context;

        public CompraService(ILogger<CompraService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }
        public override Task<CompraModelo> GetNovaCompra(CompraVerModelo request, ServerCallContext context)
        {
            var compra = new ComprarBilhete();

            compra.IdReserva = request.Idreserva;
            compra.IdUtilizador = request.Idutilizador;
            compra.TotalPagar = request.TotalPagar;
            compra.ReferenciaPagamento = request.Referencia;

            _context.Add(compra);
            _context.SaveChangesAsync();
            return Task.FromResult(new CompraModelo
            {
                Feedback = "Bilhete Comprado com Sucesso!"
            });
        }
    }
}
