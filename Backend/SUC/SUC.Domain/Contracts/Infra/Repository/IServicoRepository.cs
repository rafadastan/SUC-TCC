using SUC.Domain.Entities.Servicos;
using System;

namespace SUC.Domain.Contracts.Infra.Repository
{
    public interface IServicoRepository : IBaseRepository<Servico, Guid>
    {
    }
}
