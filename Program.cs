var builder = WebApplication.CreateBuilder(args); //Inicaliza uma WebApplication
builder.Services.AddRazorPages(); //Add suporte para Razor Pages

var app = builder.Build(); //Instancia criada

app.UseHttpsRedirection(); //HTTPS
app.UseStaticFiles(); //Arquivos estáticos
//wwwroot é diretório para arquivos estáticos css, js, imagens


//Auxilia no mapeamento das páginas
app.UseRouting(); // Procura a Raiz do Site Pages>Index
app.MapRazorPages(); // Mapeia as páginas Razor



app.Run(); //Executa a Aplicação
