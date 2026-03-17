using Azure;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MyVocabulary.Web;
using MyVokabulary.Repository.Data;
using System;
using System.Diagnostics.Metrics;
using Microsoft.AspNetCore.Identity;







    
    

var builder = WebApplication.CreateBuilder(args);


var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MyVocabularyContext>(options =>
                options.UseSqlServer(connection));
builder.Services.AddControllers();
builder.Services.AddHttpLogging(options => options.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.RequestProperties);
builder.Logging.AddFilter("Microsoft.AspNetCore.HttpLogging", LogLevel.Information);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddCors();
//builder.Host.ConfigureLogging(logging =>
//{
//    logging.ClearProviders();
//    logging.AddConsole();
//})
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error");
}
if (app.Environment.IsDevelopment())
{
    app.UseHttpLogging();
}
app.UseStaticFiles();
app.MapControllerRoute(name: "registration",pattern: "{controller=Home}/{action=Index}");
app.UseHttpsRedirection();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.UseDefaultFiles();
app.UseRouting();
app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader()
                           .AllowAnyMethod());





app.Run();
