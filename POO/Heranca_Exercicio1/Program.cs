using Heranca_Exercicio1;

Console.WriteLine("\nConta Corrente: Número: 111 Titular: Maria");
Conta conta = new();
conta.Numero = 111;
conta.Titular = "Maria";

Console.WriteLine("Depositando R$ 1.000,00");
conta.Depositar(1000);
Console.WriteLine("Sacando R$ 100,00");
conta.Sacar(100);
Console.WriteLine($"Saldo da Conta: {conta.Saldo:c}");

Console.WriteLine("Sacando R$ 2.000,00");
conta.Sacar(2000);
Console.WriteLine($"Saldo da Conta: {conta.Saldo:c}");

Console.WriteLine("\nConta Poupança: Número: 222 Titular: José");
ContaPoupanca contaPoupanca = new();
contaPoupanca.Numero = 222;
contaPoupanca.Titular = "José";
Console.WriteLine("Depositando R$ 1.000,00");
contaPoupanca.Depositar(1000);
Console.WriteLine("Sacando R$ 100,00");
contaPoupanca.Sacar(100);
Console.WriteLine($"Saldo da Conta Poupança: {contaPoupanca.Saldo:c}");

Console.WriteLine("Sacando R$ 2.000,00");
contaPoupanca.Sacar(2000);
Console.WriteLine($"Saldo da Conta Poupança: {contaPoupanca.Saldo:c}");

Console.WriteLine("\nConta Investimento: Número: 333 Titular: Ana");
ContaInvestimento contaInvestimento = new();
contaInvestimento.Numero = 333;
contaInvestimento.Titular = "Ana";

Console.WriteLine("Depositando R$ 1.000,00");
contaInvestimento.Depositar(1000);
Console.WriteLine("Sacando R$ 100,00");
contaInvestimento.Sacar(100);
Console.WriteLine($"Saldo da Conta Investimento: {contaInvestimento.Saldo:c}");

Console.WriteLine("Sacando R$ 2.000,00");
contaPoupanca.Sacar(2000);
Console.WriteLine($"Saldo da Conta Investimento: {contaInvestimento.Saldo:c}");

Console.ReadKey();