using SUC.Domain.Models.Orgao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.ReadRepository
{
    public interface IOrgaoReadRepository : IBaseReadRepository<OrgaoModel, Guid>
    {
    }
}
