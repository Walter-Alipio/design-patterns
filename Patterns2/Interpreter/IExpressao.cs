public interface IExpressao
{
  int Avalia();

  void Aceita(ImpressoraVisitor impressora);
}