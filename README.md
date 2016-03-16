# Sleepyhead barber

C# implementation of sleeping barber problem (I prefer "sleepyhead", it's a very nice term).

###Abstração do algoritmo
O método utilizado para a resolução deste desafio foi a troca de mensagens através de eventos entre a barbearia e o barbeiro.
A barbearia acomoda os clientes em espera e sabe que não pode comportar mais de 5 clientes além do que está em atendimento; adicionalmente, é dentro da barbearia que se sabe qual é o próximo cliente a ser atendido (entende-se que os clientes naturalmente se organizam em fila dentro da barbearia). É dentro dela que o cliente descobre se pode ficar ou se deve ir embora, de acordo com o tamanho da fila.
O barbeiro sabe quando um atendimento foi iniciado, quando foi finalizado e quando cada cabelo do cliente foi cortado. Também é sua função atender um cliente e chamar pelo próximo cliente da barbearia. O barbeiro entende que pode voltar a dormir caso não haja um cliente a ser atendido, assim como entende que deve acordar quando um cliente solicitar atendimento.
O cliente não tem nenhuma informação relevante além da sua quantidade atual de cabelo, afinal é tudo que importa ao barbeiro e à barbearia.

###Nota sobre a escolha de design
Ao ler o desafio proposto no trabalho, o pensamento que surge num primeiro momento é fazer o barbeiro ser uma thread, sendo que esta thread vai consultar e modificar uma fila na thread principal (a barbearia). Entretanto, optei por fazer o barbeiro ter uma thread, em vez de ser uma thread. O framework .Net provê uma classe leve e muito útil chamada Timer, que executa um callback a cada X millisegundos. Este Timer nada mais é do que uma thread encapsulada, exatamente o que eu necessitava. Desta forma, o barbeiro e a barbearia possuem, cada um, uma thread (encapsulada no Timer). Isto facilita a criação de um código enxuto e fácil de abstrair (afinal, composição é preferível ante herança). O resultado foi a criação de classes muito simples, com poucos métodos e propriedades, que resolvem 100% do problema.
