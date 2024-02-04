# Melhorias na POO

```cs
public class Pessoa {
  public string nome;
  public int idade;
  public double altura;
  public string telefone;

  public void DizerOi() {
    Console.WriteLine("Oi!");
  }
}
```

Problemas dessa Abordagem:

- Não estou cuidado da criacao da classe, isto é, não estou cuidado de atributos que deveriam obrigatórios.

- Não me preocupo com a maneira com que meus atributos são utilizados

## Construtores

Construtores sao métodos que são chamados durante a inicializacao do objeto.

```cs
Pessoa joao = new Pessoa();
```

Implicitamente está Chamando:

```cs
public class Pessoa {
  // Atributos...

  // Construtor Padrão
  public Pessoa() {
  }

  // Métodos...
}
```

### Construtores Personalizados

```cs
public class Pessoa {
  public string nome;
  public int idade;
  public double altura;
  public string telefone;

  // all args constructor = Construtor com todos os Atributos
  public Pessoa(string nome, int idade, double altura) {
    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
  }

  public void DarBoasVindas() {
    Console.WriteLine($"Bem vindo, me chamo {nome}!");
  }
}
```

```cs
Pessoa joao = new Pessoa("João da Silva", 22, 1.8);
// joao.nome = "Joao da Silva";
// joao.idade = 22;
// joao.altura = 1.8;

joao.DarBoasVindas();
// imprimir: Bem vindo, me chamo joao da silva
```

### palavra-chave `this`

O `this` permite que a gente acesse o objeto responsavel por chamar o metodo.

- Palavra diferenciadora
- Palavra this faz a gente pensar no objeto

### Construtor que Pensa

```cs
public class Pessoa {
  public string nome;
  public string sobrenome
  public int idade;
  public double altura;
  public string telefone;

  public Pessoa(string nomeCompleto, int idade, double altura) {
    // nomeCompleto = Pedro Silva
    string[] nomes = nomeCompleto.Split(' ');
    // nomes = ['Pedro', 'Silva']
    this.nome = nomes[0]; // nome = Pedro
    this.sobrenome = nomes[1]; // nome = Silva
    this.idade = idade;
    this.altura = altura;
  }

  public void DarBoasVindas() {
    Console.WriteLine($"Bem vindo, me chamo {nome}!");
  }
}
```

### Sobrecarga (Overload)

- Consequencia: Múltiplos Construtores

Quando eu tenho o mesmo nome(função) porém com uma assinatura(parametros e retorno) diferentes.

```cs
public void DizerOi() {
  Console.WriteLine("oi!");
}

public void DizerOi(string nome) {
  Console.WriteLine($"oi, {nome}!");
}

public double Somar(double a, double b) {
  return a + b;
}

public double Somar(double a, double b, double c) {
  return a + b + c;
}
```

Sobrecarga de Construtores:

```cs
public class Pessoa {
  public string nome;
  public int idade;
  public double altura;
  public string telefone;

  // all args constructor = Construtor com todos os Atributos
  public Pessoa(string nome, int idade, double altura, string telefone) {
    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
    this.telefone = telefone;
  }

  public Pessoa(string nome, int idade, double altura) {
    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
  }

  public Pessoa() {
  }

  public void DarBoasVindas() {
    Console.WriteLine($"Bem vindo, me chamo {nome}!");
  }
}
```

Reaproveitando os Construtores

```cs
public class Pessoa {
  public string nome;
  public int idade;
  public double altura;
  public string telefone;

  // all args constructor = construtor com todos os atributos
  public Pessoa(string nome, int idade, double altura) {
    if(idade <=0){
      throw new Exception("Idade inválida!");
    }

    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
  }

  public Pessoa(string nome, int idade, double altura, string telefone) : 
    this() {
    this.telefone = telefone;
  }


  public void DarBoasVindas() {
    Console.WriteLine($"Bem vindo, me chamo {nome}!");
  }
}
```

## Modificadores de Acesso

- visibilidade

|Modificador| Objetivo|
|:-:| :-: |
|`public`|Pode ser acessado em Qualquer Pasta ou Arquivo da Solucão|
|`private`|Não pode ser acessado em Nenhum Lugar fora da Classe Declarada|
|`protected`|Só pode ser acessado na Própria Classe e nas Classes Filhas|
|`(default)`|Pode ser acessado em Qualquer Lugar da mesma Pasta/Nível|

exemplo do `(default)`:

`Projeto.Model.Pessoa.cs:`

```cs
class Pessoa {
  // ...
}
```

Qualquer outra classe dentro do pacote `Model` poderia ver a classe `Pessoa`.

## Como Estamos Utilizando a Nossa Classe

```cs
public class Pessoa {

  // Outros Atributos
  public int idade;

  // Construtor

}
```

Não Quero Que Aconteça:

```cs
Pessoa joao = new Pessoa("João da Silva", 22, 1.8);

joao.idade = -1000;
```

Evitando Isso:

```cs
public class Pessoa {

  // Outros Atributos
  private int idade;

  // Construtor

}
```

## Properties (Property)

- Não Armazena Valor
- Pode fornecer acesso a Valores de com uma Sintaxe Melhor

```cs
public double Altura {
  get {
    //Será Chamado Quando for Acessar
  }
  set {
    // Será Chamado Quando for Mudar
  }
}
```
