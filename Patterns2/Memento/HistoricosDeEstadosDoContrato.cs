namespace Patterns2.Memento;

public class HistoricosDeEstadosDoContrato
{
  private IList<EstadoDoContrato> Estados = new List<EstadoDoContrato>();

  public void Adiciona(EstadoDoContrato estado)
  {
    Estados.Add(estado);
  }

  public EstadoDoContrato Pega(int indice)
  {
    return Estados[indice];
  }
}