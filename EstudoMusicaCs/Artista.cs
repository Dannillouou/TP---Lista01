using System;
using System.Collections.Generic;

namespace EstudoMusica{
    public class Artista : Pessoa{
        public string DataContrato { get; private set; }
        public string Genero { get; private set; }
        public LinkedList<Album> Albuns { get; private set; }

        public Artista(string datadoContrato, string genero, string nome, uint cpf, string datadeNascimento, string datadeFalecimento){
            this.DataContrato = datadoContrato;
            this.Genero = genero;
            this.Nome = Nome;
            this.DataNascimento = datadeNascimento;
            this.DataFalecimento = datadeFalecimento;
            this.Cpf = cpf;
        }
    }
}