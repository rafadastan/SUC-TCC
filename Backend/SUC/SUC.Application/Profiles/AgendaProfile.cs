using AutoMapper;
using SUC.Application.Commands.Agenda;
using SUC.Domain.Entities.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUC.Domain.Models.Agenda;

namespace SUC.Application.Profiles
{
    public class AgendaProfile : Profile
    {
        public AgendaProfile()
        {
            CreateMap<Agenda, AgendaCreateCommand>().ReverseMap();
            CreateMap<Agenda, AgendaUpdateCommand>().ReverseMap();
            CreateMap<Agenda, AgendaDeleteCommand>().ReverseMap();

            CreateMap<Agenda, AgendaModel>().AfterMap((src, dest) =>
            {
                dest.IdAgenda = src.IdAgenda;
                dest.Ativo = src.Ativo;
            }).ReverseMap();
        }
    }
}
