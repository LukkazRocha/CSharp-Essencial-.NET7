
MeuDelegate delegateMulticast = new MeuDelegate(Metodo1);
delegateMulticast += Metodo2;

delegateMulticast("Olá, multicast delegate!");

Console.ReadKey();

static void Metodo1(string mensagem)
{
    Console.WriteLine("Método 1: " + mensagem);
}

static void Metodo2(string mensagem)
{
    Console.WriteLine("Método 2: " + mensagem);
}

public delegate void MeuDelegate(string mensagem);