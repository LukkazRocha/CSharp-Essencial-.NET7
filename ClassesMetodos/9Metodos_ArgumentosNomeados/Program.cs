Console.WriteLine("## Argumentos nomeados ##\n");

Email email = new();

email.Enviar("teste@email.com", "Reunião de Orçamento", "Urgente");


//argumentos nomeados
email.Enviar(titulo: "Urgente", destino: "teste@email.com", assunto: "Reunião de Orçamento");

Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}
