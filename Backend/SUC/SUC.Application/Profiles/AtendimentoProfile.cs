using AutoMapper;
using SUC.Application.Commands.Agenda;
using SUC.Application.Commands.Atendimento;
using SUC.Domain.Entities.Agenda;
using SUC.Domain.Entities.Atendimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Profiles
{
    public class AtendimentoProfile : Profile
    {
        public AtendimentoProfile()
        {
            CreateMap<Atendimento, AtendimentoCreateCommand>().ReverseMap();
            CreateMap<Atendimento, AtendimentoUpdateCommand>().ReverseMap();
            CreateMap<Atendimento, AtendimentoDeleteCommand>().ReverseMap();
        }
    }
}
