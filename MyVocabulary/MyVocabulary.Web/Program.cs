using Microsoft.AspNetCore.Hosting.Server;
using MyVocabulary.Web;
using System.Diagnostics.Metrics;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages(); 
app.MapPost("entry2", (context) =>
{
    var form = context.Request.Form;
    string russianWord = form["russianWord"];
    string englishWord = form["englishWord"];
    DataBase.PostToBase(englishWord,russianWord);
    var response2 = context.Response;
    response2.ContentType = "text/plain; charset=utf-8";
    response2.WriteAsync("строка добавлена");
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
app.Run();
