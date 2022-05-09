var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { StatusCode = 200, StatusDescription = "ok", DateTime = DateTime.Now }));
app.MapGet("/namelist", () => Results.Ok(new List<string> { { "Jose" }, { "Fernando" }, { "Maria" }, { "Betina" }, { "Everton" }, { "Salomé" }, }));

app.Run();
