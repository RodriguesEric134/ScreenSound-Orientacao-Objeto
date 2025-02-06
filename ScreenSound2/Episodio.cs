// Classe que representa um episódio de podcast
class Episodio
{
    // Lista privada para armazenar os convidados do episódio
    private List<string> convidados = new();

    // Construtor que define os valores do episódio ao ser criado
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    // Propriedades somente leitura
    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }

    // Propriedade calculada que retorna um resumo do episódio
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";

    // Método para adicionar convidados ao episódio
    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}