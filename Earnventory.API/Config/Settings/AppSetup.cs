using System;
using System.Text;
using AutoMapper;
using Earnventory.Domain.Mapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ReflectionIT.Mvc.Paging;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Earnventory.API.Config.Settings
{
    public static class AppSetup
    { 
        public static void AddAppServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddVersionedApiExplorer(options => options.GroupNameFormat = "'v'VVV");
            
            services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.ReportApiVersions = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
            });
            
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigurationSwaggerOptions>();

            //paging
            services.AddPaging(options =>
            {
                options.PageParameterName = "page";
                options.DefaultNumberOfPagesToShow = 10;
            });
            //swagger gen
            services.AddSwaggerGen();
            
            //api key settings
            var apiKeySettingsSection = configuration.GetSection("ApiKeySettings");
            var apiKeySettings = apiKeySettingsSection.Get<ApiKeySettings>();

            services.Configure<ApiKeySettings>(apiKeySettingsSection);
            var key = Encoding.ASCII.GetBytes(apiKeySettings.Secret);

            services.AddAuthentication(u =>
            {
                u.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                u.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });
        }


        public static void UseAppConfiguration(this IApplicationBuilder app, IApiVersionDescriptionProvider provider)
        {
            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                options.DefaultModelsExpandDepth(-1);
                foreach (var desc in provider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint($"./swagger/{desc.GroupName}/swagger.json",
                        desc.GroupName.ToUpperInvariant());
                }

                options.RoutePrefix = "";
            });
        }
    }
}
