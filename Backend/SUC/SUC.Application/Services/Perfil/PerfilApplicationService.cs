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
        public Task Create(PerfilCreateCommand command)
        {
            throw new NotImplementedException();
        }

        public Task Update(PerfilUpdateCommand command)
        {
            throw new NotImplementedException();
        }

        public Task Delete(PerfilDeleteCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<List<PerfilModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PerfilModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
