using System;
using System.Collections.Generic;

namespace EstudoMusica{
    public abstract class Pessoa{
        public string Nome{ get; protected set; }
        public uint Cpf{ get; protected set; }
        public string DataNascimento{ get; protected set; }
        public string DataFalecimento{ get; protected set; }
    }
}