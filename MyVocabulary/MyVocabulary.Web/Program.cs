using Microsoft.AspNetCore.Hosting.Server;
using MyVocabulary.Web;
using System.Diagnostics.Metrics;


var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();
app.MapPost("entry2", (context) =>
{
    var form = context.Request.Form;
    string russianWord = form["russianWord"];
    string englishWord = form["englishWord"];
    DataBase.PostToBase(englishWord,russianWord);
    var response2 = context.Response;
    response2.ContentType = "text/plain; charset=utf-8";
    response2.WriteAsync($"{russianWord},{englishWord}");
    return Task.CompletedTask;
});
app.Run();
//Server = localhost; Database = master; Trusted_Connection = True;
//MSSQLSERVER