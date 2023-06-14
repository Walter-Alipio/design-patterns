public class ImpressoraVisitor
{
  public void ImprimeSoma(Soma soma)
  {
    System.Console.Write("(");
    soma.Esquerda.Aceita(this);

    System.Console.Write("+");
    soma.Direita.Aceita(this);

    System.Console.Write(")");
  }

  public void ImprimeSubtracao(Subtracao subtracao)
  {
    System.Console.Write("(");
    subtracao.Esquerda.Aceita(this);

    System.Console.Write("-");
    subtracao.Direita.Aceita(this);

    System.Console.Write(")");
  }

  public void ImprimeMutiplicacao(Mutiplicacao mutiplicacao)
  {
    System.Console.Write("(");
    mutiplicacao.Esquerda.Aceita(this);

    System.Console.Write("*");
    mutiplicacao.Direita.Aceita(this);

    System.Console.Write(")");
  }
  public void ImprimeDivisao(Divisao divisao)
  {
    System.Console.Write("(");
    divisao.Esquerda.Aceita(this);

    System.Console.Write("/");
    divisao.Direita.Aceita(this);

    System.Console.Write(")");
  }
  public void ImprimeNumero(Numero numero)
  {
    System.Console.Write(numero.Valor);
  }
  public void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada)
  {
    System.Console.Write("√");
    System.Console.Write(raizQuadrada.Numero);
  }
}