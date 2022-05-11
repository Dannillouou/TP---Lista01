using System;
using System.Collections.Generic;

namespace EstudoMusica{
    public abstract class Pessoa{
        public string Nome{ get; protected set; }
        public ulong Cpf{ get; protected set; }
        public DateTime DataNascimento{ get; protected set; }
        public DateTime DataFalecimento{ get; protected set; }
    }
}