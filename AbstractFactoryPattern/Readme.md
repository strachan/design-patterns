# Abstract Factory Design Pattern

## Definição

Provê um interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas. A criação de objetos é feita por composição de objeto.

## Quando usar

Usar quando tiver muitos objetos que podem ser adicionados or modificados dinamicamente durante o tempo de execução.

## Vantagens

* Não é necessário saber previamente qual classe instanciar
* Centralizar código de seleção
* O usuário não precisa saber todas as subclasses
* Encapsulamento da criação dos objetos
* Desacoplamento reduzindo a dependência da aplicação em classes concretas

## Desvantagens

* Mudança da interface significa mudança na interface de cada subclasse