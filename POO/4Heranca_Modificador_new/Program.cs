
Aluno aluno = new();
aluno.Nome = "Maria";
aluno.Curso = "Química";
Console.WriteLine(aluno.Saudacao());

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }

    public string Saudacao() => $"Oi, eu sou o(a) {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }

    public new string Saudacao()
        => $"Olá, eu sou o(a) {Nome} e estou matriculado(a) no curso de {Curso}";
}
