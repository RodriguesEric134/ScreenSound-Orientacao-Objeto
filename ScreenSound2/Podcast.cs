class Podcast
{
    // Lista privada para armazenar os episódios do podcast
    private List<Episodio> episodios = new();

    // Construtor que define o nome do podcast e o apresentador
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    // Propriedades somente leitura
    public string Nome { get; }
    public string Host { get; }

    // Propriedade calculada que retorna a quantidade de episódios
    public int TotalEpisodios => episodios.Count;

    // Método para adicionar um episódio à lista do podcast
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    // Método para exibir detalhes do podcast e seus episódios
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");

        // Ordena os episódios por ordem e exibe o resumo de cada um
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nEste podcast possui {TotalEpisodios} episódios");
    }
}