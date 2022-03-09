using AutoMapper;
using SUC.Application.Commands.Perfil;
using SUC.Domain.Entities;
using SUC.Domain.Models.Perfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Profiles
{
    public class PerfilProfile : Profile
    {
        public PerfilProfile()
        {
            CreateMap<PerfilCreateCommand, Perfil>();
            CreateMap<PerfilUpdateCommand, Perfil>();
            CreateMap<PerfilDeleteCommand, Perfil>();
            CreateMap<PerfilModel, Perfil>();
        }
    }
}
