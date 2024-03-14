using AutoManager.Api.Repository.Abstraction.Interfaces;
using AutoManager.Api.Services.Abstractions.Interfaces;
using AutoManager.Connection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ICnhService>();
builder.Services.AddSingleton<IModelService>();
builder.Services.AddSingleton<IRentedService>();
builder.Services.AddSingleton<IUserService>();
builder.Services.AddSingleton<IVehicleService>();
builder.Services.AddSingleton<IVehicleRepository>();

builder.Services.AddSingleton<ConnectionEF>();
builder.Services.AddDbContext<ConnectionEF>( options => { options.UseMongoDB });

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
