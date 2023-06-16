namespace Patterns2.Brigdges;

public class EnviaPorEmail : IEnviador
{
  public void Envia(IMensagem mensagem)
  {
    System.Console.WriteLine("Enviando a mensagem por Email.");
    System.Console.WriteLine(mensagem.Formata());
  }
}