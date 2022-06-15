using SUC.Domain.Entities;
using SUC.Domain.Enum;
using SUC.Domain.Models.Perfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.ReadRepository
{
    public interface IPerfilReadRepository : IBaseReadRepository<PerfilModel, Guid>
    {
        Task<PerfilModel> GetByProfile(DomainEnum.PerfilEnum perfilEnum);
    }
}
