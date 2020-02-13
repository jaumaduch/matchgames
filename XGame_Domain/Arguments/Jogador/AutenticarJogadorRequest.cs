using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame_Domain.Interface.Arguments;
using XGame_Domain.ValueObjects;

namespace XGame_Domain.Arguments.Jogador
{
    public class AutenticarJogadorRequest : IRequest
    {
        public Email Email { get; set; }

        public string Senha { get; set; }
    }
}
