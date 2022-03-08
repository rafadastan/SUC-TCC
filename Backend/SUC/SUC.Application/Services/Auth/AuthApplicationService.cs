using SUC.Application.Commands.Auth;
using SUC.Application.Contracts.Auth;
using SUC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Services.Auth
{
    public class AuthApplicationService : IAuthApplicationService
    {
        public Task<ResponseAuthUsuarioModel> Authentication(AuthenticationCommand authenticationModel)
        {
            throw new NotImplementedException();
        }
    }
}
