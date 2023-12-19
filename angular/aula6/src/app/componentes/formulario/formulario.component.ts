import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Output } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { Aluno } from '../../modelo/aluno';

@Component({
  selector: 'app-formulario',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './formulario.component.html',
  styleUrl: './formulario.component.css'
})
export class FormularioComponent {

  // Obter a Função cadastrarAluno que está no Componente Principal
  @Output() cadastrarAluno = new EventEmitter<Aluno>();

  // Função para Executar o Cadastro
  cadastrar():void{
    this.cadastrarAluno.emit(this.formulario.value as Aluno);
  }

  //Formulário
  formulario = new FormGroup({
    nome: new FormControl(''),
    nota1: new FormControl(''),
    nota2: new FormControl(''),
  })

}
