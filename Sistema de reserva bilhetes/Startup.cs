﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Sistema_de_reserva_bilhetes.Data;
using Sistema_de_reserva_bilhetes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_reserva_bilhetes
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc();

            services.AddDbContext<BaseTeatrosContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("BaseTeatrosContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<GreeterService>();

                endpoints.MapGrpcService<AdicionarEspetaculoService>();

                endpoints.MapGrpcService<AdicionarSessaoService>();

                endpoints.MapGrpcService<AdicionarTeatroService>();

                endpoints.MapGrpcService<CompraService>();

                endpoints.MapGrpcService<CriarLoginService>();

                endpoints.MapGrpcService<RegistarEspetaculoService>();

                endpoints.MapGrpcService<TipoUtilizadorService>();

                endpoints.MapGrpcService<AdicionarUtilizadorService>();

                endpoints.MapGrpcService<ReservaService>();

                endpoints.MapGrpcService<FundosService>();

                endpoints.MapGrpcService<AnularCompraService>();

                endpoints.MapGrpcService<CarregarRegistoService>();

                endpoints.MapGrpcService<ClientesService>();

                endpoints.MapGrpcService<ListarUtilizadoresService>();

                endpoints.MapGrpcService<ListarTeatrosService>();

                endpoints.MapGrpcService<ListarCompraBilheteService>();

                endpoints.MapGrpcService<ListarSessaoService>();

                endpoints.MapGrpcService<ListarReservaService>();

                endpoints.MapGrpcService<ListarEspetaculoService>();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
                });
            });
        }
    }
}
