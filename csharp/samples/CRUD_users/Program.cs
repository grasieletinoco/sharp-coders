﻿using System.Diagnostics;

namespace CRUD_users;

public class Program {

  static void ShowMenu() {
    Console.WriteLine("Escolha uma opcao abaixo");
    // 1 - Para criar um Usuario
    // 2 - Buscar um Usuario
    // 3 - Listar os Usuarios (sem senha se houver)
    // 4 - Atualizar um Usuario
    // 5 - Deletar um Usuario
    // 0 - Para Sair
    Console.Write("Digite a Opção Desejada: ");
  }

  static void CriarUsuario() {
    Console.WriteLine("Usuario Criado");
  }

  public static void Main () {

    int size = 1000;
    string[] usernames = new string[size];
    string[] emails = new string[size];
    string[] passwords = new string[size];

    ShowMenu();
    int option = int.Parse(Console.ReadLine());

    while(option != 0) {

      if(option == 1) {
        CriarUsuario();
      }

      ShowMenu();
      option = int.Parse(Console.ReadLine());
    }
  }

}
