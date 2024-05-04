Console.WriteLine("## Nullable Types ##\n");

//int? i = null;
//double? d = null;
//bool? b = null;

//Console.WriteLine(i);
//Console.WriteLine(d);
//Console.WriteLine(b);

//////////////////////////////////////////////////

//int? a = null;

//int b = a ?? 0;

//////////////////////////////////////////////////

//int? x = 4;
//int? y = 3;
//int? z = x * 3;

//Console.WriteLine(z);

//////////////////////////////////////////////////

int? b = null;

if (b.HasValue)
{
    Console.WriteLine($"b = {b.Value}");
}
else
{
    Console.WriteLine("b não possui um valor (null)");
}

Console.ReadKey();