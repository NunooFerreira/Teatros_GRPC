using Grpc.Core;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace Sistema_de_reserva_bilhetes
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        private IConfiguration Configuration;
        SqlDataReader reader = null;
        SqlConnection connection = null;

        public GreeterService(ILogger<GreeterService> logger, IConfiguration _configuration)
        {
            _logger = logger;
            Configuration = _configuration;


            // variavel que fica com a string para a conexao com a bd
            connection = new SqlConnection(this.Configuration.GetConnectionString("BaseTeatros"));
        }

        

       
    }
}
