using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.OpenApi.Models;
using eShop.Domain.Settings;
using eShop.Persistence;
using eShop.Service.Contract;
using eShop.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using eShop.Domain.Interfaces;
using eShop.Persistence.Repositories;
using Newtonsoft.Json;
using eShop.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json.Linq;

namespace eShop.Infrastructure.Extension
{
    public static class ConfigureServiceContainer
    {
        public static void AddDbContext(this IServiceCollection serviceCollection,
             IConfiguration configuration, IConfigurationRoot configRoot)
        {
            serviceCollection.AddDbContext<appDbContext>(options => {
                options.EnableSensitiveDataLogging();
                
                options.UseNpgsql(configuration.GetConnectionString("OnionArchConn") ?? configRoot["ConnectionStrings:OnionArchConn"]
             , b => b.MigrationsAssembly(typeof(appDbContext).Assembly.FullName));
                AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            });
        }

        public static void AddAutoMapper(this IServiceCollection serviceCollection)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            serviceCollection.AddSingleton(mapper);
        }

        public static void AddScopedServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IAppDbContext>(provider => provider.GetService<appDbContext>());

            serviceCollection.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {

            serviceCollection.AddTransient<IDateTimeService, DateTimeService>();
            serviceCollection.AddTransient<IAccountService, AccountService>();
            serviceCollection.AddTransient<IRoleService, RoleService>();
           
            serviceCollection.AddTransient<ILineService, LineService>();
           
            serviceCollection.AddTransient<IDashboardService, DashboardService>();
           
            serviceCollection.AddTransient<ICameraService, CameraService>();
           


        }
        public static void AddSwaggerOpenAPI(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSwaggerGen(setupAction =>
            {

                setupAction.SwaggerDoc(
                    "OpenAPISpecification",
                    new OpenApiInfo()
                    {
                        Title = "eShop API",
                        Version = "1",
                        Description = "eShop API",
                        Contact = new OpenApiContact()
                        {
                            Email = "eShop@ryntech.com",
                            Name = "eShop.Api",
                            Url = new Uri("https://eShop@ryntech.com/")
                        },
                    });

                setupAction.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    Description = $"Input your Bearer token in this format - Bearer token to access this API",
                });
                setupAction.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer",
                            },
                        }, new List<string>()
                    },
                });
            });

        }

        public static void AddMailSetting(this IServiceCollection serviceCollection,
            IConfiguration configuration)
        {
            serviceCollection.Configure<MailSettings>(configuration.GetSection("MailSettings"));
        }

        public static void AddController(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddControllers().AddNewtonsoftJson(options =>
              options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            serviceCollection.AddControllers().AddNewtonsoftJson(options =>
     options.SerializerSettings.Converters.Add(new TimeSpanConverter()));
        }

        public class TimeSpanConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(TimeSpan);
            }

            public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
            {
                
                writer.WriteValue(value);
            }

            public override object ReadJson(JsonReader reader, Type type, object value, Newtonsoft.Json.JsonSerializer serializer)
            {

                var json = reader.Value.ToString().Split(":");
                TimeSpan span=new TimeSpan(0, Convert.ToInt32(json[0]), Convert.ToInt32(json[1]), Convert.ToInt32(json[2]), 0);
          
         
                return span;
            }
        }


        public static void AddVersion(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
        }

        public static void AddHealthCheck(this IServiceCollection serviceCollection, AppSettings appSettings, IConfiguration configuration)
        {
            // serviceCollection.AddHealthChecks()
            //     .AddDbContextCheck<appDbContext>(name: "Application DB Context", failureStatus: HealthStatus.Degraded)
            //     .AddUrlGroup(new Uri(appSettings.ApplicationDetail.ContactWebsite), name: "My personal website", failureStatus: HealthStatus.Degraded)
            //     .AddSqlServer(configuration.GetConnectionString("OnionArchConn"));
            
            serviceCollection.AddHealthChecksUI(setupSettings: setup =>
            {
                setup.AddHealthCheckEndpoint("Basic Health Check", $"/healthz");
            }).AddInMemoryStorage();
        }


    }
}
