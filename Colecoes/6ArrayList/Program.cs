using System.Collections;

Console.WriteLine("### ArrayList ###\n");

//ArrayList lista;
//lista = new ArrayList();

//ArrayList lista1 = new ArrayList();
//var lista2 = new ArrayList();
//ArrayList lista3 = new();

//ArrayList lista4 = new ArrayList(5);
//var lista5 = new ArrayList(5);
//ArrayList lista6 = new(5);

//ArrayList lista7 = new();

//lista7.Add("Paulo");
//lista7.Add(4.5);
//lista7.Add(5);
//lista7.Add(true);
//lista7.Add(" ");
//lista7.Add(null);

//var lista8 = new ArrayList()
//{
//    "Paulo", 4.5, 5, true, " ", null
//};

////////////////////////////////////////////

//var lista = new ArrayList() { "Maria", 5, true, " ", null };

//lista.Add(3.5);

//lista.Insert(2, "Paulo");

////////////////////////////////////////////

//var lista = new ArrayList() { "Ana", 5, true, " ", 1.1, "Zé", 3, 9, null };

//int[] array1 = { 1, 2, 3, };

//lista.AddRange(array1);

//lista.InsertRange(2, array1);

//lista.Remove(null);

//lista.RemoveAt(4);

//lista.RemoveRange(0, 2);

////////////////////////////////////////////

var lista = new ArrayList() { "Maria", "Ana", "Zilda", "Carlos", "Diná" };

//Verificar se um elemento existe na coleção

//var res1 = lista.Contains(5);
//bool res2 = lista.Contains("Mari");

//Console.WriteLine(res1);
//Console.WriteLine(res2);
//Console.WriteLine(lista.Contains(null));

Console.WriteLine("\nArrayList original \n");
foreach (var item in lista)
{
    Console.Write($"{item} ");
}

Console.WriteLine("\nNúmero de elementos no array " + lista.Count);

lista.Clear();

Console.WriteLine("\nNúmero de elementos no array depois do clear " + lista.Count);

Console.ReadKey();
