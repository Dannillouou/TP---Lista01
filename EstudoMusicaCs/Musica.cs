using System;

namespace EstudoMusica{
    public class Musica{
        public string Nome { get; private set; }
        public string Genero { get; private set; }
        public float Duracao { get; private set; }
        public Date Lancamento { get; private set; }

        public Musica(string nome, string genero, float duracao, Date lancamento){
            this.Nome = nome;
            this.Genero = genero;
            this.Duracao = duracao;
            this.Lancamento = lancamento;
        }

    }
}