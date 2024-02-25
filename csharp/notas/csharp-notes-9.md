# Melhorando Herança

## Generics

- Objetivo: Criar um acumulador e disparador de mensagens, valores, objetos, etc.
- Descrição: Acumular(Informacao) -> essa informacao deve ser guardada.
- Descrição: Disparar() -> exibir todas as informações de uma única vez em tela.

```cs
public class IntermediadorDeMensagens {

  public List<string> Mensagens = new() {get; private set;}

  public void Acumular(string mensagem) {
    Mensagens.Add(mensagem);
  }

  public void Disparar() {
    foreach(string mensagem in Mensagens) {
      int currentPositionToRemove = 0;
      Console.WriteLine(mensagem);
      Mensagens.RemoveAt(currentPositionToRemove);
    }
  }

}
```

Problemas:

- Se quiser lidar com números, teria que recriar a classe para números.
- Se quiser lidar com pessoas, teria que recriar a classe para pessoas.

> Código Ruim: ruim de Entender, Extender e Mudar.

### Relembrando

upcasting:

```cs
Pessoa pedro = new Aluno(); // pedro eh um aluno e todo aluno eh tambem uma pessoa
FormaGeometrica circulo = new Circulo(); // mesma ideia
```

downcasting:

```cs
Pessoa pessoa = new Aluno();

// deixando downcasting seguro
if (pessoa is Aluno aluno) {
  // Aluno a = (Aluno) p;
  aluno.Nota = 10.0;
}
```

Consequência:

```cs
Object a = new Pessoa();
Object b = new Aluno();
Object c = new Quadrado();
```

### Melhorando com Object

```cs
public class IntermediadorDeMensagens {

  public List<Object> Mensagens = new() {get; private set;}

  public void Acumular(Object mensagem) {
    Mensagens.Add(mensagem);
  }

  public void Disparar() {
    foreach(Object mensagem in Mensagens) {
      int currentPositionToRemove = 0;
      Console.WriteLine(mensagem);
      Mensagens.RemoveAt(currentPositionToRemove);
    }
  }

}
```

Problemas:

- Não possui segurança dos Tipos dos Valores dentro do Intermediador.
- Não consegue garantir alguma chamada de Método ou Execução específica utilizando Object.

## Classes e ... abstratas

Classes Abstratas são classes feitas para serem Extendidas e Continuadas. Elas não são capazes de produzir um Objeto.
