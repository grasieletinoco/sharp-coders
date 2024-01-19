using System;

public class Program {
  public static void Main() {

    // Primeira  Solução
    /*
    int n = int.Parse(Console.ReadLine());

    // a % b = Resto de A divido por B
    for(int val = 1; val <= 10000; val++) {
      if(val%n == 2) {
        Console.WriteLine(val);
      }
    }
    */


    // Segunda Solução
    int n = int.Parse(Console.ReadLine());
    // n = 1 -> nao existe
    // n = 2 -> nao existe
    // n = 3 -> 2 eh primeiro
    // n > 3 -> 2 eh primeiro
    // n = 4 -> 2, 6, 10, 14

    if(n <= 2) {
      return;
    }
    
    for(int i = 2; i <= 10000; i += n) {
      Console.WriteLine(i);
    }

  }
}
