using System;
using XGame_Domain.Enum;

namespace XGame_Domain.Arguments.Jogador 
{ 
    public class JogadorResponse
    {
        public Guid ID { get;  set; }

        public string PrimeiroNome { get;  set; }

        public string UltimoNome { get; set; }

        public string Email { get;  set; }

        public string Status { get; set; }

        public static explicit operator JogadorResponse(Entities.Jogador entidade)
        {
            return new JogadorResponse()
            {
                Email = entidade.Email.EnderecoEmail,
                PrimeiroNome = entidade.Nome.PrimeiroNome,
                UltimoNome = entidade.Nome.UltimoNome,
                ID = entidade.ID,
                Status = entidade.Status.ToString()
            };
        }
            
    }
}