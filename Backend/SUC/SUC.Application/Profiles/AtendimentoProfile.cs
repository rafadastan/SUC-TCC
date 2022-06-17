using AutoMapper;
using SUC.Application.Commands.Agenda;
using SUC.Domain.Entities.Agenda;
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
            CreateMap<Agenda, AgendaCreateCommand>().ReverseMap();
            CreateMap<Agenda, AgendaUpdateCommand>().ReverseMap();
            CreateMap<Agenda, AgendaDeleteCommand>().ReverseMap();
        }
    }
}
