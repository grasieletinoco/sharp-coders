// file-scoped namespace
namespace HelloWorld;

public class Program
{

    // Funcão Principal - Ponto de Entrada - entrypoint
    public static void Main()
    {
        // variaveis
        int a = 2;
        long l = 43;
        long x = 43l;

        float f = 2.3f;
        double d = 2;

        long inteiroLongo = 3L;
        int longo = (int)inteiroLongo;

        string name = "Hugo Rafael";

        Console.WriteLine(double.MaxValue);
        Console.WriteLine(double.MinValue);

        Console.Write("Digite Alguma Coisa para Ser Lida: ");
        var leitura = Console.ReadLine();

        Console.WriteLine(leitura);

        var primeiroNumero = int.Parse(Console.ReadLine());
        var segundoNumero = Console.ReadLine();

        Console.WriteLine(primeiroNumero + segundoNumero);

        // Seleção/Condicionais
        // Repetição
        // Funções
    }

}