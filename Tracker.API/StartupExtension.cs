using Microsoft.OpenApi.Models;
using Tracker.Persistence;

namespace Tracker.API;

public static class StartupExtension
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        AddSwagger(builder);

        builder.Services.AddPersistenceService(builder.Configuration);
        
        builder.Services.AddControllers();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("Open",
                policyBuilder => { policyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); });
        });

        return builder.Build();
    }

    private static void AddSwagger(WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo()
            {
                Version = "v1",
                Title = "Project Tracker API"
            });
        });
    }

    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options => { options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"); });
        }

        app.UseHttpsRedirection();

        app.UseCors("Open");

        app.MapControllers();

        return app;
    }
}