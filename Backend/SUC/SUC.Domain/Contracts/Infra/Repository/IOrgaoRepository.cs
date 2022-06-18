using SUC.Domain.Entities;
using SUC.Domain.Models.Orgao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Repository
{
    public interface IOrgaoRepository : IBaseRepository<Orgao, Guid>
    {
    }
}
