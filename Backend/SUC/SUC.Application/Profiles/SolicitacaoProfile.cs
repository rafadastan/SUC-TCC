using AutoMapper;
using SUC.Application.Commands.Solicitacao;
using SUC.Domain.Entities.Solicitacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Profiles
{
    public class SolicitacaoProfile : Profile
    {
        public SolicitacaoProfile()
        {
            CreateMap<Solicitacao, SolicitacaoCreateCommand>().ReverseMap();
            CreateMap<Solicitacao, SolicitacaoUpdateCommand>().ReverseMap();
            CreateMap<Solicitacao, SolicitacaoDeleteCommand>().ReverseMap();
        }
    }
}
