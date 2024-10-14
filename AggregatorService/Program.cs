using AggregatorService.Application.Interfaces;
using System.Security.Principal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton(typeof(ILogger),typeof(Logger<Program>));
builder.Services.AddTransient<IPrincipal>(provider=>provider.GetService<IHttpContextAccessor>().HttpContext?.User);
builder.Services.AddTransient<IApiService, ApiService>();
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
