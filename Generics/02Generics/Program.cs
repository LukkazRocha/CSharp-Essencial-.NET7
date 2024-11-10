
ClasseGenerica<string> objString = new();

objString.Adicionar("10");
objString.Adicionar("20");
objString.Adicionar("30");
objString.Adicionar("40");
objString.Adicionar("50");

Console.WriteLine("Classe ClasseGenerica<T> de objetos string\n");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(objString[i]);
}


Console.ReadKey();

public class ClasseGenerica<T>
{
    //definição do array com 5 elementos
    T[] obj = new T[5];
    int contador = 0;
    //adicionar elementos
    public void Adicionar(T item)
    {
        if (contador < 5)
        {
            obj[contador] = item;
        }
        contador++;
    }

    // indexador
    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}
