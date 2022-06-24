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
            CreateMap<UsuarioCreateCommand, Usuario>()
                .ReverseMap();
            
            CreateMap<UsuarioUpdateCommand, Usuario>()
                .AfterMap((src, desc) =>
                {
                    desc.IdUsuario = src.Id;
                })
                .ReverseMap();

            CreateMap<UsuarioDeleteCommand, Usuario>()
                .AfterMap((src, desc) => 
                {
                    desc.IdUsuario = src.Id;
                })
                .ReverseMap();
            
            CreateMap<UsuarioModel, Usuario>()
                .ReverseMap();
        }
    }
}
