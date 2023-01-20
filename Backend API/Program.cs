using Backend_API;
using Backend_API.Interfaces;
using Backend_API.Services;
using BeatSaverScraper.Extensions;
using BeatSaverScraper.Interfaces;
using MapConverter.Extensions;
using Persistence.Extensions;

/*
 * docker run --name postgres-db -e POSTGRES_PASSWORD=docker -p 5432:5432 -d postgres
 */

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddPersistence(builder.Configuration.GetConnectionString("Default"));

builder.Services.AddScoped<ISectionService, SectionService>();

builder.Services.AddSingleton<Constants>();
builder.Services.AddSingleton<IConstantsBeatSaverScraper>(provider => provider.GetRequiredService<Constants>());
builder.Services.AddBeatSaverScraper();
builder.Services.AddMapConverter();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(options =>
{
    options.AllowAnyOrigin();
    options.AllowAnyHeader();
    options.AllowAnyMethod();
});
app.MapControllers();

app.Run();