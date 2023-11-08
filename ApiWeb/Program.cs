using Microsoft.EntityFrameworkCore;
using Stock.Repositories.Context;
using System.Configuration;
using Stock.Presenters;
using Stock.UsesCases;
using Stock.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddServicesPresenter();
builder.Services.AddServicesUseCases();
builder.Services.AddServicesRepositories();
builder.Services.AddDbContext<Controlstock1Context>(options =>
            options.UseMySQL());

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
