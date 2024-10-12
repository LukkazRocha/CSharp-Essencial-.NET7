using _8Heranca_UpcastingDowncasting;

//Object carroObj = new Carro();

//var x = carroObj as string;

//if (x != null)
//{
//    Console.WriteLine("converteu obj para string");
//}
//else
//{
//    Console.WriteLine("Não foi possível converter, x é null");
//}

/////////////////////////////////////////////////////////////////////

//Circulo circulo = new();
//Forma forma = new(); // upcasting

////Circulo c = (Circulo)forma;
//Circulo? c = forma as Circulo; // downcast

//if (c != null)
//{
//    c.PintarCirculo();
//}
//else
//{
//    Console.WriteLine("Operação de downcast é inválida");
//}

/////////////////////////////////////////////////////////////////////

Circulo circulo = new();
Forma forma = circulo;

if (forma is Circulo) //verifica se o downcast é possível
{
    Console.WriteLine("Converteu Forma para Círculo\n");

    //((Circulo)forma).PintarCirculo();
    var tipo = forma as Circulo;
    tipo?.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcast não é possível");
}

Console.ReadKey();
class Carro
{

}
