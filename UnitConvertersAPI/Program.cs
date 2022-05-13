using Microsoft.AspNetCore.Cors.Infrastructure;
using System.Text.Json.Serialization;
using UnitConvertersService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ITemperatureService, TemperatureService>();
builder.Services.AddTransient<IWeightService, WeightService>();
builder.Services.AddTransient<ILengthService, LengthService>();
builder.Services.AddTransient<IHeightService, HeightService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("DefaultCORSPolicy", GenerateCorsPolicy());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseHttpsRedirection();
app.UseCors("DefaultCORSPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();

CorsPolicy GenerateCorsPolicy()
{
    var corsBuilder = new CorsPolicyBuilder();
    corsBuilder.SetIsOriginAllowed(_ => true);
    corsBuilder.AllowAnyHeader();
    corsBuilder.AllowAnyMethod();
    corsBuilder.AllowAnyOrigin(); // For anyone access.
    return corsBuilder.Build();
}
