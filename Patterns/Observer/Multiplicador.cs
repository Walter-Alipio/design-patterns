using Patterns.Builder;

namespace Patterns.Observer;

public class Multiplicador : AcaoAposGerarNota
{
  public double Fator { get; private set; }
  public Multiplicador(double fator)
  {
    Fator = fator;
  }

  public void Executa(NotaFiscal notaFiscal)
  {
    System.Console.WriteLine($"Saldo multiplicado por {Fator} = {Fator * notaFiscal.ValorBruto}");
  }
}