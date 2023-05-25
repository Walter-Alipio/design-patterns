namespace Patterns.State;

public class Aprovado : EstadoDeUmOrcamento
{
  private bool descontoAplicado = false;
  public void AplicaUmDescontoExtra(Orcamento orcamento)
  {
    if (descontoAplicado) throw new Exception("Desconto já aplicado!");

    orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
    descontoAplicado = true;

  }

  public void Aprova(Orcamento orcamento)
  {
    throw new Exception("Orçamento já está em estado de aprovação");
  }

  public void Finaliza(Orcamento orcamento)
  {
    orcamento.EstadoAtual = new Finalizado();
  }

  public void Reprova(Orcamento orcamento)
  {
    throw new Exception("Orçamento está em aprovação e não pode ser reprovado agora");
  }
}