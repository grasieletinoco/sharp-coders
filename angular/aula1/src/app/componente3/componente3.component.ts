import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-componente3',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './componente3.component.html',
  styleUrl: './componente3.component.css'
})
export class Componente3Component {

  //Variável de Mádia
  media: number = 8;

  //Variável de Linguagem
  linguagem: string = 'CSS';

  //Vetor de Nomes
  nomes: string[] = ['Luciana', 'Renato', 'Carla']
}
