using System;
using System.Collections.Generic;

namespace EstudoMusica{
    public class Artista : Pessoa{
        public DateTime DataContrato { get; private set; }
        public string Genero { get; private set; }
        public List<Album> Albuns { get; private set; }

        public Artista(DateTime datadoContrato, string genero, string nome, ulong cpf, DateTime datadeNascimento, DateTime datadeFalecimento){
            this.DataContrato = datadoContrato;
            this.Genero = genero;
            this.Nome = nome;
            this.DataNascimento = datadeNascimento;
            this.DataFalecimento = datadeFalecimento;
            this.Cpf = cpf;
            this.Albuns = new List<Album>();
        }
    }
}