using Patterns.Builder;

namespace Patterns.Observer;

public class EnviadorDeEmail : AcaoAposGerarNota
{
  public void Executa(NotaFiscal notaFiscal)
  {
    System.Console.WriteLine("Simula envio de email");
  }
}