using interplanetary_delivery_simulator.Data;
using interplanetary_delivery_simulator.planetary_resources.Configuration;
using interplanetary_delivery_simulator.planetary_resources.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("LunarLogisticsDb");
builder.Services.AddDbContext<LunarLogisticsDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHostedService<PlanetConfiguration>();
builder.Services.AddScoped<IPlanetService, PlanetService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();