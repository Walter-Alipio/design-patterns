
using Patterns;

public class IKCV : TemplateDeImpostCondicional
{
  protected override bool DeveUsarMaximaTaxaçao(Orcamento orcamento)
  {
    return orcamento.Valor >= 500 && TemItemMaiorQue100ReaisNo(orcamento);
  }

  protected override double MaximaTaxacao(Orcamento orcamento)
  {
    return orcamento.Valor * 0.1;
  }

  protected override double MinimaTaxacao(Orcamento orcamento)
  {
    return orcamento.Valor * 0.06;
  }

  private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
  {
    foreach (var item in orcamento.Itens)
    {
      if (item.Valor > 100) return true;

    }
    return false;
  }
}