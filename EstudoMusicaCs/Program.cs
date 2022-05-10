using System;
using System.Collections.Generic;
using EstudoMusica;

namespace EstudoMusica{
    class Program{
        static void Main(string[] args){
            //Criando artista
            var silkSonic = new Artista("26/02/2021", "R&B", "Silk Sonic", 12345678901, "8/10/1985", "vivo");
            
            //Criando produtor e adicionando gênerio
            var stereotypes = new Produtor("The Stereotypes", "The Stereotypes", "01/05/2003", "vivo", 12345678901);
            stereotypes.Generos.Add("RnB");

            //Criando álbum
            var anEvening = new Album("An Evening With Silk Sonic", "R&B", "12/11/2021", "capa Silk Sonic");
            //Criando músicas e adicionando ao álbum
            var leaveDoor = new Musica("Leave the Door Open", "R&B", 242, "12/11/2021");
            anEvening.Musicas.Add(leaveDoor);
            var flyasMe = new Musica("Fly As Me", "R&B", 219, "12/11/2021");
            anEvening.Musicas.Add(flyasMe);
            var smokingOut= new Musica("Smoking Out the Window", "R&B", 197, "12/11/2021");
            anEvening.Musicas.Add(leaveDoor);

            //Adicionando Álbum a artista e produtor
            silkSonic.Albuns.Add(anEvening);
            stereotypes.Albuns.Add(anEvening);

            Console.WriteLine("Artista:" + silkSonic.Nome + "Genero:" + silkSonic.Genero);
            Console.WriteLine("Album:" + anEvening.Nome + "\nMusicas:");
            
            for(int i = 0; i < anEvening.Musicas.Count; i++){
                Console.WriteLine(anEvening.Musicas[i].Nome);
            }

            /*foreach(Musica element in anEvening.Musicas){
                Console.WriteLine(anEvening.Musicas);
            }*/

        }
    }
}
