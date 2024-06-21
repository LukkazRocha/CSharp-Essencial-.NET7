Console.WriteLine("## Instrução for ##\n");

double resultado, numero;
double i;

Console.WriteLine("Informe o número inteiro maior que zero: \t");
numero = Convert.ToInt32(Console.ReadLine());


if (numero > 0)
{
    for (i = 1; i <= 10; i++)
    {
        resultado = numero * i;
        //Console.WriteLine(numero + " X " + i + " = " + resultado);
        Console.WriteLine($"{numero} X {i} = {resultado}");
    }
}
else
{
    Console.WriteLine("Número inválido");
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();
