import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { AlunoService } from '../../servicos/aluno.service';
import { Aluno } from '../../modelos/Aluno';

@Component({
  selector: 'app-aluno',
  standalone: true,
  imports: [CommonModule,ReactiveFormsModule],
  templateUrl: './aluno.component.html',
  styleUrl: './aluno.component.css'
})

export class AlunoComponent {

  // Vetor de Alunos
  alunos:Aluno[] = [];

  // Formulário
  formulario = new FormGroup({
    nome: new FormControl(''),
    nota1: new FormControl(''),
    nota2: new FormControl('')
  });

  // Construtor
  constructor(private servico:AlunoService){}

  // Após Renderizar o Componente
  ngOnInit(){
    this.servico.selecionar()
    .subscribe(dados => this.alunos = dados);
  }

  // Método para Cadastrar Alunos
  cadastrar():void{
    this.servico.cadastrar(this.formulario.value as Aluno)
    .subscribe(aluno => {
    // Cadastrar no Vetor de Alunos
    this.alunos.push(aluno)

    // Limpar o Formulário
    this.formulario.reset();
  });
  }

  // Método para Remover Alunos
  remover(id:number):void{
    this.servico.remover(id)
    .subscribe(() => {

    // Encontrar a Posição do Aluno no Vetor
    let posicaoAluno = this.alunos.findIndex(obj => {return obj.id === id});

    // Remover do Vetor
    this.alunos.splice(posicaoAluno, 1);

  });
  }

}
