using AutoMapper;
using SUC.Application.Commands.Indice;
using SUC.Domain.Entities.Indices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Profiles
{
    public class IndiceProfile : Profile
    {
        public IndiceProfile()
        {
            CreateMap<Indice, IndiceCreateCommand>().ReverseMap();
            CreateMap<Indice, IndiceUpdateCommand>().ReverseMap();
            CreateMap<Indice, IndiceDeleteCommand>().ReverseMap();
        }
    }
}
