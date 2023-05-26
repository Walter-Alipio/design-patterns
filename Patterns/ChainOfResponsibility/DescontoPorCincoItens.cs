namespace Patterns.ChaiOfResponsability;
public class DescontoPorCincoItens : Desconto
{
  public Desconto Proximo { get; set; } = new SemDesconto();

  public double Desconta(Orcamento orcamento)
  {
    if (orcamento.Itens.Count > 5)
    {
      return orcamento.Valor * 0.1;
    }
    return Proximo.Desconta(orcamento);
  }
}