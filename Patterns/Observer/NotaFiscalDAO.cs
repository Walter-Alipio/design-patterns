using Patterns.Builder;

namespace Patterns.Observer;

public class NotaFiscalDAO : AcaoAposGerarNota
{
  public void Executa(NotaFiscal notaFiscal)
  {
    System.Console.WriteLine("Simula salvar no banco de dados");
  }
}