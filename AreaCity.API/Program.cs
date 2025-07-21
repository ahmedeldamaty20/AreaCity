using AreaCity.Application.Handlers;
using AreaCity.Application.Interfaces;
using AreaCity.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("LogisticsService", client =>
{
	client.BaseAddress = new Uri(builder.Configuration["LogisticsServiceUrl"] ?? "http://logistics-service/api/");
});

builder.Services.AddHttpClient("CentralizationService", client =>
{
	client.BaseAddress = new Uri(builder.Configuration["CentralizationServiceUrl"] ?? "http://centralization-service/api/");
});

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAreaCityInfoQueryHandler).Assembly));

builder.Services.AddScoped<ILogisticsService, LogisticsService>();
builder.Services.AddScoped<ICentralizationService, CentralizationService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
