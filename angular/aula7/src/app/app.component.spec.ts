//Importações
import {TestBed} from '@angular/core/testing';
import { AppComponent } from './app.component';
import { Pessoa } from './pessoa';


// Descrição do Teste Unitário
describe('AppComponent', () => {

  // Inicialização
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports:[AppComponent]
    }).compileComponents();
  });

  // Validar a Variável Texto
  it('Validar Variável de Texto', () => {

    // Fixture
    const fixture = TestBed.createComponent(AppComponent);

    // Obter as Variáveis e Funções do Componente
    const componente = fixture.componentInstance;

    //Validação
    expect(componente.texto).toEqual('Aprendendo a Trabalhar com o Jasmine e o Karma');

  });

  //Validar a Função Soma
  it('Validar Função Soma', () => {

    // Fixture
    const fixture = TestBed.createComponent(AppComponent);

    // Obter as Variáveis e Funções do Componente
    const componente = fixture.componentInstance;

    // Executar Função e Obter o Retorno
    let retorno = componente.soma(5, 6);

    // Validar
    expect(typeof retorno).toBe('number');

  });
  

  // Validar o Retorno da Função retornarPessoa
  it('Função Retornar Pessoa', () =>{

    // Fixture
    const fixture = TestBed.createComponent(AppComponent);

    // Obter as Variáveis e Funções do Componente
    const componente = fixture.componentInstance;

    // Criar um Objeto do Tipo Pessoa
    const obj = new Pessoa ('Ralf', 33);

    // Executar Função
    const retorno = componente.retornarPessoa(obj);

    // Validar
    expect(obj instanceof Pessoa).toBeTrue();
  })

});