using System.Collections;

//Análise de desempenho

ArrayList obj = new ArrayList();

//boxing - converter o tipo por valor para o tipo referência
obj.Add(50);

int x = (int)obj[10]; // realize o unboxing

foreach (int i in obj)
{
    Console.WriteLine(i); // realize o unboxing
}