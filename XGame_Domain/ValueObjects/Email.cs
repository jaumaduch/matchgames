using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame_Domain.Resources;

namespace XGame_Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string enderecoEmail)
        {
            EnderecoEmail = enderecoEmail;

            new AddNotifications<Email>(this).IfNotEmail(x => x.EnderecoEmail, Message.X0_Invalido.ToFormat("E-mail"));
        }

        public string EnderecoEmail { get; private set; }
    }
}
