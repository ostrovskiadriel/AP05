public class Leitor
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public List<Emprestimo> Emprestimos { get; set; }

    public Leitor(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
        Emprestimos = new List<Emprestimo>();
    }

    public void ExibirEmprestimos()
    {
        Console.WriteLine($"Emprestimos de {Nome}:");
        foreach (var emprestimo in Emprestimos)
        {
            emprestimo.ExibirInformacoes();
            Console.WriteLine("-----");
        }
    }
}
