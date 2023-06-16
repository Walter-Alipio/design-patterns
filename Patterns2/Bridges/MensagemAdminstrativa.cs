namespace Patterns2.Brigdges;

public class MensagemAdminstrador : IMensagem
{
  private readonly string nome;
  public IEnviador Enviador { get; set; }

  public MensagemAdminstrador(string nome)
  {
    this.nome = nome;
  }
  public void Envia()
  {
    Enviador.Envia(this);
  }
  public string Formata()
  {
    return string.Format("Enviando mensagem para o administrador {0} ", nome);
  }
}