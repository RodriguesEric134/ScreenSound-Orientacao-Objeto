/* o que tem em uma música?
 * artista - string
 * nome - string
 * duração -int
 * disponibilidade - booleano (true or false)
 */
class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("disponível no plano");
        }
        else
        {
            Console.WriteLine("Música indisponível no plano, adiquira o plano mega plus ultra mais");
        }
    }
}