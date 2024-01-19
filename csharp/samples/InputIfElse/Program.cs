﻿namespace InputIfElse;

public class Program
{
    public static void Main()
    {
        
        string nome = Console.ReadLine();
        int idade = int.Parse(Console.ReadLine());
        double nota = double.Parse(Console.ReadLine());

        // if braceless - sem as chaves
        // Só vale se tiver apenas uma linha dentro
        if(idade >= 18) 
            Console.WriteLine("Pode Dirigir");
        else 
            Console.WriteLine("Nao Pode Dirigir");
        
        // >= 7 Aprovado
        // >= 4 e < 7 Recuperacão
        // < 4 Reprovado

        if(nota >= 7)
            Console.WriteLine("Aprovado");
        else if(nota >= 4)
            Console.WriteLine("Recuperacão");
        else
            Console.WriteLine("Reprovado");
        

        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Nota: {nota}");
    }
}
