using AutoMapper;
using SUC.Application.Commands.Usuario;
using SUC.Domain.Entities;
using SUC.Domain.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioCreateCommand, Usuario>().ReverseMap();
            CreateMap<UsuarioUpdateCommand, Usuario>().ReverseMap();
            CreateMap<UsuarioDeleteCommand, Usuario>().ReverseMap();
            CreateMap<UsuarioModel, Usuario>().ReverseMap();
        }
    }
}
