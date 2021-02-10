using System;
using Earnventory.API.Config.Settings;
using Earnventory.API.Utils;
using Earnventory.Domain.Context;
using Earnventory.Domain.Utils;
using Earnventory.Services.Utils;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Earnventory.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //register services
            services.RegisterDomainServices();
            services.RegisterAppRepoServices();
            
            services.AddAppServices(Configuration);
            
            var herokuDbConnectionString =  Environment.GetEnvironmentVariable("MARIA_URL");
            var localDbConnectionString =  Configuration.GetConnectionString("DefaultConnection");
            
            services.AddCors(options =>
            {
                options.AddPolicy(AppConstants.MyAllowedSpecificOrigins,
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                    });
            });

            services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(
                herokuDbConnectionString ?? localDbConnectionString,
                ServerVersion.AutoDetect(herokuDbConnectionString ?? localDbConnectionString)
            ));
             
            
            services.AddControllers().AddFluentValidation().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAppConfiguration(provider);
            
            app.UseHttpsRedirection();

            app.UseRouting();
            
            app.UseCors(AppConstants.MyAllowedSpecificOrigins);
            
            //app.UseMiddleware<JwtMiddleware>();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}