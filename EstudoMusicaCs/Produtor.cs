using System;
using System.Collections.Generic;

namespace EstudoMusica{
    public class Produtor : Pessoa{
        public string Produtora { get; private set; }
        public LinkedList<string> Generos { get; private set; }
        public LinkedList<Album> Albuns { get; private set; }

        public Produtor(string produtora, string nome, string datadeNascimento, string datadeFalecimento, uint cpf){
            this.Produtora = produtora;
            this.Generos = new LinkedList<string>(null);
            this.Albuns = new LinkedList<string>(null);
            this.Nome = nome;
            this.DataNascimento = datadeNascimento;
            this.DataFalecimento = datadeFalecimento;
            this.Cpf = cpf;
        }
    }
}