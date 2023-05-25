using Patterns.State;

namespace Patterns;
public class Orcamento
{
  public EstadoDeUmOrcamento EstadoAtual { get; set; }
  public double Valor { get; set; }
  public List<Item> Itens { get; private set; }
  public Orcamento(double valor)
  {
    this.Valor = valor;
    this.Itens = new List<Item>();
    this.EstadoAtual = new EmAprovacao();
  }

  public void AdicionaItem(Item item)
  {
    Itens.Add(item);
  }
  public void AplicaDescontoExtra()
  {
    EstadoAtual.AplicaUmDescontoExtra(this);
  }
  public void Aprova()
  {
    EstadoAtual.Aprova(this);
  }
  public void Reprova()
  {
    EstadoAtual.Reprova(this);
  }
  public void Finaliza()
  {
    EstadoAtual.Finaliza(this);
  }
}
