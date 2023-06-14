public class Numero : IExpressao
{

  public int Valor { get; private set; }

  public Numero(int numero)
  {
    Valor = numero;
  }


  public int Avalia()
  {
    return this.Valor;
  }

  public void Aceita(ImpressoraVisitor impressora)
  {
    impressora.ImprimeNumero(this);
  }
}