using AutoMapper;
using SUC.Application.Commands.Auth;
using SUC.Domain.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Profiles
{
    public class AuthProfile : Profile
    {
        public AuthProfile()
        {
            CreateMap<AuthenticationDomainModel, AuthenticationCommand>().ReverseMap();
        }
    }
}
