using CarRentalComposition.RegisterServicesExtensions;
using Microsoft.AspNetCore.Authentication.Certificate;

namespace CarRentalWebApi.Startup;

internal static class RegisterStartupServices
{
    internal static WebApplicationBuilder RegisterServices(this WebApplicationBuilder appBuilder)
    {
        appBuilder.Host.RegisterHostBuilder();
        appBuilder.Services.RegisterServicesCollection();
        appBuilder.Services.AddAuthentication(
                CertificateAuthenticationDefaults.AuthenticationScheme)
                .AddCertificate();

        appBuilder.Services.AddControllers();

        appBuilder.Services.AddCors(options =>
        {
            options.AddPolicy("CoresPolicy",
                builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        });

        appBuilder.Services.AddEndpointsApiExplorer();
        appBuilder.Services.AddRouting();
        appBuilder.Services.AddSwaggerGen();

        return appBuilder;
    }
}
