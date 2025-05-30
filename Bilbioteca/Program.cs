class Program
{
    static void Main(string[] args)
    {
       
        Livro livro1 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien");
        Livro livro2 = new Livro("Dom Casmurro", "Machado de Assis");

        Leitor leitor1 = new Leitor("Ana", "123.456.789-00");
        Leitor leitor2 = new Leitor("Carlos", "987.654.321-00");

        try
        {
            Emprestimo emprestimo1 = new Emprestimo(livro1, leitor1);
            Emprestimo emprestimo2 = new Emprestimo(livro2, leitor2);

            Console.WriteLine("Empréstimos realizados com sucesso.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao realizar empréstimo: {ex.Message}");
        }

        // Tentativa de emprestar livro já emprestado
        try
        {
            Emprestimo emprestimoInvalido = new Emprestimo(livro1, leitor2);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro esperado: {ex.Message}");
        }

        Console.WriteLine("\nDevolvendo livro...");
        leitor1.Emprestimos[0].Devolver();


        Console.WriteLine("\nEstado dos livros:");
        livro1.ExibirInformacoes();
        livro2.ExibirInformacoes();

        Console.WriteLine("\nEmprestimos dos leitores:");
        leitor1.ExibirEmprestimos();
        leitor2.ExibirEmprestimos();
    }
}
