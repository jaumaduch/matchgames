using System;
using System.Collections.Generic;
using XGame_Domain.Arguments.Jogador;
using XGame_Domain.Entities;
using XGame_Domain.ValueObjects;

namespace XGame_Domain.Interface.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador AutenticarJogador(Email email, string senha);

        Guid AdicionarJogador(Jogador jogador);

        List<JogadorResponse> Listar();

        Jogador ObterPorId(Guid id);
        void AlterarJogador(Jogador jogador);
    }
}
