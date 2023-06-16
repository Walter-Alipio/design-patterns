namespace Patterns2.Brigdges;

public class MensagemCliente : IMensagem
{
  public IEnviador Enviador { get; set; }
  private readonly string nome;

  public MensagemCliente(string nome)
  {
    this.nome = nome;
  }

  public void Envia()
  {
    Enviador.Envia(this);
  }

  public string Formata()
  {
    return string.Format("Mensagem para o cliente {0}", nome);
  }
}