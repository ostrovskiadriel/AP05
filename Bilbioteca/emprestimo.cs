public class Emprestimo
{
    public Livro Livro { get; set; }
    public Leitor Leitor { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime? DataDevolucao { get; set; }

    public Emprestimo(Livro livro, Leitor leitor)
    {
        if (!livro.Disponivel)
        {
            throw new InvalidOperationException("Livro não disponível para empréstimo.");
        }

        Livro = livro;
        Leitor = leitor;
        DataEmprestimo = DateTime.Now;
        DataDevolucao = null;

        livro.Disponivel = false;
        leitor.Emprestimos.Add(this);
    }

    public void Devolver()
    {
        DataDevolucao = DateTime.Now;
        Livro.Disponivel = true;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Livro: {Livro.Titulo}");
        Console.WriteLine($"Leitor: {Leitor.Nome}");
        Console.WriteLine($"Data de Empréstimo: {DataEmprestimo}");
        Console.WriteLine($"Data de Devolução: {(DataDevolucao.HasValue ? DataDevolucao.Value.ToString() : "Em andamento")}");
    }
}
