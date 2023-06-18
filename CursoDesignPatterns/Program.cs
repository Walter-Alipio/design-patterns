using System.Linq.Expressions;
using System.Xml.Serialization;
using Patterns;
using Patterns.Builder;
using Patterns.Observer;
using Patterns.Strategy;
using Patterns2.Adapter;
using Patterns2.Brigdges;
using Patterns2.Command;
using Patterns2.FacadeSingleton;
using Patterns2.Flyweight;
using Patterns2.Memento;

#region StrategyPattern
// Imposto icms = new ICMS();
// Imposto iss = new ISS();

// Orcamento orcamento = new Orcamento(500.0);

// CalculadorDeImpostos calculador = new CalculadorDeImpostos();

// calculador.RealizaCalculo(orcamento, icms);
// calculador.RealizaCalculo(orcamento, iss);
#endregion

#region ChainOfResponsibility
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
// Orcamento reforma = new Orcamento(500);
// System.Console.WriteLine(reforma.Valor);

// reforma.AplicaDescontoExtra();
// System.Console.WriteLine(reforma.Valor);

// reforma.Aprova();
// reforma.AplicaDescontoExtra();
// System.Console.WriteLine(reforma.Valor);
// reforma.Finaliza();


#endregion

#region Builder

// NotaFiscalBuilder criador = new NotaFiscalBuilder(new List<AcaoAposGerarNota>()
// {
//   new EnviadorDeEmail(),
//   new EnviadorDeSMS(),
//   new NotaFiscalDAO(),
//   new Multiplicador(3)
// });

// //Fluent interface | Method chaining 
// criador.ParaEmpresa("Caelum ensino e inovação")
//   .ComCnpj("23.156.456/0001-12")
//   .ComItem(new ItemNota("item 1", 100.0))
//   .ComItem(new ItemNota("item 2", 200.0))
//   .NaDataAtual()
//   .ComObservacoes("Uma obs qualquer");

// NotaFiscal nf = criador.Constroi();
// System.Console.WriteLine(nf.ValorBruto);
// System.Console.WriteLine(nf.RazaoSocial);
#endregion

#region Flyweight
//Essa sequencia funciona apenas em ambiente Windows devido ao uso do Console.Beep
// internal class Program
// {
//   private static void Main(string[] args)
//   {
//     var notas = new NotasMusicais();
//     IList<INota> musica = new List<INota>()
//     {
//       notas.Pega("do"),
//       notas.Pega("re"),
//       notas.Pega("mi"),
//       notas.Pega("fa"),
//       notas.Pega("fa"),
//       notas.Pega("fa")
//     };

//     var piano = new Piano();
//     piano.Toca(musica);
//   }
// }

#endregion

#region Memento

// HistoricosDeEstadosDoContrato historico = new();
// Contrato contrato = new Contrato(DateTime.Now, "Victor", TipoContrato.Novo);

// historico.Adiciona(contrato.SalvaEstado());

// System.Console.WriteLine(contrato.Tipo);

// contrato.Avanca();
// historico.Adiciona(contrato.SalvaEstado());

// contrato.Avanca();
// historico.Adiciona(contrato.SalvaEstado());

// System.Console.WriteLine(contrato.Tipo);
// System.Console.WriteLine(historico.Pega(0).Contrato.Tipo);

#endregion

#region Interpreter e o Visitor
// (1 + 10) + (20 - 10)

// var esquerda = new Soma(new Numero(1), new Numero(10));
// var direita = new Subtracao(new Numero(20), new Numero(10));
// var soma = new Soma(esquerda, direita);

// Console.WriteLine(soma.Avalia());

// // var soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
// // Func<int> funcaoMatematica = Expression.Lambda<Func<int>>(soma).Compile();
// // System.Console.WriteLine(funcaoMatematica());

// ImpressoraVisitor impressora = new ImpressoraVisitor();
// soma.Aceita(impressora);

#endregion

#region Bridges

// var mensagem = new MensagemAdminstrador("Salomão");
// var enviador = new EnviaPorEmail();
// mensagem.Enviador = enviador;
// mensagem.Envia();

#endregion

#region Command

// var fila = new FilaDeTrabalho();
// var pedido1 = new Pedido("Mauro", 100);
// var pedido2 = new Pedido("Célia", 200);

// fila.Adiciona(new PagaPedido(pedido1));
// fila.Adiciona(new PagaPedido(pedido2));

// fila.Adiciona(new FinalizaPedido(pedido1));

// fila.Processa();

#endregion

#region Adapter

// var cliente = new Cliente();
// cliente.Nome = "Samuel";
// cliente.Endereco = "Rua Vergueiro";
// cliente.DataNascimento = DateTime.Now;

// var xml = new GeradorXml().GeraXml(cliente);

// System.Console.WriteLine(xml);

#endregion

#region Facade e Singleton

// string cpf = "123.456.789-93";

// var fachada = new EmpresaFacadeSingleton().Instancia;

// fachada.BuscaClientePorCPF(cpf);


#endregion