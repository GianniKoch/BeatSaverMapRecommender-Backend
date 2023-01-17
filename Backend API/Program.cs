using Backend_API;
using Backend_API.Interfaces;
using Backend_API.Services;
using BeatSaverScraper.Extensions;
using BeatSaverScraper.Interfaces;
using MapConverter.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ISectionService, SectionService>();

builder.Services.AddSingleton<Constants>();
builder.Services.AddSingleton<IConstantsBeatSaverScraper>(provider => provider.GetRequiredService<Constants>());
builder.Services.AddBeatSaverScraper();
builder.Services.AddMapConverter();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();