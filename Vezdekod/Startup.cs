using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Vezdekod
{
    public class Startup
    {
        ///обратиться к appsettings
        private readonly IConfiguration Configuration;
        public IHostEnvironment Environment { get; }

        ///env - все инофрмация о приложении
        public Startup(IConfiguration configuration, IHostEnvironment env)
        {
            Configuration = configuration;
            Environment = env;
        }
        /// добавление сервисов
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }
        ///подключение контролеров, порядок важен
        public void Configure(IApplicationBuilder app)
        {
            app.UseHttpsRedirection();
            if (Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}