using System;

namespace XGame_Domain.Entities
{
    public class MeuJogos
    {
        public Guid Id { get; set; }

        public JogosPlataformas JogoPlataforma { get; set; }

        public bool Desejo { get; set; }

        public DateTime DataDesejo { get; set; }

        public bool Troco { get; set; }

        public bool Vendo { get; set; }
    }
}
