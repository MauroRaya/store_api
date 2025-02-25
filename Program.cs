using System.Reflection;
using Microsoft.EntityFrameworkCore;
using store_api.Domain.Repositories;
using store_api.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ReadDbContext>(options =>
    options.UseSqlite("Data Source=Infrastructure/read_database.db"));

builder.Services.AddDbContext<WriteDbContext>(options =>
    options.UseSqlite("Data Source=Infrastructure/write_database.db"));

builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.MapGet("api/ping", () => "pong");

app.Run();