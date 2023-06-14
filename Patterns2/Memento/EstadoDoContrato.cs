namespace Patterns2.Memento;

public class EstadoDoContrato
{
  public Contrato Contrato { get; private set; }

  public EstadoDoContrato(Contrato contrato)
  {
    Contrato = contrato;
  }
}