public class Aluno : Pessoa
{
    public string Matricula { get; set; }
    public string Turma { get; set; }

    public Aluno(string nome, string cpf, DateTime dataNascimento, string matricula, string turma)
        : base(nome, cpf, dataNascimento)
    {
        Matricula = matricula;
        Turma = turma;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Turma: {Turma}");
    }
}
