namespace Patterns.Builder;

public class NotaFiscalBuilder
{
  public String RazaoSocial { get; private set; } = string.Empty;
  public String Cnpj { get; private set; } = string.Empty;
  public String Observacoes { get; private set; } = string.Empty;
  public DateTime Data { get; private set; }

  private double valorTotal;
  private double impostos;
  private IList<ItemNota> todosOsItens = new List<ItemNota>();

  public NotaFiscalBuilder ComObservacoes(String observacoes)
  {
    this.Observacoes = observacoes;
    return this;
  }

  public NotaFiscalBuilder NaDataAtual()
  {
    this.Data = DateTime.Now;
    return this;
  }

  public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
  {
    this.RazaoSocial = razaoSocial;
    return this;
  }
  public NotaFiscalBuilder ComCnpj(String cnpj)
  {
    this.Cnpj = cnpj;
    return this;
  }
  public NotaFiscalBuilder ComItem(ItemNota itemNota)
  {
    this.todosOsItens.Add(itemNota);
    this.valorTotal += itemNota.Valor;
    this.impostos += itemNota.Valor * 0.05;
    return this;
  }

  public NotaFiscal Constroi()
  {
    return new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosOsItens, Observacoes);
  }
}