using Grpc.Core;
using System;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Sistema_de_reserva_bilhetes.Data;



namespace Sistema_de_reserva_bilhetes.Services
{
    public class CriarLoginService : CriarLogin.CriarLoginBase
    {
        private readonly ILogger<CriarLoginService> _logger;
        private readonly BaseTeatrosContext _context;

        public CriarLoginService(ILogger<CriarLoginService> logger, BaseTeatrosContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }

        public override Task<CriarModeloLogin> GetLogin(ModeloLogin request, ServerCallContext context)
        {
            var uti = new CriarModeloLogin();
            foreach (var i in _context.Utilizadors)
            {
                if ((request.User == i.Username) && (request.Password == i.Pass))
                {
                 
                    uti.Sucesso = 0;
                    uti.UtilizadorTipo = (int)i.Tipoutilizador;
                    uti.Feedback = "Sucesso";

                    return Task.FromResult(uti);

                }
            }

            return Task.FromResult(new CriarModeloLogin
            {
                Sucesso = 0,
                UtilizadorTipo = 1,
                Feedback = "sucesso"
            }
            ); ;
        }
    }
}
