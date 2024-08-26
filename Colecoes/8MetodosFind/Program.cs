
List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maçã", "Abacate", "Laranja", "Morango"
};

//usando Predicado como uma função
var fruta1 = frutas.Find(Procura);
Console.WriteLine(fruta1);
Console.WriteLine($"\nPredicado => {fruta1}");

//usando a expressão lambda
var fruta2 = frutas.Find(f => f.Contains('n'));
Console.WriteLine($"\nExpressão lambda => {fruta2}");

Console.ReadKey();

static bool Procura(string item)
{
    return item.Contains('n');
}
