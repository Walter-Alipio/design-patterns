namespace Patterns.State;

public class Finalizado : EstadoDeUmOrcamento
{
  public void AplicaUmDescontoExtra(Orcamento orcamento)
  {
    throw new Exception("Orçamentos finalizados não recebem desconto extra");
  }

  public void Aprova(Orcamento orcamento)
  {
    throw new Exception("Orçamento já está finalizado");
  }

  public void Finaliza(Orcamento orcamento)
  {
    throw new Exception("Orçamento já está finalizado");
  }

  public void Reprova(Orcamento orcamento)
  {
    throw new Exception("Orçamento já está finalizado");
  }
}