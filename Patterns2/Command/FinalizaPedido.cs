namespace Patterns2.Command;

public class FinalizaPedido : IComando
{
  private readonly Pedido pedido;

  public FinalizaPedido(Pedido pedido)
  {
    this.pedido = pedido;
  }
  public void Executa()
  {
    System.Console.WriteLine("Finalizando o pedido do cliente {0}", pedido.Cliente);
    this.pedido.Finaliza();
  }
}