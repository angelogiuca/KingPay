using Kingpay.DepositOrchestrator.Facade.Implementations;
using Kingpay.DepositOrchestrator.Facade.Interfaces;
using Kingpay.DepositOrchestrator.Services.Implementations;
using Kingpay.DepositOrchestrator.Services.Interfaces;
using Kingpay.DepositOrchestratorService.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddScoped<IDepositFacadeFactory, DepositFacadeFactory>()
    .AddScoped<IDepositFacade, CardDepositFacade>()
    .AddScoped<IDepositFacade, MoMoDepositFacade>()
    .AddScoped<IDepositFacade, OfflineDepositFacade>()
    .AddScoped<IDepositService, DepositService>()
    .AddGrpc();


var app = builder.Build();

app.MapGrpcService<DepositOrchestratorController>();

app.MapGet("/getdeposit", () => "haqq alla"        
);

//app.MapPost("/initiatedeposit",
//            async ([FromServices] IDepositFacadeFactory factory, InitiateDepositRequest req) =>
//            await factory.GetFacade(req.Instrument, req.PaymentMethod).InitiateDepositAsync(req)
//);


app.Run();
