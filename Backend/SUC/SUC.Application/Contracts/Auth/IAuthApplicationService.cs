using SUC.Application.Commands.Auth;
using SUC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Contracts.Auth
{
    public interface IAgendaApplicationService
    {
        Task<AuthModel> Authentication(AuthenticationCommand authenticationModel);
    }
}
