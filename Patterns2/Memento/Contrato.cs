namespace Patterns2.Memento;

public class Contrato
{

  public DateTime Date { get; private set; }
  public string Nome { get; private set; }
  public TipoContrato Tipo { get; private set; }

  public Contrato(DateTime date, string nome, TipoContrato tipo)
  {
    Date = date;
    Nome = nome;
    Tipo = tipo;
  }

  public void Avanca()
  {
    if (Tipo == TipoContrato.Novo) Tipo = TipoContrato.EmAndamento;
    else if (Tipo == TipoContrato.EmAndamento) Tipo = TipoContrato.Acertado;
    else if (Tipo == TipoContrato.Acertado) Tipo = TipoContrato.Concluido;
  }

  public EstadoDoContrato SalvaEstado()
  {
    return new EstadoDoContrato(new Contrato(Date, Nome, Tipo));
  }
}