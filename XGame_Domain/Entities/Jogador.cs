using prmToolkit.NotificationPattern;
using System;
using XGame_Domain.Enum;
using XGame_Domain.ValueObjects;

namespace XGame_Domain
{
    public class Jogador : Notifiable
    {
        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this)
                .IfNotEmail(x => x.Email.EnderecoEmail, "Informe um E-mail Válido.")
                .IfNullOrInvalidLength(x=>x.Senha, 6, 12, "Senha Não condiz com padrão básico de requisito.");
        }

        public Guid ID { get; set; }

        public Nome Nome { get; set; }

        public Email Email { get; set; }

        public string Senha { get; set; }

        public EnumStatusJogador Status { get; set; }
    }
}
