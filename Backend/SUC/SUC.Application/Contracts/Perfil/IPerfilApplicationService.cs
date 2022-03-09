using SUC.Application.Commands.Perfil;
using SUC.Domain.Models.Perfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Contracts.Perfil
{
    public interface IPerfilApplicationService
    {
        Task Create(PerfilCreateCommand command);
        Task Update(PerfilUpdateCommand command);
        Task Delete(PerfilDeleteCommand command);
        Task<List<PerfilModel>> GetAll();
        Task<PerfilModel> GetById(Guid id);
    }
}
