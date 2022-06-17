using AutoMapper;
using SUC.Application.Commands.Contato;
using SUC.Domain.Entities.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Profiles
{
    public class ContatoProfile : Profile
    {
        public ContatoProfile()
        {
            CreateMap<Contato, ContatoCreateCommand>().ReverseMap();
            CreateMap<Contato, ContatoUpdateCommand>().ReverseMap();
            CreateMap<Contato, ContatoDeleteCommand>().ReverseMap();
        }
    }
}
