using AutoMapper;
using SUC.Application.Commands.Chamado;
using SUC.Domain.Entities.Chamado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Profiles
{
    public class ChamadoProfile : Profile
    {
        public ChamadoProfile()
        {
            CreateMap<Chamado, ChamadoCreateCommand>().ReverseMap();
            CreateMap<Chamado, ChamadoUpdateCommand>().ReverseMap();
            CreateMap<Chamado, ChamadoDeleteCommand>().ReverseMap();
        }
    }
}
