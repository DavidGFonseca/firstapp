class Artista
{
    public Artista(string nomeArtista)
    {
        NomeArtista = nomeArtista;
    }
    public string NomeArtista {get;set;}

    public void ExibirNomeArtista()
    {
        Console.WriteLine($"Nome do Artista: {NomeArtista}");
    }
}