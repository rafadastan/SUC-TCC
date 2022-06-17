using AutoMapper;
using SUC.Application.Commands.Catalago;
using SUC.Application.Commands.CatalagoDelete;
using SUC.Application.Commands.CatalagoUpdate;
using SUC.Domain.Entities.Catalago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Profiles
{
    public class CatalagoProfile : Profile
    {
        public CatalagoProfile()
        {
            CreateMap<Catalago, CatalogoCreateCommand>().ReverseMap();
            CreateMap<Catalago, CatalogoUpdateCommand>().ReverseMap();
            CreateMap<Catalago, CatalogoDeleteCommand>().ReverseMap();
        }
    }
}
