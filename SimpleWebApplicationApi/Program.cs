using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SimpleWebApplication.Infrastructure.Data;
using SimpleWebApplication.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers().AddNewtonsoftJson(v => v.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddDbContext<ApiContext>(v=> { v.UseInMemoryDatabase("CompanyDB");});
builder.Services.AddCors();



var app = builder.Build();
app.UseCors(v => {  v.AllowAnyMethod(); v.AllowAnyOrigin(); }) ;
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<ApiContext>();
    
    context.Seed();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/Company", (ApiContext apiContext, IMapper mapper) =>
{
    return mapper.Map<List<CompanyViewModel>>(apiContext.GetCompanies());
})
.WithName("GetCompanies")
.WithOpenApi();

app.MapGet("/Company/{id}", (int id,ApiContext apiContext, IMapper mapper) =>
{
    return apiContext.GetCompanyById(id);
})
.WithName("GetCompaniesById")
.WithOpenApi();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
