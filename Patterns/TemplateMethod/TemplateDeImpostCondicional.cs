using Patterns;
using Patterns.Strategy;

public abstract class TemplateDeImpostCondicional : Imposto
{
  public TemplateDeImpostCondicional(Imposto outroImposto) : base(outroImposto) { }
  public TemplateDeImpostCondicional() : base() { }

  public override double Calcula(Orcamento orcamento)
  {
    if (DeveUsarMaximaTaxaçao(orcamento))
    {
      return MaximaTaxacao(orcamento);
    }
    return MinimaTaxacao(orcamento);
  }
  protected abstract bool DeveUsarMaximaTaxaçao(Orcamento orcamento);

  protected abstract double MaximaTaxacao(Orcamento orcamento);
  protected abstract double MinimaTaxacao(Orcamento orcamento);
}