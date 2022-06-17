using AutoMapper;
using SUC.Application.Commands.Endereco;
using SUC.Domain.Entities.EntityEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<Endereco, EnderecoCreateCommand>().ReverseMap();
            CreateMap<Endereco, EnderecoUpdateCommand>().ReverseMap();
            CreateMap<Endereco, EnderecoDeleteCommand>().ReverseMap();
        }
    }
}
