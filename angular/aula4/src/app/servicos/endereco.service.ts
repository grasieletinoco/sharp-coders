import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Endereco } from '../modelos/endereco'; 

@Injectable({
  providedIn: 'root'
})
export class EnderecoService {

  // Construtor
  constructor(private http:HttpClient) { }

  // Método para retornar o endereco
  retornarEndereco(cep:string):Observable<Endereco>{
    return this.http.get<Endereco>(`https://viacep.com.br/ws/${cep}/json/`)
  }


}