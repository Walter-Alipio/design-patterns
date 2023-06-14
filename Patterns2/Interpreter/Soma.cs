public class Soma : IExpressao
{

  public IExpressao Esquerda { get; }
  public IExpressao Direita { get; }

  public Soma(IExpressao esquerda, IExpressao direita)
  {
    Esquerda = esquerda;
    Direita = direita;
  }


  public int Avalia()
  {
    return this.Esquerda.Avalia() + this.Direita.Avalia();
  }

  public void Aceita(ImpressoraVisitor impressora)
  {
    impressora.ImprimeSoma(this);
  }
}