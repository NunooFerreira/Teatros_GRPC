using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes;
using Sistema_de_reserva_bilhetes.Models;

namespace Sistema_de_reserva_bilhetes.Services
{
        public class AnularCompraService : AnularCompra.AnularCompraBase
        {
            private readonly ILogger<AnularCompraService> _logger;
            private readonly BaseTeatrosContext _context;

            public AnularCompraService(ILogger<AnularCompraService> logger, BaseTeatrosContext dbcontext)
            {
                _logger = logger;
                _context = dbcontext;
            }
      


        }
    
}
