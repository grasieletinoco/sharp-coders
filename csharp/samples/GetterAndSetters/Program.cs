using GetterAndSetters.Model;


// Getters and Setters Manuais
/*
Pessoa alice = new Pessoa("Alice da Silva", 1.7, 23);

// Não Funciona :)
// alice.idade = -1000;
alice.SetAltura(-1.69);

Console.WriteLine(alice.nome);
Console.WriteLine(alice.GetAltura());
Console.WriteLine(alice.GetIdade());
*/






// Melhorando com Properties
/*
Pessoa alice = new Pessoa("Alice da Silva", 1.7, 60, 23);

// nao funciona :)
// alice.idade = -1000;
alice.Altura = 1.69;
// alice.Idade = 10;

Console.WriteLine(alice.nome);
Console.WriteLine(alice.Altura);
Console.WriteLine(alice.Idade);
Console.WriteLine($"{alice.IMC:F2}");
*/






//Resultado Final com Autoproperties

Pessoa alice = new Pessoa("Alice da Silva", 23, 1.7, 60.0);

// Não Funciona
// alice.idade = -1000;
alice.Altura = 1.69;
// alice.Idade = 10;

Console.WriteLine(alice.Nome);
Console.WriteLine(alice.Altura);
Console.WriteLine(alice.Idade);
Console.WriteLine($"{alice.IMC:F2}");
