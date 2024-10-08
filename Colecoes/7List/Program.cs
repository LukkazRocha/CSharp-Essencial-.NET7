﻿Console.WriteLine("### List ###\n");

//declarar uma coleção do tipo List<T>
//List<string> lista;
//lista = new List<string>();

//List<int> lista1 = new List<int>();
//var lista2 = new List<float>();
//List<double> lista3 = new();

//List<string> nomes = new();
//nomes.Add("Paulo");
//nomes.Add("Maria");

//var lista4 = new List<string>()
//{
//    "Paulo", "Maria", "Bia", "Pedro"
//};

////////////////////////////////////////////////

//var lista = new List<string>() { "Maria", "Pedro", "Ana" };

//string[] array1 = { "Diná", "Carlos", "Pedro" };

//lista.AddRange(array1);

//lista.InsertRange(1, array1);

////////////////////////////////////////////////

//var lista = new List<int>() { 9, 5, 4, 1, 7, 8, 3, 6, 9, 0 };

//lista.Remove(7);

//lista.RemoveAt(4);

//lista.RemoveRange(0, 2);

//Console.WriteLine(lista.Count + " itens ");

////////////////////////////////////////////////

var lista = new List<string>() { "Maria", "Ana", "Marcos", "Pedro" };

//Acessar um elemento da lista usando índice
//var primeiro = lista[0];
//var quarto = lista[3];

//Console.WriteLine(primeiro);
//Console.WriteLine(quarto);

//lista[0] = "Zé";
//lista[3] = "Silvia";

//Console.WriteLine(lista[0]);
//Console.WriteLine(lista[3]);

////////////////////////////////////////////////

//for (int i = 0; i < lista.Count; i++)
//{
//    Console.WriteLine(lista[i]);
//}

////////////////////////////////////////////////

//var res1 = lista.Contains("Ana");
//var res2 = lista.Contains("Zé");

//var res3 = lista.Contains("Ze");
//var res4 = lista.Contains("Mari");

//Console.WriteLine(lista.Contains("Pedro"));

////////////////////////////////////////////////

ExibirLista(lista);

lista.Sort();

ExibirLista(lista);

lista.Clear();
ExibirLista(lista);
Console.WriteLine(lista.Count + " itens ");
Console.WriteLine("Fim");

Console.ReadKey();

static void ExibirLista(List<string> lista)
{
    Console.WriteLine();
    foreach (var item in lista)
    {
        Console.WriteLine(item);
    }
}