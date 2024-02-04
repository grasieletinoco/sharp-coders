namespace GetterAndSetters.Model;


// Getters and Setters Manuais

/*
public class Pessoa
{
  private int _idade;
  private double _altura;
  public string nome;

  public Pessoa(string nome, double altura, int idade)
  {
      this.nome = nome;
      _altura = altura;
      _idade = idade;
  }

  public int GetIdade() {
    return _idade;
  }

  public double GetAltura() {
    return _altura;
  }

  public void SetAltura(double altura) {
    if(altura < 0) {
      throw new Exception("A Altura deve ser Positiva");
    }

    _altura = altura;
  }
}
*/






// Melhorando com Properties
/*
public class Pessoa
{
  private int _idade;
  private double _altura;
  private double _peso;
  public string nome;

  public Pessoa(string nome, double altura, double peso, int idade)
  {
      this.nome = nome;
      _altura = altura;
      _idade = idade;
      _peso = peso;
  }

  public double Altura {
    get {
      return _altura;
    }
    set {
      if(value < 0) {
        throw new Exception("A Altura deve ser Positiva");
      }

      _altura = value;
    }
  }

  public int Idade {
    get {
      return _idade;
    }
  }

  public double IMC {
    get {
      return _peso / (_altura * _altura);
    }
  }

  // public void SetAltura(double altura) {
  //   if(altura < 0) {
  //     throw new Exception("A altura deve ser positiva");
  //   }

  //   _altura = altura;
  // }

  // public int GetIdade() {
  //   return _idade;
  // }

  // public double GetAltura() {
  //   return _altura;
  // }

}
*/






//Resultado Final com Autoproperties

public class Pessoa
{
  public string Nome { get; set; }
  public int Idade { get; private set; }
  public double Altura { get; set; }
  public double Peso { get; set; }

  public Pessoa(string nome, int idade, double altura, double peso)
  {
      Nome = nome;
      Idade = idade;
      Altura = altura;
      Peso = peso;
  }

  public double IMC {
    get {
      return Peso / (Altura * Altura);
    }
  }

}
