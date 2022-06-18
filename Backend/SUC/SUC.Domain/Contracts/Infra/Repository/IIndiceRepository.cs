using SUC.Domain.Entities.Indices;
using SUC.Domain.Models.Indice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Repository
{
    public interface IIndiceRepository : IBaseRepository<Indice, Guid>
    {
    }
}
