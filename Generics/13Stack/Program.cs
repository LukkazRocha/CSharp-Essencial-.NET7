//Stack<int> numeros = new Stack<int>();
//numeros.Push(1);

//int[] array1 = new int[] { 1, 2, 3, 4 };
//Stack<int> pilha1 = new Stack<int>(array1);

//var impares = new Stack<int>(3);
//impares.Push(1);

Stack<int> numeros = new Stack<int>();
numeros.Push(10);
numeros.Push(20);
numeros.Push(30);
numeros.Push(10);

Console.WriteLine($"-A pilha original contém {numeros.Count} itens");

ExibirPilha(numeros);

//retorna sem remover
Console.WriteLine($"\n-Item obtido da pilha (Peek) : {numeros.Peek()}");

//remove e retorna
Console.WriteLine($"\n-Item removido da pilha (Pop) : {numeros.Pop()}");

Console.WriteLine($"\nA pilha agora contém {numeros.Count} itens");

if (numeros.Contains(20))
{
    Console.WriteLine("\nItem 20 está na pilha");
}
else
{
    Console.WriteLine("\nItem 20 não está na pilha");
}

Console.WriteLine("\nCopia a pilha usando o ToArray");
var copia = new Stack<int>(numeros.ToArray());
ExibirPilha(copia);

Console.WriteLine("\n-Removendo todos os itens da pilha\n");
numeros.Clear();
Console.WriteLine($"{numeros.Count} itens na pilha");

ExibirPilha(numeros);

Console.ReadKey();

static void ExibirPilha<T>(IEnumerable<T> numeros)
{
    Console.WriteLine();
    foreach (var item in numeros)
    {
        Console.WriteLine(item);
    }
}