using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Markup;

class Album
{
    public Album(string nomeAlbum, string nomeArtista)
    {
        NomeAlbum = nomeAlbum;
        NomeArtista = nomeArtista;
    }
    public string NomeAlbum {get;set;}
    public string NomeArtista {get;set;}
    public Dictionary<int,List<Musica>> musicas = new();

    public int DuracaoTotal {
        get {
            int duracaoTotal = 0;
            for(int i = 1; i <= musicas.Count; i++)
            {
                duracaoTotal += musicas[i].Sum(m => m.Duracao);
            }
            return duracaoTotal;
        }
    }

    public void AdicionarMusica(int ordem, Musica musica)
    {
        musicas[ordem].Add(musica);
    }

    public void ExibirAlbum()
    {
        Console.WriteLine($"Nome do Album: {NomeAlbum} - Nome Artista/Banda: {NomeArtista}");

        foreach (var chv in musicas)
        {
            Console.WriteLine($"Nº: {chv.Key}");
            foreach (var vlr in chv.Value)
            {
                Console.WriteLine($"{vlr.NomeMusica} - Composição: {vlr.NomeCompositor} Ano: {vlr.AnoComposicao} duração: {vlr.Duracao}");
            }


        }


        Console.WriteLine($"\nDuração total do album {DuracaoTotal/60} Minutos");
    }




}