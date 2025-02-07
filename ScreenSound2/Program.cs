// Criando episódios e adicionando convidados
Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(1, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flavia");

// Criando um podcast e adicionando episódios
Podcast podcast = new("Podicast Especial", "Eric");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);

// Exibindo detalhes do podcast
podcast.ExibirDetalhes();


// Criando a temporada
Temporada temporada1 = new("\n\n\nMeu Podcast", 1);

// Criando episódios
Episodio ep4 = new(4, "Quarto Episódio", 30);
Episodio ep3 = new(3, "Terceiro Episódio", 45);

// Adicionando episódios à temporada
temporada1.AdicionarEpisodio(ep4);
temporada1.AdicionarEpisodio(ep3);

// Exibindo o resumo da temporada
Console.WriteLine(temporada1.Resumo);  // Saída: Podcast Meu Podcast! Estamos no episódio 2 da temporada 1.
