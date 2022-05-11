using System;
using System.Collections.Generic;

namespace EstudoMusica{
    public class Produtor : Pessoa{
        public string Produtora { get; private set; }
        public List<string> Generos { get; private set; }
        public List<Album> Albuns { get; private set; }

        public Produtor(string produtora, string nome, DateTime datadeNascimento, DateTime datadeFalecimento, ulong cpf){
            this.Produtora = produtora;
            this.Generos = new List<string>();
            this.Albuns = new List<Album>();
            this.Nome = nome;
            this.DataNascimento = datadeNascimento;
            this.DataFalecimento = datadeFalecimento;
            this.Cpf = cpf;
        }
    }
}