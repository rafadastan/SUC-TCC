using SUC.Domain.Models;
using SUC.Domain.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Auth
{
    public interface IAuthDomainService
    {
        Task<AuthModel> Authentication(string cpf, string senha);
    }
}
