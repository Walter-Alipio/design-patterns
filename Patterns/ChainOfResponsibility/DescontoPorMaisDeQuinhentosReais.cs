namespace Patterns.ChaiOfResponsability;
public class DescontoPorMaisDeQuinhentosReais : Desconto
{
  public Desconto Proximo { get; set; } = new SemDesconto();
  public double Desconta(Orcamento orcamento)
  {
    if (orcamento.Valor > 500.0)
    {
      return orcamento.Valor * 0.07;
    }
    return Proximo.Desconta(orcamento);
  }
}