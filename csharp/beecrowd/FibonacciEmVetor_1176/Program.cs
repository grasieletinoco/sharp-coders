namespace FibonacciEmVetor_1176;

public class Program
{
  static void Main(string[] args)
  {

    ulong[] fib = new ulong[70];
    int nTestes = int.Parse(Console.ReadLine());

    // Valores Iniciais
    fib[0] = 0;
    fib[1] = 1;

    for (int _ = 0; _ < nTestes; _++)
    {

      int n = int.Parse(Console.ReadLine());

      // TODO: Melhorar percorrendo apenas os Valores ainda nao Calculados
      for(int i = 2; i <= n; i++) {
        fib[i] = fib[i-1] + fib[i-2];
      }

      Console.WriteLine($"Fib({n}) = {fib[n]}");
    }

  }
}
