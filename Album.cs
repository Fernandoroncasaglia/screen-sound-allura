class Album
{
    private List<Musica> musicas = new List<Musica>();
    

    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum() 
    {
        System.Console.WriteLine($"Lista de musicas do album {Nome}:\n");
        foreach (var musica in musicas) 
        {
            System.Console.WriteLine($"Musica: {musica.Nome}");
        }
        System.Console.WriteLine($"Para ouvir esse album inteiro voce precisa de {DuracaoTotal} segundos");
    }
}