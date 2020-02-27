using XGame_Domain.Interface.Arguments;
using XGame_Domain.ValueObjects;

namespace XGame_Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {

        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string ConfirmarSenha { get; set; }
    }
}
