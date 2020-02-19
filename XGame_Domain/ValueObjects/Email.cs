using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame_Domain.ValueObjects
{
    public class Email
    {
        public Email(string enderecoEmail)
        {
            EnderecoEmail = enderecoEmail;
        }

        public string EnderecoEmail { get; private set; }
    }
}
