using System;
using XGame_Domain.Arguments.Jogador;

namespace XGame_Domain.Interface.Services
{
    public interface IServiceJogador 
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest resquest);

        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);

    }
}
