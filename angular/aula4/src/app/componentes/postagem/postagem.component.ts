import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PostagemService } from '../../servicos/postagem.service';
import { Postagem } from '../../modelos/Postagem';

@Component({
  selector: 'app-postagem',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './postagem.component.html',
  styleUrl: './postagem.component.css'
})

export class PostagemComponent {

  // Construtor
  constructor(private servicoPostagem:PostagemService){}

  // Vetor de Postagens
  postagens:Postagem[] = [];

  // Ao iniciar (Quando o Componente é Criado)
  ngOnInit(){
    this.listarPostagens();
  }

  // Função para Listar as Postagens
  listarPostagens():void{
    this.servicoPostagem.listarPostagens().subscribe(retorno => {
      //console.table(retorno); 
      this.postagens = retorno;
    })
  }

}