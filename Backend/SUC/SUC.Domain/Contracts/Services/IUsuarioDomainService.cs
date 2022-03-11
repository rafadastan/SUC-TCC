using SUC.Domain.Contracts.Services;
using SUC.Domain.Entities;
using SUC.Domain.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Usuarios
{
    public interface IUsuarioDomainService : IBaseDomainService<Usuario, Guid>
    {
        Task<UsuarioModel> Get(string cpf, string senha);
    }
}
