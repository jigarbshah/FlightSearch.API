using BuildingBlocks.Exceptions.Handler;
using FlightSearch.API.Data;
using HealthChecks.UI.Client;
using Marten;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Configuration;

namespace FlightSearch.API;

public static class DependencyInjection
{
    public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration configuration)
    {

        services.InitializeMartenWith<FlightInitialData>();
        services.AddCarter();
        services.AddMarten(opts =>
        {
            opts.Connection(configuration.GetConnectionString("Database")!);
        }).UseLightweightSessions();
     

        services.AddExceptionHandler<CustomExceptionHandler>();
        //services.AddHealthChecks()
        //    .AddSqlServer(configuration.GetConnectionString("Database")!);

        return services;
    }

    //public static WebApplication UseApiServices(this WebApplication app)
    //{
    //    app.MapCarter();

    //    app.UseExceptionHandler(options => { });
    //    app.UseHealthChecks("/health",
    //        new HealthCheckOptions
    //        {
    //            ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
    //        });

    //    return app;
    //}
}
