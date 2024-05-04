using GameStore.Api.Endpoints;
using GameStore.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IGamesRepository, InMemoryGamesRepository>();

var app = builder.Build();

app.MapGamesEndpoints();

app.Run();