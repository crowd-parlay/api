using CrowdParlay.Api.Routing.ParameterTransformers;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
    // Use kebab-case routing convention
    options.Conventions.Add(
        new RouteTokenTransformerConvention(
            new KebabCaseParameterTransformer())));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();