using CarRentalWebApi.Startup;

WebApplication.CreateBuilder(args)
   .RegisterServices()
   .Build()
   .RegisterMiddlewares()
   .Run();


