using Fundamentos.Models;  //Mostrando o namespace ao qual a class pessoa está


DateTime dataatual = DateTime.Now; //Puxa a data atual do computador. Caso queria adicionar dias na data atual .AddDays(5)
Console.WriteLine($"A data e hora atual são: {dataatual}"); // Caso queira formatar apenas para aparecer dd/MM/yyyy:  .ToString("dd/MM/yyyy") ou .ToString("HH/mm") para mostrar somente a hora.


//Declarando variáveis
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


//Instanciando uma classe 
/*Pessoa p = new Pessoa();

p.Nome = "Igor";
p.Idade = 20;
p.Apresentar();
*/


