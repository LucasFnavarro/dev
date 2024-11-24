var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! C# é bom dimais!!");

app.MapGet("/nome/{nome}", (string nome) => {
    return Results.Ok($"Hello {nome}");
});

app.MapGet("/somar/{v1}/{v2}", (int v1, int v2) => {
    return Results.Ok($"A soma é {v1 + v2}");
});

app.MapPost("/user", (User user) => {
    return Results.Ok(user);
});

app.MapGet("/return", () => {
    return "Hello World, C# é muito bom!!!";
});

app.Run();

public class User {
    public int Id { get; set; }
    public string? Username { get; set; }
    public string? Cargo { get; set; }
}