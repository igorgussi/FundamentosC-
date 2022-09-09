using Fundamentos.Models;  //Mostrando o namespace ao qual as classes estão

//Operador de atribuição (=)
/*
int a= 2, b = 1, c = a +b;
Console.WriteLine($"O valor de c é: {c}" );
*/

//Operadores aritiméticos (+, -, *, /)
/*
int  a = 1, b = 2, c = a + b;
//c = c + 5;
//ou 
c += 5;
Console.WriteLine($"O valor de c é: {c}");
*/

//Conversão de valores (Cast - Casting)
/*
int  a = Convert.ToInt32 ("5"); // Utilizando o método Convert
int b = int.Parse("6"); //Utilizando o método Parse
Console.WriteLine($"Valor de a é: {a}");
Console.WriteLine($"Valor de b é: {b}");
*/


//Conversão para String
/*
int  inteiro = 5;
string a = inteiro.ToString(); //O comando ToStrin() converte qualquer tipo para String 

Console.WriteLine($"{a}");
*/

//Casting implicito
/*
int a = 5; 
double b = a;
Console.WriteLine(b.ToString("0.00"));
*/

//Convertendo de maneira segura 
/*
string a="15-";
int b = 0;

int.TryParse (a, out b); //Nesse caso ele tenta converter a variável "a" de string para int, porém, caso ele não consiga ele não encerra o programa, ele aponta para a variavel "b" como valor de saída
Console.WriteLine(b);
Console.WriteLine("Linha teste para testar execução!");
*/


//Variável do Tipo DateTime
/*
DateTime dataatual = DateTime.Now; //Puxa a data atual do computador. Caso queria adicionar dias na data atual .AddDays(5)
Console.WriteLine($"A data e hora atual são: {dataatual}"); // Caso queira formatar apenas para aparecer dd/MM/yyyy:  .ToString("dd/MM/yyyy") ou .ToString("HH/mm") para mostrar somente a hora.
*/

//Declarando variáveis
/*
string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.70;
decimal preco= 1.99M; //valores decimais, é necessário colocar um M no final
bool condicao = true;

//Exibindo variáveis
Console.WriteLine($"{apresentacao}");
Console.WriteLine($"O valor da variável quantidade é: {quantidade}");
Console.WriteLine($"O valor da variável altura é:{altura.ToString("0.00")}"); //Tratamento para colocar casa decimal em variável do tipo double: ToString("0.00")
Console.WriteLine($"O valor da variável preço é: {preco}");
Console.WriteLine($"O valor da variável condição é: {condicao}");
*/

//Instanciando uma classe 
/*
Produto pr = new Produto();
pr.Nome = "Detergente";
pr.Preco = 1.98M;
pr.Validade  = Convert.ToDateTime("10/01/2024"); //Para inserir uma data é preciso fazer a conversão de String para DateTime
pr.ChamaProduto();

Pessoa p = new Pessoa();
p.Nome = "Igor";
p.Idade = 20;
p.Apresentar();
*/


