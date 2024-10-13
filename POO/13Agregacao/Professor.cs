namespace _13Agregacao
{
    public class Professor
    {
        public Professor(string? nome, string? disciplina)
        {
            Nome = nome;
            Disciplina = disciplina;
        }

        public string? Nome { get; set; }
        public string? Disciplina { get; set; }
    }
}
