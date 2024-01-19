using System;

public class Program {

  public static void Main() {

    // Primeira Solução
    /*
    string[] entradas = Console.ReadLine().Split(' ');
    int a =int.Parse(entradas[0]);
    int b =int.Parse(entradas[1]);
    int c =int.Parse(entradas[2]);

    int menor, meio, maior;

    if(a < b && a < c){
      Console.WriteLine(a);

      if(b < c) {// a < b < c
        Console.WriteLine(b);
        Console.WriteLine(c);
      } else { // a < c < b
        Console.WriteLine(c);
        Console.WriteLine(b);
      }
    } else if (b < a && b < c){ 
      Console.WriteLine(b);

      if(a < c) { // b < a < c
        Console.WriteLine(a);
        Console.WriteLine(c);
      } else {
        Console.WriteLine(c);
        Console.WriteLine(a);
      }
    } else {
      Console.WriteLine(c);

      if(a < b) { // c < a < b
        Console.WriteLine(a);
        Console.WriteLine(b);
      } else { // c < b < a
        Console.WriteLine(b);
        Console.WriteLine(a);
      }
    }

    Console.WriteLine();
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    */



    // Segunda Solução Sort Simples com min e max
    /*
    string[] entradas = Console.ReadLine().Split(' ');
    int a =int.Parse(entradas[0]);
    int b =int.Parse(entradas[1]);
    int c =int.Parse(entradas[2]);

    int menor = Math.Min(Math.Min(a, b), c);
    int maior = Math.Max(Math.Max(a, b), c);
    int meio;

    if(a != menor && a != maior)
      meio = a;
    else if(b != menor && b != maior)
      meio = b
    else 
      meio = c;

    Console.WriteLine(menor);
    Console.WriteLine(meio);
    Console.WriteLine(maior);
    Console.WriteLine();
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    */


    // Terceira Solução Sort Simples
    string[] entradas = Console.ReadLine().Split(' ');
    int a = int.Parse(entradas[0]);
    int b = int.Parse(entradas[1]);
    int c = int.Parse(entradas[2]);

    int x = a; // 1
    int y = b; // 2
    int z = c; // 3

    // int a = 2, b = 3; // a = 2, b = 3
    // int temp = a; // a = 2, b = 3, temp = 2
    // a = b; // a = 3, b = 3, temp = 2
    // b = temp; // a = 3, b = 2, temp = 2

    if(y > z) {
      int aux = y;
      y = z;
      z = aux;
    }

    if(x > y) {
      int aux = x;
      x = y;
      y = aux;
    }

    if(y > z) {
      int aux = y;
      y = z;
      z = aux;
    }

    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(z);
    Console.WriteLine();
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);

  }

}


