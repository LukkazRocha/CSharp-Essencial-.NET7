
//Queue<string> diasSemana = new Queue<string>();
//diasSemana.Enqueue("Segunda");
//diasSemana.Enqueue("Terça");

//int[] array1 = new int[] { 1, 2, 3, 4, 5 };
//var numeros = new Queue<int>(array1);

//var impares = new Queue<int>(3);
//impares.Enqueue(1);

////////////////////////////////////////////

string[] cursos = { "C#", "Python", "Java", "SQL", "ASP.NET" };
Queue<string> fila1 = new Queue<string>(cursos);

Console.WriteLine("No. de Elementos na fila1: " + fila1.Count());

ExibirFila(fila1);

fila1.Enqueue(".NET MAUI");
ExibirFila(fila1);

Console.WriteLine("\n-Obtem o primeiro item da fila com Peek");
var elemento = fila1.Peek();
Console.WriteLine(elemento);

Console.WriteLine("\n-Método Dequeue - remove item do início da fila");
fila1.Dequeue();
ExibirFila(fila1);

if (fila1.Contains("C#"))
{
    Console.WriteLine("C# está na fila");
}
else
{
    Console.WriteLine("\nC# não está na fila");
}

Console.WriteLine("\n-Limpa a fila com Clear()");
fila1.Clear();
Console.WriteLine("No. de Elementos na fila 1: " + fila1.Count());

Console.ReadKey();

static void ExibirFila<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var item in colecao)
    {
        Console.WriteLine(item);
    }
}