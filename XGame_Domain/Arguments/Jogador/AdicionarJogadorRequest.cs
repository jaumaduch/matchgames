using XGame_Domain.Interface.Arguments;
using XGame_Domain.ValueObjects;

namespace XGame_Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {

        public Nome Nome { get; set; }

        public Email Email { get; set; }]

        public string Senha { get; set; }

        public string ConfirmarSenha { get; set; }
    }
}
