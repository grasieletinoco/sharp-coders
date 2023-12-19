import { Pipe, PipeTransform } from '@angular/core';
import { Aluno } from '../modelo/aluno';

@Pipe({
  name: 'media',
  standalone: true
})
export class MediaPipe implements PipeTransform {

  transform(obj:Aluno): number {

    // Extrair as Notas
    let nota1:number = obj.nota1 || 0;
    let nota2:number = obj.nota2 || 0;

    // Realizar Cálculo de Média
    let media:number = (nota1+nota2)/2;

    //Retorno
    return media;
  }

}
