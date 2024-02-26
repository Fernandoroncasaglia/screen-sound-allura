//Criação de uma classe, onde todos os campos são publicos(podem ser usados em outros arquivos)
class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {Nome} pertence a banda {Artista}";

    //Criação de um métodos (get = leitura set = escrita)

    public void ExibirFichaTecnica() 
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel) 
        {
            Console.WriteLine("Disponivel no plano");
        } else
        {
            Console.WriteLine("Não disponivel no plano");
        }

    }
}

