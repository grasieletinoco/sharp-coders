# POO de um Jeito Prático

## null assertion

O operador `null!` ou usar `!` para evitar warnings(avisos) de nulo, não garante que o conteúdo não vira nulo, apenas indica que você está se responsabilizando que o conteúdo não será nulo.

```cs
public class User
{
   public int Id { get; set; }
   public string Email { get; set; } = null!;
   public string Username { get; set; }
   public string? Nickname {get; set;} = null;
   public string Password { get; set; }
}
```

## Struct

Uma estrutura de dados que precede a criação a POO.

```cs
struct Pessoa {
   string Nome;
   int Idade;
   double Altura;
   string NumeroDeTelefone;
}

public class Program {
   public static void Main() {

      Pessoa pessoa;
   }
}
```

## Composição

usernamesOfUsers
emailsOfUsers
passwordsOfUsers

```js
const user = {
   email: "email@gmail.com",
   password: "password123",
   address: {
      street: "Rua X",
      city: "Cidade Y",
      number: "123a",
      country: "Brasil"
   },
   posts: [
      {
         content: "Treta Renato Cariani",
         likes: 400
      },
      {
         content: "BBB 2024",
         likes: 200
      }
   ]
}

user.posts.push({
   // Meu Post Aqui
})
```

```ts
export interface Address {
   street: string
   city: string
   number: string
   country: string
}

export interface Post {
   id: number
   content: string
   likes: number
}

export interface User {
   email: string
   password: string
   level: 'basic' | 'blue' | 'gold' | 'emerald'
   address: Address
   posts: Post[]
}

export interface Report {
   category: 'spam' | 'fake news'
   postId: number
}

const myUser = {
   level: 
}
```

## Relacionamentos

### 1. Relacionamento tem-um

> O Arqueiro Possui um Arco

```cs
public class Arco {
   public string Nome {get; set;}
   public int NumeroDeFlechas {get; set;}
   public double Forca {get; set;}

   public void Atirar() {
      NumeroDeFlechas--;
      Console.WriteLine("atirei");
   }
}

public class Arqueiro {
   public double Forca {get; set;}
   public Arco ArcoPrincipal {get; set;}
   public Arco ArcoSecundario {get; set;}
}

Arqueiro arq = new Arqueiro();

arq.ArcoPrincipal.Atirar();
```

## 2. Relacionamento tem-varios

```cs
public class Flecha() {
   public string Dano {get; set;}
   public string Efeito {get; set;}
}

public class Arco {
   public string Nome {get; set;}
   public double Forca {get; set;}
   public List<Flecha> Flechas {get; set;}
}

public class Arqueiro {
   public double Forca {get; set;}
   public Arco Arco {get; set;}
}
```

### 3. Consequências

- um pra um = tem-um + tem-um
- um pra muitos ou muitos pra um = tem-um + tem-varios
- um pra muitos ou muitos pra um = tem-varios + tem-um
- muitos pra muitos = tem-varios + tem-varios

## Diagramas

### 1. Diagrama UML

Diagrama UML é usado normalmente para descrever relacionamentos(Composições e Heranças) em Orientação a Objetos

Normalmente:

- A classe vai no topo de cada caixa
- Os atributos vao no meio
- Os metodos vao no fim
- Não colocamos construtores, ToString e métodos pre-prontos
- Se tiver em italico, é Classe Abstrata
- 0..1 = Indica que Pode ter Nenhum ou Um
- 0..* = Indica que Pode ter Nenhum ou Muitos
- 1..* = Indica que Pode ter 1 ou Muitos

### 2. Diagrama ER - Entidade Relacional

Este diagrama é focado em descrever as tabelas do banco de dados e os relacionamentos entre elas (chaves estrageiras e tabelas de normalização)

### 3. Diagrama de Use-Case

Este diagrama foca na parte operacional da solução, isto é, descrever o inicio de um uso até o seu fim, incluindo todas as possibilidades do usuário durante este caminho.

Caso de Uso:

> O usuário faz login e o sistema valida, depois o usuário acessa

Variante:

> Um usuário não cadastrado vai ao login, cria uma conta, o sistema registra, envia email, ele valida o email, a conta é ativada e depois o usuário acessa a conta.
