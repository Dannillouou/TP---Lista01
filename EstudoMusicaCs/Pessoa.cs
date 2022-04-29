using System;

namespace EstudoMusica{
    public abstract class Pessoa{
        public string Nome{ get; protected set; }
        public uint Cpf{ get; protected set; }
        public Date DataNascimento{ get; protected set; }
        public Date DataFalecimento{ get; protected set; }
    }
}