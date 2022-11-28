using Microsoft.AspNetCore.HttpOverrides;
using MotorcycleCompany.Extensions;
using NLog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
builder.Services.ConfigureCors();
builder.Services.configureIISIntegratio();
builder.Services.ConfigureLoggerService();

builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.Configuremysqlcontext(builder.Configuration);
builder.Services.AddControllers().AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//app.UseStaticFiles();

//app.UseForwardedHeaders(new ForwardedHeadersOptions()
//{
//    ForwardedHeaders = ForwardedHeaders.All
//});

//app.UseCors("CorsPolicy");


//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hola desde el middleware personalizado");

//app.Use(async (context, next) =>
//{
//    Console.WriteLine($"Hola desde el middleware personalizado");
//    await next.Invoke();
//    Console.WriteLine($"Hola desde el middleware personalizado");
//});

app.MapControllers();

app.Run();
