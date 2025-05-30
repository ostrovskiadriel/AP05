class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        pessoas.Add(new Aluno("Ana", "123.456.789-00", new DateTime(2005, 5, 10), "A001", "3ºA"));
        pessoas.Add(new Professor("Carlos", "987.654.321-00", new DateTime(1980, 3, 15), new List<string> { "Matemática", "Física" }));
        pessoas.Add(new Funcionario("Beatriz", "111.222.333-44", new DateTime(1975, 7, 20), "Secretaria"));

        foreach (var pessoa in pessoas)
        {
            Console.WriteLine("-----");
            pessoa.ExibirInformacoes();
        }
    }
}
