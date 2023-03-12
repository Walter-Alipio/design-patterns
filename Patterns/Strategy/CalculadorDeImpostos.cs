namespace Patterns.Strategy;
public class CalculadorDeImpostos
{
    public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
    {
        double icms = imposto.Calcula(orcamento);
        System.Console.WriteLine(icms);
    }
}