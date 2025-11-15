using Microsoft.OpenApi.Models;

namespace BackendAwSmartstay.API.Shared.Infrastructure.Documentation.OpenApi.Configuration.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static void AddOpenApiConfigurationServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApi();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "SmartStay Platform API",
                    Version = "v1",
                    Description = "Hotel Management System API - Accommodations, Bookings and Payments",
                    TermsOfService = new Uri("https://smartstay.com/tos"),
                    Contact = new OpenApiContact
                    {
                        Name = "SmartStay",
                        Email = "contact@smartstay.com"
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Apache 2.0",
                        Url = new Uri("https://www.apache.org/licenses/LICENSE-2.0.html")
                    }
                });
            options.EnableAnnotations();
        });
    }
}

