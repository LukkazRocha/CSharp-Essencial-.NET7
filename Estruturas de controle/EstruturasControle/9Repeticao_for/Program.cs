﻿Console.WriteLine("## Loop for ##\n");

//for (int i = 0, j = 0; i + j <= 20; i++, j++)
//{
//    Console.WriteLine($"i= {i} e j= {j}");
//}

//////////////////////////////////////////////

//int i = 1;
//for (; i <= 10;)
//{
//    Console.WriteLine($"i= {i}");
//    i++;
//}

//////////////////////////////////////////////

for (int x = 0; x < 5; x++)
{
    for (int y = 0; y < 5; y++)
    {
        Console.Write($"({x},{y}) ");
    }
    Console.WriteLine();
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();
