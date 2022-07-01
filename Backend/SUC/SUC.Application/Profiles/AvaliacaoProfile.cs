using AutoMapper;
using SUC.Application.Commands.Avaliacao;
using SUC.Domain.Entities.Avaliacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Profiles
{
    public class AvaliacaoProfile : Profile
    {
        public AvaliacaoProfile()
        {
            CreateMap<Avaliacao, AvaliacaoCreateCommand>().ReverseMap();
            CreateMap<Avaliacao, AvaliacaoUpdateCommand>().ReverseMap();
            CreateMap<Avaliacao, AvaliacaoDeleteCommand>().ReverseMap();
        }
    }
}
