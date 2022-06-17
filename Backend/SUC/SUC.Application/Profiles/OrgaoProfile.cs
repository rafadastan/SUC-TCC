using AutoMapper;
using SUC.Application.Commands.Orgao;
using SUC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Profiles
{
    public class OrgaoProfile : Profile
    {
        public OrgaoProfile()
        {
            CreateMap<Orgao, OrgaoCreateCommand>().ReverseMap();
            CreateMap<Orgao, OrgaoUpdateCommand>().ReverseMap();
            CreateMap<Orgao, OrgaoDeleteCommand>().ReverseMap();
        }
    }
}
