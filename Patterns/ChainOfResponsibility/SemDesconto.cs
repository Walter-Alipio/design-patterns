using Patterns;

public class SemDesconto : Desconto
{
  public Desconto Proximo { get; set; } = new SemDesconto();

  public double Desconta(Orcamento orcamento)
  {
    return 0;
  }
}