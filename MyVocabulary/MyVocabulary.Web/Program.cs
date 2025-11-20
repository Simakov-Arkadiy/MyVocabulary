var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();
app.MapPost("entry2", (context) =>
{
    var form = context.Request.Form;
    string russianWord = form["russianWord"];
    string englishWord = form["englishWord"];
     context.Response.WriteAsync($"{russianWord},{englishWord}");
    return Task.CompletedTask;
});
app.Run();
