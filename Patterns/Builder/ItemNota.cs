namespace Patterns.Builder;

public class ItemNota
{
  public String Nome { get; set; }
  public double Valor { get; set; }
  public ItemNota(string nome, double valor)
  {
    Nome = nome;
    Valor = valor;
  }
}