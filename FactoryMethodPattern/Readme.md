# Factory Method Pattern

## Definição

Factory method pattern define uma interface para criação de um objeto, mas permite que subclasses decidam qual classe instanciar. Esse termo decisão não é porque a classe decide durante o tempo de execução e sim porque a classe construtora é escrita sem o conhecimento dos produtos que serão criados. A criação de objetos é feita por herança.

## Quando usar

Será usado quando uma classe não consegue antecipar qual tipo de objeto ela precisa criar. 

## Vantagens

* Não é necessário saber previamente qual classe instanciar
* Centralizar código de seleção
* O usuário não precisa saber todas as subclasses
* Encapsulamento da criação dos objetos
* Desacoplamento reduzindo a dependência da aplicação em classes concretas
