using Azure;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyVocabulary.Web;
using MyVokabulary.Repository.Data;
using System;
using System.Diagnostics.Metrics;




var serviceCollection = new ServiceCollection();


DatabaseCreator.CreateDataBase();
    
    

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var myAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors();

var connection = builder.Configuration.GetConnectionString("DefaultConnection");

//builder.Host.ConfigureLogging(logging =>
//{
//    logging.ClearProviders();
//    logging.AddConsole();
//})
builder.Services.AddDbContext<MyVocabularyContext>(options =>
                options.UseSqlServer(connection));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//app.MapControllerRoute(
//    name: "registration",
//    pattern: "{controller=Registration}/{action=Register}");


app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI();

app.UseDefaultFiles();
app.UseRouting();

app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader()
                            .AllowAnyMethod());

app.UseStaticFiles();
app.MapPost("entry2", (context) =>
{
    var form = context.Request.Form;
    string russianWord = form["russianWord"];
    string englishWord = form["englishWord"];

    DataBase.PostToBase(englishWord,russianWord);
    var response2 = context.Response;
    response2.ContentType = "text/plain; charset=utf-8";
    response2.WriteAsync("������ ���������");
    return Task.CompletedTask;
});
app.MapGet("search", (context) =>
{
    var query = context.Request.Query;
    string wordOfSearch = query["wordOfSearch"];
    var dataBaseString = DataBase.GetFromBase(wordOfSearch);
    var response2 = context.Response;
    response2.ContentType = "text/plain; charset=utf-8";
    response2.WriteAsync($"{dataBaseString.RussianWord},{dataBaseString.EnglishWord}");
    return Task.CompletedTask;
});
app.MapPost("examination", (context) =>
{
    var form = context.Request.Form;
    string selectedValue = form["word"];
    string translationGiwenWord = form["translationGiwenWord"];
    var response2 = context.Response;
    if (selectedValue == translationGiwenWord)
    {
        response2.ContentType = "text/html; charset=utf-8";
        response2.WriteAsync("<meta http-equiv=\"refresh\" content=\"2; url=/Exercise\"><h2>�����!</h2>");
    }
    else 
    {
        response2.ContentType = "text/html; charset=utf-8";
        response2.WriteAsync("<meta http-equiv=\"refresh\" content=\"2; url=/Exercise\"><h2>�� �����!</h2>");
    }
    return Task.CompletedTask;

});
app.Run();
