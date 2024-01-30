class Musica
{
    public Musica(string nomeMusica, string nomeCompositor, int anoComposicao, int duracao)
    {
        NomeMusica = nomeMusica;
        NomeCompositor = nomeCompositor;
        AnoComposicao = anoComposicao;
        Duracao = duracao;

    }
    public string NomeMusica {get;set;}
    public string NomeCompositor {get;set;}
    public int AnoComposicao {get;set;}
    public int Duracao {get;set;}

    public void ExibirListaMusicas()
    {
        Console.WriteLine($"Música: {NomeMusica} - Compositor: {NomeCompositor} : Ano de composição: {AnoComposicao} - Duração: {Duracao} Segundos");
    }
}