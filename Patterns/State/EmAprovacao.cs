namespace Patterns.State;

public class EmAprovacao : EstadoDeUmOrcamento
{
  private bool descontoAplicado = false;
  public void AplicaUmDescontoExtra(Orcamento orcamento)
  {
    if (descontoAplicado) throw new Exception("Desconto já aplicado!");

    orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
    descontoAplicado = true;

  }

  public void Aprova(Orcamento orcamento)
  {
    orcamento.EstadoAtual = new Aprovado();
  }

  public void Finaliza(Orcamento orcamento)
  {
    throw new Exception("Orçamento em aprovação não pode ir direto para finalizado");
  }

  public void Reprova(Orcamento orcamento)
  {
    orcamento.EstadoAtual = new Reprovado();
  }
}