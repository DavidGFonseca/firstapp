// string logoSoundDisc = @"
// ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░██████╗░██╗░██████╗░█████╗░
// ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗██╔══██╗██║██╔════╝██╔══██╗
// ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║██║░░██║██║╚█████╗░██║░░╚═╝
// ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║██║░░██║██║░╚═══██╗██║░░██╗
// ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝██████╔╝██║██████╔╝╚█████╔╝
// ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░╚═════╝░╚═╝╚═════╝░░╚════╝░";
// string welcome = "\nSeja bem vindo!!!";

// // List<string> listBandas = new List<string>();
// Dictionary<string,List<float>> listBandas = new Dictionary<string, List<float>>();

// ExibirMensagens(logoSoundDisc);
// ExibirMensagens(welcome);

// ListOptionMenu();

// void ExibirMensagens(string mensagem)
// {
//     Console.WriteLine(mensagem);
// }

// void ListOptionMenu()
// {

//     ExibirMensagens("\nOpção 1 - Registrar uma banda");
//     ExibirMensagens("\nOpção 2 - Mostrar todas as bandas");
//     ExibirMensagens("\nOpção 3 - Avaliar uma bandas");
//     ExibirMensagens("\nOpção 4 - Media de uma banda");
//     ExibirMensagens("\nOpção 9 - Sair\n");  
//     string optionStr = Console.ReadLine()!;
//     int optionInt = int.Parse(optionStr);
//     VerifyOption(optionInt);
// }

// void VerifyOption(int option)
// {
//     switch (option)
//     {
//         case 1: RegistreBanda();
//             break;
//         case 2: ListaBandas();
//             break;
//         case 3: AvaliarBanda();
//             break;
//         case 4: MediaBanda();
//             break;
//         default: ExibirMensagens("Opção invalida");
//             break;
//     }
// }

// void RegistreBanda()
// {
//     ExibirMensagens("Informe nome da Banda: \n");
//     string newBanda = Console.ReadLine()!;
//     listBandas.Add(newBanda, new List<float>());
//     Console.Clear();
//     ListOptionMenu();
// }

// void ListaBandas()
// {
//     ExibirMensagens("Lista de Bandas\n");
//     foreach (string banda in listBandas.Keys)
//     {
//         Console.WriteLine($"Banda: {banda}");
//     }
//     Thread.Sleep(2000);
//     Console.Clear();
//     ListOptionMenu();
// }

// void AvaliarBanda()
// {
//     Console.WriteLine("Qual banda deseja avaliar: \n");
//     string bandaChoised = Console.ReadLine()!;
//     if (listBandas.ContainsKey(bandaChoised))
//     {
//         Console.WriteLine($"Informe da nota desejada para a banda {bandaChoised}: ");
//         string notaString = Console.ReadLine()!;
//         float notaBanda = float.Parse(notaString);
//         listBandas[bandaChoised].Add(notaBanda);
//         Console.WriteLine(notaBanda);
//         Console.Clear();

//         ListOptionMenu();
//     } else
//     {
//         ExibirMensagens($"Banda {bandaChoised} não foi encontrada!");

//     }
// }

// void MediaBanda()
// {
//     Console.WriteLine("Qual banda deseja verificar a média das avaliações: \n");
//     string bandaChoised = Console.ReadLine()!;
//     if (listBandas.ContainsKey(bandaChoised))
//     {
//         float notaTotal = 0;
//         foreach (float notaAtual in listBandas[bandaChoised])
//         {
//             notaTotal += notaAtual;

//         }
//         float notaMedia = notaTotal / listBandas[bandaChoised].Count;
//         Console.WriteLine(notaMedia);
//     }

// }

Artista artista1 = new("Tom Jobim");
Musica musica1 = new("Garota de Ipanema",artista1.NomeArtista,1962,240);
Musica musica2 = new("Águas de Março",artista1.NomeArtista,1972,300);
Album albumTomJobim = new("Tom Jobim - Inédito",artista1.NomeArtista);
albumTomJobim.musicas.Add(1,new List<Musica>{musica1});
albumTomJobim.musicas.Add(2,new List<Musica>{musica2});


albumTomJobim.ExibirAlbum();
