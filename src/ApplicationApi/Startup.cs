using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    //Services the class with a functions where services are added to the container
    //This is the method where services are registered for dependency injection.
    public void ConfigureServices(IServiceCollection services)
    {
        // Register services here This line registers the MVC controller services.
        services.AddControllers();
    }
    //Middleware this is where the requests are handled
    //this method gets called by the runtime ut uses this method to configure the http request pipelines
    //
    public void Configure(IApplicationBuilder app)
    {
        // Configure middleware here
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapDefaultControllerRoute();
        });
    }
}