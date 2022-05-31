using Kingpay.DepositOrchestratorService.Core;
using Kingpay.DepositOrchestratorService.Facade;
using Kingpay.DepositOrchestratorService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ITenantService, TenantService>();
builder.Services.AddScoped<IDepositFacadeFactory, DepositFacadeFactory>();
builder.Services.AddScoped<IDepositService, DepositService>();
builder.Services.AddScoped<IDepositFacade, BaseFacade>();
builder.Services.AddScoped<IDepositFacade, DepositFacade>();
builder.Services.AddScoped<IDepositFacade, CardDepositFacade>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

builder.Services.Configure<TenantSettings>(app.Configuration.GetSection(nameof(TenantSettings)));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseAuthorization();

app.MapControllers();

app.Run();
