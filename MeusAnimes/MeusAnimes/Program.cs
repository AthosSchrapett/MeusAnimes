using MeusAnimes.Data;
using MeusAnimes.Repositories.Implementations;
using MeusAnimes.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MeusAnimesContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("MeusAnimesConnection"),
                    b => b.MigrationsAssembly(typeof(MeusAnimesContext).Assembly.FullName)));

builder.Services.AddScoped<IAnimeRepository, AnimeRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
