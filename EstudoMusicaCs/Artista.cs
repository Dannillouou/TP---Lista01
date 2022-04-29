using System;

namespace EstudoMusica{
    public class Artista : Pessoa{
        public Date DatadoContrato { get; private set; }
        public string Genero { get; private set; }

        public Artista(Date datadoContrato, string genero, string nome, uint cpf, Date datadeNascimento, Date datadeFalecimento){
            this.DatadoContrato = datadoContrato;
            this.Genero = genero;
            this.Nome = Nome;
            this.DataNascimento = datadeNascimento;
            this.DataFalecimento = datadeFalecimento;
            this.Cpf = cpf;
        }
    }
}