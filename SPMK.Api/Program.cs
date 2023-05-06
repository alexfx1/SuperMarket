using SPMK.Infra.DbConfig;
using Microsoft.EntityFrameworkCore;
using SPMK.Infra.IoC;
using SPMK.Infra.DataBase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration
    .AddJsonFile("appsettings.json", true)
    .AddJsonFile("appsettings.{environment}.json", true)
    .AddEnvironmentVariables()
    .Build();

//[INFRA]
builder.Services.AddDbConfig(builder.Configuration);
builder.Services.AddScoped<DbContext, SpmkContext>();
builder.Services.AddRepositoriesIoC();
builder.Services.AddServicesIoC();

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
