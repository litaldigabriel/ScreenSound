class Musica
{
    public Musica(Banda artista, string nome, Genero genero)
    {
        Artista = artista;
        Nome = nome;
        Genero = genero;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"{Nome} - {Artista}";
    public Genero Genero { get; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} sec.");
        Console.WriteLine($"Genero: {Genero.Nome}");
        if (Disponivel)
        {
            Console.WriteLine("Música disponível no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}