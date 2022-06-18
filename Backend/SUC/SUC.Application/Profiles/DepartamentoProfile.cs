using AutoMapper;
using SUC.Application.Commands.Departamento;
using SUC.Domain.Entities.DepartamentoEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Profiles
{
    public class DepartamentoProfile : Profile
    {
        public DepartamentoProfile()
        {
            CreateMap<Departamento, DepartamentoCreateCommand>().ReverseMap();
            CreateMap<Departamento, DepartamentoUpdateCommand>().ReverseMap();
            CreateMap<Departamento, DepartamentoDeleteCommand>().ReverseMap();
        }
    }
}
