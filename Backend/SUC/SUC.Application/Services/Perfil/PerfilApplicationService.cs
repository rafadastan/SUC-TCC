using SUC.Application.Commands.Perfil;
using SUC.Application.Contracts.Perfil;
using SUC.Domain.Models.Perfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Services.Perfil
{
    public class PerfilApplicationService : IPerfilApplicationService
    {
        public Task<ResponsePerfilModel> Create(PerfilCreateCommand model)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResponsePerfilModel>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
