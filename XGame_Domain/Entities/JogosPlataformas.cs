using System;

namespace XGame_Domain.Entities
{
    public class JogosPlataformas
    {
        public Guid Id { get; set; }

        public Jogos Jogo { get; set; }

        public Plataformas Plataforma { get; set; }

        public DateTime DataLancamento { get; set; }
    }
}
