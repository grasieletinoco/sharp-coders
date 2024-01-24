# POO

## Motivação

Quero Criar 1 Pessoa:

```cs
string nome;
int idade;
double altura;
```

Quero Criar 3 Pessoas:

```cs
string nome1, nome2, nome3;
int idade1, idade2, idade3;
double altura1, altura2, altura3;
```

Quero Criar 1000 Pessoas:

```cs
int quantidade = 1000;
string[] nomes = new string[1000];
int[] idades = new int[1000];
double[] alturas = new double[1000];
```

Relembrando... Como Trocar Duas Variaveis?

Solucão: Criar Variavel Auxiliar

```cs
int a = 2, b = 3;
int antigo_a = a;
a = b;
b = antigo_a;
```

Solucão Exótica:

```cs
int a = 2, b = 3;
(a, b) = (b, a);
```

Relembrando... Ordenacão

- Estratégia de Troca
- Estratégia de Comparacão

Tentando Trocar a Primeira e a Quinta Pessoa:

```cs
int quantidade = 1000;
string[] nomes = new string[1000];
int[] idades = new int[1000];
double[] alturas = new double[1000];

string aux1 = nomes[0];
nomes[0] = nomes[4];
nomes[4] = aux1;

int aux2 = idades[0];
// ...
```

🔴 Problemas

- Baixa Legibilidade
- Difícil Manutencão

## Classe

- O que Faz uma Classe?
  molde, tipo de variavel personalizado, classificacao

- O que eh um Objeto?
  fruto do molde

molde(classe): Carro, exemplo(objeto): Ferrari
molde(classe): Ferrari, exemplo(objeto): Ferrari do Bruno
molde(classe): Pessoa, exemplo(objeto): joao

- O que Compoe uma Classe?
  - o que ela tem: atributos
  - o que ela faz: metodo

Declarando...

```cs
public class Pessoa {
  // Tem - Atributos
  public string nome;
  public int idade; 
  public double altura; 

  // Faz - Métodos
  public void FazerAniversario() {
    idade++;
  }

  public double Somar(double a, double b) {
    return a + b;
  }
}
```

Instância Sinônimo de Exemplo.

Usando ...

```cs
public class Program {
 
  public static void Main() {

    // short sintax
    // Pessoa joao = new();

    Pessoa joao = new Pessoa();

  }

}
```
