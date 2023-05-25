using Patterns;
using Patterns.Strategy;

#region StrategyPattern
// Imposto icms = new ICMS();
// Imposto iss = new ISS();

// Orcamento orcamento = new Orcamento(500.0);

// CalculadorDeImpostos calculador = new CalculadorDeImpostos();

// calculador.RealizaCalculo(orcamento, icms);
// calculador.RealizaCalculo(orcamento, iss);
#endregion

#region ChainOfResponsability
// CalculadorDeDescontos calculador = new CalculadorDeDescontos();
// Orcamento orcamento = new Orcamento(0);

// orcamento.AdicionaItem(new Item("Caneta", 250));
// orcamento.AdicionaItem(new Item("Lapis", 250));
// orcamento.AdicionaItem(new Item("Caderno", 250));
// orcamento.AdicionaItem(new Item("borracha", 250));
// orcamento.AdicionaItem(new Item("Lapiseira", 250));
// orcamento.AdicionaItem(new Item("Apontador", 250));

// foreach (var item in orcamento.Itens)
// {
//   orcamento.Valor += item.Valor;
// }

// double desconto = calculador.Calcula(orcamento);
// System.Console.WriteLine(desconto);
#endregion

#region TemplateMethod 
// var icpp = new ICPP();
// var ikcv = new IKCV();

// var resultadoIcpp = icpp.Calcula(orcamento);
// var resultadoIkcv = ikcv.Calcula(orcamento);

// System.Console.WriteLine($"ICCP: {resultadoIcpp}");
// System.Console.WriteLine($"IKCV: {resultadoIkcv}");
#endregion

#region Decorator
// Imposto impostoComplexo = new ISS(new ICMS());

// Orcamento novoOrcamento = new Orcamento(500.0);

// double valor = impostoComplexo.Calcula(orcamento);

// Console.WriteLine(valor);

// Imposto impostoMuitoAlto = new ImpostoMuitoAlto(new ISS(new ICMS(new IKCV())));
// Orcamento orcamentoMuitoAlto = new Orcamento(200);

// double valorMuitoAlto = impostoMuitoAlto.Calcula(orcamento);
// System.Console.WriteLine(valorMuitoAlto);
#endregion

#region State
Orcamento reforma = new Orcamento(500);
System.Console.WriteLine(reforma.Valor);

reforma.AplicaDescontoExtra();
System.Console.WriteLine(reforma.Valor);

reforma.Aprova();
reforma.AplicaDescontoExtra();
System.Console.WriteLine(reforma.Valor);
reforma.Finaliza();


#endregion
