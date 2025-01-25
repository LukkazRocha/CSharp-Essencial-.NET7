
using _01Delegates;

var resultado = Calculadora.Somar(10, 40);
Console.WriteLine(resultado);

DelegateCalculadora calc = Calculadora.Somar;
var resultado1 = calc.Invoke(20, 30);
Console.WriteLine($"Soma = {resultado1}");

calc = Calculadora.Dividir;
var resultado2 = calc.Invoke(20, 30);
Console.WriteLine($"Dividir = {resultado2}");

calc = Calculadora.Subtrair;
var resultado3 = calc.Invoke(20, 30);
Console.WriteLine($"Subtrair = {resultado3}");

calc = Calculadora.Multiplicar;
var resultado4 = calc.Invoke(20, 30);
Console.WriteLine($"Multiplicar = {resultado4}");

Console.ReadKey();

public delegate float DelegateCalculadora(float x, float y);
