using FluentValidation;
using FluentValidation.AspNetCore;
using SubscriptionManager.API.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(oprions =>
{
    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    oprions.IncludeXmlComments(xmlPath);
});

builder.Services.AddValidatorsFromAssemblyContaining<PeopleValidator>();

app.UseAuthorization();

app.MapControllers();

app.Run();
