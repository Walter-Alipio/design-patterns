namespace Patterns2.Flyweight;

public class Piano
{
  public void Toca(IList<INota> musica)
  {
    foreach (var nota in musica)
    {
      Console.Beep(nota.Frequencia, 300);
    }
  }
}