namespace _12Interfaces_exercicio
{
    public interface ISalvar
    {
        void Salvar();

        void Compactar()
        {
            Console.WriteLine("Compactando arquivos");
        }
    }
}
