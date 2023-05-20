
using Patterns;

public class ICPP : TemplateDeImpostCondicional
{
  public ICPP() : base() { }
  public ICPP(Imposto outroImposto) : base(outroImposto) { }
  protected override bool DeveUsarMaximaTaxaçao(Orcamento orcamento)
  {
    return orcamento.Valor >= 500;
  }

  protected override double MaximaTaxacao(Orcamento orcamento)
  {
    return orcamento.Valor * 0.07;
  }

  protected override double MinimaTaxacao(Orcamento orcamento)
  {
    return orcamento.Valor * 0.05;
  }
}