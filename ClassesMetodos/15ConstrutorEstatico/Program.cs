Console.WriteLine("## Construtor estático ##\n");

//invoca construtor parametrizado e estático
Pessoa p1 = new("Maria", 19);
Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("Idade mínima " + Pessoa.IdadeMinima);

//invoca somente o construtor parametrizado
Pessoa p2 = new("Manoel", 20);
Console.WriteLine(p2.Nome + " - " + p2.Idade);
Console.WriteLine("Idade mínima " + Pessoa.IdadeMinima);

Console.ReadKey();
