# Design Patterns

Estudo de design patterns em C#. Material visto durante curso na plataforma da Alura como parte da formação "Boas práticas em C#".

## Padrões vistos durante o curso:

### Strategy:

- O padrão Strategy permite definir uma família de algoritmos, encapsulá-los em classes separadas e torná-los intercambiáveis. Isso permite que o algoritmo seja selecionado em tempo de execução de acordo com a necessidade.

### Chain of responsibility:

- O padrão Chain of Responsibility estabelece uma cadeia de objetos receptores, onde cada objeto tem a oportunidade de tratar uma solicitação. Isso permite que a solicitação seja passada ao longo da cadeia até que seja tratada por um dos objetos.

### Decorator:

- O padrão Decorator permite adicionar comportamentos extras a um objeto dinamicamente, envolvendo-o em objetos decoradores. Isso oferece uma alternativa flexível à herança tradicional para estender a funcionalidade de um objeto.

### Template method:

- O padrão Template Method define o esqueleto de um algoritmo em uma classe base, permitindo que as subclasses forneçam a implementação dos passos individuais. Isso promove a reutilização de código e a personalização do comportamento.

### State:

- O padrão State permite que um objeto altere seu comportamento quando seu estado interno muda. Isso é alcançado através da definição de diferentes classes de estado e permitindo a transição entre eles conforme necessário.

### Builder:

- O padrão Builder separa a construção de um objeto complexo de sua representação, permitindo que o mesmo processo de construção possa criar diferentes representações. Isso ajuda a evitar construtores complexos e oferece uma maneira mais flexível de criar objetos.
