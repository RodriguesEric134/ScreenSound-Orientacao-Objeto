class Temporada
{
    private List<Episodio> Episodios = new(); // Agora armazenamos objetos Episodio

    public Temporada(string nome, int edicao)
    {
        Nome = nome;
        Edicao = edicao;
    }

    public string Nome { get; }
    public int Edicao { get; }

    // Obtém o número do último episódio adicionado ou 0 se não houver episódios
    public int UltimoEpisodio => Episodios.Count > 0 ? Episodios.Last().Ordem : 0;

    public string Resumo => $"Podcast {Nome}! Estamos no episódio {UltimoEpisodio} da temporada {Edicao}.";

    // Método para adicionar episódios
    public void AdicionarEpisodio(Episodio episodio)
    {
        Episodios.Add(episodio);
    }
}
