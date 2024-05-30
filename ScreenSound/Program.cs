Episodio ep1 = new(2, "NerdCast de RPG", 120);
ep1.AdicionarConvidado("Alexandre Ottoni");
ep1.AdicionarConvidado("Azagal");

Episodio ep2 = new(1, "Cotidiano", 60);
ep2.AdicionarConvidado("Alexandre Ottoni");
ep2.AdicionarConvidado("Azagal");
ep2.AdicionarConvidado("Tucano");

Podcast podcast = new("Jovem Nerd", "Alexandre Ottoni e Azagal");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();
