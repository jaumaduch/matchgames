using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame_Domain.Interface.Arguments;

namespace XGame_Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse : IResponse
    {
        public string Message { get; set; }
    }
}
