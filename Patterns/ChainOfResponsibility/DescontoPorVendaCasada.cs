using Patterns;

public class DescontoPorVendaCasada : Desconto
{
  public Desconto Proximo { get; set; } = new SemDesconto();

  public double Desconta(Orcamento orcamento)
  {
    if (this.Existe("LAPIS", orcamento) && this.Existe("CANETA", orcamento))
    {
      return orcamento.Valor * 0.05;
    }
    return Proximo.Desconta(orcamento);
  }
  private bool Existe(String nomeDoItem, Orcamento orcamento)
  {
    foreach (var item in orcamento.Itens)
    {
      item.Nome.ToUpper();
      if (item.Nome.Equals(nomeDoItem))
      {
        return true;
      }
    }
    return false;
  }
}