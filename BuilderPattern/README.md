# Builder Design Pattern

## Definição

Permite a separação da construção de um objeto complexo da sua representação, de forma que o mesmo processo de construção possa criar diferentes representações.

## Quando usar

Usar quando o algoritmo de criação de um objeto complexo é independente das partes que efetivamente compõem o objeto. 
Ou quando o sistema precisa permitir diferentes representações de um objeto que está sendo construído. 

## Vantagens

* Permite variar a representação internal de um produto;
* Encapsula o código entre construção e representação;
* Provê controle durante o processo de construção.

## Desvantagens

* Requer criar um ConcreteBuilder específico para cada instância diferente do produto.