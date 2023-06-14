public class RaizQuadrada : IExpressao
{


  public RaizQuadrada(IExpressao numero)
  {
    Numero = numero;
  }

  public IExpressao Numero { get; }

  public void Aceita(IVisitor impressora)
  {
    throw new NotImplementedException();
  }

  public int Avalia()
  {
    var result = Math.Sqrt(this.Numero.Avalia());
    return (int)result;
  }
}