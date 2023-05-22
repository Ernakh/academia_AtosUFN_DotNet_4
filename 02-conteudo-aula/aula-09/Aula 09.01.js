/**
 * Javascript
 * 
 * É uma linguagem de programação que roda no navegador do usuário (front-end), ou seja, client side, por isso informações sensíveis não devem ser manipuladas no lado do cliente.
 * 
 * Tem diversos usos, como:
 *  - Validar formários;
 * - Controlar o que é exibido e o que é escondido em uma tela;
 * - Animar um elemento;
 * - Calcular valores;
 * - Alterar estilos;
 * - Comunicar-se com o back-end;
 * - etc.
 * 
 * Javascript é uma linguagem interpretada, ou seja, o código é lido de cima para baixo e executado conforme a leitura.
 * 
 * É uma linguagem fracamente tipada e dinâmica, ou seja, não é necessário definir o tipo de dado da variável no momento da sua criação e o mesmo pode ser alterado no decorrer da execução, o uso do ponto e vírgula (;) é opcional.
 * 
 * O nome da variável é case sensitive, ou seja, letras maiúsculas e minúsculas fazem diferença no nome da variável.
 * 
 *Existem 3 formas de adicionar o javascript em uma página HTML:
    * - Inline: diretamente na tag HTML; Ex:
    * <button onclick="alert('Oi')">Clique aqui</button>
    * 
    * - Tag <script> no head: dentro da tag script, no head do HTML; Ex:
    * <head>
    *  <script>
    *  alert('Oi');
    * </script>
    * </head>
    * 
    * - Por meio de um arquivo externo: dentro da tag script, no head do HTML; Ex:
    * <body>
    * <script src="script.js"></script>
    * </body>
    * 
    * O arquivo externo é o mais recomendado, pois deixa o código mais organizado e de fácil manutenção.
    * 
    * Para acessar o console do navegador, basta clicar com o botão direito do mouse na página e clicar em inspecionar. Na aba que abrir, clique em console.
    * 
    * Para exibir uma mensagem no console, basta digitar console.log('mensagem');
    *
 */

// Variáveis
//  Para criar uma variável, basta digitar a palavra reservada var, let ou const, seguida do nome da variável e do valor que ela irá armazenar, separados por um sinal de igual (=). Ex:
var nome = 'Fernando';
let idade = 28;
const possuiFaculdade = true;

// O uso de var, let ou const depende da necessidade de alteração do valor da variável. Se o valor não for alterado, deve-se usar const, caso contrário, deve-se usar let.

//Condicionais
//  São utilizadas para verificar se uma condição é verdadeira ou falsa e, a partir disso, executar um trecho de código ou outro. Ex:
if (idade > 18) {
    console.log('Maior de idade');
} else {
    console.log('Menor de idade');
}

// Operadores de comparação
//  São utilizados para comparar dois valores e retornar verdadeiro ou falso. Ex:
10 > 5; // true
5 > 10; // false

// Laços de repetição
//  São utilizados para repetir um trecho de código enquanto uma condição for verdadeira. Ex:

// while
var i = 0;
while (i <= 10) {
    console.log(i);
    i++;
}

// Do while
var i = 0;
do {
    console.log(i);
    i++;
} while (i <= 10);

// for
for (var i = 0; i <= 10; i++) {
    console.log(i);
}

// Arrays
//  São utilizados para armazenar vários valores em uma única variável. Ex:
var videoGames = ['Switch', 'PS4', 'XBox'];

// Para acessar um valor específico do array, basta informar o índice do valor desejado. Ex:
videoGames[0]; // Switch
videoGames[2]; // XBox

// Para adicionar um valor ao array, basta informar o índice do valor desejado e atribuir o valor. Ex:
videoGames[3] = '3DS';

// Para verificar o tamanho do array, basta utilizar a propriedade length. Ex:
videoGames.length; // 4

// Funções
//  São utilizadas para armazenar um trecho de código que pode ser executado diversas vezes. Ex:
function soma(a, b) {
    return a + b;
}

// Para executar a função, basta informar o nome da função seguido dos parênteses e dos valores que serão passados como parâmetro. Ex:
soma(1, 2); // 3

// Objetos
//  São utilizados para armazenar diversas propriedades e métodos em uma única variável. Ex:
var pessoa = {
    nome: 'Lucas Ferreira',
    idade: 32,
    profissao: 'Desenvolvedor',
    possuiFaculdade: false,

    // Métodos
    apresentesse: function () {
        console.log('Meu nome é ' + this.nome + ', tenho ' + this.idade + ' anos e sou ' + this.profissao + '.');
    }


}

// Para acessar uma propriedade do objeto, basta informar o nome do objeto seguido de um ponto e do nome da propriedade. Ex:
pessoa.nome; // Lucas Ferreira
pessoa.possuiFaculdade; // false

// Para acessar um método do objeto, basta informar o nome do objeto seguido de um ponto e do nome do método, seguido de parênteses. Ex:
pessoa.apresentesse(); // Meu nome é Lucas Ferreira, tenho 32 anos e sou Desenvolvedor.

// DOM
//  É uma interface que representa documentos HTML e XML através de objetos. Com ela, é possível manipular o HTML com o Javascript. Ex:
//  Para selecionar um elemento do HTML, basta utilizar o método querySelector() e informar o seletor do elemento desejado. Ex:

document.querySelector('.titulo'); // <h1 class="titulo">Título</h1>

// Para alterar o conteúdo de um elemento, basta utilizar a propriedade innerHTML e atribuir o novo valor. Ex:
document.querySelector('.titulo').innerHTML = 'Novo título';

// Para alterar o valor de um atributo de um elemento, basta utilizar a propriedade setAttribute() e atribuir o novo valor. Ex:
document.querySelector('.titulo').setAttribute('id', 'titulo');

// Para adicionar uma classe a um elemento, basta utilizar a propriedade classList.add() e atribuir o nome da classe. Ex:
document.querySelector('.titulo').classList.add('titulo-principal');

// Eventos
//  São utilizados para executar uma função quando algo acontece na página. Ex:
//  Para adicionar um evento a um elemento, basta utilizar a propriedade addEventListener() e informar o nome do evento e a função que será executada. Ex:
const titulo = document.querySelector('.titulo');
titulo.addEventListener('click', function () {
    console.log('Clicou no título');
});

// jQuery
//  É uma biblioteca de funções Javascript que facilita a manipulação de elementos HTML. Ex:

// Para selecionar um elemento do HTML, basta utilizar o método jQuery() e informar o seletor do elemento desejado. Ex:
$('h1'); // <h1 class="titulo">Título</h1>

// Para alterar o conteúdo de um elemento, basta utilizar o método html() e atribuir o novo valor. Ex:
$('h1').html('Novo título');

// Para alterar o valor de um atributo de um elemento, basta utilizar o método attr() e atribuir o novo valor. Ex:
$('h1').attr('id', 'titulo');

// Para adicionar uma classe a um elemento, basta utilizar o método addClass() e atribuir o nome da classe. Ex:
$('h1').addClass('titulo-principal');

// Para adicionar um evento a um elemento, basta utilizar o método on() e informar o nome do evento e a função que será executada. Ex:
$('h1').on('click', function () {
    console.log('Clicou no título');
});

// Efeitos
//  São utilizados para alterar o CSS de um elemento. Ex:

// Para alterar o CSS de um elemento, basta utilizar o método css() e informar o nome da propriedade e o valor. Ex:
$('h1').css('color', 'red');

