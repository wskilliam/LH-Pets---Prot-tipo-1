using LH_PETS;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Projeto Web - HL PETS Versão 1");

Banco banco = new Banco();
app.MapGet("/listaClientes", (HttpContext context) => {
    context.Response.WriteAsync(banco.GetListaString());
});

app.MapGet("/index", (HttpContext context) => {
    context.Response.Redirect("index.html", false);
});

app.UseStaticFiles();
app.Run();
