using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;
using ServerCRUDAPI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Contexto>(opcoes =>
    opcoes.UseNpgsql(builder.Configuration.GetConnectionString("ConexaoDB"))
);

// Adiciona o serviço de CORS
builder.Services.AddCors(opcoes =>
{
    opcoes.AddPolicy("PermitirTudo", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors("PermitirTudo");

app.UseAuthorization();

app.MapControllers();
app.Run();
