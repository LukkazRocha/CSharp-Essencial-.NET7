﻿using System.Collections;

//Análise da segurança de tipagem

ArrayList lista = new ArrayList()
{
    50, // cast boxing
    "Generics", // cast
    new Aluno()
};

foreach (var obj in lista)
{
    Console.WriteLine(obj); // unboxing
}

Console.ReadLine();

public class Aluno
{
    public string? Nome { get; set; }
}