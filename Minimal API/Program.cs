using InstantAPIs;
using Microsoft.EntityFrameworkCore;
using Minimal_API.Data.DbContexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInstantAPIs();

builder.Services.AddDbContext<LibraryContext>(ops=> ops.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();

app.MapInstantAPIs<LibraryContext>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.Run();

