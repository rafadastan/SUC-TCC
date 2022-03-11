using SUC.Domain.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.ReadRepository
{
    public interface IUsuarioReadRepository
    {
        Task<UsuarioModel> Get(string cpf, string senha);
    }
}
