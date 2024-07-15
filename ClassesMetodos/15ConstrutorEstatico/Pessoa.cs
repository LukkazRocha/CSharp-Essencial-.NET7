


public class Pessoa
{
    public static int IdadeMinima;

    public int Idade { get; set; }
    public string Nome { get; set; } = string.Empty;

    public Pessoa(string nome, int idade)
    {
        Console.WriteLine("\nExecutando o construtor parametrizado");
        Nome = nome;
        Idade = idade;
    }

    public Pessoa()
    {

    }

    static Pessoa()
    {
        Console.WriteLine("\nExecutando o construtor estático");
        Console.WriteLine("\nInicializando o campo IdadeMinima");
        IdadeMinima = 18;
    }
}
