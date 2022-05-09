using System;
using System.Collections.Generic;

namespace EstudoMusica{
    public class Album{
        public string Nome { get; private set; }
        public string Genero { get; private set; }
        public string DataLancamento { get; private set; }
        public string Capa { get; private set; }
        public LinkedList<Musica> Musicas{ get; private set; }

        Album(string nome, string genero, string lancamento, string capa){
            this.Nome = nome;
            this.Genero = genero;
            this.DataLancamento = lancamento;
            this.Capa = capa;
        }
    }
}