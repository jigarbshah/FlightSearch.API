using BuildingBlocks.Exceptions.Handler;
using Marten;

namespace FlightSearch.API;

public static class DependencyInjection
{
    public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration configuration)
    {

        //services.InitializeMartenWith<FlightInitialData>();
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
