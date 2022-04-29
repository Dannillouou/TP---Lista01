using System;

namespace EstudoMusica{
    public class Album{
        public string Nome { get; private set; }
        public string Genero { get; private set; }
        public Date DatadeLancamento { get; private set; }
        public string Capa { get; private set; }

        Album(string nome, string genero, Date datadeLancamento, string capa){
            this.Nome = nome;
            this.Genero = genero;
            this.DatadeLancamento = datadeLancamento;
            this.Capa = capa;
        }
    }
}