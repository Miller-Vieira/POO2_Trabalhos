namespace AtacadoConsole;

using Atacado.DB.EF.Database;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    { 
        string conn = "Data Source=.\\sqlexpress;Initial Catalog=BdAtacado;User=usrAtacado;Password=123;TrustServerCertificate=True;";
        var options = new DbContextOptionsBuilder<AtacadoContext>().UseSqlServer(conn).Options;
        var contexto = new AtacadoContext(options);
        Console.WriteLine("Executando pesquisa...");
        foreach (Cidade item in contexto.Cidades)
        {
            Console.WriteLine($"{item.CodigoCidade} - {item.Nome} - {item.CodigoIBGE7} - {item.CodigoEstado}");
        }
        Console.WriteLine("Fim do programa");
        Console.ReadLine();
    }
}

