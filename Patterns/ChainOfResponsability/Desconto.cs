using Patterns;

public interface Desconto
{
    double Desconta(Orcamento orcamento);
    Desconto Proximo { get; set; }
}