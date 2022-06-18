using AutoMapper;
using SUC.Application.Commands.Demanda;
using SUC.Domain.Entities.Demanda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Profiles
{
    public class DemandaProfile : Profile
    {
        public DemandaProfile()
        {
            CreateMap<Demanda, DemandaCreateCommand>().ReverseMap();
            CreateMap<Demanda, DemandaUpdateCommand>().ReverseMap();
            CreateMap<Demanda, DemandaDeleteCommand>().ReverseMap();
        }
    }
}
