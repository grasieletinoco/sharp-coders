namespace Constructors.Model;

public class Pessoa {
  public string nome;
  public int idade;
  public double altura;
  public string telefone;

  // Herança = Este Construtor Extende o Construtor
  public Pessoa(string nome, int idade, double altura, string telefone) 
    : this(nome, idade, altura) {
    this.telefone = telefone;
  }

  // all args constructor = Construtor com Todos os Atributos
  public Pessoa(string nome, int idade, double altura) {
    if(idade <=0){
      throw new Exception("Idade Invalida!");
    }

    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
  }
  
  public void DarBoasVindas() {
    Console.WriteLine($"Bem vindo, me chamo {nome}!");
  }

  public void TestaMetodos() {
    DarBoasVindas();
  }
}
