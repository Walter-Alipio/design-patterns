namespace Patterns2.Command;

public class FilaDeTrabalho
{
  private IList<IComando> comandos = new List<IComando>();

  public void Adiciona(IComando comando)
  {
    this.comandos.Add(comando);
  }

  public void Processa()
  {
    foreach (var comando in comandos)
    {
      comando.Executa();
    }
  }


}