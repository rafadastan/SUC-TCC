using AutoMapper;
using SUC.Application.Commands.Servico;
using SUC.Application.Commands.ServicoDelete;
using SUC.Application.Commands.ServicoUpdate;
using SUC.Domain.Entities.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Profiles
{
    public class ServicoProfile : Profile
    {
        public ServicoProfile()
        {
            CreateMap<Servico, ServiceCreateCommand>().ReverseMap();
            CreateMap<Servico, ServiceUpdateCommand>().ReverseMap();
            CreateMap<Servico, ServiceDeleteCommand>().ReverseMap();
        }
    }
}
