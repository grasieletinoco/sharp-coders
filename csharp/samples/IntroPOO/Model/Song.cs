namespace IntroPOO.Model;

public class Song
{
  // Atributos
   public string? nome;
   public int duracaoEmMinutos;
   public string? artista;
   private int _anoDeLancamento;
   public string DataDeCriacao { get; private set; } // autoproperty

  // construtor this (pronome pocessivo) = desse
  // this = Referência ao Objeto que Chamou ou a Própria Classe
  // this = Resolver Smbiguidade
  public Song(string nome, int duracaoEmMinutos, string artista, int anoDeLancamento, string dataDeCriacao) {
    this.nome = nome;
    this.duracaoEmMinutos = duracaoEmMinutos;
    this.artista = artista;
    _anoDeLancamento = anoDeLancamento;
    DataDeCriacao = dataDeCriacao;
  }

  // Métodos

  // setter => Isola a Lógica de Alterar a Variável
  public void SetAnoDeLancamento(int anoDeLancamento) {
    if(anoDeLancamento <= 0)
      return;

    _anoDeLancamento = anoDeLancamento;
  }

  // getter => Isola a Lógica de Acessar a Variável
  // public string GetDataDeCriacao() {
  //   return _dataDeCriacao;
  // }

  public int GetAnoDeLancamento() {
    return _anoDeLancamento;
  }
}
