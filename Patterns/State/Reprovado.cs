namespace Patterns.State;

public class Reprovado : EstadoDeUmOrcamento
{
  public void AplicaUmDescontoExtra(Orcamento orcamento)
  {
    throw new Exception("Orçamentos reprovados não recebem desconto extra");
  }

  public void Aprova(Orcamento orcamento)
  {
    throw new Exception("Orçamento já está reprovado");
  }

  public void Finaliza(Orcamento orcamento)
  {
    orcamento.EstadoAtual = new Finalizado();
  }

  public void Reprova(Orcamento orcamento)
  {
    throw new Exception("Orçamento já está reprovado");
  }
}