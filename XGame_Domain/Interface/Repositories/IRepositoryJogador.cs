using System;
using XGame_Domain.Arguments.Jogador;

namespace XGame_Domain.Interface.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest resquest);

        Guid AdicionarJogador(AdicionarJogadorRequest request);

    }
}
