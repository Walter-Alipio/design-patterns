# Design Patterns

Estudo de design patterns em C#. Material visto durante curso na plataforma da Alura como parte da formação "Boas práticas em C#". <br>
O projeto `Patterns` contém as implementações, enquanto que o projeto `CursoDeignPatterns` contém os testes para cada pattern.

## Padrões vistos durante a parte 1 da formação:

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

# Parte 2

### Factory

- Facotory é padrão de projeto que fornece uma interface para criar objetos de uma classe, permitindo a criação de diferentes tipos de objetos sem expor a lógica de criação.

### Flyweight

- Flyweight é um padrão de projeto que visa minimizar o uso de memória compartilhando objetos com características similares, reduzindo a quantidade de instâncias necessárias.

### Memento

- Memento é um padrão de projeto que permite capturar e restaurar o estado interno de um objeto sem violar a encapsulação, fornecendo um mecanismo para desfazer ou reverter operações.

### Interpreter

- Interpreter é um padrão de projeto que define a forma de interpretar ou avaliar expressões em uma linguagem específica, permitindo a implementação de um sistema de processamento de linguagens.

### Visitor

- Visitor é um padrão de projeto que separa algoritmos de uma estrutura de objetos, permitindo adicionar novas operações sem modificar as classes dos objetos visitados.

### Bridgie

- Bridgie é um padrão de projeto que separa uma abstração de sua implementação, permitindo que ambas variem independentemente.

### Command

- Commando é um padrão de projeto que encapsula uma solicitação como um objeto, permitindo parametrizar clientes com diferentes solicitações, enfileirar ou registrar solicitações e suportar operações de desfazer.

### Adapter

- Adapter é um padrão de projeto que permite a interoperabilidade entre interfaces incompatíveis, envolvendo um objeto com uma interface em uma interface esperada pelo cliente.

### Facade

- Facade é um padrão de projeto que fornece uma interface simplificada para um conjunto complexo de subsistemas, facilitando o uso desses subsistemas pelos clientes.

### Singleton

- Singleton é um padrão de projeto que garante a existência de apenas uma instância de uma classe, fornecendo um ponto global de acesso a essa instância.
