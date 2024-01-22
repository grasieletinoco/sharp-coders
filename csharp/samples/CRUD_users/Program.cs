﻿using System.Diagnostics;

namespace CRUD_users;

public class Program {

  static void ShowMenu() {
    Console.WriteLine("Escolha uma Opção Abaixo");
    Console.WriteLine("1 - Para Criar um Usuário");
    Console.WriteLine("2 - Buscar um Usuário");
    Console.WriteLine("3 - Listar os Usuários (sem senha se houver)");
    Console.WriteLine("4 - Atualizar um Usuário");
    Console.WriteLine("5 - Deletar um Usuário");
    Console.WriteLine("0 - Para Sair");
    Console.Write("Digite a Opção Desejada: ");
  }

  static void CriarUsuario(int emptyPosition, string[] usernames, string[] emails, string[] passwords) {
    Console.Write("Digite seu Username: ");
    usernames[emptyPosition] = Console.ReadLine();

    Console.Write("Digite seu Email: ");
    emails[emptyPosition] = Console.ReadLine();

    Console.Write("Digite sua Senha: ");
    passwords[emptyPosition] = Console.ReadLine();
  }




  // // Teste 01
  // static void TestaCopiaReferencia(int numeroPrimitivo){
  //   numeroPrimitivo = 99999;
  // }

  //  // Teste 02
  //  static void TestaCopiaReferencia2(string[] vetorDeStrings){
  //   vetorDeStrings[0] = "hrafa";
  // }




  public static void Main () {

    int TOTAL_SIZE = 1000, size = 0;

    string[] usernames = new string[TOTAL_SIZE];
    string[] emails = new string[TOTAL_SIZE];
    string[] passwords = new string[TOTAL_SIZE];

    // CriarUsuario(emptyPosition++, usernames, emails, passwords);
    // emptyPosition++;

    // 6 = 0, 1, 2, 3, 4, 5, _ A posição vazia é a 6

    // CriarUsuario(size++, usernames, emails, passwords);

    // TODO: Reutilizar isso quando for Listar todos
    // for(int i = 0; i < size; i++) {
    //   Console.WriteLine("-----------------");
    //   Console.WriteLine(usernames[i]);
    //   Console.WriteLine(emails[i]);
    //   Console.WriteLine(passwords[i]);
    //   Console.WriteLine("-----------------");
    // }




    // // Teste 01: Não mudou o valor da variável size porque foi uma cópia
    // TestaCopiaReferencia(size);
    // Console.WriteLine(size);

    // // Teste 02: Antes não tem nada e depois foi modificada
    // Console.WriteLine($"Antes: {usernames[0]}");
    // TestaCopiaReferencia2(usernames);
    // Console.WriteLine($"Depois: {usernames[0]}");




    // Comparativo
    // while pra menu = mostrarMenu verifico&faço mostrarMenu ...
    // do...while = fazendo verifica fazendo

    // ShowMenu();
    // int option = int.Parse(Console.ReadLine());

    // while(option != 0) {

    //   switch(option) {
    //     case 1:
    //       CriarUsuario(size++, usernames, emails, passwords);
    //       break;
    //     default:
    //       Console.WriteLine("Digite uma opcao valida!");
    //       break;
    //   }

    //   ShowMenu();
    //   option = int.Parse(Console.ReadLine());
    // }
    

    int option;

    do {
      ShowMenu();
      option = int.Parse(Console.ReadLine());

      switch(option) {
        case 0:
          Console.WriteLine("Valeu, até a próxima!");
          break;
        case 1:
          CriarUsuario(size++, usernames, emails, passwords);
          break;
        default:
          Console.WriteLine("Digite uma Opcão Válida!");
          break;
      }
            
    } while(option != 0);

  }

}
