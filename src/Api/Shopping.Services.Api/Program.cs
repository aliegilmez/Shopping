using Atlas.Services.Api.Extensions;
using Shopping.Services.Application.Bootstrap;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddApiVersioning(config =>
            {
                // Specify the default API Version as 1.0
                config.DefaultApiVersion = new ApiVersion(1, 0);
                // If the client hasn't specified the API version in the request, use the default API version number 
                config.AssumeDefaultVersionWhenUnspecified = true;
                // Advertise the API versions supported for the particular endpoint
                config.ReportApiVersions = true;
                // HTTP Header based versioning
                //config.ApiVersionReader = new HeaderApiVersionReader("x-api-version");
                // Combine versioning
                //config.ApiVersionReader = ApiVersionReader.Combine(new HeaderApiVersionReader("x-api-version"), new QueryStringApiVersionReader("api-version"));
            });

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddShoppingDependencies(builder.Configuration);
builder.Services.AddDependencyServiceUtilities();
builder.Services.AddApplication();

var app = builder.Build();

// Configure the HTTP request pipeline.

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
