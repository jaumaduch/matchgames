using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame_Domain.Resources;

namespace XGame_Domain.ValueObjects
{
    public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            new AddNotifications<Nome>(this).IfNullOrInvalidLength(x => x.PrimeiroNome, 3, 20, Message.X0_Invalido.ToFormat("Primeiro Nome"))
                                            .IfNullOrInvalidLength(x => x.UltimoNome, 5, 100, Message.X0_Invalido.ToFormat("Primeiro Nome"));
        }

        public string PrimeiroNome { get; private set; }

        public string UltimoNome { get; private set; }
    }
}
