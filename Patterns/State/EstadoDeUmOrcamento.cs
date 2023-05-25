namespace Patterns.State;

public interface EstadoDeUmOrcamento
{
  void AplicaUmDescontoExtra(Orcamento orcamento);
  void Aprova(Orcamento orcamento);
  void Reprova(Orcamento orcamento);
  void Finaliza(Orcamento orcamento);
}