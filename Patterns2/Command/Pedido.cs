namespace Patterns2.Command;

public class Pedido
{
  public string Cliente { get; private set; } = string.Empty;
  public double Valor { get; private set; }
  public DateTime DataFinalizacao { get; private set; }
  public Status Status { get; private set; }
  public Pedido(string cliente, double valor)
  {
    this.Cliente = cliente;
    this.Valor = valor;
    this.Status = Status.Novo;
  }

  public void Paga()
  {
    this.Status = Status.Pago;
  }
  public void Finaliza()
  {
    this.Status = Status.Entregue;
    this.DataFinalizacao = DateTime.Now;
  }

}