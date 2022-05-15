using System;
using System.Collections.Generic;
using System.Linq;
using EstudoMusica;

namespace EstudoMusica{
    class Program{
        static void Main(string[] args){
            //Variáveis
            string pesquisaNomeArtista;
            int pesquisaAnoAlbum;
            string pesquisaNomeAno;
            string pesquisaNomeProdutorGenero;
            string pesquisaNomeProdutorAno;

            //Criando listas
            var todosArtistas = new List<Artista>();
            var todosProdutores = new List<Produtor>();

            //Criando artistas e adicionando a lista
            var silkSonic = new Artista(new DateTime(2021, 02, 26), "rnb", "Silk Sonic", 12345678901, new DateTime(1985, 10, 8), new DateTime(2300));
            todosArtistas.Add(silkSonic);
            var brunoMars = new Artista(new DateTime(2021, 02, 26), "pop", "Bruno Mars", 11876543212, new DateTime(1985, 10, 8), new DateTime(2300));
            todosArtistas.Add(brunoMars);
            
            //Criando produtor e adicionando à lista
            var stereotypes = new Produtor("The Stereotypes", "The Stereotypes", new DateTime(2003, 5, 1), new DateTime(2300), 12345678901);
            todosProdutores.Add(stereotypes);
            //Adicionando gênero do produtor
            stereotypes.Generos.Add("RnB");
            
            //Criando álbuns
            var anEvening = new Album("An Evening With Silk Sonic", "rnb", new DateTime(2021, 11, 12), "capa Silk Sonic");
            var unortodox = new Album("Unorthodox Jukebox", "pop", new DateTime(2012, 12, 7), "capa Unorthodox Jukebox");

            //Criando músicas e adicionando aos álbuns
            //silksonic
            var leaveDoor = new Musica("Leave the Door Open", "rnb", 242, new DateTime(2021, 11, 12));
            anEvening.Musicas.Add(leaveDoor);

            var flyasMe = new Musica("Fly As Me", "rnb", 219, new DateTime(2021, 11, 12));
            anEvening.Musicas.Add(flyasMe);

            var smokingOut = new Musica("Smoking Out the Window", "rnb", 197, new DateTime(2021, 11, 12));
            anEvening.Musicas.Add(smokingOut);
            //unortodox
            var lockedOut = new Musica("Locked Out of Heaven", "pop", 233, new DateTime(2012, 12, 7));
            unortodox.Musicas.Add(lockedOut);

            var treasure = new Musica("Treasure", "pop", 178, new DateTime(2012, 12, 7));
            unortodox.Musicas.Add(treasure);
            
            var wenIWas = new Musica("When I Was Your Man", "pop", 213, new DateTime(2012, 12, 7));
            unortodox.Musicas.Add(wenIWas);

            //Adicionando Álbum a artista e produtor
            silkSonic.Albuns.Add(anEvening);
            brunoMars.Albuns.Add(unortodox);
            stereotypes.Albuns.Add(anEvening);
            stereotypes.Albuns.Add(unortodox);

            int escolha = 22;

            do{
		Console.WriteLine("Aperte qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Digite a opção:");
                Console.WriteLine("1. Todos os álbuns de determinado artista");
                Console.WriteLine("2. Todos os álbuns de determinado ano");
                Console.WriteLine("3. Todas as músicas de um determinado artista");
                Console.WriteLine("4. Todas as músicas de um artista lançadas em um determinado ano");
                Console.WriteLine("5. Todos os albuns de um mesmo genero de um produtor");
                Console.WriteLine("6. Todos os álbuns do mesmo ano de um produtor");
                Console.WriteLine("7. A lista ordenada decrescente de lançamento dos álbuns de um artista");
                Console.WriteLine("0. Sair:");

                escolha = int.Parse(Console.ReadLine());

                switch(escolha){
                    case 1:
                        //Todos os álbuns de determinado artista
                        Console.WriteLine("Digite o artista para procurar os álbuns dele: ");
                        pesquisaNomeArtista = Console.ReadLine();
                        
                        var albunsArtista = from c in todosArtistas 
                                    from albuns in c.Albuns
                                    where c.Nome.Equals(pesquisaNomeArtista)
                                    select albuns;

                        Console.WriteLine("Albuns lancados de " + pesquisaNomeArtista + ":");
                        foreach(Album albumSelecionado in albunsArtista){
                            Console.WriteLine(albumSelecionado.Nome + "\n");
                        }
                    break;
                    case 2:
                        //Todos os álbuns de determinado ano
                        Console.WriteLine("Digite o ano para procurar os álbuns desse ano: ");
                        pesquisaAnoAlbum = int.Parse(Console.ReadLine());
                        
                        var albunsAno = from c in todosArtistas 
                                    from albuns in c.Albuns
                                    where albuns.DataLancamento.Year == pesquisaAnoAlbum
                                    select albuns;

                        Console.WriteLine("Albums lancados no ano " + pesquisaAnoAlbum);
                        foreach(Album albumSelecionado in albunsAno){
                            Console.WriteLine("\n" + albumSelecionado.Nome);
                        }
                    break;
                    case 3:
                        //Todas as músicas de um determinado artista
                        Console.WriteLine("Digite o artista para procurar as músicas dele: ");
                        pesquisaNomeArtista = Console.ReadLine();

                        var musicasArtista = from c in todosArtistas 
                                    from albuns in c.Albuns
                                    from musicas in albuns.Musicas
                                    where c.Nome.Equals(pesquisaNomeArtista)
                                    select musicas;

                        Console.WriteLine("Musicas lançadas de " + pesquisaNomeArtista + ":");
                        foreach(Musica musicaSelecionada in musicasArtista){
                            Console.WriteLine(musicaSelecionada.Nome + "\n");
                        }
                    break;
                    case 4:
                        //Todas as músicas de um artista lançadas em um determinado ano
                        Console.WriteLine("Digite o nome do artista para procurar pelas suas musicas: ");
                        pesquisaNomeAno = Console.ReadLine();
                        Console.WriteLine("Digite o ano para procurar as musicas desse ano: ");
                        int pesquisaAnoMusica = int.Parse(Console.ReadLine());
                        
                        var musicasAno = from c in todosArtistas
                                    from albuns in c.Albuns
                                    from musicas in albuns.Musicas
                                    where musicas.DataLancamento.Year.Equals(pesquisaAnoMusica) && c.Nome.Equals(pesquisaNomeAno)
                                    select musicas;

                        Console.WriteLine("Musicas de " + pesquisaNomeAno + " lançadas no ano de " + pesquisaAnoMusica + "\n");
                        foreach(Musica musicaSelecionada in musicasAno){
                            Console.WriteLine(musicaSelecionada.Nome + "\n");
                        }
                    break;
                    case 5:
                        //Todos os albuns de um mesmo genero de um produtor
                        Console.WriteLine("Digite o nome do produtor para procurar pelos seus álbuns: ");
                        pesquisaNomeProdutorGenero = Console.ReadLine();
                        Console.WriteLine("Digite o nome do genero pala procurar pelos seus álbuns: ");
                        string pesquisaGenero = Console.ReadLine();

                        var albunsGeneroProd = from c in todosProdutores
                                        from albuns in c.Albuns
                                        where albuns.Genero.Equals(pesquisaGenero) && c.Nome.Equals(pesquisaNomeProdutorGenero)
                                        select albuns;
                        
                        Console.WriteLine("Albuns do genero " + pesquisaGenero + " lançadas pelo produtor " + pesquisaNomeProdutorGenero + "\n");
                        foreach(Album albumSelecionado in albunsGeneroProd){
                            Console.WriteLine(albumSelecionado.Nome + "\n");
                        }
                    break;
                    case 6:
                        //Todos os álbuns do mesmo ano de um produtor
                        Console.WriteLine("Digite o nome do produtor para procurar pelas suas musicas: ");
                        pesquisaNomeProdutorAno = Console.ReadLine();
                        Console.WriteLine("Digite o ano para procurar pelos álbuns lançados nesse ano: ");
                        int pesquisaAnoProd = int.Parse(Console.ReadLine());

                        var musicasAnoProd = from c in todosProdutores
                                        from albuns in c.Albuns
                                        where albuns.DataLancamento.Year.Equals(pesquisaAnoProd) && c.Nome.Equals(pesquisaNomeProdutorAno)
                                        select albuns;
                        
                        Console.WriteLine("Albuns do ano " + pesquisaAnoProd + " lançadas pelo produtor " + pesquisaNomeProdutorAno + "\n");
                        foreach(Album albumSelecionado in musicasAnoProd){
                            Console.WriteLine(albumSelecionado.Nome + "\n");
                        }
                    break;
                    case 7:
                        //A lista ordenada decrescente de lançamento dos álbuns de um artista
                        Console.WriteLine("Digite o nome do artista para procurar pelos seus álbuns: ");
                        pesquisaNomeProdutorAno = Console.ReadLine();

                        var ordenaAlbunsArtista = from c in todosArtistas
                                        from albuns in c.Albuns
                                        orderby albuns.DataLancamento
                                        select albuns;

                        Console.WriteLine("Albuns em ordem decrescente: \n");
                        foreach(Album albumSelecionado in ordenaAlbunsArtista){
                            Console.WriteLine(albumSelecionado.Nome + "\n");
                        }
                    break;
                    case 0:
                        Console.WriteLine("Encerrando programa");
                    break;
                    default:
                        Console.WriteLine("Valor inválido");
                    break;
                }
            }while (escolha != 0);
        }
    }
}