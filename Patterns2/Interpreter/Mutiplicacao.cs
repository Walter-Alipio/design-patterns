public class Mutiplicacao : IExpressao
{


  public Mutiplicacao(IExpressao esquerda, IExpressao direita)
  {
    Esquerda = esquerda;
    Direita = direita;
  }

  public IExpressao Esquerda { get; }
  public IExpressao Direita { get; }

  public void Aceita(ImpressoraVisitor impressora)
  {
    impressora.ImprimeMutiplicacao(this);
  }

  public int Avalia()
  {
    return this.Esquerda.Avalia() * this.Direita.Avalia();
  }
}