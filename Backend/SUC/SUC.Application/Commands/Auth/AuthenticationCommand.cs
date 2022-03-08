using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Commands.Auth
{
    public class AuthenticationCommand
    {
        public string Cpf { get; set; }
        public string Senha { get; set; }
    }
}
