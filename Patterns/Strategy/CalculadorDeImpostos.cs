namespace Patterns.Strategy;
public class CalculadorDeImpostos
{
    public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
    {
        double valorImposto = imposto.Calcula(orcamento);
        System.Console.WriteLine(valorImposto);
    }
}