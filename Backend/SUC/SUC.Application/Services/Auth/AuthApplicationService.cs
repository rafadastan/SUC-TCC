using AutoMapper;
using SUC.Application.Commands.Auth;
using SUC.Application.Contracts.Auth;
using SUC.Domain.Contracts.Auth;
using SUC.Domain.Models;
using SUC.Domain.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Services.Auth
{
    public class AuthApplicationService : IAuthApplicationService
    {
        private readonly IAuthDomainService _auth;
        private readonly IMapper _mapper;

        public AuthApplicationService(IAuthDomainService auth, IMapper mapper)
        {
            _auth = auth;
            _mapper = mapper;
        }

        public async Task<AuthModel> Authentication(AuthenticationCommand authenticationModel)
        {
            var auth = await _auth.Authentication(authenticationModel.Cpf, authenticationModel.Senha);

            return auth;
        }
    }
}
