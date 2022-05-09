using System;
using System.Collections.Generic;

namespace EstudoMusicaCs{
    class Program{
        static void Main(string[] args){
            //Criando artista
            var silkSonic = new Artista("26/02/2021", "R&B", "Silk Sonic", 12345678901, "8/10/1985", "vivo");
            
            //Criando produtor e adicionando gênerio
            var stereotypes = new Produtor("The Stereotypes", "The Stereotypes", "01/05/2003", "vivo", 12345678901);
            stereotypes.Generos.AddAfter("R&B");

            //Criando álbum
            var anEvening = new Album("An Evening With Silk Sonic", "R&B", "12/11/2021", "capa Silk Sonic");
            //Criando músicas e adicionando ao álbum
            var leaveDoor = new Musica("Leave the Door Open", "R&B", 4.02, "12/11/2021");
            anEvening.Musicas.AddAfter(leaveDoor);
            var flyasMe = new Musica("Fly As Me", "R&B", 3.39, "12/11/2021");
            anEvening.Musicas.AddAfter(flyasMe);
            var smokingOut= new Musica("Smoking Out the Window", "R&B", 3.17, "12/11/2021");
            anEvening.Musicas.AddAfter(leaveDoor);

            //Adicionando Álbum a artista e produtor
            silkSonic.Albuns.AddAfter(anEvening);
            stereotypes.Albuns.AddAfter(anEvening);

            Console.WriteLine("Artista:" + silkSonic.Nome + "Genero:" + silkSonic.Genero);
            Console.WriteLine("Album:" + anEvening.Nome + "\nMusicas:" + anEvening.Musicas[0] + anEvening.Musicas[1] + anEvening.Musicas[2]);
        }
    }
}
