Console.WriteLine("### Arrays Bidimensionais ###\n");

//int[,] a;

//a = new int[2, 2];

//a[0, 0] = 10;
//a[0, 1] = 11;
//a[1, 0] = 12;
//a[1, 1] = 13;

//Console.WriteLine("\nArray a\n");

//Console.WriteLine(a[0, 0]);
//Console.WriteLine(a[0, 1]);
//Console.WriteLine(a[1, 0]);
//Console.WriteLine(a[1, 1]);

////int[,] b = new int[2, 2] { { 20, 30 }, { 40, 50 } };
//int[,] b = { { 20, 30 }, { 40, 50 } };

//Console.WriteLine("\nArray b\n");

//Console.WriteLine(b[0, 0]);
//Console.WriteLine(b[0, 1]);
//Console.WriteLine(b[1, 0]);
//Console.WriteLine(b[1, 1]);

//////////////////////////////////////////////////////////

int[,] n = {
            { 11, 22, 33 }, //  n[0,0] n[0,1] n[0,2]
            { 44, 55, 66 }, //  n[1,0] n[1,1] n[1,2]
            { 77, 88, 99 }  //  n[2,0] n[2,1] n[2,2]
        };

Console.WriteLine("\nfor\n");
for (int i = 0; i < n.GetLength(0); i++)
{
    for (int j = 0; j < n.GetLength(1); j++)
    {
        Console.Write($"{n[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nforeach\n");
foreach (var x in n)
{
    Console.Write($"{x} ");
}

Console.ReadKey();
