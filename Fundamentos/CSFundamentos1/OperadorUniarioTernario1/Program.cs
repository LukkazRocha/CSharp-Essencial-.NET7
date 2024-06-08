Console.WriteLine("## Operador Unário e Ternário ##\n");

Console.WriteLine("Informe a temperatura: \n");
var temp = Convert.ToDouble(Console.ReadLine());

var resultado = temp > 27 ? "Quente" : "Normal";

Console.WriteLine($"O tempo está {resultado}");

Console.ReadKey();
