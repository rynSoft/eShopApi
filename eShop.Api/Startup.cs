using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.FeatureManagement;
using eShop.Domain.Settings;
using eShop.Infrastructure.Extension;
using eShop.Persistence;
using eShop.Service;
using Serilog;
using System;
using System.IO;
using eShopApi.Auth;

namespace eShopApi
{
    public class Startup
    {
        private readonly IConfigurationRoot configRoot;
        private AppSettings AppSettings { get; set; }

        public Startup(IConfiguration configuration)
        {
            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration)
                .WriteTo.File(@"C:\logs\log.txt",rollingInterval : RollingInterval.Hour)
                .WriteTo.Debug()
                .CreateLogger();
            Configuration = configuration;

            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            configRoot = builder.Build();

            AppSettings = new AppSettings();
            Configuration.Bind(AppSettings);
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddController();

            services.AddDbContext(Configuration, configRoot);

            services.AddIdentityService(Configuration);
            services.AddMemoryCache();
            services.AddAutoMapper();
            services.AddMemoryCache(x => { });

            services.AddScopedServices();

            services.AddTransientServices();

            services.AddSwaggerOpenAPI();

            //services.AddMailSetting(Configuration);

            services.AddServiceLayer();

            services.AddVersion();

            //services.AddHealthCheck(AppSettings, Configuration);

            services.AddFeatureManagement();
            
            services.AddScoped<YetkiDenetimi>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory log)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options =>
                 options
                     .AllowAnyOrigin()
                 .AllowAnyHeader()
                 .AllowAnyMethod());

            app.ConfigureCustomExceptionMiddleware();

            log.AddSerilog();

            //app.ConfigureHealthCheck();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();
            app.ConfigureSwagger();
            //app.UseHealthChecks("/healthz", new HealthCheckOptions
            //{
            //    Predicate = _ => true,
            //    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse,
            //    ResultStatusCodes =
            //    {
            //        [HealthStatus.Healthy] = StatusCodes.Status200OK,
            //        [HealthStatus.Degraded] = StatusCodes.Status500InternalServerError,
            //        [HealthStatus.Unhealthy] = StatusCodes.Status503ServiceUnavailable,
            //    },
            //}).UseHealthChecksUI(setup =>
            //  {
            //      setup.ApiPath = "/healthcheck";
            //      setup.UIPath = "/healthcheck-ui";
            //      //setup.AddCustomStylesheet("Customization/custom.css");
            //  });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
