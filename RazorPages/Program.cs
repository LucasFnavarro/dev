var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages(); // Adicionando suporte para RazorPages.

var app = builder.Build();

app.UseHttpsRedirection(); // Para não dar erros 404, pois estamos rodando uma app HTTPs ecessando via HTTP.
app.UseStaticFiles(); // Para acessarmos arquivos estáticos da wwwroot (css, images, js, json)...

app.UseRouting(); // Auxilia no mapeamento das páginas, para criar URLs customizadas
app.MapRazorPages(); // Mapea as pages

app.Run();
