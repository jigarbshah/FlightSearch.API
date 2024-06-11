using FlightSearch.Application;
using FlightSearch.Application.Queries;
using FluentValidation;
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
var assembly = typeof(Program).Assembly;
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(assembly);

});
// Add services to the container.
builder.Services
    .AddApplicationServices(builder.Configuration);

builder.Services.AddValidatorsFromAssembly(assembly);

builder.Services.AddCarter();

// Add swagger service registration.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 
// Add Refit client handler 
builder.Services.AddRefitClient<IService>()
    .ConfigureHttpClient(c =>
    {
        c.BaseAddress = new Uri(builder.Configuration["ApiSettings:GatewayAddress"]!);
    });

 
// Configure the web application.
var app = builder.Build(); 

// Add Register Swagger middleware
app.UseSwagger();
app.UseSwaggerUI();
 

// Configure the HTTP request pipeline.
app.MapCarter();

app.UseExceptionHandler(options => { });

app.Run();
