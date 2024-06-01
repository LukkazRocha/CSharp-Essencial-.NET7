Console.WriteLine("## Constantes ##\n");

//calculo da área e perímetro do círculo

double raio, perimetro, area;
const double PI = 3.14;

Console.WriteLine("Informe o raio do círculo");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * Math.PI * raio;
area = Math.PI * Math.Pow(raio, 2);

Console.WriteLine($"Perímetro = {perimetro}");
Console.WriteLine($"Área = {area}");

Console.ReadKey();
