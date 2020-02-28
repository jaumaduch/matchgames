using System;
using System.Collections.Generic;
using XGame_Domain.Arguments.Jogador;

namespace XGame_Domain.Interface.Services
{
    public interface IServiceJogador 
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);

        AlterarJogadorResponse AlterarJogador(AlterarJogadorResquest request);

        List<JogadorResponse> ListarJogador();

    }
}
