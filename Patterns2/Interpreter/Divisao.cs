public class Divisao : IExpressao
{


  public Divisao(IExpressao esquerda, IExpressao direita)
  {
    Esquerda = esquerda;
    Direita = direita;
  }

  public IExpressao Esquerda { get; }
  public IExpressao Direita { get; }

  public void Aceita(IVisitor impressora)
  {
    impressora.ImprimeDivisao(this);
  }

  public int Avalia()
  {
    return this.Esquerda.Avalia() / this.Direita.Avalia();
  }
}
