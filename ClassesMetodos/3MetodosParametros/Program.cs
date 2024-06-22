Console.WriteLine("## Métodos ##\n");

MinhaClasse minhaClasse = new();
var nomeCliente = "Maria";
var dataAtual = DateTime.Now.ToShortDateString();

//minhaClasse.Saudacao("Maria", DateTime.Now.ToShortDateString());

minhaClasse.Saudacao(nomeCliente, dataAtual);

Console.ReadKey();

public class MinhaClasse
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}