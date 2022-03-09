using SUC.Application.Commands.Usuario;
using SUC.Application.Contracts.Usuario;
using SUC.Domain.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Services.Usuario
{
    public class UsuarioApplicationService : IUsuarioApplicationService
    {
        public Task Create(UsuarioCreateCommand command)
        {
            throw new NotImplementedException();
        }

        public Task Update(UsuarioUpdateCommand command)
        {
            throw new NotImplementedException();
        }

        public Task Delete(UsuarioDeleteCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
