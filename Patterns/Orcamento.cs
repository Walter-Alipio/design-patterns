namespace Patterns;
public class Orcamento
{
    public double Valor { get; set; }
    public List<Item> Itens { get; private set; }
    public Orcamento(double valor)
    {
        this.Valor = valor;
        this.Itens = new List<Item>();
    }

    public void AdicionaItem(Item item)
    {
        Itens.Add(item);
    }
}
