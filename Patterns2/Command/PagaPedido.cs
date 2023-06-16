namespace Patterns2.Command;

public class PagaPedido : IComando
{
  private readonly Pedido pedido;

  public PagaPedido(Pedido pedido)
  {
    this.pedido = pedido;
  }
  public void Executa()
  {
    System.Console.WriteLine("Pagando o pedido do cliente {0}", pedido.Cliente);
    this.pedido.Paga();
  }
}