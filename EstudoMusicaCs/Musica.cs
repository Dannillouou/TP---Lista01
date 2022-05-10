using System;
using System.Collections.Generic;

namespace EstudoMusica{
    public class Musica{
        public string Nome { get; private set; }
        public string Genero { get; private set; }
        public int Duracao { get; private set; }
        public string DataLancamento{ get; private set; }

        public Musica(string nome, string genero, int duracao, string lancamento){
            this.Nome = nome;
            this.Genero = genero;
            this.Duracao = duracao;
            this.DataLancamento = lancamento;
        }

    }
}