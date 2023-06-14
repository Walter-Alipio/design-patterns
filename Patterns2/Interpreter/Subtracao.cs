public class Subtracao : IExpressao
{

  public IExpressao Esquerda { get; }
  public IExpressao Direita { get; }

  public Subtracao(IExpressao esquerda, IExpressao direita)
  {
    Esquerda = esquerda;
    Direita = direita;
  }


  public int Avalia()
  {
    return this.Esquerda.Avalia() - this.Direita.Avalia();
  }

  public void Aceita(ImpressoraVisitor impressora)
  {
    impressora.ImprimeSubtracao(this);
  }
}