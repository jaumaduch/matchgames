using prmToolkit.NotificationPattern;
using System;
using System.Net.Mail;
using XGame_Domain.Arguments.Jogador;
using XGame_Domain.Interface.Repositories;
using XGame_Domain.Interface.Services;

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
            Guid Id = _repositoryJogador.AdicionarJogador(request);

            return new AdicionarJogadorResponse() { Message = string.Format("Jogador Adicionado com Sucesso {0}", Id) }; 
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {

            var response = _repositoryJogador.AutenticarJogador(request);

            return response;

        }

        /// <summary>
        /// Método de validação de E-mail.
        /// </summary>
        /// <param name="enderecoEmail"></param>
        /// <returns></returns>
        private bool IsEmail(string enderecoEmail)
        {
            try
            {
                MailAddress m = new MailAddress(enderecoEmail);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
