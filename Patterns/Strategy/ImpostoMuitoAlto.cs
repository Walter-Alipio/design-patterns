namespace Patterns.Strategy;

public class ImpostoMuitoAlto : Imposto
{
  public ImpostoMuitoAlto(Imposto outroImposot) : base(outroImposot) { }
  public ImpostoMuitoAlto() : base() { }
  public override double Calcula(Orcamento orcamento)
  {
    return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
  }
}