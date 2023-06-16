namespace Patterns2.Brigdges;

public class EnviaPorSMS : IEnviador
{
  public void Envia(IMensagem mensagem)
  {
    System.Console.WriteLine("Enviando a mensagem por SMS.");
    System.Console.WriteLine(mensagem.Formata());
  }
}