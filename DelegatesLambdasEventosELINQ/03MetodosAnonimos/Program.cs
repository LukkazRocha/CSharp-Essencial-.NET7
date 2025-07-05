List<string> nomes = new()
{
    "Maria",
    "Miriam",
    "Paulo",
    "Carlos"
};

//string resultado = nomes.Find(VerificaNomeNaLista);

string resultado = nomes.Find(delegate (string nome)
{
    return nome.Equals("Paulo");
});

Console.WriteLine(resultado);

Console.ReadKey();