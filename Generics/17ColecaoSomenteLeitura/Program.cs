﻿
using System.Collections.ObjectModel;

var planetas = new List<string>()
{
    "Mercúrio", "Vênus", "Terra", "Marte"
};

var listaPlanetas = new ReadOnlyCollection<string>(planetas);
//var novaLista = planetas.AsReadOnly();

Console.WriteLine("\nPlanetas não gasosos do sistema solar:");
foreach (var planeta in listaPlanetas)
{
    Console.Write($"{planeta} ");
}

Console.WriteLine($"\n\nPlanetas na coleção: {listaPlanetas.Count}");

Console.WriteLine("\nJúpiter está na coleção?");
Console.WriteLine(listaPlanetas.Contains("Júpiter") ? "Sim" : "Não");

Console.WriteLine($"\nPlaneta de índice 3: {listaPlanetas[3]}");

Console.WriteLine($"\nÍndice do planeta Terra: {listaPlanetas.IndexOf("Terra")}");

Console.WriteLine("\nInserindo um novo elemento na Lista original (índice 4)");
planetas.Insert(4, "Plutão");
Console.WriteLine("\nExibindo o novo planeta na lista");
foreach (string planeta in listaPlanetas)
{
    Console.Write($"{planeta} ");
}

Console.WriteLine("\n\nCopiando os elementos da coleção para um Array unidimensional");
string[] planetasArray = new string[listaPlanetas.Count + 2];
listaPlanetas.CopyTo(planetasArray, 1);
foreach (string planeta in planetasArray)
{
    Console.WriteLine($"\"{planeta}\"");
}

Console.ReadKey();