using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame_Domain.Interface.Arguments;
using XGame_Domain.Resources;

namespace XGame_Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse : IResponse
    {
        public AutenticarJogadorResponse()
        {
        }

        public string Message { get; set; }

        public static explicit operator AutenticarJogadorResponse(Entities.Jogador entidade)
        {
            return new AutenticarJogadorResponse()
            {
                Message = "Jogador " + entidade.Email.EnderecoEmail + " Logado!"
            };
        }
    }
}
