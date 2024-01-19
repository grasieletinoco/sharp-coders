# Dicas Beecrowd

## Entradas em uma Linha

- objeto: soma dois valores
- entrada: `2 3`
- saida: `5`

- split: separar

```cs
string linha = Console.ReadLine(); // 2 3
string[] dados = linha.Split(' '); // ['2', '3']

int a = int.Parse(dados[0]); // int a = 2
int b = int.Parse(dados[1]); // int b = 3
```

Fazendo mais Curto:

```cs
string a, b = Console.ReadLine().Split(' '); 
// Dados = ['2', '3']

int a = int.Parse(dados[0]); // int a = 2
int b = int.Parse(dados[1]); // int b = 3
```

## Posições Anteriores e Posteriores em Vetor

Problema de borda.

- checar até onde vai e garantir que não acessa posições indesejadas
- borda falsa

## Criando Projeto CLI (Command Line Interface)

Checando dotnet:

```bash
dotnet --version
```

Criando em .net6:

```bash
dotnet new console -n NomeDoProjeto --framework net6.0
```
