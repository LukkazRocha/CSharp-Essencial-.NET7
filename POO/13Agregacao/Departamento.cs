namespace _13Agregacao
{
    public class Departamento
    {
        public Departamento(string? nome)
        {
            Nome = nome;
            Professores = new List<Professor>();
        }

        public string? Nome { get; set; }
        private List<Professor>? Professores { get; set; }

        public void IncluirProfessor(Professor professor)
        {
            Professores?.Add(professor);
        }

        public void ListaProfessores()
        {
            Console.WriteLine($"\nDepartamento de: {Nome}\n");

            foreach (var prof in Professores)
            {
                Console.WriteLine(prof.Nome + " -> " + prof.Disciplina);
            }
        }
    }
}
