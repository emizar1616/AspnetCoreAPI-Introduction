using AspnetCoreAPI_Introduction.Data;
using AspnetCoreAPI_Introduction.Interfaces;
using AspnetCoreAPI_Introduction.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CityDbContext>(
        options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ConnStr")
    ));

builder.Services.AddScoped<ICityRepository,CityRepository>();

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
