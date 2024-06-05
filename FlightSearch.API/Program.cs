using BuildingBlocks.Behaviors;
using BuildingBlocks.Exceptions.Handler;
using FlightSearch.API.Data;
using FlightSearch.Application;
using FlightSearch.Infrastructure;
using FluentValidation;
using Marten;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
var assembly = typeof(Program).Assembly;
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(assembly);
    //config.AddOpenBehavior(typeof(ValidationBehavior<,>));
    //config.AddOpenBehavior(typeof(LoggingBehavior<,>));
});
// Add services to the container.
builder.Services
    .AddApplicationServices(builder.Configuration)
    .AddInfrastructureServices(builder.Configuration);

builder.Services.AddValidatorsFromAssembly(assembly);

builder.Services.AddCarter();

builder.Services.AddMarten(opts =>
{
    //opts.Connection(builder.Configuration.GetConnectionString("Database")!);
}).UseLightweightSessions();

////if (builder.Environment.IsDevelopment())
//    builder.Services.InitializeMartenWith<FlightInitialData>();

//builder.Services.AddExceptionHandler<CustomExceptionHandler>();
 
var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapCarter();

app.UseExceptionHandler(options => { });
 

app.Run();
