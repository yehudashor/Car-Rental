namespace CarRentalWebApi.Startup;

internal static class RegisterStartupMiddlewares
{
    internal static WebApplication RegisterMiddlewares(this WebApplication webApplication)
    {
        if (webApplication.Environment.IsDevelopment())
        {
            webApplication.UseSwagger();
            webApplication.UseSwaggerUI();
            webApplication.UseDeveloperExceptionPage();
        }


        webApplication.UseHttpsRedirection();
        webApplication.UseRouting();
        webApplication.UseCors("CoresPolicy");

        webApplication.UseEndpoints((en) =>
        {
            en.MapControllers();
        });

        return webApplication;
    }
}
