using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Finaldayexam.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FinaldayexamContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FinaldayexamContext") ?? throw new InvalidOperationException("Connection string 'FinaldayexamContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
app.Run();
