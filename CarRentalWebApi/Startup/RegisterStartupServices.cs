using CarRentalComposition.RegisterServicesExtensions;
using Microsoft.AspNetCore.Authentication.Certificate;

namespace CarRentalWebApi.Startup;

internal static class RegisterStartupServices
{
    internal static WebApplicationBuilder RegisterServices(this WebApplicationBuilder webApplicationBuilder)
    {
        webApplicationBuilder.Host.RegisterHostBuilder();
        webApplicationBuilder.Services.AddAuthentication(
                CertificateAuthenticationDefaults.AuthenticationScheme)
                .AddCertificate();

        webApplicationBuilder.Services.AddControllers();
        webApplicationBuilder.Services.AddEndpointsApiExplorer();
        webApplicationBuilder.Services.AddRouting();
        webApplicationBuilder.Services.AddSwaggerGen();

        return webApplicationBuilder;
    }
}
