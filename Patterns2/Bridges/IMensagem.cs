namespace Patterns2.Brigdges;

public interface IMensagem
{
  IEnviador Enviador { get; set; }
  void Envia();
  string Formata();
}