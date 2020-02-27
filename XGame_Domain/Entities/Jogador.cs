using prmToolkit.NotificationPattern;
using System;
using XGame_Domain.Enum;
using XGame_Domain.Extensions;
using XGame_Domain.ValueObjects;

namespace XGame_Domain
{
    public class Jogador : Notifiable
    {
        public Jogador(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            ID = Guid.NewGuid();
            Status = EnumStatusJogador.EmAnalise;
            
            new AddNotifications<Jogador>(this).IfNullOrInvalidLength(x=>x.Senha, 6, 12, "Senha Não condiz com padrão básico de requisito.");
            
            if (IsValid())
                Senha = Senha.ConvertToMD5();

            AddNotifications(Nome, Email);
        }

        public Guid ID { get; private set; }

        public Nome Nome { get; private set; }

        public Email Email { get; private set; }

        public string Senha { get; private set; }

        public EnumStatusJogador Status { get; private set; }
    }
}
