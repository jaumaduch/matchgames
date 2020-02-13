using System;
using XGame_Domain.Enum;
using XGame_Domain.ValueObjects;

namespace XGame_Domain
{
    public class Jogador
    {
        public Guid ID { get; set; }

        public Nome Nome { get; set; }

        public Email Email { get; set; }

        public string Senha { get; set; }

        public EnumStatusJogador Status { get; set; }
    }
}
