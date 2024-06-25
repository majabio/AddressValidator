using AddressValidation;
using AddressValidation.Services;
using AddressValidation.Validation;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<ValidateAddressService>();
builder.Services.AddSingleton<GetAddressSchemaService>();
builder.Services.AddSingleton<IAddressFactory, AddressFactory>();
builder.Services.AddSingleton<IAddressValidator, AddressValidator>();
builder.Services.AddSingleton<JsonSchemaGenerator>();
builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
