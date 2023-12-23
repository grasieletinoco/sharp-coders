import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { Pessoa } from './pessoa';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {

  // Variável de Texto
  texto:string = 'Aprendendo a Trabalhar com o Jasmine e o Karma';

  // Função para Retornar a Soma
  soma(n1:number, n2:number):number{
    return n1+n2;
  }

  // Função para Retornar um Objeto do Tipo Pessoa
  retornarPessoa(obj:Pessoa):Pessoa{
    return obj;
  }

}
