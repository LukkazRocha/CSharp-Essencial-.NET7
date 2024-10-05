namespace Heranca_Exercicio1
{
    public class Conta
    {
        public int Numero { get; set; }
        public string? Titular { get; set; }
        public decimal Saldo { get; set; }

        public virtual double Juros { get; set; }

        private decimal CalculaRemuneracao(double juros)
        {
            return Saldo * (decimal)Juros;
        }

        public virtual decimal Sacar(decimal valor)
        {
            Saldo -= valor;
            return Saldo;
        }

        public decimal Depositar(decimal valor)
        {
            Saldo += valor;
            Saldo = Saldo + CalculaRemuneracao(Juros);
            return Saldo;
        }
    }
}
