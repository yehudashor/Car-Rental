using CarRentalWebApi.Startup;

WebApplication.CreateBuilder(args).WebHost.
   .RegisterServices()
   .Build()
   .RegisterMiddlewares()
   .Run();


