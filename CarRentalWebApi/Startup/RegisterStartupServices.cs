using Microsoft.AspNetCore.Authentication.Certificate;

namespace CarRentalWebApi.Startup;

internal static class RegisterStartupServices
{
    internal static WebApplicationBuilder RegisterServices(this WebApplicationBuilder webApplicationBuilder)
    {
        //להוסיף את פונקציית הרחבה של הפרויקט שנוסיף 
        // Add services to the container.
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
