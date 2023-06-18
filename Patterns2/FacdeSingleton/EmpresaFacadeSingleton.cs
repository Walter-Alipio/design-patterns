namespace Patterns2.FacadeSingleton;

public class EmpresaFacadeSingleton
{
  private static EmpresaFacade instancia = new EmpresaFacade();

  public EmpresaFacade Instancia
  {
    get
    {
      return instancia;
    }
  }
}

public class Servico
{
  public Servico() { }

  // outros metodos aqui
}
public class ServicoSingleton
{
  private static Servico instancia = new Servico();

  public Servico Instancia
  {
    get
    {
      return instancia;
    }
  }
}