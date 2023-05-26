using Patterns.Builder;

namespace Patterns.Observer;

public class EnviadorDeSMS : AcaoAposGerarNota
{
  public void Executa(NotaFiscal notaFiscal)
  {
    System.Console.WriteLine("Simula envio de SMS");
  }
}