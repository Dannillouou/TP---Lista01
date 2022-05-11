using System;
using System.Collections.Generic;

namespace EstudoMusica{
    public class Album{
        public string Nome { get; private set; }
        public string Genero { get; private set; }
        public DateTime DataLancamento { get; private set; }
        public string Capa { get; private set; }
        public List<Musica> Musicas{ get; private set; }

        public Album(string nome, string genero, DateTime lancamento, string capa){
            this.Nome = nome;
            this.Genero = genero;
            this.DataLancamento = lancamento;
            this.Capa = capa;
            this.Musicas = new List<Musica>();
        }
    }
}