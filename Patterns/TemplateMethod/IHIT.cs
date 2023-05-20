
using Patterns;

public class IHIT : TemplateDeImpostCondicional
{
  public IHIT() : base() { }
  public IHIT(Imposto outroImposto) : base(outroImposto) { }
  protected override bool DeveUsarMaximaTaxaçao(Orcamento orcamento)
  {
    IList<String> noOrcamento = new List<String>();

    foreach (Item item in orcamento.Itens)
    {
      if (noOrcamento.Contains(item.Nome))
        return true;
      else
        noOrcamento.Add(item.Nome);
    }

    return false;
  }

  protected override double MaximaTaxacao(Orcamento orcamento)
  {
    return orcamento.Valor * 0.13 + 100;
  }

  protected override double MinimaTaxacao(Orcamento orcamento)
  {
    return orcamento.Valor * (orcamento.Itens.Count() * 0.01);
  }
}