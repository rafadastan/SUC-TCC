using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Models.Auth
{
    public class AuthenticationDomainCommand
    {
        public string Cpf { get; set; }
        public string Senha { get; set; }
    }
}
