Console.WriteLine("\n ## Entrada de dados ##");

Console.WriteLine("\nInforme o seu nome");
string nome = Console.ReadLine();

Console.WriteLine("\nInforme a sua idade");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O seu nome é {nome}");
Console.WriteLine($"e você tem {idade} anos");

Console.ReadKey();