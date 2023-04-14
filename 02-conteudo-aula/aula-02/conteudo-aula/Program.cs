// Várias etapas do processamento de um algoritmo envolvem operações matemáticas.

// A linguagem C# possui uma biblioteca padrão que contém uma série de calculos matemáticos mais complexto, Math.

// - Funções trigonométircas
Console.WriteLine($"Funções trigonométricas:");
// Seno, Cosseno e Tangente: Essa funções retornam o valor de um ângulo em radianos.

double valorX, seno, cosseno, tangente;

valorX = Math.PI; // PI é uma constante da classe Math que representa o valor de PI.

Console.WriteLine($"Valor de PI: {valorX}");

seno = Math.Sin(valorX/2);
cosseno = Math.Cos(valorX/3);
tangente = Math.Tan(valorX/4);

Console.WriteLine($"Seno de 90: {seno}");
Console.WriteLine($"Cosseno de 60: {cosseno}");
Console.WriteLine($"Tangente de 45: {tangente}");

Console.WriteLine($"=====================================");


// - Função de Potenciação e Raiz Quadrada
Console.WriteLine($"Funções de Potenciação e Raiz Quadrada:");
// Essas funções retornam o valor de um número elevado a uma potência ou a raiz quadrada de um número.

// Raiz Quadrada
double valor = 9;
double resultadoRaiz = Math.Sqrt(valor);
Console.WriteLine($"Raiz quadrada de {valor}: {resultadoRaiz}");

// Potencia
double valorBase = 2;
double valorExpoente = 3;
double resultadoPotencia = Math.Pow(valorBase, valorExpoente);
Console.WriteLine($"Potencia de {valorBase} elevado a {valorExpoente}: {resultadoPotencia}");

Console.WriteLine($"=====================================");

// Função de Logaritmo e Exponencial
Console.WriteLine($"Funções de Logaritmo e Exponencial:");
// Essas funções retornam o valor do logaritmo de um número ou o valor de um número elevado a uma potência.

// Logaritmo: A função Math.Log(x) calcula o logaritmo natural de um número. Enquanto a função Math.Log10(x) calcula o logaritmo de base 10 de um número.

double valorLog = 100;
double resultadoLogNatural = Math.Log(valorLog);
double resultadoLogBase10 = Math.Log10(valorLog);
Console.WriteLine($"Logaritmo natural de {valorLog}: {resultadoLogNatural}");
Console.WriteLine($"Logaritmo de base 10 de {valorLog}: {resultadoLogBase10}");

// Exponencial: A função Math.Exp(x) calcula o valor de [e] elevado a uma potência.

double valorExp = 2;
double resultadoExp = Math.Exp(valorExp);
Console.WriteLine($"Exponencial de {valorExp}: {resultadoExp}");

Console.WriteLine($"=====================================");

// Arrerondamento e Truncamento
Console.WriteLine($"Arrerondamento e Truncamento:");

// Função Math.Ceiling(x): Retorna o primeiro float sem casas decimais acima de x.

double valorCeiling = 3.1415;
double resultadoCeiling = Math.Ceiling(valorCeiling);

Console.WriteLine($"Valor arrerondado para cima: {resultadoCeiling}");


// Função Math.Floor(x): Retorna o primeiro float sem casas decimais abaixo de x.

double valorFloor = 3.1415;
double resultadoFloor = Math.Floor(valorFloor);
Console.WriteLine($"Valor arrerondado para baixo: {resultadoFloor}");

// Função Math.Round(x): Retorna o primeiro float sem casas decimais mais próximo de x. De acordo com a convenção matemática
// - Se x estiver até .49999, o valor é arredondado para baixo.
// - Se x estiver acima de .5, o valor é arredondado para cima.

double valorRound = 3.1415;
double resultadoRound = Math.Round(valorRound);

Console.WriteLine($"Valor arrerondado para o mais próximo: {resultadoRound}");

double valorRound2 = 3.45;
double resultadoRound2 = Math.Round(valorRound2);
Console.WriteLine($"Valor arrerondado para o mais próximo: {resultadoRound2}");

double valorRound3 = 3.55;
double resultadoRound3 = Math.Round(valorRound3);
Console.WriteLine($"Valor arrerondado para o mais próximo: {resultadoRound3}");

// Função Math.Truncate(x): Retorna o float sem casas decimais.

double valorTruncate = 3.1415;
double resultadoTruncate = Math.Truncate(valorTruncate);
Console.WriteLine($"Valor truncado: {resultadoTruncate}");

double valorTruncate2 = 3.45;
double resultadoTruncate2 = Math.Truncate(valorTruncate2);
Console.WriteLine($"Valor truncado: {resultadoTruncate2}");

double valorTruncate3 = 3.55;
double resultadoTruncate3 = Math.Truncate(valorTruncate3);
Console.WriteLine($"Valor truncado: {resultadoTruncate3}");


Console.WriteLine($"=====================================");

// Constantes Matemáticas
Console.WriteLine($"Constantes Matemáticas:");

// A classe Math possui algumas constantes matemáticas que podem ser utilizadas em seus algoritmos.

// e: Número de Euler (2,7182818284590452)
Console.WriteLine($"Simbolo: e | Número de Euler: | Math.E | Valor: {Math.E}");

// PI: Número PI (3,1415926535897931)
Console.WriteLine($"Simbolo: PI | Número PI: | Math.PI | Valor: {Math.PI}");

// Tau: Número Tau (6,2831853071795862)
Console.WriteLine($"Simbolo: Tau | Número Tau: | Math.Tau | Valor: {Math.Tau}");

Console.WriteLine($"=====================================");