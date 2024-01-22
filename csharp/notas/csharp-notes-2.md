# Funções

##

Conjunto de passos bem definidos.

podem ter...

- retorno
- parametros, entradas, argumento

- calculos matematicos

```cs
//f(x) = x + 2
static double SomarDois(double x) {
  return x + 2;
}

// void = vazio
static void SayHello() {
  Console.WriteLine("Hello!");
  return;
}

static void SayHelloToSomeone(string name) {
  Console.WriteLine($"Hello, {name}");
}

// boolean = Prefixo Is e Has
// even = Par
static boolean IsEven(int num) {
  return num%2 == 0;
}

static boolean HasInvalidCharacters(string username) {
  // Lógica para Validar se o username está com Caracteres Invalidos
}

public static void Main() {

  string username = Console.ReadLine();

  if(HasInvalidCharacters(username)) {
    // Faz Algo com o username
  }

  Console.WriteLine(SomarDois(5));
}
```

Menção Honrosa:

- valor em detrimento de outro
- execucao de processos
- reaproveitamento (reuso, e se codigo fosse muito grande)
- instrucao isolada/divisao de tarefas
- utilidade
- modularizacao/bloco de codigo
- objetivo/resolve problemas
- Legibilidade

## Práticas interessantes

### early return (retorno "adiantado")

- Tento retornar antes, e mantenho um caso padrao

Jeito Antigo:

```cs
static boolean EhPar(int number) {
  if(number%2 == 0)
    return true;
  else
    return false;
}
```

Boa Prática do early return:

```cs
static boolean EhPar(int number) {
  if(number%2 == 0)
    return true;

  return false;
}
```

```cs
static void Sacar(double quantia) {
  if(ativa == true && saldo >= quantia) {
    saldo -= quantia;
  }
}
```

Refatorando...

```cs
static void Sacar(double quantia) {
  if(!ativa)
    throw new Exception("Conta inativa");

  if(saldo < quantia)
    throw new Exception("Saldo insuficiente");

  if(!cpfValido)
    throw new Exception("Cpf Invalido");

  saldo -= quantia;
}
```

Se for Múltiplo de 3 = foo
Se for Múltiplo de 5 = boo
Se for Múltiplo de Ambos = fooboo

```cs
public boolean IsMultipleOf(int number, int divisor) {
  if(number%divisor != 0)
    return false;

  return true;
}

public static string TestFooBoo(int number) {
  string aux = "";

  if(IsMultipleOf(number, 3))
    aux += "foo";

  if(IsMultipleOf(number, 5))
    aux += "boo";

  return aux;
}

Console.WriteLine(TestFooBoo(int.Parse(Console.ReadLine())));
```

Código Ruim = Dificil de extender, entender e mudar

### switch-case

```cs
string sinal = "Vermelho";

switch(sinal) {
  case "vermelho":
    Console.WriteLine("Parar");
    break;
  case "amarelo":
    Console.WriteLine("Atencão");
  case "verde":
    Console.WriteLine("Passar");
    break;
  default: // padrao
    Console.WriteLine("Dirija com Cuidado");
    break;
}
```

```cs
static void IsConsonant(char c) {
  swith(c) {
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
      return true;
  }

  return false;
}
```

## Predencia do ++/--

variavel++ = primeiro entrega o valor e depois aumenta
++variavel = primeiro aumenta e depois entrega o valor

```cs
int x = 10;

Console.WriteLine(++x); // 11
Console.WriteLine(x); // 11

int y = 10;
Console.WriteLine(y++); // 10
Console.WriteLine(y); // 11
```
## Fibonacci

cada próximo termo é a soma dos 2 anteriores a ele

valores = 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89

indices = 0, 1, 2, 3, 4, 5, 6,  7,  8,  9, 10, 11

## Keywords ref, in, out

As 3 criam refencias de memoria.

### ref - referencia

sintaxe:

```cs
public static void Troca(ref int a, ref int b) {
  int aux = a;
  a = b;
  b = aux;
}

int a = 3, b = 2;
Console.WriteLine($"A: {a}, B: {b}"); // A: 3, B: 2

Troca(ref a, ref b);

Console.WriteLine($"A: {a}, B: {b}"); // A: 2, B: 3
```

### in - entrada/dentro

```cs
public static void Imprime(in double valor) {
  // Consegue Garantir Imutabilidade da Variavel
  // valor = 200.0; // Não Funciona
  Console.WriteLine($"Valor: R${valor:F2}");
}

double valor = 239.99;
Imprime(in valor);
```

### out - saida/sair

```cs
public static void Inicializa(out int pontuacao) {
  pontuacao = 100;
}

// int pontuacao;
Inicializa(out pontuacao);
```

## Nullables

triste:

```cs
Nullable<int> nota = null;
```

feliz:

```cs
int? nota = null;
nota = 3.0;
```

sei o que estou fazendo (garantia de nao nulo):

```cs
// ! -> Indica que o Valor Não Será Nulo
string texto = Console.ReadLine()!;
```

### Nullish Coalescence Operator

Testa se o Valor é Nulo, se for usa um Valor Secundário.

```cs
double? salarioTrabalhoVoluntario = null;
double? salarioSemTrabalho = 0.0;

// Trabalho Voluntário = Recebe 0 Reais
Console.WriteLine(salarioTrabalhoVoluntario ?? "Nao recebe");

// Salário sem Trabalho = Recebe 0 Reais
Console.WriteLine(salarioSemTrabalho ?? "Nao recebe");
```
