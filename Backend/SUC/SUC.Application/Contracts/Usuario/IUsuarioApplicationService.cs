using SUC.Application.Commands.Usuario;
using SUC.Domain.Models.Perfil;
using SUC.Domain.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Contracts.Usuario
{
    public interface IUsuarioApplicationService
    {
        Task Create(UsuarioCreateCommand command);
        Task Update(UsuarioUpdateCommand command);
        Task Delete(UsuarioDeleteCommand command);
        Task<List<UsuarioModel>> GetAll();
        Task<UsuarioModel> GetById(Guid id);
    }
}
