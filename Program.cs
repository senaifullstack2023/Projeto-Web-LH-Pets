namespace Projeto_WEB;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Projeto WEb - LH Pets Versão 1");

        app.Run();
    }
}
