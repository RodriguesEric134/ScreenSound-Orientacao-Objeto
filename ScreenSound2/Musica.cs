/* O que tem em uma música?
 * Nome - string
 * Artista - string
 * Duração - int
 * Disponibilidade - bool (true ou false)
 * DescriçãoResumida - string (gerada a partir do Nome e Artista, e somente de leitura)
 */
class Musica
{
    public string Nome { get; set; } // Nome da música
    public string Artista { get; set; } // Nome do artista
    public int Duracao { get; set; } // Duração da música em segundos (ou minutos, conforme o caso)
    public bool Disponivel { get; set; } // Indica se a música está disponível (true) ou não (false)
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}"; // Método lambda que gera uma descrição resumida da música e é somente leitura

    public void ExibirFichaTecnica() // Método que exibe informações sobre a música
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Música indisponível no plano, adquira o plano mega plus ultra mais");
        }
    }
}
