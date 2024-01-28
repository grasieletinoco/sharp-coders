namespace IntroPOO.Model;

public class Carro
{ 

  // Tem - Atributos
  public string? placa; // null
  public string dono = "";
  public int ano; // 0
  public string cor = null!;
  public string modelo = null!;
  public double combustivelEmLitros; // 0.0

  // Faz - Métodos
  public void Abastecer(double quantidadeEmLitros) {
    combustivelEmLitros += quantidadeEmLitros;
  }

  public void GastarCombustivel(double quantidadeEmLitros) {
    combustivelEmLitros -= quantidadeEmLitros;
  }

}
