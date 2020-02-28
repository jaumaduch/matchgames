using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using XGame_Domain.Arguments.Jogador;
using XGame_Domain.Entities;
using XGame_Domain.Extensions;
using XGame_Domain.Interface.Repositories;
using XGame_Domain.Interface.Services;
using XGame_Domain.Resources;
using XGame_Domain.ValueObjects;

namespace XGame_Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);

            var email = new Email(request.Email);

            Jogador jogador = new Jogador(nome, email, request.Senha);

            if (this.IsInvalid())
                return null;
            
            Guid Id = _repositoryJogador.AdicionarJogador(jogador);

            return new AdicionarJogadorResponse() { Message = string.Format("Jogador Adicionado com Sucesso {0}", Id) }; 
        }

        public AlterarJogadorResponse AlterarJogador(AlterarJogadorResquest request)
        {

            Jogador jogador = _repositoryJogador.ObterPorId(request.Id);

            if (jogador == null)
            {
                AddNotification("Id", Message.DADOS_NAO_ENCONTRADO);
                return null;
            }

            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);

            var email = new Email(request.Email);

            jogador.AlterarJogador(nome, email);

            if (IsInvalid())
                return null;

            _repositoryJogador.AlterarJogador(jogador);

            return new AlterarJogadorResponse() { Message = "Jogador Alterado com Sucesso." };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            var email = new Email(request.Email);

            var senha = request.Senha.ConvertToMD5();

            Jogador jogador = _repositoryJogador.AutenticarJogador(email, senha);

            return (AutenticarJogadorResponse)jogador;

        }

        public List<JogadorResponse> ListarJogador()
        {
            return _repositoryJogador.Listar().Select(jogador => (JogadorResponse)jogador).ToList();
        }

    }
}
