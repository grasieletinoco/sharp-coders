# Aprofundando em  POO

## Atributos e Métodos estáticos

```cs
public class Circulo {
  public readonly double PI = 3.14159265;

  public double Raio {get; set;}

  public double Area {
    get { return PI * Raio * Raio; }
  }

  public double Perimetro {
    get { return 2 * PI * Raio; }
  }
}
```

Problemas:

- Cada circulo está tendo o seu próprio PI
- Eu deveria conseguir saber o valor de PI independente de um objeto Circulo

**Static** (estático):

```cs
public class Circulo {
  public static readonly double PI = 3.14159265;

  public double Raio {get; set;}

  public double Area {
    get { return PI * Raio * Raio; }
  }

  public double Perimetro {
    get { return 2 * PI * Raio; }
  }
}
```

- Serve para criar variável global
- Seria compartilhado entre todos (não gastaria memória adicional)
- Não depende de um objeto para ser utilizado, passaria a funcionar:

```cs
  Console.WriteLine(Circulo.PI); // 3.1415...
```

```cs
Math.Log10();
```

```cs
public class TimeUtils {
  public static readonly double DAY_IN_HOURS = 24.0;
  public static readonly double DAY_IN_MINUTES = 24.0 * 60.0;
}
```

Se eu estivesse num Programa onde não quero instanciar Circulos, apenas isolar Calculos dentro de uma Classe

```cs
public class CircleUtils {

  private static readonly double PI = 3.14159265;

  public static double CalculateArea(double raio) {
    return PI * Raio * Raio;
  }

  public static double CalculatePerimetro(double raio) {
    return 2 * PI * Raio;
  }

}
```

Usando:

```cs
double result = CircleUtils.CalculateArea(3.0);
```

## Herança

A Herança é permitir que uma Classe extenda comportamentos e Atributos de outra, para que sejam reaproveitados.

- Tem um / Tem Vários = Atributo ou Property
- Faz ou um Comportamento = Método
- É um, é uma = Herança

```
Pessoa
- Estudante
- Professor
```

```cs
public class Pessoa {
  public string Nome {get; set;}
  public string Cpf {get; set;}
  public string Idade {get; set;}
}

public class Estudante : Pessoa { // Estudante Extende Pessoa
  // public string Nome {get; set;}
  // public string Cpf {get; set;}
  // public string Idade {get; set;}
  public string RegistroDoAluno {get; set;}
}

public class Professor : Pessoa { // Professor Extende Pessoa
  // public string Nome {get; set;}
  // public string Cpf {get; set;}
  // public string Idade {get; set;}
  public List<string> Habilidades {get; set;} = new();
}
```
